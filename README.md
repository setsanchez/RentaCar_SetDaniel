# RentaCar Express - Sistema de Alquiler de Vehículos

Examen práctico de Programación Básica - Windows Forms (C#)

## 1. Nombre y Matrícula
- **Nombre:** Set Daniel Sánchez Javier
- **Matrícula:** 2026-1508

## 2. Descripción del Programa
Aplicación de escritorio desarrollada en C# con Windows Forms para la empresa RentaCar Express. Permite registrar los vehículos de un alquiler, calcular la tarifa diaria según el seguro y el GPS elegidos, acumular un subtotal y obtener el total a pagar aplicando descuento corporativo, entrega a domicilio e ITBIS.

## 3. Datos de Entrada
- **Cliente:** nombre del cliente (`TextBox`) y si es corporativo (`CheckBox`).
- **Fecha de salida:** `DateTimePicker`, con la fecha actual por defecto.
- **Vehículo:** nombre del vehículo (`TextBox`).
- **Tarifa:** tarifa por día en RD$ (`TextBox`).
- **Días:** de 1 a 30 (`NumericUpDown`).
- **Seguro:** Básico o Completo, +RD$300 por día (`RadioButton`).
- **GPS:** +RD$100 por día (`CheckBox`).
- **Entrega:** En sucursal o A domicilio, +RD$500 (`RadioButton`).

## 4. Proceso
1. **Al cargar el formulario:** se dejan los controles en sus valores iniciales y se muestra el encabezado de columnas (Días, Vehículo, Tarifa, Total).
2. **Agregar al alquiler:** se validan el vehículo y la tarifa. Luego se calcula:
   - Tarifa diaria = tarifa digitada + 300 si el seguro es completo + 100 si lleva GPS.
   - Total de línea = tarifa diaria × días.
   
   La línea se muestra en el `ListBox`, el total de línea se acumula en el subtotal y se reinician los controles del vehículo.
3. **Calcular total:** si hay vehículos agregados, se calcula:
   - Descuento = 15 % del subtotal si el cliente es corporativo.
   - Domicilio = RD$500 una sola vez si se elige entrega a domicilio.
   - Base imponible = subtotal - descuento + domicilio.
   - ITBIS = 18 % de la base imponible.
   - Total = base imponible + ITBIS.
4. **Nuevo alquiler:** limpia todo, deja el subtotal en cero y coloca el foco en el cliente.
5. **Salir:** pide confirmación con un `MessageBox` (Sí/No) antes de cerrar.

## 5. Salida
- Lista del alquiler en columnas (días, vehículo con su seguro, tarifa diaria y total de línea).
- Subtotal, descuento, domicilio, ITBIS y **total a pagar**, en formato `RD$ 0.00`.
- Mensajes de advertencia con `MessageBox` cuando faltan datos o no hay vehículos agregados.


## 6. Capturas de Pantalla del Programa en Ejecución

### Formulario al iniciar
![Formulario al iniciar](capturas/inicio.png)

### Vehículos agregados al alquiler
![Vehículos agregados](capturas/total.png)

