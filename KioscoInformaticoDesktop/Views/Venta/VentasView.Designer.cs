﻿namespace KioscoInformaticoDesktop.GenerateCompraView
{
    partial class VentasView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            comboBoxCliente = new ComboBox();
            comboBoxFormadePago = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridViewDetalleVenta = new DataGridView();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            btnQuitar = new Button();
            comboBoxProducto = new ComboBox();
            numericTotal = new NumericUpDown();
            numericPrecio = new NumericUpDown();
            numericCantidad = new NumericUpDown();
            numericSubtotal = new NumericUpDown();
            panel1 = new Panel();
            btnFinalizarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(700, 125);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(108, 43);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(260, 65);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(198, 23);
            comboBoxCliente.TabIndex = 26;
            // 
            // comboBoxFormadePago
            // 
            comboBoxFormadePago.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormadePago.FormattingEnabled = true;
            comboBoxFormadePago.Location = new Point(37, 65);
            comboBoxFormadePago.Name = "comboBoxFormadePago";
            comboBoxFormadePago.Size = new Size(172, 23);
            comboBoxFormadePago.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 28;
            label1.Text = "Forma de Pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 29);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 29;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 107);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 31;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 107);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 33;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 107);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 35;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 107);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 38;
            label6.Text = "Subtotal $";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(738, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // dataGridViewDetalleVenta
            // 
            dataGridViewDetalleVenta.AllowUserToAddRows = false;
            dataGridViewDetalleVenta.AllowUserToDeleteRows = false;
            dataGridViewDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalleVenta.Location = new Point(28, 324);
            dataGridViewDetalleVenta.Name = "dataGridViewDetalleVenta";
            dataGridViewDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetalleVenta.Size = new Size(805, 143);
            dataGridViewDetalleVenta.TabIndex = 40;
            dataGridViewDetalleVenta.DataBindingComplete += dataGridViewDetalleVenta_DataBindingComplete;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 199);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 42;
            label7.Text = "NETO";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(98, 195);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(97, 23);
            textBox5.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 199);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 44;
            label8.Text = "IVA";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(306, 195);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(97, 23);
            textBox6.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(643, 251);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 46;
            label9.Text = "TOTAL";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(700, 183);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(108, 43);
            btnQuitar.TabIndex = 47;
            btnQuitar.Text = "Quitar Venta";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // comboBoxProducto
            // 
            comboBoxProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducto.FormattingEnabled = true;
            comboBoxProducto.Location = new Point(37, 137);
            comboBoxProducto.Name = "comboBoxProducto";
            comboBoxProducto.Size = new Size(172, 23);
            comboBoxProducto.TabIndex = 49;
            comboBoxProducto.SelectedIndexChanged += comboBoxProducto_SelectedIndexChanged;
            // 
            // numericTotal
            // 
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(700, 249);
            numericTotal.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(120, 23);
            numericTotal.TabIndex = 52;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // numericPrecio
            // 
            numericPrecio.DecimalPlaces = 2;
            numericPrecio.Enabled = false;
            numericPrecio.Location = new Point(247, 42);
            numericPrecio.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericPrecio.Name = "numericPrecio";
            numericPrecio.Size = new Size(120, 23);
            numericPrecio.TabIndex = 49;
            numericPrecio.TextAlign = HorizontalAlignment.Right;
            numericPrecio.ValueChanged += numericPrecio_ValueChanged;
            // 
            // numericCantidad
            // 
            numericCantidad.Location = new Point(412, 42);
            numericCantidad.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(69, 23);
            numericCantidad.TabIndex = 50;
            numericCantidad.TextAlign = HorizontalAlignment.Center;
            numericCantidad.ValueChanged += numericCantidad_ValueChanged;
            // 
            // numericSubtotal
            // 
            numericSubtotal.DecimalPlaces = 2;
            numericSubtotal.Enabled = false;
            numericSubtotal.Location = new Point(532, 42);
            numericSubtotal.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericSubtotal.Name = "numericSubtotal";
            numericSubtotal.Size = new Size(120, 23);
            numericSubtotal.TabIndex = 51;
            numericSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(numericSubtotal);
            panel1.Controls.Add(numericCantidad);
            panel1.Controls.Add(numericPrecio);
            panel1.Location = new Point(12, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 83);
            panel1.TabIndex = 50;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(28, 275);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(108, 43);
            btnFinalizarVenta.TabIndex = 53;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // RegistroVentaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(858, 479);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(numericTotal);
            Controls.Add(comboBoxProducto);
            Controls.Add(btnQuitar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(dataGridViewDetalleVenta);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxFormadePago);
            Controls.Add(comboBoxCliente);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "RegistroVentaView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSubtotal).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxFormadePago;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridViewDetalleVenta;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private Button btnQuitar;
        private ComboBox comboBoxProducto;
        private NumericUpDown numericTotal;
        private NumericUpDown numericPrecio;
        private NumericUpDown numericCantidad;
        private NumericUpDown numericSubtotal;
        private Panel panel1;
        private Button btnFinalizarVenta;
    }
}