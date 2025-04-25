idf_component_register(SRCS "FINAL.c" "wifi_config.c" "web_server.c"
                    PRIV_REQUIRES spi_flash
                    INCLUDE_DIRS "." REQUIRES esp_http_server esp_wifi nvs_flash driver)
                    target_add_binary_data(${COMPONENT_TARGET} "index.html" TEXT)
