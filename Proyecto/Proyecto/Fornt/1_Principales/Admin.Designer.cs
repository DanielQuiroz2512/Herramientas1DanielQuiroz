﻿namespace Proyecto
{
    partial class Admin
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
            this.Inventario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inventario
            // 
            this.Inventario.Location = new System.Drawing.Point(406, 191);
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(148, 89);
            this.Inventario.TabIndex = 3;
            this.Inventario.Text = "Inventario";
            this.Inventario.UseVisualStyleBackColor = true;
            this.Inventario.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu admin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 88);
            this.button1.TabIndex = 5;
            this.button1.Text = "Estadisticas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 76);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ventas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 810);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inventario);
            this.Name = "Admin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}