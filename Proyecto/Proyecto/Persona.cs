using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Persona
    {
        private string persona;
        private string cedula;
        private string rol;

        public Persona(string persona, string cedula, string rol)
        {
            this.Persona = persona;
            this.Cedula = cedula;
            this.Rol = rol;
        }

        public string Persona { get => persona; set => persona = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
