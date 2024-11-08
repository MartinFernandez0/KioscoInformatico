namespace KioscoInformaticoDesktop.Views
{
    partial class HistoricoVentasView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            panel1 = new Panel();
            panelFiltrado = new Panel();
            dateTimeHasta = new DateTimePicker();
            dateTimeDesde = new DateTimePicker();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            label5 = new Label();
            dataGridVentas = new DataGridView();
            btnImprimirInforme = new FontAwesome.Sharp.IconButton();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericTotal = new NumericUpDown();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            checkBoxActivarFIltrado = new CheckBox();
            panel1.SuspendLayout();
            panelFiltrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(303, 33);
            label2.TabIndex = 0;
            label2.Text = "Historico de Ventas";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 52);
            panel1.TabIndex = 32;
            // 
            // panelFiltrado
            // 
            panelFiltrado.BackColor = SystemColors.Control;
            panelFiltrado.BorderStyle = BorderStyle.Fixed3D;
            panelFiltrado.Controls.Add(dateTimeHasta);
            panelFiltrado.Controls.Add(dateTimeDesde);
            panelFiltrado.Controls.Add(btnFiltrar);
            panelFiltrado.Controls.Add(label4);
            panelFiltrado.Controls.Add(label5);
            panelFiltrado.Enabled = false;
            panelFiltrado.Location = new Point(189, 78);
            panelFiltrado.Name = "panelFiltrado";
            panelFiltrado.Size = new Size(579, 64);
            panelFiltrado.TabIndex = 34;
            // 
            // dateTimeHasta
            // 
            dateTimeHasta.Format = DateTimePickerFormat.Short;
            dateTimeHasta.Location = new Point(267, 31);
            dateTimeHasta.Name = "dateTimeHasta";
            dateTimeHasta.Size = new Size(98, 23);
            dateTimeHasta.TabIndex = 56;
            // 
            // dateTimeDesde
            // 
            dateTimeDesde.Format = DateTimePickerFormat.Short;
            dateTimeDesde.Location = new Point(50, 31);
            dateTimeDesde.Name = "dateTimeDesde";
            dateTimeDesde.Size = new Size(98, 23);
            dateTimeDesde.TabIndex = 55;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.BackColor = Color.OrangeRed;
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnFiltrar.IconColor = Color.White;
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFiltrar.IconSize = 38;
            btnFiltrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFiltrar.Location = new Point(447, 8);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(101, 46);
            btnFiltrar.TabIndex = 54;
            btnFiltrar.Text = "FIltrar";
            btnFiltrar.TextAlign = ContentAlignment.MiddleRight;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(72, 9);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 29;
            label4.Text = "Desde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(302, 9);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 31;
            label5.Text = "Hasta";
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridVentas.Location = new Point(3, 148);
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(799, 223);
            dataGridVentas.TabIndex = 41;
            // 
            // btnImprimirInforme
            // 
            btnImprimirInforme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimirInforme.BackColor = Color.OrangeRed;
            btnImprimirInforme.ForeColor = Color.White;
            btnImprimirInforme.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnImprimirInforme.IconColor = Color.White;
            btnImprimirInforme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnImprimirInforme.IconSize = 38;
            btnImprimirInforme.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimirInforme.Location = new Point(650, 384);
            btnImprimirInforme.Name = "btnImprimirInforme";
            btnImprimirInforme.Size = new Size(138, 54);
            btnImprimirInforme.TabIndex = 53;
            btnImprimirInforme.Text = "Imprimir Informe";
            btnImprimirInforme.TextAlign = ContentAlignment.MiddleRight;
            btnImprimirInforme.UseVisualStyleBackColor = false;
            btnImprimirInforme.Click += btnImprimirInforme_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Enabled = false;
            numericUpDown3.Location = new Point(82, 414);
            numericUpDown3.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 62;
            numericUpDown3.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(278, 414);
            numericUpDown2.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 61;
            numericUpDown2.TextAlign = HorizontalAlignment.Right;
            // 
            // numericTotal
            // 
            numericTotal.DecimalPlaces = 2;
            numericTotal.Enabled = false;
            numericTotal.Location = new Point(458, 414);
            numericTotal.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericTotal.Name = "numericTotal";
            numericTotal.Size = new Size(120, 23);
            numericTotal.TabIndex = 60;
            numericTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DeepSkyBlue;
            label9.Location = new Point(503, 384);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 59;
            label9.Text = "TOTAL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DeepSkyBlue;
            label8.Location = new Point(327, 384);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 58;
            label8.Text = "IVA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DeepSkyBlue;
            label7.Location = new Point(121, 384);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 57;
            label7.Text = "NETO";
            // 
            // checkBoxActivarFIltrado
            // 
            checkBoxActivarFIltrado.AutoSize = true;
            checkBoxActivarFIltrado.BackColor = Color.DeepSkyBlue;
            checkBoxActivarFIltrado.Font = new Font("Segoe UI", 13F);
            checkBoxActivarFIltrado.Location = new Point(12, 96);
            checkBoxActivarFIltrado.Name = "checkBoxActivarFIltrado";
            checkBoxActivarFIltrado.Size = new Size(150, 29);
            checkBoxActivarFIltrado.TabIndex = 63;
            checkBoxActivarFIltrado.Text = "Activar Filtrado";
            checkBoxActivarFIltrado.UseVisualStyleBackColor = false;
            checkBoxActivarFIltrado.CheckedChanged += checkBoxActivarFIltrado_CheckedChanged;
            // 
            // HistoricoVentasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFiltrado);
            Controls.Add(checkBoxActivarFIltrado);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericTotal);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnImprimirInforme);
            Controls.Add(dataGridVentas);
            Controls.Add(panel1);
            Name = "HistoricoVentasView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HistoricoVentasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFiltrado.ResumeLayout(false);
            panelFiltrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFormadePago;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private Panel panel1;
        private Panel panelFiltrado;
        private DataGridView dataGridVentas;
        private FontAwesome.Sharp.IconButton btnImprimirInforme;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericTotal;
        private Label label9;
        private Label label8;
        private Label label7;
        private CheckBox checkBoxActivarFIltrado;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimeHasta;
        private DateTimePicker dateTimeDesde;
    }
}