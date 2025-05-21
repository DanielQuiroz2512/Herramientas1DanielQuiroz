using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Materiales
    {
        private string Titulo;
        private int ISBN;
        private int precio_comptra;
        private int precio_venta;
        private int cantidadActual;
        private int cantidadregistrada;

        public Materiales(string titulo, int iSBN, int precio_comptra, int precio_venta, int cantidadActual, int cantidadregistrada)
        {
            this.Titulo1 = titulo;
            this.ISBN1 = iSBN;
            this.Precio_comptra = precio_comptra;
            this.Precio_venta = precio_venta;
            this.CantidadActual = cantidadActual;
            this.Cantidadregistrada = cantidadregistrada;
        }

        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public int Precio_comptra { get => precio_comptra; set => precio_comptra = value; }
        public int Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int CantidadActual { get => cantidadActual; set => cantidadActual = value; }
        public int Cantidadregistrada { get => cantidadregistrada; set => cantidadregistrada = value; }
    }
}
