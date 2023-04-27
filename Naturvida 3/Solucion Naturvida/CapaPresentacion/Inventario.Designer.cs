namespace CapaPresentacion
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.Cbo_Inventario_Producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_MInventario_Mostrar_Todo = new System.Windows.Forms.Button();
            this.Btn_Inventario_Consultar = new System.Windows.Forms.Button();
            this.Dgv_Inventario = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Inventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbo_Inventario_Producto
            // 
            this.Cbo_Inventario_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Inventario_Producto.FormattingEnabled = true;
            this.Cbo_Inventario_Producto.Location = new System.Drawing.Point(357, 83);
            this.Cbo_Inventario_Producto.Name = "Cbo_Inventario_Producto";
            this.Cbo_Inventario_Producto.Size = new System.Drawing.Size(233, 21);
            this.Cbo_Inventario_Producto.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Producto";
            // 
            // Btn_MInventario_Mostrar_Todo
            // 
            this.Btn_MInventario_Mostrar_Todo.Location = new System.Drawing.Point(449, 144);
            this.Btn_MInventario_Mostrar_Todo.Name = "Btn_MInventario_Mostrar_Todo";
            this.Btn_MInventario_Mostrar_Todo.Size = new System.Drawing.Size(75, 23);
            this.Btn_MInventario_Mostrar_Todo.TabIndex = 8;
            this.Btn_MInventario_Mostrar_Todo.Text = "Mostrar Todo";
            this.Btn_MInventario_Mostrar_Todo.UseVisualStyleBackColor = true;
            this.Btn_MInventario_Mostrar_Todo.Click += new System.EventHandler(this.Btn_MInventario_Mostrar_Todo_Click);
            // 
            // Btn_Inventario_Consultar
            // 
            this.Btn_Inventario_Consultar.Location = new System.Drawing.Point(335, 144);
            this.Btn_Inventario_Consultar.Name = "Btn_Inventario_Consultar";
            this.Btn_Inventario_Consultar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Inventario_Consultar.TabIndex = 7;
            this.Btn_Inventario_Consultar.Text = "Consultar";
            this.Btn_Inventario_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Inventario_Consultar.Click += new System.EventHandler(this.Btn_Inventario_Consultar_Click);
            // 
            // Dgv_Inventario
            // 
            this.Dgv_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Inventario.Location = new System.Drawing.Point(211, 201);
            this.Dgv_Inventario.Name = "Dgv_Inventario";
            this.Dgv_Inventario.RowHeadersWidth = 51;
            this.Dgv_Inventario.Size = new System.Drawing.Size(467, 150);
            this.Dgv_Inventario.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Inventario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(628, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(901, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cbo_Inventario_Producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_MInventario_Mostrar_Todo);
            this.Controls.Add(this.Btn_Inventario_Consultar);
            this.Controls.Add(this.Dgv_Inventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Inventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbo_Inventario_Producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_MInventario_Mostrar_Todo;
        private System.Windows.Forms.Button Btn_Inventario_Consultar;
        private System.Windows.Forms.DataGridView Dgv_Inventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}