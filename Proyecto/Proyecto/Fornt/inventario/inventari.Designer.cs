namespace Proyecto
{
    partial class inventari
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
            this.button_Registrar_libro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Buscar_por_ISBN = new System.Windows.Forms.Button();
            this.button_Buscar_por_Titulo = new System.Windows.Forms.Button();
            this.button_Eliminar_Libro = new System.Windows.Forms.Button();
            this.button_Abastecimiento = new System.Windows.Forms.Button();
            this.Texto_Titulo = new System.Windows.Forms.Label();
            this.text_Titutlo = new System.Windows.Forms.Label();
            this.text_Precio_de_compra = new System.Windows.Forms.Label();
            this.text_Precio_de_venta = new System.Windows.Forms.Label();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.textBox_Precio_de_Compra = new System.Windows.Forms.TextBox();
            this.textBox_Precio_de_venta = new System.Windows.Forms.TextBox();
            this.button_Registrar = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Registrar_libro
            // 
            this.button_Registrar_libro.Location = new System.Drawing.Point(100, 92);
            this.button_Registrar_libro.Name = "button_Registrar_libro";
            this.button_Registrar_libro.Size = new System.Drawing.Size(191, 42);
            this.button_Registrar_libro.TabIndex = 0;
            this.button_Registrar_libro.Text = "Registrar Libro";
            this.button_Registrar_libro.UseVisualStyleBackColor = true;
            this.button_Registrar_libro.Click += new System.EventHandler(this.button_Registrar_libro_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(586, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_Buscar_por_ISBN
            // 
            this.button_Buscar_por_ISBN.Location = new System.Drawing.Point(100, 233);
            this.button_Buscar_por_ISBN.Name = "button_Buscar_por_ISBN";
            this.button_Buscar_por_ISBN.Size = new System.Drawing.Size(191, 42);
            this.button_Buscar_por_ISBN.TabIndex = 2;
            this.button_Buscar_por_ISBN.Text = "Buscar por ISBN";
            this.button_Buscar_por_ISBN.UseVisualStyleBackColor = true;
            // 
            // button_Buscar_por_Titulo
            // 
            this.button_Buscar_por_Titulo.Location = new System.Drawing.Point(100, 183);
            this.button_Buscar_por_Titulo.Name = "button_Buscar_por_Titulo";
            this.button_Buscar_por_Titulo.Size = new System.Drawing.Size(191, 44);
            this.button_Buscar_por_Titulo.TabIndex = 3;
            this.button_Buscar_por_Titulo.Text = "Buscar por Titulo";
            this.button_Buscar_por_Titulo.UseVisualStyleBackColor = true;
            // 
            // button_Eliminar_Libro
            // 
            this.button_Eliminar_Libro.Location = new System.Drawing.Point(100, 140);
            this.button_Eliminar_Libro.Name = "button_Eliminar_Libro";
            this.button_Eliminar_Libro.Size = new System.Drawing.Size(191, 37);
            this.button_Eliminar_Libro.TabIndex = 4;
            this.button_Eliminar_Libro.Text = "Eliminar libro";
            this.button_Eliminar_Libro.UseVisualStyleBackColor = true;
            this.button_Eliminar_Libro.Click += new System.EventHandler(this.button_Eliminar_Libro_Click);
            // 
            // button_Abastecimiento
            // 
            this.button_Abastecimiento.Location = new System.Drawing.Point(100, 281);
            this.button_Abastecimiento.Name = "button_Abastecimiento";
            this.button_Abastecimiento.Size = new System.Drawing.Size(191, 44);
            this.button_Abastecimiento.TabIndex = 5;
            this.button_Abastecimiento.Text = "Abastecimiento";
            this.button_Abastecimiento.UseVisualStyleBackColor = true;
            // 
            // Texto_Titulo
            // 
            this.Texto_Titulo.AutoSize = true;
            this.Texto_Titulo.Location = new System.Drawing.Point(534, 80);
            this.Texto_Titulo.Name = "Texto_Titulo";
            this.Texto_Titulo.Size = new System.Drawing.Size(74, 25);
            this.Texto_Titulo.TabIndex = 6;
            this.Texto_Titulo.Text = "# ISBN";
            // 
            // text_Titutlo
            // 
            this.text_Titutlo.AutoSize = true;
            this.text_Titutlo.Location = new System.Drawing.Point(534, 129);
            this.text_Titutlo.Name = "text_Titutlo";
            this.text_Titutlo.Size = new System.Drawing.Size(60, 25);
            this.text_Titutlo.TabIndex = 7;
            this.text_Titutlo.Text = "Titulo";
            // 
            // text_Precio_de_compra
            // 
            this.text_Precio_de_compra.AutoSize = true;
            this.text_Precio_de_compra.Location = new System.Drawing.Point(534, 185);
            this.text_Precio_de_compra.Name = "text_Precio_de_compra";
            this.text_Precio_de_compra.Size = new System.Drawing.Size(164, 25);
            this.text_Precio_de_compra.TabIndex = 8;
            this.text_Precio_de_compra.Text = "Precio de compra";
            // 
            // text_Precio_de_venta
            // 
            this.text_Precio_de_venta.AutoSize = true;
            this.text_Precio_de_venta.Location = new System.Drawing.Point(532, 240);
            this.text_Precio_de_venta.Name = "text_Precio_de_venta";
            this.text_Precio_de_venta.Size = new System.Drawing.Size(147, 25);
            this.text_Precio_de_venta.TabIndex = 9;
            this.text_Precio_de_venta.Text = "Precio de venta";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(646, 78);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(96, 29);
            this.textBox_ISBN.TabIndex = 10;
            this.textBox_ISBN.TextChanged += new System.EventHandler(this.textBox_ISBN_TextChanged);
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.Location = new System.Drawing.Point(645, 131);
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.Size = new System.Drawing.Size(192, 29);
            this.textBox_Titulo.TabIndex = 11;
            // 
            // textBox_Precio_de_Compra
            // 
            this.textBox_Precio_de_Compra.Location = new System.Drawing.Point(704, 185);
            this.textBox_Precio_de_Compra.Name = "textBox_Precio_de_Compra";
            this.textBox_Precio_de_Compra.Size = new System.Drawing.Size(194, 29);
            this.textBox_Precio_de_Compra.TabIndex = 12;
            // 
            // textBox_Precio_de_venta
            // 
            this.textBox_Precio_de_venta.Location = new System.Drawing.Point(704, 236);
            this.textBox_Precio_de_venta.Name = "textBox_Precio_de_venta";
            this.textBox_Precio_de_venta.Size = new System.Drawing.Size(211, 29);
            this.textBox_Precio_de_venta.TabIndex = 13;
            // 
            // button_Registrar
            // 
            this.button_Registrar.Location = new System.Drawing.Point(641, 295);
            this.button_Registrar.Name = "button_Registrar";
            this.button_Registrar.Size = new System.Drawing.Size(287, 36);
            this.button_Registrar.TabIndex = 14;
            this.button_Registrar.Text = "Registrar";
            this.button_Registrar.UseVisualStyleBackColor = true;
            this.button_Registrar.Click += new System.EventHandler(this.button_Registrar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(640, 295);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(288, 35);
            this.button_Eliminar.TabIndex = 15;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // inventari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 680);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Registrar);
            this.Controls.Add(this.textBox_Precio_de_venta);
            this.Controls.Add(this.textBox_Precio_de_Compra);
            this.Controls.Add(this.textBox_Titulo);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.text_Precio_de_venta);
            this.Controls.Add(this.text_Precio_de_compra);
            this.Controls.Add(this.text_Titutlo);
            this.Controls.Add(this.Texto_Titulo);
            this.Controls.Add(this.button_Abastecimiento);
            this.Controls.Add(this.button_Eliminar_Libro);
            this.Controls.Add(this.button_Buscar_por_Titulo);
            this.Controls.Add(this.button_Buscar_por_ISBN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Registrar_libro);
            this.Name = "inventari";
            this.Text = "inventari";
            this.Load += new System.EventHandler(this.inventari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Registrar_libro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Buscar_por_ISBN;
        private System.Windows.Forms.Button button_Buscar_por_Titulo;
        private System.Windows.Forms.Button button_Eliminar_Libro;
        private System.Windows.Forms.Button button_Abastecimiento;
        private System.Windows.Forms.Label Texto_Titulo;
        private System.Windows.Forms.Label text_Titutlo;
        private System.Windows.Forms.Label text_Precio_de_compra;
        private System.Windows.Forms.Label text_Precio_de_venta;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.TextBox textBox_Precio_de_Compra;
        private System.Windows.Forms.TextBox textBox_Precio_de_venta;
        private System.Windows.Forms.Button button_Registrar;
        private System.Windows.Forms.Button button_Eliminar;
    }
}