using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    internal class Tienda
    {
        private List<Persona> persona;
        private List<Materiales> catalogo;
        private List<Inventario> Móvimiento;

        public Tienda(List<Persona> persona, List<Materiales> catalogo, List<Inventario> móvimiento)
        {
            this.Persona = persona;
            this.Catalogo = catalogo;
            Móvimiento1 = móvimiento;
        }

        internal List<Persona> Persona { get => persona; set => persona = value; }
        internal List<Materiales> Catalogo { get => catalogo; set => catalogo = value; }
        internal List<Inventario> Móvimiento1 { get => Móvimiento; set => Móvimiento = value; }
    }
}
