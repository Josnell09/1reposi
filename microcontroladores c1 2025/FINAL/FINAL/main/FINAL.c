#include <string.h>
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "esp_log.h"
#include "nvs_flash.h"
#include "esp_netif.h"
#include "esp_event.h"
#include "esp_wifi.h"
#include "esp_http_server.h"
#include "driver/ledc.h"
#include "driver/gpio.h"

#include "esp_heap_caps.h"
#include "esp_wifi_default.h"

#ifndef CONFIG_FREERTOS_HZ
#define CONFIG_FREERTOS_HZ 1000
#endif
#ifndef CONFIG_LOG_MAXIMUM_LEVEL
#define CONFIG_LOG_MAXIMUM_LEVEL 3  // Nivel por defecto: INFO
#endif

#define WIFI_SSID "esp555"
#define WIFI_PASS "12345678"
#define LED_PIN 2
#define BOTON_MONO 0 // GPIO del botón

static const char *TAG = "NE555_Web";

static float frecuencia = 1.0;
static float duracion_pulso = 1.0;
static bool modo_monoestable = false;

void iniciar_pwm() {
    ledc_timer_config_t timer = {
        .duty_resolution = LEDC_TIMER_10_BIT,
        .freq_hz = 1000,
        .speed_mode = LEDC_HIGH_SPEED_MODE,
        .timer_num = LEDC_TIMER_0
    };
    ledc_timer_config(&timer);

    ledc_channel_config_t channel = {
        .channel    = LEDC_CHANNEL_0,
        .duty       = 512,
        .gpio_num   = LED_PIN,
        .speed_mode = LEDC_HIGH_SPEED_MODE,
        .hpoint     = 0,
        .timer_sel  = LEDC_TIMER_0
    };
    ledc_channel_config(&channel);
}

void ejecutar_monoestable() {
    ledc_set_duty(LEDC_HIGH_SPEED_MODE, LEDC_CHANNEL_0, 1023);
    ledc_update_duty(LEDC_HIGH_SPEED_MODE, LEDC_CHANNEL_0);
    vTaskDelay(pdMS_TO_TICKS((int)(duracion_pulso * 1000)));
    ledc_set_duty(LEDC_HIGH_SPEED_MODE, LEDC_CHANNEL_0, 0);
    ledc_update_duty(LEDC_HIGH_SPEED_MODE, LEDC_CHANNEL_0);
}

static void IRAM_ATTR gpio_isr_handler(void* arg) {
    if (modo_monoestable) {
        ejecutar_monoestable();
    }
}

void iniciar_gpio_interrupt() {
    gpio_config_t io_conf = {
        .intr_type = GPIO_INTR_NEGEDGE,
        .mode = GPIO_MODE_INPUT,
        .pin_bit_mask = (1ULL << BOTON_MONO),
        .pull_up_en = 1,
    };
    gpio_config(&io_conf);
    gpio_install_isr_service(0);
    gpio_isr_handler_add(BOTON_MONO, gpio_isr_handler, NULL);
}

esp_err_t ejecutar_handler(httpd_req_t *req) {
    if (!modo_monoestable) {
        int periodo_ms = (int)(1000.0 / frecuencia);
        ledc_set_freq(LEDC_HIGH_SPEED_MODE, LEDC_TIMER_0, (uint32_t)frecuencia);
        ledc_set_duty(LEDC_HIGH_SPEED_MODE, LEDC_CHANNEL_0, 512);
        ledc_update_duty(LEDC_HIGH_SPEED_MODE, LEDC_CHANNEL_0);
    }
    httpd_resp_send(req, "OK", HTTPD_RESP_USE_STRLEN);
    return ESP_OK;
}

esp_err_t detener_handler(httpd_req_t *req) {
    ledc_set_duty(LEDC_HIGH_SPEED_MODE, LEDC_CHANNEL_0, 0);
    ledc_update_duty(LEDC_HIGH_SPEED_MODE, LEDC_CHANNEL_0);
    httpd_resp_send(req, "Parado", HTTPD_RESP_USE_STRLEN);
    return ESP_OK;
}

esp_err_t modo_post_handler(httpd_req_t *req) {
    char buf[100];
    int ret = httpd_req_recv(req, buf, sizeof(buf));
    if (ret <= 0) return ESP_FAIL;

    buf[ret] = '\0';
    sscanf(buf, "modo=%d&valor=%f", (int*)&modo_monoestable, &frecuencia);
    duracion_pulso = frecuencia; // En modo monoestable se usa "valor" como duración

    ESP_LOGI (TAG, "Modo %s, Valor: %.2f", modo_monoestable ? "Monoestable" : "Astable", frecuencia);
    httpd_resp_send(req, "Recibido", HTTPD_RESP_USE_STRLEN);
    return ESP_OK;
}

httpd_handle_t iniciar_servidor_web() {
    httpd_config_t config = HTTPD_DEFAULT_CONFIG();
    httpd_handle_t server = NULL;
    httpd_start(&server, &config);

    httpd_uri_t ejecutar_uri = {
        .uri = "/ejecutar",
        .method = HTTP_GET,
        .handler = ejecutar_handler
    };
    httpd_register_uri_handler(server, &ejecutar_uri);

    httpd_uri_t detener_uri = {
        .uri = "/detener",
        .method = HTTP_GET,
        .handler = detener_handler
    };
    httpd_register_uri_handler(server, &detener_uri);

    httpd_uri_t modo_uri = {
        .uri = "/modo",
        .method = HTTP_POST,
        .handler = modo_post_handler
    };
    httpd_register_uri_handler(server, &modo_uri);

    return server;
}

int wifi_init(void) {
    ESP_ERROR_CHECK(nvs_flash_init());
    ESP_ERROR_CHECK(esp_netif_init());
    ESP_ERROR_CHECK(esp_event_loop_create_default());
    esp_netif_create_default_wifi_sta();

    wifi_init_config_t cfg = WIFI_INIT_CONFIG_DEFAULT();
    

    ESP_ERROR_CHECK(esp_wifi_init(&cfg));

    wifi_config_t wifi_config = {
        .sta = {
            .ssid = WIFI_SSID,
            .password = WIFI_PASS,
        },
    };

    ESP_ERROR_CHECK(esp_wifi_set_mode(WIFI_MODE_STA));
    ESP_ERROR_CHECK(esp_wifi_set_config(WIFI_IF_STA, &wifi_config));
    ESP_ERROR_CHECK(esp_wifi_start());
    ESP_LOGI(TAG, "WiFi inicializado y conectado");
}

void app_main(void) {
    wifi_init();
    iniciar_pwm();
    iniciar_gpio_interrupt();
    iniciar_servidor_web();
}
