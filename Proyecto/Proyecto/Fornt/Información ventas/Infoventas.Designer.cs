namespace Proyecto
{
    partial class Infoventas
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
            this.button_mas_costoso = new System.Windows.Forms.Button();
            this.button_menos_costoso = new System.Windows.Forms.Button();
            this.button_mas_vendido = new System.Windows.Forms.Button();
            this.button_Transacciones = new System.Windows.Forms.Button();
            this.text_Isbn = new System.Windows.Forms.Label();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.button_buscar_transa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_mas_costoso
            // 
            this.button_mas_costoso.Location = new System.Drawing.Point(90, 134);
            this.button_mas_costoso.Name = "button_mas_costoso";
            this.button_mas_costoso.Size = new System.Drawing.Size(313, 56);
            this.button_mas_costoso.TabIndex = 1;
            this.button_mas_costoso.Text = "Libro mas costoso";
            this.button_mas_costoso.UseVisualStyleBackColor = true;
            this.button_mas_costoso.Click += new System.EventHandler(this.button_mas_costoso_Click);
            // 
            // button_menos_costoso
            // 
            this.button_menos_costoso.Location = new System.Drawing.Point(90, 196);
            this.button_menos_costoso.Name = "button_menos_costoso";
            this.button_menos_costoso.Size = new System.Drawing.Size(313, 52);
            this.button_menos_costoso.TabIndex = 2;
            this.button_menos_costoso.Text = "Libro menos costoso";
            this.button_menos_costoso.UseVisualStyleBackColor = true;
            this.button_menos_costoso.Click += new System.EventHandler(this.button_menos_costoso_Click);
            // 
            // button_mas_vendido
            // 
            this.button_mas_vendido.Location = new System.Drawing.Point(90, 254);
            this.button_mas_vendido.Name = "button_mas_vendido";
            this.button_mas_vendido.Size = new System.Drawing.Size(313, 58);
            this.button_mas_vendido.TabIndex = 3;
            this.button_mas_vendido.Text = "Libro mas vendido";
            this.button_mas_vendido.UseVisualStyleBackColor = true;
            this.button_mas_vendido.Click += new System.EventHandler(this.button_mas_vendido_Click);
            // 
            // button_Transacciones
            // 
            this.button_Transacciones.Location = new System.Drawing.Point(90, 77);
            this.button_Transacciones.Name = "button_Transacciones";
            this.button_Transacciones.Size = new System.Drawing.Size(313, 51);
            this.button_Transacciones.TabIndex = 4;
            this.button_Transacciones.Text = "Cantidad de transacciones(Aba)";
            this.button_Transacciones.UseVisualStyleBackColor = true;
            this.button_Transacciones.Click += new System.EventHandler(this.button_Transacciones_Click);
            // 
            // text_Isbn
            // 
            this.text_Isbn.AutoSize = true;
            this.text_Isbn.Location = new System.Drawing.Point(609, 124);
            this.text_Isbn.Name = "text_Isbn";
            this.text_Isbn.Size = new System.Drawing.Size(74, 25);
            this.text_Isbn.TabIndex = 5;
            this.text_Isbn.Text = "# ISBN";
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.Location = new System.Drawing.Point(701, 125);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.Size = new System.Drawing.Size(267, 29);
            this.textBox_ISBN.TabIndex = 6;
            // 
            // button_buscar_transa
            // 
            this.button_buscar_transa.Location = new System.Drawing.Point(855, 312);
            this.button_buscar_transa.Name = "button_buscar_transa";
            this.button_buscar_transa.Size = new System.Drawing.Size(175, 51);
            this.button_buscar_transa.TabIndex = 7;
            this.button_buscar_transa.Text = "Buscar";
            this.button_buscar_transa.UseVisualStyleBackColor = true;
            this.button_buscar_transa.Click += new System.EventHandler(this.button_buscar_transa_Click);
            // 
            // Infoventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 650);
            this.Controls.Add(this.button_buscar_transa);
            this.Controls.Add(this.textBox_ISBN);
            this.Controls.Add(this.text_Isbn);
            this.Controls.Add(this.button_Transacciones);
            this.Controls.Add(this.button_mas_vendido);
            this.Controls.Add(this.button_menos_costoso);
            this.Controls.Add(this.button_mas_costoso);
            this.Name = "Infoventas";
            this.Text = "Infoventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_mas_costoso;
        private System.Windows.Forms.Button button_menos_costoso;
        private System.Windows.Forms.Button button_mas_vendido;
        private System.Windows.Forms.Button button_Transacciones;
        private System.Windows.Forms.Label text_Isbn;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.Button button_buscar_transa;
    }
}