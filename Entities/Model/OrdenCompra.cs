using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class OrdenCompra
    {
        public int ID { get; set; }

        public DateTime Fecha { get; set; }

        public Articulo[] Articulos { get; set; }

        public OrdenCompra()
        {
            ID = -1;
            Fecha = DateTime.MinValue;
            Articulos = new Articulo[20];
        }

        public OrdenCompra(int iD, DateTime fecha, Articulo[] articulos)
        {
            ID = iD;
            Fecha = fecha;
            Articulos = new Articulo[20];
        }

    }
}
