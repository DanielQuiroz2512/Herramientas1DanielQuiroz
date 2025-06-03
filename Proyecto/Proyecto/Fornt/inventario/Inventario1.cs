using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Inventario1 : Form
    {
        public Inventario1()
        {
            InitializeComponent();
        }

        private void Inventario1_Load(object sender, EventArgs e)
        {
            TextBox_Precio_venta.Visible = false;
            Precio_a_vender.Visible = false;
            text_precio_compra.Visible = false;
            textBox_precio_Compra.Visible = false;
            Text_title.Visible = false;
            textBox_title.Visible = false;
            Text_I_S_B_N.Visible = false;
            textBox_I_S_B_N.Visible = false;
            Button_Registrar.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_libros_Click(object sender, EventArgs e)
        {
            TextBox_Precio_venta.Visible = true;
            Precio_a_vender.Visible = true;
            text_precio_compra.Visible = true;
            textBox_precio_Compra.Visible = true;
            Text_title.Visible = true;
            textBox_title.Visible = true;
            Text_I_S_B_N.Visible = true;
            textBox_I_S_B_N.Visible = true;
            Button_Registrar.Visible = true;


        }

        private void text_ISBN(object sender, EventArgs e)
        {

        }

        private void Textbox_ISBN(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_precio_venta_Click(object sender, EventArgs e)
        {

        }

        private void text_precio_compra_Click(object sender, EventArgs e)
        {

        }

        private void textBox_precio_Compra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_title_Click(object sender, EventArgs e)
        {

        }

        private void Button_Registrar_Click(object sender, EventArgs e)
        {

        }
    }
}
