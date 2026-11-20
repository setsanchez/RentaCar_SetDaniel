namespace Examen_RentarCar_SetDaniel
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtCliente = new TextBox();
            dtpSalida = new DateTimePicker();
            chkCorporativo = new CheckBox();
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            nudDias = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            lblEncabezado = new Label();
            lstAlquileres = new ListBox();
            lblTxtSubtotal = new Label();
            lblTxtDescuento = new Label();
            lblTxtDomicilio = new Label();
            lblTxtItbis = new Label();
            lblTxtTotal = new Label();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            rbtCompleto = new RadioButton();
            rbtBasico = new RadioButton();
            lblCliente = new Label();
            lblSalida = new Label();
            lblVehiculo = new Label();
            lblTarifa = new Label();
            lblDias = new Label();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblDomicilio = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            chkGps = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(108, 12);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(275, 27);
            txtCliente.TabIndex = 0;
            // 
            // dtpSalida
            // 
            dtpSalida.Format = DateTimePickerFormat.Short;
            dtpSalida.Location = new Point(98, 85);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(285, 27);
            dtpSalida.TabIndex = 2;
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(21, 45);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(158, 24);
            chkCorporativo.TabIndex = 1;
            chkCorporativo.Text = "Cliente corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(98, 129);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(285, 27);
            txtVehiculo.TabIndex = 3;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(98, 162);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(285, 27);
            txtTarifa.TabIndex = 4;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(98, 195);
            nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(138, 27);
            nudDias.TabIndex = 5;
            nudDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1 (Entrega)
            // 
            groupBox1.Controls.Add(rbtDomicilio);
            groupBox1.Controls.Add(rbtSucursal);
            groupBox1.Location = new Point(198, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrega";
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(6, 66);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(171, 24);
            rbtDomicilio.TabIndex = 1;
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Checked = true;
            rbtSucursal.Location = new Point(6, 36);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(102, 24);
            rbtSucursal.TabIndex = 0;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "En sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Location = new Point(406, 62);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(295, 20);
            lblEncabezado.TabIndex = 9;
            lblEncabezado.Text = "Dias  Vehiculo                         Tarifa      Total";
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(406, 85);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(440, 164);
            lstAlquileres.TabIndex = 10;
            // 
            // lblTxtSubtotal
            // 
            lblTxtSubtotal.AutoSize = true;
            lblTxtSubtotal.Location = new Point(406, 261);
            lblTxtSubtotal.Name = "lblTxtSubtotal";
            lblTxtSubtotal.Size = new Size(65, 20);
            lblTxtSubtotal.TabIndex = 11;
            lblTxtSubtotal.Text = "Subtotal";
            // 
            // lblTxtDescuento
            // 
            lblTxtDescuento.AutoSize = true;
            lblTxtDescuento.Location = new Point(406, 294);
            lblTxtDescuento.Name = "lblTxtDescuento";
            lblTxtDescuento.Size = new Size(79, 20);
            lblTxtDescuento.TabIndex = 12;
            lblTxtDescuento.Text = "Descuento";
            // 
            // lblTxtDomicilio
            // 
            lblTxtDomicilio.AutoSize = true;
            lblTxtDomicilio.Location = new Point(406, 327);
            lblTxtDomicilio.Name = "lblTxtDomicilio";
            lblTxtDomicilio.Size = new Size(74, 20);
            lblTxtDomicilio.TabIndex = 13;
            lblTxtDomicilio.Text = "Domicilio";
            // 
            // lblTxtItbis
            // 
            lblTxtItbis.AutoSize = true;
            lblTxtItbis.Location = new Point(406, 360);
            lblTxtItbis.Name = "lblTxtItbis";
            lblTxtItbis.Size = new Size(96, 20);
            lblTxtItbis.TabIndex = 14;
            lblTxtItbis.Text = "ITBIS ( 18 % )";
            // 
            // lblTxtTotal
            // 
            lblTxtTotal.AutoSize = true;
            lblTxtTotal.Location = new Point(406, 398);
            lblTxtTotal.Name = "lblTxtTotal";
            lblTxtTotal.Size = new Size(114, 20);
            lblTxtTotal.TabIndex = 15;
            lblTxtTotal.Text = "TOTAL A PAGAR";
            // 
            // lblSubtotal
            // 
            lblSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblSubtotal.Location = new Point(560, 255);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(160, 27);
            lblSubtotal.TabIndex = 16;
            lblSubtotal.Text = "RD$ 0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.BorderStyle = BorderStyle.FixedSingle;
            lblDescuento.Location = new Point(560, 288);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(160, 27);
            lblDescuento.TabIndex = 17;
            lblDescuento.Text = "RD$ 0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDomicilio
            // 
            lblDomicilio.BorderStyle = BorderStyle.FixedSingle;
            lblDomicilio.Location = new Point(560, 321);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(160, 27);
            lblDomicilio.TabIndex = 18;
            lblDomicilio.Text = "RD$ 0.00";
            lblDomicilio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItbis
            // 
            lblItbis.BorderStyle = BorderStyle.FixedSingle;
            lblItbis.Location = new Point(560, 354);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(160, 27);
            lblItbis.TabIndex = 19;
            lblItbis.Text = "RD$ 0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Location = new Point(560, 392);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(160, 27);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "RD$ 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(406, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(440, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2 (Seguro)
            // 
            groupBox2.Controls.Add(rbtCompleto);
            groupBox2.Controls.Add(rbtBasico);
            groupBox2.Location = new Point(21, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seguro";
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Location = new Point(6, 66);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(172, 24);
            rbtCompleto.TabIndex = 1;
            rbtCompleto.Text = "Completo (+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Checked = true;
            rbtBasico.Location = new Point(6, 36);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(73, 24);
            rbtBasico.TabIndex = 0;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(21, 15);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 21;
            lblCliente.Text = "Cliente:";
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(21, 92);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(53, 20);
            lblSalida.TabIndex = 22;
            lblSalida.Text = "Salida:";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(21, 132);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(68, 20);
            lblVehiculo.TabIndex = 23;
            lblVehiculo.Text = "Vehiculo:";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(21, 165);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(48, 20);
            lblTarifa.TabIndex = 24;
            lblTarifa.Text = "Tarifa:";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(21, 197);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(41, 20);
            lblDias.TabIndex = 25;
            lblDias.Text = "Dias:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(27, 411);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(117, 43);
            btnCalcular.TabIndex = 27;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(154, 411);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 43);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Nuevo alquiler";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(287, 411);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 43);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(32, 368);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(185, 24);
            chkGps.TabIndex = 26;
            chkGps.Text = "GPS (+RD$100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 467);
            Controls.Add(chkGps);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(lblDias);
            Controls.Add(lblTarifa);
            Controls.Add(lblVehiculo);
            Controls.Add(lblSalida);
            Controls.Add(lblCliente);
            Controls.Add(groupBox2);
            Controls.Add(btnAgregar);
            Controls.Add(lblTxtTotal);
            Controls.Add(lblTxtItbis);
            Controls.Add(lblTxtDomicilio);
            Controls.Add(lblTxtDescuento);
            Controls.Add(lblTxtSubtotal);
            Controls.Add(lstAlquileres);
            Controls.Add(lblEncabezado);
            Controls.Add(groupBox1);
            Controls.Add(nudDias);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(chkCorporativo);
            Controls.Add(dtpSalida);
            Controls.Add(txtCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentaCar Express - Alquileres";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCliente;
        private DateTimePicker dtpSalida;
        private CheckBox chkCorporativo;
        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private NumericUpDown nudDias;
        private GroupBox groupBox1;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private Label lblEncabezado;
        private ListBox lstAlquileres;
        private Label lblTxtSubtotal;
        private Label lblTxtDescuento;
        private Label lblTxtDomicilio;
        private Label lblTxtItbis;
        private Label lblTxtTotal;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private RadioButton rbtCompleto;
        private RadioButton rbtBasico;
        private Label lblCliente;
        private Label lblSalida;
        private Label lblVehiculo;
        private Label lblTarifa;
        private Label lblDias;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblDomicilio;
        private Label lblItbis;
        private Label lblTotal;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private CheckBox chkGps;
    }
}