#include <stdio.h>
#include "freertos/FreeRTOS.h"
#include "freertos/task.h"
#include "freertos/timers.h"
#include "driver/gpio.h"
#include "esp_log.h"

// Definiciones
#define BOTON_PIN 13
#define LED_PIN 2

// Variables globales
volatile uint32_t pressTime = 0;
volatile uint32_t duration = 0;
TaskHandle_t buttonTaskHandle;
TimerHandle_t blinkTimer;

// Interrupción del botón
void IRAM_ATTR buttonISR() {
    if (gpio_get_level(BOTON_PIN) == 0) {  // Botón presionado
        pressTime = xTaskGetTickCount();
        gpio_set_level(LED_PIN, 1);  // Enciende el LED
    } else {  // Botón liberado
        duration = (xTaskGetTickCount() - pressTime) * portTICK_PERIOD_MS;
        xTaskNotifyFromISR(buttonTaskHandle, duration, eSetValueWithOverwrite, NULL);
    }
}

// Callback del timer para parpadeo del LED
void vTimerCallback(TimerHandle_t pxTimer) {
    gpio_set_level(LED_PIN, !gpio_get_level(LED_PIN));
}

// Tarea para manejar el botón
void buttonTask(void *parameter) {
    uint32_t timeHeld;
    for (;;) {
        if (xTaskNotifyWait(0, ULONG_MAX, &timeHeld, portMAX_DELAY) == pdTRUE) {
            gpio_set_level(LED_PIN, 0);  // Apagar LED antes de iniciar parpadeo
            if (timeHeld > 0) {
                xTimerChangePeriod(blinkTimer, pdMS_TO_TICKS(timeHeld), 0);
                xTimerStart(blinkTimer, 0);
            }
        }
    }
}

void app_main() {
    // Configuración de pines
    gpio_set_direction(BOTON_PIN, GPIO_MODE_INPUT);
    gpio_set_pull_mode(BOTON_PIN, GPIO_PULLUP_ONLY);
    gpio_set_direction(LED_PIN, GPIO_MODE_OUTPUT);
    
    // Configuración de interrupción
    gpio_install_isr_service(0);
    gpio_set_intr_type(BOTON_PIN, GPIO_INTR_ANYEDGE);
    gpio_isr_handler_add(BOTON_PIN, buttonISR, NULL);

    // Crear tarea para manejar botón
    xTaskCreate(buttonTask, "buttonTask", 2048, NULL, 1, &buttonTaskHandle);

    // Crear timer para parpadeo del LED
    blinkTimer = xTimerCreate("blinkTimer", pdMS_TO_TICKS(1000), pdTRUE, NULL, vTimerCallback);
}
