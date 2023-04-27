namespace CapaPresentacion
{
    partial class Gestion_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_productos));
            this.Btningresar_producto_limpiar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.Label();
            this.Txtingresar_producto_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tpgingresarproductos = new System.Windows.Forms.TabPage();
            this.Txtingresar_producto_cantidad = new System.Windows.Forms.TextBox();
            this.Txtingresar_producto_valor = new System.Windows.Forms.TextBox();
            this.Txtingresar_producto_descripcion = new System.Windows.Forms.TextBox();
            this.Btningresa_producto_guardar = new System.Windows.Forms.Button();
            this.Tpgconsultarproducto = new System.Windows.Forms.TabPage();
            this.Btnconsultar_producto_mostrarproducto = new System.Windows.Forms.Button();
            this.Cbxconsultar_producto_producto = new System.Windows.Forms.ComboBox();
            this.Dgwconsultarproducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_consultar_producto_consultar = new System.Windows.Forms.Button();
            this.Tpgmodificarproducto = new System.Windows.Forms.TabPage();
            this.Txtmodificar_producto_cantidad = new System.Windows.Forms.TextBox();
            this.Txtmodificar_producto_valor = new System.Windows.Forms.TextBox();
            this.Txtmodificar_producto_descripcion = new System.Windows.Forms.TextBox();
            this.Btnmodificar_producto_guardarcambios = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbomodificar_produntos_producto = new System.Windows.Forms.ComboBox();
            this.Txtmodificar_producto_codigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btnmodificar_producto_consultar = new System.Windows.Forms.Button();
            this.Tpgeliminarproducto = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.Cboeliminar_produncto_producto = new System.Windows.Forms.ComboBox();
            this.Btneliminar_productos_productos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Tpgingresarproductos.SuspendLayout();
            this.Tpgconsultarproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgwconsultarproducto)).BeginInit();
            this.Tpgmodificarproducto.SuspendLayout();
            this.Tpgeliminarproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btningresar_producto_limpiar
            // 
            this.Btningresar_producto_limpiar.Location = new System.Drawing.Point(310, 147);
            this.Btningresar_producto_limpiar.Name = "Btningresar_producto_limpiar";
            this.Btningresar_producto_limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btningresar_producto_limpiar.TabIndex = 0;
            this.Btningresar_producto_limpiar.Text = "Limpiar";
            this.Btningresar_producto_limpiar.UseVisualStyleBackColor = true;
            this.Btningresar_producto_limpiar.Click += new System.EventHandler(this.Btningresar_producto_limpiar_Click);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(35, 26);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(46, 13);
            this.Codigo.TabIndex = 1;
            this.Codigo.Text = "Codigo";
            // 
            // Txtingresar_producto_codigo
            // 
            this.Txtingresar_producto_codigo.Location = new System.Drawing.Point(137, 23);
            this.Txtingresar_producto_codigo.Name = "Txtingresar_producto_codigo";
            this.Txtingresar_producto_codigo.ShortcutsEnabled = false;
            this.Txtingresar_producto_codigo.Size = new System.Drawing.Size(100, 20);
            this.Txtingresar_producto_codigo.TabIndex = 2;
            this.Txtingresar_producto_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtingresar_producto_codigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tpgingresarproductos);
            this.tabControl1.Controls.Add(this.Tpgconsultarproducto);
            this.tabControl1.Controls.Add(this.Tpgmodificarproducto);
            this.tabControl1.Controls.Add(this.Tpgeliminarproducto);
            this.tabControl1.Location = new System.Drawing.Point(146, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 360);
            this.tabControl1.TabIndex = 6;
            // 
            // Tpgingresarproductos
            // 
            this.Tpgingresarproductos.BackColor = System.Drawing.Color.Coral;
            this.Tpgingresarproductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Tpgingresarproductos.Controls.Add(this.Txtingresar_producto_cantidad);
            this.Tpgingresarproductos.Controls.Add(this.Codigo);
            this.Tpgingresarproductos.Controls.Add(this.Txtingresar_producto_valor);
            this.Tpgingresarproductos.Controls.Add(this.Btningresar_producto_limpiar);
            this.Tpgingresarproductos.Controls.Add(this.Txtingresar_producto_descripcion);
            this.Tpgingresarproductos.Controls.Add(this.Txtingresar_producto_codigo);
            this.Tpgingresarproductos.Controls.Add(this.Btningresa_producto_guardar);
            this.Tpgingresarproductos.Controls.Add(this.label2);
            this.Tpgingresarproductos.Controls.Add(this.label3);
            this.Tpgingresarproductos.Controls.Add(this.label4);
            this.Tpgingresarproductos.Location = new System.Drawing.Point(4, 22);
            this.Tpgingresarproductos.Name = "Tpgingresarproductos";
            this.Tpgingresarproductos.Padding = new System.Windows.Forms.Padding(3);
            this.Tpgingresarproductos.Size = new System.Drawing.Size(438, 334);
            this.Tpgingresarproductos.TabIndex = 0;
            this.Tpgingresarproductos.Text = "Ingresar producto";
            // 
            // Txtingresar_producto_cantidad
            // 
            this.Txtingresar_producto_cantidad.Location = new System.Drawing.Point(137, 178);
            this.Txtingresar_producto_cantidad.Name = "Txtingresar_producto_cantidad";
            this.Txtingresar_producto_cantidad.ShortcutsEnabled = false;
            this.Txtingresar_producto_cantidad.Size = new System.Drawing.Size(100, 20);
            this.Txtingresar_producto_cantidad.TabIndex = 10;
            this.Txtingresar_producto_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtingresar_producto_cantidad_KeyPress);
            // 
            // Txtingresar_producto_valor
            // 
            this.Txtingresar_producto_valor.Location = new System.Drawing.Point(137, 122);
            this.Txtingresar_producto_valor.Name = "Txtingresar_producto_valor";
            this.Txtingresar_producto_valor.ShortcutsEnabled = false;
            this.Txtingresar_producto_valor.Size = new System.Drawing.Size(100, 20);
            this.Txtingresar_producto_valor.TabIndex = 9;
            this.Txtingresar_producto_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtingresar_producto_valor_KeyPress);
            // 
            // Txtingresar_producto_descripcion
            // 
            this.Txtingresar_producto_descripcion.Location = new System.Drawing.Point(137, 64);
            this.Txtingresar_producto_descripcion.Name = "Txtingresar_producto_descripcion";
            this.Txtingresar_producto_descripcion.ShortcutsEnabled = false;
            this.Txtingresar_producto_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Txtingresar_producto_descripcion.TabIndex = 8;
            this.Txtingresar_producto_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtingresar_producto_descripcion_KeyPress);
            // 
            // Btningresa_producto_guardar
            // 
            this.Btningresa_producto_guardar.Location = new System.Drawing.Point(310, 92);
            this.Btningresa_producto_guardar.Name = "Btningresa_producto_guardar";
            this.Btningresa_producto_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btningresa_producto_guardar.TabIndex = 7;
            this.Btningresa_producto_guardar.Text = "Guardar";
            this.Btningresa_producto_guardar.UseVisualStyleBackColor = true;
            this.Btningresa_producto_guardar.Click += new System.EventHandler(this.Btningresa_producto_guardar_Click);
            // 
            // Tpgconsultarproducto
            // 
            this.Tpgconsultarproducto.BackColor = System.Drawing.Color.Coral;
            this.Tpgconsultarproducto.Controls.Add(this.Btnconsultar_producto_mostrarproducto);
            this.Tpgconsultarproducto.Controls.Add(this.Cbxconsultar_producto_producto);
            this.Tpgconsultarproducto.Controls.Add(this.Dgwconsultarproducto);
            this.Tpgconsultarproducto.Controls.Add(this.label1);
            this.Tpgconsultarproducto.Controls.Add(this.Btn_consultar_producto_consultar);
            this.Tpgconsultarproducto.Location = new System.Drawing.Point(4, 22);
            this.Tpgconsultarproducto.Name = "Tpgconsultarproducto";
            this.Tpgconsultarproducto.Padding = new System.Windows.Forms.Padding(3);
            this.Tpgconsultarproducto.Size = new System.Drawing.Size(438, 334);
            this.Tpgconsultarproducto.TabIndex = 1;
            this.Tpgconsultarproducto.Text = "Consultar productos";
            // 
            // Btnconsultar_producto_mostrarproducto
            // 
            this.Btnconsultar_producto_mostrarproducto.Location = new System.Drawing.Point(252, 119);
            this.Btnconsultar_producto_mostrarproducto.Name = "Btnconsultar_producto_mostrarproducto";
            this.Btnconsultar_producto_mostrarproducto.Size = new System.Drawing.Size(75, 23);
            this.Btnconsultar_producto_mostrarproducto.TabIndex = 4;
            this.Btnconsultar_producto_mostrarproducto.Text = "Mostrar todo";
            this.Btnconsultar_producto_mostrarproducto.UseVisualStyleBackColor = true;
            this.Btnconsultar_producto_mostrarproducto.Click += new System.EventHandler(this.Btnconsultar_producto_mostrarproducto_Click);
            // 
            // Cbxconsultar_producto_producto
            // 
            this.Cbxconsultar_producto_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbxconsultar_producto_producto.FormattingEnabled = true;
            this.Cbxconsultar_producto_producto.Location = new System.Drawing.Point(185, 62);
            this.Cbxconsultar_producto_producto.Name = "Cbxconsultar_producto_producto";
            this.Cbxconsultar_producto_producto.Size = new System.Drawing.Size(121, 21);
            this.Cbxconsultar_producto_producto.TabIndex = 3;
            // 
            // Dgwconsultarproducto
            // 
            this.Dgwconsultarproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgwconsultarproducto.Location = new System.Drawing.Point(23, 176);
            this.Dgwconsultarproducto.Name = "Dgwconsultarproducto";
            this.Dgwconsultarproducto.RowHeadersWidth = 51;
            this.Dgwconsultarproducto.Size = new System.Drawing.Size(370, 150);
            this.Dgwconsultarproducto.TabIndex = 2;
       
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto:";
            // 
            // Btn_consultar_producto_consultar
            // 
            this.Btn_consultar_producto_consultar.Location = new System.Drawing.Point(122, 119);
            this.Btn_consultar_producto_consultar.Name = "Btn_consultar_producto_consultar";
            this.Btn_consultar_producto_consultar.Size = new System.Drawing.Size(75, 23);
            this.Btn_consultar_producto_consultar.TabIndex = 0;
            this.Btn_consultar_producto_consultar.Text = "Consultar";
            this.Btn_consultar_producto_consultar.UseVisualStyleBackColor = true;
            this.Btn_consultar_producto_consultar.Click += new System.EventHandler(this.Btn_consultar_producto_consultar_Click);
            // 
            // Tpgmodificarproducto
            // 
            this.Tpgmodificarproducto.BackColor = System.Drawing.Color.Coral;
            this.Tpgmodificarproducto.Controls.Add(this.Txtmodificar_producto_cantidad);
            this.Tpgmodificarproducto.Controls.Add(this.Txtmodificar_producto_valor);
            this.Tpgmodificarproducto.Controls.Add(this.Txtmodificar_producto_descripcion);
            this.Tpgmodificarproducto.Controls.Add(this.Btnmodificar_producto_guardarcambios);
            this.Tpgmodificarproducto.Controls.Add(this.label9);
            this.Tpgmodificarproducto.Controls.Add(this.label8);
            this.Tpgmodificarproducto.Controls.Add(this.label7);
            this.Tpgmodificarproducto.Controls.Add(this.label6);
            this.Tpgmodificarproducto.Controls.Add(this.Cbomodificar_produntos_producto);
            this.Tpgmodificarproducto.Controls.Add(this.Txtmodificar_producto_codigo);
            this.Tpgmodificarproducto.Controls.Add(this.label5);
            this.Tpgmodificarproducto.Controls.Add(this.Btnmodificar_producto_consultar);
            this.Tpgmodificarproducto.Location = new System.Drawing.Point(4, 22);
            this.Tpgmodificarproducto.Name = "Tpgmodificarproducto";
            this.Tpgmodificarproducto.Size = new System.Drawing.Size(438, 334);
            this.Tpgmodificarproducto.TabIndex = 2;
            this.Tpgmodificarproducto.Text = "Modificar productos";
            // 
            // Txtmodificar_producto_cantidad
            // 
            this.Txtmodificar_producto_cantidad.Location = new System.Drawing.Point(219, 251);
            this.Txtmodificar_producto_cantidad.Name = "Txtmodificar_producto_cantidad";
            this.Txtmodificar_producto_cantidad.ShortcutsEnabled = false;
            this.Txtmodificar_producto_cantidad.Size = new System.Drawing.Size(100, 20);
            this.Txtmodificar_producto_cantidad.TabIndex = 12;
            this.Txtmodificar_producto_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtmodificar_producto_cantidad_KeyPress);
            // 
            // Txtmodificar_producto_valor
            // 
            this.Txtmodificar_producto_valor.Location = new System.Drawing.Point(219, 218);
            this.Txtmodificar_producto_valor.Name = "Txtmodificar_producto_valor";
            this.Txtmodificar_producto_valor.ShortcutsEnabled = false;
            this.Txtmodificar_producto_valor.Size = new System.Drawing.Size(100, 20);
            this.Txtmodificar_producto_valor.TabIndex = 10;
            this.Txtmodificar_producto_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtmodificar_producto_valor_KeyPress);
            // 
            // Txtmodificar_producto_descripcion
            // 
            this.Txtmodificar_producto_descripcion.Location = new System.Drawing.Point(220, 181);
            this.Txtmodificar_producto_descripcion.Name = "Txtmodificar_producto_descripcion";
            this.Txtmodificar_producto_descripcion.ShortcutsEnabled = false;
            this.Txtmodificar_producto_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Txtmodificar_producto_descripcion.TabIndex = 9;
            // 
            // Btnmodificar_producto_guardarcambios
            // 
            this.Btnmodificar_producto_guardarcambios.Location = new System.Drawing.Point(236, 295);
            this.Btnmodificar_producto_guardarcambios.Name = "Btnmodificar_producto_guardarcambios";
            this.Btnmodificar_producto_guardarcambios.Size = new System.Drawing.Size(75, 23);
            this.Btnmodificar_producto_guardarcambios.TabIndex = 8;
            this.Btnmodificar_producto_guardarcambios.Text = "Guardar Cambios";
            this.Btnmodificar_producto_guardarcambios.UseVisualStyleBackColor = true;
            this.Btnmodificar_producto_guardarcambios.Click += new System.EventHandler(this.Btnmodificar_producto_guardarcambios_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(111, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(111, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Codigo";
            // 
            // Cbomodificar_produntos_producto
            // 
            this.Cbomodificar_produntos_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbomodificar_produntos_producto.FormattingEnabled = true;
            this.Cbomodificar_produntos_producto.Location = new System.Drawing.Point(219, 42);
            this.Cbomodificar_produntos_producto.Name = "Cbomodificar_produntos_producto";
            this.Cbomodificar_produntos_producto.Size = new System.Drawing.Size(121, 21);
            this.Cbomodificar_produntos_producto.TabIndex = 3;
            // 
            // Txtmodificar_producto_codigo
            // 
            this.Txtmodificar_producto_codigo.Location = new System.Drawing.Point(220, 126);
            this.Txtmodificar_producto_codigo.Name = "Txtmodificar_producto_codigo";
            this.Txtmodificar_producto_codigo.ReadOnly = true;
            this.Txtmodificar_producto_codigo.Size = new System.Drawing.Size(100, 20);
            this.Txtmodificar_producto_codigo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Productos";
            // 
            // Btnmodificar_producto_consultar
            // 
            this.Btnmodificar_producto_consultar.Location = new System.Drawing.Point(236, 76);
            this.Btnmodificar_producto_consultar.Name = "Btnmodificar_producto_consultar";
            this.Btnmodificar_producto_consultar.Size = new System.Drawing.Size(75, 23);
            this.Btnmodificar_producto_consultar.TabIndex = 0;
            this.Btnmodificar_producto_consultar.Text = "Consultar";
            this.Btnmodificar_producto_consultar.UseVisualStyleBackColor = true;
            this.Btnmodificar_producto_consultar.Click += new System.EventHandler(this.Btnmodificar_producto_consultar_Click);
            // 
            // Tpgeliminarproducto
            // 
            this.Tpgeliminarproducto.BackColor = System.Drawing.Color.Coral;
            this.Tpgeliminarproducto.Controls.Add(this.label11);
            this.Tpgeliminarproducto.Controls.Add(this.Cboeliminar_produncto_producto);
            this.Tpgeliminarproducto.Controls.Add(this.Btneliminar_productos_productos);
            this.Tpgeliminarproducto.Location = new System.Drawing.Point(4, 22);
            this.Tpgeliminarproducto.Name = "Tpgeliminarproducto";
            this.Tpgeliminarproducto.Size = new System.Drawing.Size(438, 334);
            this.Tpgeliminarproducto.TabIndex = 3;
            this.Tpgeliminarproducto.Text = "Eliminar Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(110, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Producto";
            // 
            // Cboeliminar_produncto_producto
            // 
            this.Cboeliminar_produncto_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cboeliminar_produncto_producto.FormattingEnabled = true;
            this.Cboeliminar_produncto_producto.Location = new System.Drawing.Point(200, 83);
            this.Cboeliminar_produncto_producto.Name = "Cboeliminar_produncto_producto";
            this.Cboeliminar_produncto_producto.Size = new System.Drawing.Size(121, 21);
            this.Cboeliminar_produncto_producto.TabIndex = 1;
            // 
            // Btneliminar_productos_productos
            // 
            this.Btneliminar_productos_productos.Location = new System.Drawing.Point(167, 154);
            this.Btneliminar_productos_productos.Name = "Btneliminar_productos_productos";
            this.Btneliminar_productos_productos.Size = new System.Drawing.Size(75, 23);
            this.Btneliminar_productos_productos.TabIndex = 0;
            this.Btneliminar_productos_productos.Text = "Eliminar";
            this.Btneliminar_productos_productos.UseVisualStyleBackColor = true;
            this.Btneliminar_productos_productos.Click += new System.EventHandler(this.Btneliminar_productos_productos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(723, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(141, 65);
            this.dataGridView1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Gestión de Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Gestion_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1035, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_productos";
            this.Text = "Gestion_productos";
            this.Load += new System.EventHandler(this.Gestion_productos_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tpgingresarproductos.ResumeLayout(false);
            this.Tpgingresarproductos.PerformLayout();
            this.Tpgconsultarproducto.ResumeLayout(false);
            this.Tpgconsultarproducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgwconsultarproducto)).EndInit();
            this.Tpgmodificarproducto.ResumeLayout(false);
            this.Tpgmodificarproducto.PerformLayout();
            this.Tpgeliminarproducto.ResumeLayout(false);
            this.Tpgeliminarproducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btningresar_producto_limpiar;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.TextBox Txtingresar_producto_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tpgingresarproductos;
        private System.Windows.Forms.TextBox Txtingresar_producto_cantidad;
        private System.Windows.Forms.TextBox Txtingresar_producto_valor;
        private System.Windows.Forms.TextBox Txtingresar_producto_descripcion;
        private System.Windows.Forms.Button Btningresa_producto_guardar;
        private System.Windows.Forms.TabPage Tpgconsultarproducto;
        private System.Windows.Forms.Button Btnconsultar_producto_mostrarproducto;
        private System.Windows.Forms.ComboBox Cbxconsultar_producto_producto;
        private System.Windows.Forms.DataGridView Dgwconsultarproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_consultar_producto_consultar;
        private System.Windows.Forms.TabPage Tpgmodificarproducto;
        private System.Windows.Forms.TextBox Txtmodificar_producto_valor;
        private System.Windows.Forms.TextBox Txtmodificar_producto_descripcion;
        private System.Windows.Forms.Button Btnmodificar_producto_guardarcambios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbomodificar_produntos_producto;
        private System.Windows.Forms.TextBox Txtmodificar_producto_codigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btnmodificar_producto_consultar;
        private System.Windows.Forms.TabPage Tpgeliminarproducto;
        private System.Windows.Forms.TextBox Txtmodificar_producto_cantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Cboeliminar_produncto_producto;
        private System.Windows.Forms.Button Btneliminar_productos_productos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}