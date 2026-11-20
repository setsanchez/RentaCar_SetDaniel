using System.Globalization;

namespace Examen_RentarCar_SetDaniel
{
    public partial class Form1 : Form
    {
        // ===== Constantes de negocio =====
        private const decimal RECARGO_SEGURO_COMPLETO = 300m;
        private const decimal RECARGO_GPS = 100m;
        private const decimal PORC_DESCUENTO_CORP = 0.15m;
        private const decimal COSTO_DOMICILIO = 500m;
        private const decimal PORC_ITBIS = 0.18m;

        // Cultura fija para que los montos siempre salgan como 7,500.00
        private static readonly CultureInfo Cultura = CultureInfo.InvariantCulture;

        // Subtotal acumulado de todas las líneas del alquiler
        private decimal subtotal = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        // ===== Load =====
        private void Form1_Load(object sender, EventArgs e)
        {
            // Fuente monoespaciada para que las columnas alineen
            lblEncabezado.Font = new Font("Consolas", 9);
            lstAlquileres.Font = new Font("Consolas", 9);

            lblEncabezado.Text = "Días".PadRight(6) + "Vehículo".PadRight(24)
                               + "Tarifa".PadLeft(10) + "Total".PadLeft(12);

            LimpiarTodo();
        }

        // ===== Agregar al alquiler =====
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtVehiculo.Text))
            {
                MessageBox.Show("Digite el nombre del vehículo.");
                txtVehiculo.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text, NumberStyles.Number, Cultura, out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("Digite una tarifa válida mayor que cero.");
                txtTarifa.Focus();
                return;
            }

            int dias = (int)nudDias.Value;

            // Tarifa diaria = tarifa + seguro completo + GPS
            decimal tarifaDiaria = tarifa;
            string detalle = "Básico";

            if (rbtCompleto.Checked)
            {
                tarifaDiaria += RECARGO_SEGURO_COMPLETO;
                detalle = "Completo";
            }
            if (chkGps.Checked)
            {
                tarifaDiaria += RECARGO_GPS;
                detalle += ", GPS";
            }

            // Total de línea y acumulación
            decimal totalLinea = tarifaDiaria * dias;
            subtotal += totalLinea;

            // Línea en columnas (anchos 6, 24, 10 y 12)
            string vehiculo = txtVehiculo.Text.Trim() + " (" + detalle + ")";
            string linea = dias.ToString().PadRight(6)
                         + vehiculo.PadRight(24)
                         + tarifaDiaria.ToString("N2", Cultura).PadLeft(10)
                         + totalLinea.ToString("N2", Cultura).PadLeft(12);
            lstAlquileres.Items.Add(linea);

            ReiniciarControlesVehiculo();
        }

        // ===== Calcular total =====
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (subtotal == 0)
            {
                MessageBox.Show("Agregue al menos un vehículo al alquiler.");
                return;
            }

            decimal descuento = chkCorporativo.Checked ? subtotal * PORC_DESCUENTO_CORP : 0m;
            decimal domicilio = rbtDomicilio.Checked ? COSTO_DOMICILIO : 0m;
            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * PORC_ITBIS;
            decimal total = baseImponible + itbis;

            lblSubtotal.Text = "RD$ " + subtotal.ToString("N2", Cultura);
            lblDescuento.Text = "RD$ " + descuento.ToString("N2", Cultura);
            lblDomicilio.Text = "RD$ " + domicilio.ToString("N2", Cultura);
            lblItbis.Text = "RD$ " + itbis.ToString("N2", Cultura);
            lblTotal.Text = "RD$ " + total.ToString("N2", Cultura);
        }

        // ===== Nuevo alquiler =====
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            txtCliente.Focus();
        }

        // ===== Salir =====
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir de la aplicación?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Close();
        }

        // ===== Métodos auxiliares =====
        private void ReiniciarControlesVehiculo()
        {
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            txtVehiculo.Focus();
        }

        private void LimpiarTodo()
        {
            txtCliente.Clear();
            chkCorporativo.Checked = false;
            dtpSalida.Value = DateTime.Now;
            rbtSucursal.Checked = true;
            ReiniciarControlesVehiculo();

            lstAlquileres.Items.Clear();
            subtotal = 0m;

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";
        }
    }
}