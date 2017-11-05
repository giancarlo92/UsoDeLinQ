using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.ListarUsuarioConVentas();
            Console.Read();
        }

        private static void ListarUsuarioConVentas()
        {
            using (CMV_LOCAL3Entities db = new CMV_LOCAL3Entities())
            {
                var query = from ventas in db.Venta_
                            join grupo in db.Usuario_ on ventas.idUsuario equals grupo.username
                            select new
                            {
                                TotalParaPagar = ventas.totalAPagar,
                                NombreUsuario = grupo.nombre
                            };
                query.ToList().ForEach(x => Console.WriteLine(x.NombreUsuario + " - " + x.TotalParaPagar));
            }
        }
    }
}
