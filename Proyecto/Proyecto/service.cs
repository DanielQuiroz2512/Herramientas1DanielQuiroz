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
            foreach (Materiales material in Tienda.Catalogo)
            {
                if (material.ISBN1 == ISBN)
                {
                    return material;
                }
            }
            return null;

        }
        public Materiales BuscarMaterial_For_name(string Titulo)
        {
            foreach (var material in Tienda.Catalogo)
            {
                if (material.Titulo1.Equals(Titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return material;
                }
            }
            return null;
        }

        public string EliminarMaterial(int ISBN)
        {
            Materiales existe = BuscarMaterial_For_ID(ISBN);
            if (existe == null)
            {
                
                return "No existe material con este ID";
            }
            Tienda.Catalogo.Remove(existe);
            return "Se ha Eliminado el material con exito";

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

        public string MostrarLibrosMasCaros()
        {
            if (Tienda.Catalogo == null || Tienda.Catalogo.Count == 0)
            {
                return "No hay materiales registrados.";
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

            // Construir el mensaje con los libros más caros
            string resultado = "Libros con el precio más alto:\n";

            foreach (var material in Tienda.Catalogo)
            {
                if (material.Precio_venta == precioMaximo)
                {
                    resultado += $"- Título: {material.Titulo1}, Precio: {material.Precio_venta}\n";
                }
            }

            return resultado;
        }

        public string MostrarLibrosmenosCostoso()
        {
            if (Tienda.Catalogo == null || Tienda.Catalogo.Count == 0)
            {
                return "No hay materiales registrados.";
            }

            double precioMaximo = Tienda.Catalogo[0].Precio_venta;
            foreach (var material in Tienda.Catalogo)
            {
                if (material.Precio_venta < precioMaximo)
                {
                    precioMaximo = material.Precio_venta;
                }
            }

            string resultado = "Libros con el precio más bajo:\n";
            foreach (var material in Tienda.Catalogo)
            {
                if (material.Precio_venta == precioMaximo)
                {
                    resultado += $"- Título: {material.Titulo1}, Precio: {material.Precio_venta}\n";
                }
            }

            return resultado;
        }

        public string Buscar_Libro_vendido()
        {
            if (Tienda.Catalogo == null || Tienda.Catalogo.Count == 0)
            {
                return "No hay materiales registrados.";
            }

            int libroMasVendido = Tienda.Catalogo[0].CantidadVentas;

            // Primero determinamos la mayor cantidad de ventas
            foreach (var material in Tienda.Catalogo)
            {
                if (material.CantidadVentas > libroMasVendido)
                {
                    libroMasVendido = material.CantidadVentas;
                }
            }

            // Construimos el resultado
            string resultado = $"El libro más vendido se ha vendido {libroMasVendido} veces:\n";

            foreach (var material in Tienda.Catalogo)
            {
                if (material.CantidadVentas == libroMasVendido)
                {
                    resultado += $"- Título: {material.Titulo1}, Cantidad Vendida: {material.CantidadVentas}\n";
                }
            }

            return resultado;
        }

    }
}
