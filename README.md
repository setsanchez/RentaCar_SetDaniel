# Sistema de Renta de Vehículos (Examen_RentarCar_SetDaniel)

## 1. Nombre y Matrícula
- **Nombre:** Set Daniel Sánchez Javier
- **Matrícula:** (2026-1508)

## 2. Descripción del Programa
Aplicación de escritorio desarrollada en C# con Windows Forms para gestionar el alquiler de vehículos, calculando costos, días de renta y generando el resumen de la operación.

## 3. Datos de Entrada
- Datos del cliente (nombre, cédula/documento, etc. ingresados mediante `TextBox`).
- Selección del vehículo y tarifa (mediante `ComboBox` / `RadioButton`).
- Cantidad de días o fechas de renta (mediante `NumericUpDown` / `DateTimePicker`).

## 4. Proceso
Al presionar el botón de calcular/procesar, el sistema valida que los campos obligatorios no estén vacíos, obtiene la tarifa diaria según el vehículo seleccionado, multiplica por la cantidad de días, aplica impuestos o descuentos si corresponden y actualiza el resumen de renta.

## 5. Salida
- Muestra el desglose del monto total a pagar y los detalles de la renta en pantalla (en `Label`, `TextBox` de solo lectura o `DataGridView`).
- Muestra mensajes de confirmación o advertencia mediante `MessageBox`.

## 6. Capturas de Pantalla del Programa en Ejecución
### Proyecto en ejecucion
(captura/programa.png)