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

        public string crearpersona(Persona persona)
        {
            Persona Existe = Buscarpersona(persona.Cedula);
            if (Existe != null)
            {
            return "Ya existe una persona con esa Cedula" ;
            }
            Tienda.Persona.Add(persona);
            return "Se ha creado el Usuario";
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
                else if (material.ISBN1 != ISBN)
                {
                    Console.WriteLine("No existe material con este ID");
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
            existe.CantidadActual += 1;
            existe.Cantidadregistrada += 1;
        }

        public void Vender_libros(int ISBN)
        {
            Materiales existe = BuscarMaterial_For_ID(ISBN);
            if (existe == null)
            {
                Console.WriteLine("No existe material con este ID");
                return;
            }
            existe.CantidadVentas =+1;
            existe.CantidadActual =-1;
            

        }

        public void Transacciones_abastecimineto(int ISBN)
        {
            Materiales existe = BuscarMaterial_For_ID(ISBN);
            if (existe == null)
            {
                Console.WriteLine("No existe material con este ID");
                return;
            }
            Console.WriteLine("Se han realizado " + existe.Cantidadregistrada + " de registro para el libro con ID" + existe.ISBN1 + "el nombre es " + existe.Titulo1);

        }

        public void MostrarLibrosMasCaros()
        {
            if (Tienda.Catalogo == null || Tienda.Catalogo.Count == 0)
            {
                Console.WriteLine("No hay materiales registrados.");
                return;
            }

            // Encontrar el precio máximo
            double precioMaximo = Tienda.Catalogo[0].Precio_venta;
            foreach (var material in Tienda.Catalogo)
            {
                if (material.Precio_venta > precioMaximo)
                {
                    precioMaximo = material.Precio_venta;
                }
            }

            // Mostrar todos los libros con ese precio máximo
            Console.WriteLine("Libros con el precio más alto:");

            foreach (var material in Tienda.Catalogo)
            {
                if (material.Precio_venta == precioMaximo)
                {
                    Console.WriteLine($"- Título: {material.Titulo1}, Precio: {material.Precio_venta}");
                }
            }
        }

        public void MostrarLibrosmenosCostoso()
        {
            if (Tienda.Catalogo == null || Tienda.Catalogo.Count == 0)
            {
                Console.WriteLine("No hay materiales registrados.");
                return;
            }

            double precioMaximo = Tienda.Catalogo[0].Precio_venta;
            foreach (var material in Tienda.Catalogo)
            {
                if (material.Precio_venta < precioMaximo)
                {
                    precioMaximo = material.Precio_venta;
                }
            }

            Console.WriteLine("Libros con el precio mas Bajo:");

            foreach (var material in Tienda.Catalogo)
            {
                if (material.Precio_venta == precioMaximo)
                {
                    Console.WriteLine($"- Título: {material.Titulo1}, Precio: {material.Precio_venta}");
                }
            }
        }

        public void Buscar_Libro_vendido()
        {
            if (Tienda.Catalogo == null || Tienda.Catalogo.Count == 0)
            {
                Console.WriteLine("No hay materiales registrados.");
                return;
            }
            int Libromasvendido = Tienda.Catalogo[0].CantidadVentas;
            foreach( var material in Tienda.Catalogo)
            {
                if (material.CantidadVentas < Libromasvendido)
                {
                    Libromasvendido = material.CantidadVentas;

                }
               Console.WriteLine("El libro mas vendido es" +  Libromasvendido);

            }
             foreach (var material in Tienda.Catalogo)
            {
                if (material.CantidadVentas == Libromasvendido)
                {
                    Console.WriteLine($"- Título: {material.Titulo1}, Cantidad Vendida: {material.CantidadVentas}");
                }

            }

        }

    }
}
