namespace Proyecto
{
    partial class Inventario1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Text_title = new System.Windows.Forms.Label();
            this.Text_I_S_B_N = new System.Windows.Forms.Label();
            this.text_precio_compra = new System.Windows.Forms.Label();
            this.Precio_a_vender = new System.Windows.Forms.Label();
            this.textBox_I_S_B_N = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_precio_Compra = new System.Windows.Forms.TextBox();
            this.TextBox_Precio_venta = new System.Windows.Forms.TextBox();
            this.Button_Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar Libro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Registrar_libros_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar un Libro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(58, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Buscar titulo Nombre";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Busqueda por ISBN";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(221, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Abastecimiento";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Text_title
            // 
            this.Text_title.AutoSize = true;
            this.Text_title.Location = new System.Drawing.Point(564, 203);
            this.Text_title.Name = "Text_title";
            this.Text_title.Size = new System.Drawing.Size(60, 25);
            this.Text_title.TabIndex = 5;
            this.Text_title.Text = "Titulo";
            this.Text_title.Click += new System.EventHandler(this.Text_title_Click);
            // 
            // Text_I_S_B_N
            // 
            this.Text_I_S_B_N.AutoSize = true;
            this.Text_I_S_B_N.Location = new System.Drawing.Point(550, 152);
            this.Text_I_S_B_N.Name = "Text_I_S_B_N";
            this.Text_I_S_B_N.Size = new System.Drawing.Size(74, 25);
            this.Text_I_S_B_N.TabIndex = 6;
            this.Text_I_S_B_N.Text = "# ISBN";
            this.Text_I_S_B_N.Click += new System.EventHandler(this.text_ISBN);
            // 
            // text_precio_compra
            // 
            this.text_precio_compra.AutoSize = true;
            this.text_precio_compra.Location = new System.Drawing.Point(542, 252);
            this.text_precio_compra.Name = "text_precio_compra";
            this.text_precio_compra.Size = new System.Drawing.Size(159, 25);
            this.text_precio_compra.TabIndex = 7;
            this.text_precio_compra.Text = "Precio comprado";
            this.text_precio_compra.Click += new System.EventHandler(this.text_precio_compra_Click);
            // 
            // Precio_a_vender
            // 
            this.Precio_a_vender.AutoSize = true;
            this.Precio_a_vender.Location = new System.Drawing.Point(537, 303);
            this.Precio_a_vender.Name = "Precio_a_vender";
            this.Precio_a_vender.Size = new System.Drawing.Size(148, 25);
            this.Precio_a_vender.TabIndex = 8;
            this.Precio_a_vender.Text = "Precio a vender";
            this.Precio_a_vender.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_I_S_B_N
            // 
            this.textBox_I_S_B_N.Location = new System.Drawing.Point(630, 148);
            this.textBox_I_S_B_N.Name = "textBox_I_S_B_N";
            this.textBox_I_S_B_N.Size = new System.Drawing.Size(83, 29);
            this.textBox_I_S_B_N.TabIndex = 9;
            this.textBox_I_S_B_N.TextChanged += new System.EventHandler(this.Textbox_ISBN);
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(630, 203);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(334, 29);
            this.textBox_title.TabIndex = 10;
            // 
            // textBox_precio_Compra
            // 
            this.textBox_precio_Compra.Location = new System.Drawing.Point(713, 249);
            this.textBox_precio_Compra.Name = "textBox_precio_Compra";
            this.textBox_precio_Compra.Size = new System.Drawing.Size(250, 29);
            this.textBox_precio_Compra.TabIndex = 11;
            this.textBox_precio_Compra.TextChanged += new System.EventHandler(this.textBox_precio_Compra_TextChanged);
            // 
            // TextBox_Precio_venta
            // 
            this.TextBox_Precio_venta.Location = new System.Drawing.Point(714, 299);
            this.TextBox_Precio_venta.Name = "TextBox_Precio_venta";
            this.TextBox_Precio_venta.Size = new System.Drawing.Size(248, 29);
            this.TextBox_Precio_venta.TabIndex = 12;
            this.TextBox_Precio_venta.Click += new System.EventHandler(this.textBox_precio_venta_Click);
            this.TextBox_Precio_venta.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Button_Registrar
            // 
            this.Button_Registrar.Location = new System.Drawing.Point(570, 368);
            this.Button_Registrar.Name = "Button_Registrar";
            this.Button_Registrar.Size = new System.Drawing.Size(391, 61);
            this.Button_Registrar.TabIndex = 13;
            this.Button_Registrar.Text = "Registrar";
            this.Button_Registrar.UseVisualStyleBackColor = true;
            this.Button_Registrar.Click += new System.EventHandler(this.Button_Registrar_Click);
            // 
            // Inventario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 826);
            this.Controls.Add(this.Button_Registrar);
            this.Controls.Add(this.TextBox_Precio_venta);
            this.Controls.Add(this.textBox_precio_Compra);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.textBox_I_S_B_N);
            this.Controls.Add(this.Precio_a_vender);
            this.Controls.Add(this.text_precio_compra);
            this.Controls.Add(this.Text_I_S_B_N);
            this.Controls.Add(this.Text_title);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Inventario1";
            this.Text = "Inventario1";
            this.Load += new System.EventHandler(this.Inventario1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Text_title;
        private System.Windows.Forms.Label Text_I_S_B_N;
        private System.Windows.Forms.Label text_precio_compra;
        private System.Windows.Forms.Label Precio_a_vender;
        private System.Windows.Forms.TextBox textBox_I_S_B_N;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_precio_Compra;
        private System.Windows.Forms.TextBox TextBox_Precio_venta;
        private System.Windows.Forms.Button Button_Registrar;
    }
}