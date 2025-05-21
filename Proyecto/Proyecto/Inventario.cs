using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Inventario
    {
        private DateTime fecha;
        private Materiales material;
        private Persona persona;
        private string tipo;
        private int Cantidad;

        public Inventario(DateTime fecha, Materiales material, Persona persona, string tipo, int cantidad)
        {
            this.Fecha = fecha;
            this.Material = material;
            this.Persona = persona;
            this.Tipo = tipo;
            Cantidad1 = cantidad;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        internal Materiales Material { get => material; set => material = value; }
        internal Persona Persona { get => persona; set => persona = value; }
    }
}
