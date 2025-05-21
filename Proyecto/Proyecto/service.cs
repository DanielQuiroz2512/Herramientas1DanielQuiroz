using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Proyecto
{
    internal class service
    {
        private Tienda tienda;

        public service(Tienda tienda)
        {
            this.Tienda = tienda;
        }

        internal Tienda Tienda { get => tienda; set => tienda = value; }

        public void crearpersona(Persona persona)
        {
            Persona Existe = Buscarpersona(persona.Cedula);
            if (Existe != null)
            {
                Console.WriteLine("Ya existe una persona con esa Cedula");
                return;
            }
            Tienda.Persona.Add(persona);
            Console.WriteLine("Se ha creado el Usuario");
        }

        public Persona Buscarpersona(string cedula)
        {
            foreach (Persona persona in Tienda.Persona)
            {
                if (persona.Cedula.Equals(cedula))
                {
                    return persona;
                }
            }
            return null;
        }
        public void cearmaterial(Materiales material)
        {
            Materiales existe = BuscarMaterial_For_ID(material.ISBN1);
            if (existe != null)
            {
                Console.WriteLine("Ya existe material con este ID");
                return;
            }
            Tienda.Catalogo.Add(material);
            Console.WriteLine("Se ha creado el material con exito");
        }
        public Materiales BuscarMaterial_For_ID(int ISBN)
        {
            foreach (Materiales material in tienda.Catalogo)
            {
                if (material.ISBN1 == ISBN)
                {
                    Console.WriteLine("El libro con ID: " + ISBN + "Es: " + material);
                    return material;
                }
            }
            return null;
        }
        public Materiales BuscarMaterial_For_name(string Titulo)
        {
            foreach (Materiales material in tienda.Catalogo)
            {
                if (material.Titulo1 == Titulo)
                {
                    Console.WriteLine("El libro con Titulo: " + Titulo + "Es: " + material);
                    return material;
                }
            }
            return null;
        }

        public void EliminarMaterial(int ISBN)
        {
            Materiales existe = BuscarMaterial_For_ID(ISBN);
            if (existe == null)
            {
                Console.WriteLine("No existe material con este ID");
                return;
            }
            Tienda.Catalogo.Remove(existe);
            Console.WriteLine("Se ha Eliminado el material con exito");

        }

        public void Abastecimineto_material(int ISBN)
        {
            Materiales existe = BuscarMaterial_For_ID(ISBN);
            if (existe == null)
            {
                Console.WriteLine("No existe material con este ID");
                return;
            }
            Materiales.
        }
    }
}
