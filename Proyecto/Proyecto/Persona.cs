using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Persona
    {
        private string persona1;
        private string cedula;
        private string rol;

        public Persona(string persona, string cedula, string rol)
        {
            this.Persona1 = persona;
            this.Cedula = cedula;
            this.Rol = rol;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Persona1 { get => persona1; set => persona1 = value; }
    }
}
