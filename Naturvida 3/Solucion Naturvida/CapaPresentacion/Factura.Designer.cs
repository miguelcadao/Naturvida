namespace CapaPresentacion
{
    partial class Factura
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
            this.DgvProductosFactura = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboProducto = new System.Windows.Forms.ComboBox();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.DtpFecha_Factura = new System.Windows.Forms.DateTimePicker();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnTerminarFactura = new System.Windows.Forms.Button();
            this.TxtTotal_Factura = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtNFactura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProductosFactura
            // 
            this.DgvProductosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosFactura.Location = new System.Drawing.Point(349, 89);
            this.DgvProductosFactura.Margin = new System.Windows.Forms.Padding(2);
            this.DgvProductosFactura.Name = "DgvProductosFactura";
            this.DgvProductosFactura.ReadOnly = true;
            this.DgvProductosFactura.RowHeadersWidth = 51;
            this.DgvProductosFactura.RowTemplate.Height = 24;
            this.DgvProductosFactura.Size = new System.Drawing.Size(552, 160);
            this.DgvProductosFactura.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(615, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Facturación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Productos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "#Factura";
            // 
            // CboProducto
            // 
            this.CboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProducto.FormattingEnabled = true;
            this.CboProducto.Location = new System.Drawing.Point(165, 219);
            this.CboProducto.Margin = new System.Windows.Forms.Padding(2);
            this.CboProducto.Name = "CboProducto";
            this.CboProducto.Size = new System.Drawing.Size(151, 21);
            this.CboProducto.TabIndex = 28;
            // 
            // CboCliente
            // 
            this.CboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(165, 182);
            this.CboCliente.Margin = new System.Windows.Forms.Padding(2);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(151, 21);
            this.CboCliente.TabIndex = 27;
            // 
            // DtpFecha_Factura
            // 
            this.DtpFecha_Factura.Enabled = false;
            this.DtpFecha_Factura.Location = new System.Drawing.Point(165, 144);
            this.DtpFecha_Factura.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFecha_Factura.Name = "DtpFecha_Factura";
            this.DtpFecha_Factura.Size = new System.Drawing.Size(151, 20);
            this.DtpFecha_Factura.TabIndex = 26;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(342, 271);
            this.BtnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(117, 25);
            this.BtnAgregarProducto.TabIndex = 25;
            this.BtnAgregarProducto.Text = "Agregar Producto";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnTerminarFactura
            // 
            this.BtnTerminarFactura.Location = new System.Drawing.Point(165, 307);
            this.BtnTerminarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTerminarFactura.Name = "BtnTerminarFactura";
            this.BtnTerminarFactura.Size = new System.Drawing.Size(111, 26);
            this.BtnTerminarFactura.TabIndex = 24;
            this.BtnTerminarFactura.Text = "Terminar Factura";
            this.BtnTerminarFactura.UseVisualStyleBackColor = true;
            this.BtnTerminarFactura.Click += new System.EventHandler(this.BtnTerminarFactura_Click);
            // 
            // TxtTotal_Factura
            // 
            this.TxtTotal_Factura.Enabled = false;
            this.TxtTotal_Factura.Location = new System.Drawing.Point(703, 271);
            this.TxtTotal_Factura.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotal_Factura.Name = "TxtTotal_Factura";
            this.TxtTotal_Factura.ShortcutsEnabled = false;
            this.TxtTotal_Factura.Size = new System.Drawing.Size(76, 20);
            this.TxtTotal_Factura.TabIndex = 23;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(165, 266);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.ShortcutsEnabled = false;
            this.TxtCantidad.Size = new System.Drawing.Size(76, 20);
            this.TxtCantidad.TabIndex = 22;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // TxtNFactura
            // 
            this.TxtNFactura.BackColor = System.Drawing.Color.White;
            this.TxtNFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNFactura.Enabled = false;
            this.TxtNFactura.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNFactura.ForeColor = System.Drawing.Color.Black;
            this.TxtNFactura.Location = new System.Drawing.Point(165, 89);
            this.TxtNFactura.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNFactura.Name = "TxtNFactura";
            this.TxtNFactura.Size = new System.Drawing.Size(75, 24);
            this.TxtNFactura.TabIndex = 21;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1386, 631);
            this.Controls.Add(this.DgvProductosFactura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboProducto);
            this.Controls.Add(this.CboCliente);
            this.Controls.Add(this.DtpFecha_Factura);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.BtnTerminarFactura);
            this.Controls.Add(this.TxtTotal_Factura);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtNFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvProductosFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboProducto;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.DateTimePicker DtpFecha_Factura;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnTerminarFactura;
        private System.Windows.Forms.TextBox TxtTotal_Factura;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtNFactura;
    }
}