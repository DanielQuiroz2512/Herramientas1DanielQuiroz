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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cajero Menu_cajero = new Cajero();
            Menu_cajero.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inventari Menu_inventario = new inventari();
            Menu_inventario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Infoventas Menu_infventas = new Infoventas();
            Menu_infventas.Show();
            this.Hide();
        }
    }
}
