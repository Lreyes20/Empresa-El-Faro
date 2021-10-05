using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Model;

namespace DataAcces.Data
{
    public class Array
    {
        public static Articulo[] Inventario = new Articulo[20];

        public static Vendedor[] Vendedores = new Vendedor[20];

        public static OrdenCompra[] OrdenCompras = new OrdenCompra[20];
    }
}
