#include <stdio.h>
#include <stdbool.h>
#include <stdint.h>


#define LM_NOACTIVO 0
#define MOTOR_OFF 0
#define MOTOR_ON 1
#define LAMP_OFF 0
#define LAMP_ON 1
#define FD_CIERRA 1
#define FD_ESPERA 2
#define FD_ABRIR 3
#define FD_PARPADEAR 4
#define TIME_CA 120
#define PARPADEO_LENTO 10
#define PIN_LED_FALLA 2

// Estados
typedef enum {
    ESTADO_INICIAL,
    ESTADO_ERROR,
    ESTADO_ABRIENDO,
    ESTADO_ABIERTO,
    ESTADO_CERRANDO,
    ESTADO_CERRADO,
    ESTADO_DETENIDA,
    ESTADO_DESCONOCIDO
} ESTADO;

// Variables globales
ESTADO ESTADO_SIGUIENTE = ESTADO_INICIAL;
static unsigned int cnt_led_lamp = 0;

struct SYSTEM_IO {
    unsigned int lsc : 1; // Limit switch cerrado
    unsigned int lsa : 1; // Limit switch abierto
    unsigned int ftc : 1; // Sensor de fallo
    unsigned int ma : 1;  // Motor abrir
    unsigned int mc : 1;  // Motor cerrar
    unsigned int lamp : 1; // Lámpara
    unsigned int keya : 1; // Botón abrir
    unsigned int keyc : 1; // Botón cerrar
    unsigned int pp : 1;   // Sensor de presencia
    unsigned int dpsw_fd : 2; // Dip switch función desconocida
    unsigned int dpsw_fpp : 2; // Dip switch función especial
} io;

// Función para parpadear el LED en caso de error


void main() {
    for (;;) {
        switch (ESTADO_SIGUIENTE) {
            case ESTADO_INICIAL:
                ESTADO_SIGUIENTE = Func_ESTADO_INICIAL();
                break;
            case ESTADO_ERROR:
                ESTADO_SIGUIENTE = Func_ESTADO_ERROR();
                break;
            case ESTADO_ABRIENDO:
                ESTADO_SIGUIENTE = Func_ESTADO_ABRIENDO();
                break;
            case ESTADO_ABIERTO:
                ESTADO_SIGUIENTE = Func_ESTADO_ABIERTO();
                break;
            case ESTADO_CERRANDO:
                ESTADO_SIGUIENTE = Func_ESTADO_CERRANDO();
                break;
            case ESTADO_CERRADO:
                ESTADO_SIGUIENTE = Func_ESTADO_CERRADO();
                break;
            case ESTADO_DETENIDA:
                ESTADO_SIGUIENTE = Func_ESTADO_DETENIDA();
                break;
            case ESTADO_DESCONOCIDO:
                ESTADO_SIGUIENTE = Func_ESTADO_DESCONOCIDO();
                break;
            default:
                ESTADO_SIGUIENTE = ESTADO_ERROR;
                break;
        }
    }
}

// Implementación de funciones de estados
int Func_ESTADO_INICIAL(void) {
    if (io.lsc && io.lsa) {
        return ESTADO_ERROR; // Estado in
    } else if (io.lsc) {
        return ESTADO_CERRADO;
    } else if (io.lsa) {
        return ESTADO_ABIERTO;
    } else {
        return ESTADO_DESCONOCIDO;
    }
}

int Func_ESTADO_ERROR(void) {
    return ESTADO_DETENIDA;
}

int Func_ESTADO_ABRIENDO(void) {
    if (io.lsa) {
        return ESTADO_ABIERTO;
    } else if (io.ftc) {
        return ESTADO_ERROR;
    } else {
        return ESTADO_ABRIENDO;
    }
}

int Func_ESTADO_ABIERTO(void) {
    if (io.keyc) {
        return ESTADO_CERRANDO;
    } else {
        return ESTADO_ABIERTO;
    }
}

int Func_ESTADO_CERRANDO(void) {
    if (io.lsc) {
        return ESTADO_CERRADO;
    } else if (io.ftc) {
        return ESTADO_ERROR;
    } else {
        return ESTADO_CERRANDO;
    }
}

int Func_ESTADO_CERRADO(void) {
    if (io.keya) {
        return ESTADO_ABRIENDO;
    } else {
        return ESTADO_CERRADO;
    }
}

int Func_ESTADO_DETENIDA(void) {
    return ESTADO_INICIAL;
}

int Func_ESTADO_DESCONOCIDO(void) {
    return ESTADO_ERROR;
}
