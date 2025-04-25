#include "web_server.h"
#include "esp_log.h"
#include <stdbool.h>  

static const char *TAG = "web_server";

// Simulación de inicio del servidor
void start_web_server(void) {
    ESP_LOG(TAG, "Servidor web simulado iniciado.");
}

// Simulación de la configuración de PWM según los parámetros
void set_pwm_parameters(float r1, float r2, float c, bool monostable) {
    ESP_LOG(TAG, "Valores recibidos: R1=%.2f, R2=%.2f, C=%.2f, Modo: %s",
             r1, r2, c, monostable ? "Monostable" : "Astable");

    // Aquí va la lógica del cálculo real de frecuencia y PWM si quieres simular el NE555
}
