#include "wifi_config.h"
#include "esp_wifi.h"
#include "esp_event.h"
#include "nvs_flash.h"
#include "esp_log.h"
#include <stdbool.h>
#include "esp_wifi_default.h"

#ifndef CONFIG_LOG_MAXIMUM_LEVEL
#define CONFIG_LOG_MAXIMUM_LEVEL 3  // Nivel por defecto: INFO
#endif

static const char *TAG = "wifi_config";
#ifndef WIFI_CONFIG_H
#define WIFI_CONFIG_H
#endif

     void wifi_init(void) {
    // Inicializa la NVS
    esp_netif_init();
    esp_event_loop_create_default();
    esp_netif_create_default_wifi_sta();

    // Inicializa la configuración WiFi
    
    wifi_init_config_t cfg = ESP_WIFI_INIT_CONFIG_DEFAULT();

    // Inicializa el WiFi
    esp_wifi_init(&cfg);

    // Configura las credenciales WiFi
    wifi_config_t wifi_config = {
        .sta = {
            .ssid = "esp32_555",
            .password = "12345678",
        },
    };

    // Establece el modo de WiFi a estación (STA)
    esp_wifi_set_mode(WIFI_MODE_STA);

    // Configura el WiFi con las credenciales
    esp_wifi_set_config(WIFI_IF_STA, &wifi_config);

    // Inicia el WiFi
    esp_wifi_start();
    
    // Conéctate a la red WiFi
    esp_wifi_connect();

    ESP_LOGI (TAG, "WiFi inicializado");
}
