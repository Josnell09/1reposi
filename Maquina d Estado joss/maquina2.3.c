#include <stdio.h>
#include <stdint.h>
#include <stdbool.h>
#include <unistd.h> // Para la función sleep()

// Definiciones de estados de la máquina
typedef enum {
    ESTADO_CERRADO,
    ESTADO_ABRIENDO,
    ESTADO_ABIERTO,
    ESTADO_CERRANDO,
    ESTADO_DETENIDA,
    ESTADO_DESCONOCIDO,
    ESTADO_ERROR
} ESTADO;

// Definiciones de pines y entradas
#define LSC  1  // Limit Switch Cerrado
#define LSA  2  // Limit Switch Abierto
#define FTC  3  // Fotocelda (sensor de obstrucción)
#define BTN_A  4  // Botón Abrir
#define BTN_C  5  // Botón Cerrar
#define BTN_PP 6  // Botón de Parada (Presencia)
#define DIP_MODE 7  // Configuración del modo (DIP Switch)

// Definiciones de salidas
#define MOTOR_A 8  // Motor Abriendo
#define MOTOR_C 9  // Motor Cerrando
#define LAMPARA 10 // Indicador luminoso

// Estructura para representar el estado de entradas/salidas
struct SYSTEM_IO {
    uint8_t lsc;
    uint8_t lsa;
    uint8_t ftc;
    uint8_t btn_a;
    uint8_t btn_c;
    uint8_t btn_pp;
    uint8_t dip_mode;
    uint8_t motor_a;
    uint8_t motor_c;
    uint8_t lampara;
} io;

// Estado actual
ESTADO estado_actual = ESTADO_CERRADO;

// Función de parpadeo de la lámpara en caso de error
void Timer50ms(void) {
    static unsigned int cnt_led_lamp = 0;
    cnt_led_lamp++;
    static bool led_state = false;
    if (estado_actual == ESTADO_ERROR) {
        if (cnt_led_lamp >= 10) { // Define la velocidad del parpadeo
            cnt_led_lamp = 0;
            led_state = !led_state;
            io.lampara = led_state;
        }
    } else {
        io.lampara = 0;
    }
}

// Función de actualización de estado
void actualizar_estado() {
    switch (estado_actual) {
        case ESTADO_CERRADO:
            if (io.btn_a) {
                estado_actual = ESTADO_ABRIENDO;
                io.motor_a = 1;
                io.motor_c = 0;
                printf("Transición: CERRADO -> ABRIENDO\n");
                sleep(4);
                estado_actual = ESTADO_ABIERTO;
                io.motor_a = 0;
                printf("Transición: ABRIENDO -> ABIERTO\n");
            }
            break;

        case ESTADO_ABIERTO:
            if (io.btn_c) {
                estado_actual = ESTADO_CERRANDO;
                io.motor_c = 1;
                io.motor_a = 0;
                printf("Transición: ABIERTO -> CERRANDO\n");
                sleep(4);
                estado_actual = ESTADO_CERRADO;
                io.motor_c = 0;
                printf("Transición: CERRANDO -> CERRADO\n");
            }
            break;

        case ESTADO_ABRIENDO:
        case ESTADO_CERRANDO:
            if (io.btn_pp) {
                estado_actual = ESTADO_DETENIDA;
                io.motor_a = 0;
                io.motor_c = 0;
                printf("Transición: DETENIDA\n");
            }
            break;

        case ESTADO_DETENIDA:
            if (io.btn_a) {
                estado_actual = ESTADO_ABRIENDO;
                io.motor_a = 1;
                printf("Reanudando apertura\n");
            } else if (io.btn_c) {
                estado_actual = ESTADO_CERRANDO;
                io.motor_c = 1;
                printf("Reanudando cierre\n");
            }
            break;

        case ESTADO_ERROR:
            io.motor_a = 0;
            io.motor_c = 0;
            printf("Sistema en estado de ERROR. Ingrese un comando válido para restaurar.\n");
            break;
    }
}

// Función para visualizar el estado y recibir comandos
void visualizar_estado() {
    printf("Estado actual: ");
    switch (estado_actual) {
        case ESTADO_CERRADO: printf("CERRADO\n"); break;
        case ESTADO_ABRIENDO: printf("ABRIENDO\n"); break;
        case ESTADO_ABIERTO: printf("ABIERTO\n"); break;
        case ESTADO_CERRANDO: printf("CERRANDO\n"); break;
        case ESTADO_DETENIDA: printf("DETENIDA\n"); break;
        case ESTADO_DESCONOCIDO: printf("DESCONOCIDO\n"); break;
        case ESTADO_ERROR: printf("ERROR\n"); break;
    }
    printf("Ingrese comando (a: abrir, c: cerrar, p: parar): ");
    char comando;
    scanf(" %c", &comando);

    if (comando == 'a') io.btn_a = 1;
    else if (comando == 'c') io.btn_c = 1;
    else if (comando == 'p') io.btn_pp = 1;
    else {
        printf("Comando inválido. Intente nuevamente.\n");
        estado_actual = ESTADO_ERROR;
    }

    if (estado_actual == ESTADO_ERROR && (comando == 'a' || comando == 'c' || comando == 'p')) {
        estado_actual = ESTADO_CERRADO;
        printf("Sistema restaurado.\n");
    }
}

int main() {
    while (1) {
        visualizar_estado();
        actualizar_estado();
        Timer50ms();
    }
    return 0;
}
