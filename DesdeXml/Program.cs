using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesdeXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("../../libros.xml");
            Program.PrecioPromedio(document);
            Console.Read();
        }

        private static void PrecioPromedio(XDocument document)
        {
            var AutorPrecio = from element in document.Descendants("catalog").Elements("book")
                              select new
                              {
                                  autor = element.Element("author").Value,
                                  precio = double.Parse(element.Element("price").Value)
                              };

            var AutorPrecioPromedio = from autorPrecio in AutorPrecio
                                      group autorPrecio by new { autorPrecio.autor } into agrupamiento
                                      select new
                                      {
                                          autor = agrupamiento.Key.autor,
                                          precioPorLibro = agrupamiento.Average(x => x.precio)
                                      };
            var ListaDeAutorPrecioPromedio = AutorPrecioPromedio.ToList();
            ListaDeAutorPrecioPromedio.ForEach(x => Console.WriteLine(x.autor + " - " + x.precioPorLibro));
        }
    }
}
