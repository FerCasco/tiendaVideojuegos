namespace TiendaVideoJuegosV2
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompania = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBox_Digital = new System.Windows.Forms.CheckBox();
            this.chkBox_Fisico = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Seminuevo = new System.Windows.Forms.RadioButton();
            this.rb_Nuevo = new System.Windows.Forms.RadioButton();
            this.lst_Box = new System.Windows.Forms.ListBox();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.cbBox_Categoria = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(9, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(361, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "TIENDA VIDEOJUEGOS";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(86, 72);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(163, 20);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Compañía";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCompania
            // 
            this.txtCompania.Location = new System.Drawing.Point(86, 106);
            this.txtCompania.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompania.Name = "txtCompania";
            this.txtCompania.Size = new System.Drawing.Size(163, 20);
            this.txtCompania.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categoría";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(86, 171);
            this.txt_Precio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(163, 20);
            this.txt_Precio.TabIndex = 10;
            this.txt_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBox_Digital);
            this.groupBox1.Controls.Add(this.chkBox_Fisico);
            this.groupBox1.Location = new System.Drawing.Point(304, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(108, 86);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato";
            // 
            // chkBox_Digital
            // 
            this.chkBox_Digital.AutoSize = true;
            this.chkBox_Digital.Location = new System.Drawing.Point(11, 55);
            this.chkBox_Digital.Margin = new System.Windows.Forms.Padding(2);
            this.chkBox_Digital.Name = "chkBox_Digital";
            this.chkBox_Digital.Size = new System.Drawing.Size(96, 17);
            this.chkBox_Digital.TabIndex = 1;
            this.chkBox_Digital.Text = "Formato Digital";
            this.chkBox_Digital.UseVisualStyleBackColor = true;
            // 
            // chkBox_Fisico
            // 
            this.chkBox_Fisico.AutoSize = true;
            this.chkBox_Fisico.Location = new System.Drawing.Point(11, 25);
            this.chkBox_Fisico.Margin = new System.Windows.Forms.Padding(2);
            this.chkBox_Fisico.Name = "chkBox_Fisico";
            this.chkBox_Fisico.Size = new System.Drawing.Size(96, 17);
            this.chkBox_Fisico.TabIndex = 0;
            this.chkBox_Fisico.Text = "Formato Físico";
            this.chkBox_Fisico.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Seminuevo);
            this.groupBox2.Controls.Add(this.rb_Nuevo);
            this.groupBox2.Location = new System.Drawing.Point(464, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(108, 86);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // rb_Seminuevo
            // 
            this.rb_Seminuevo.AutoSize = true;
            this.rb_Seminuevo.Location = new System.Drawing.Point(14, 53);
            this.rb_Seminuevo.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Seminuevo.Name = "rb_Seminuevo";
            this.rb_Seminuevo.Size = new System.Drawing.Size(78, 17);
            this.rb_Seminuevo.TabIndex = 1;
            this.rb_Seminuevo.TabStop = true;
            this.rb_Seminuevo.Text = "Seminuevo";
            this.rb_Seminuevo.UseVisualStyleBackColor = true;
            // 
            // rb_Nuevo
            // 
            this.rb_Nuevo.AutoSize = true;
            this.rb_Nuevo.Location = new System.Drawing.Point(14, 23);
            this.rb_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Nuevo.Name = "rb_Nuevo";
            this.rb_Nuevo.Size = new System.Drawing.Size(57, 17);
            this.rb_Nuevo.TabIndex = 0;
            this.rb_Nuevo.TabStop = true;
            this.rb_Nuevo.Text = "Nuevo";
            this.rb_Nuevo.UseVisualStyleBackColor = true;
            // 
            // lst_Box
            // 
            this.lst_Box.FormattingEnabled = true;
            this.lst_Box.Location = new System.Drawing.Point(274, 156);
            this.lst_Box.Margin = new System.Windows.Forms.Padding(2);
            this.lst_Box.Name = "lst_Box";
            this.lst_Box.Size = new System.Drawing.Size(318, 199);
            this.lst_Box.TabIndex = 14;
            this.lst_Box.SelectedIndexChanged += new System.EventHandler(this.lst_Box_SelectedIndexChanged);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(11, 209);
            this.btn_Alta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(100, 47);
            this.btn_Alta.TabIndex = 15;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(162, 209);
            this.btn_Baja.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(100, 47);
            this.btn_Baja.TabIndex = 16;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(11, 300);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(100, 47);
            this.btn_Nuevo.TabIndex = 17;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(162, 300);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(100, 47);
            this.btn_Modificar.TabIndex = 18;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // cbBox_Categoria
            // 
            this.cbBox_Categoria.FormattingEnabled = true;
            this.cbBox_Categoria.Location = new System.Drawing.Point(86, 139);
            this.cbBox_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbBox_Categoria.Name = "cbBox_Categoria";
            this.cbBox_Categoria.Size = new System.Drawing.Size(163, 21);
            this.cbBox_Categoria.TabIndex = 8;
            this.cbBox_Categoria.SelectedIndexChanged += new System.EventHandler(this.cbBox_Categoria_SelectedIndexChanged);
            this.cbBox_Categoria.Items.AddRange(new object[]{
                "Accion",
                "Arcade",
                "Aventuras",
                "Juegos de mesa",
                "Juegos educativos",
                "Juegos musicales",
                "Plataformas",
                "Sandbox",
                "Shooter",
                "Terror"
            });
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.lst_Box);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBox_Categoria);
            this.Controls.Add(this.txtCompania);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompania;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBox_Digital;
        private System.Windows.Forms.CheckBox chkBox_Fisico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Seminuevo;
        private System.Windows.Forms.RadioButton rb_Nuevo;
        private System.Windows.Forms.ListBox lst_Box;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.ComboBox cbBox_Categoria;
    }
}

