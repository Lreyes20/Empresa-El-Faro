using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Articulo
    {
        public int ID { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        public decimal PrecioVendedor { get; set; }

        public double PrecioFinal { get => PrecioFinal * 1.13; }

        public int Cantidad { get; set; }

        public Articulo()
        {
            ID = -1;
            Descripcion = string.Empty;
            Activo = true;
            PrecioVendedor = 0;
            Cantidad = -1;
        }

        public Articulo(int iD, string descripcion, bool activo, decimal precioVendedor, decimal precioFinal, int cantidad)
        {
            ID = iD;
            Descripcion = descripcion;
            Activo = activo;
            PrecioVendedor = precioVendedor;
            Cantidad = cantidad;
        }
    }
}
