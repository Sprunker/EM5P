using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Mundo_de_5_Peso
{
    class ObjVenta
    {
        public int numVenta { set; get; }
        public string usuario { set; get; }
        public string articulos { set; get; }
        public int cantidad { set; get; }
        public decimal total { set; get; }
        public DateTime fecha { set; get; }
        public DateTime hora { set; get; }
        public string estado { set; get; }

        public ObjVenta() { }

        public ObjVenta(int numVenta, string usuario, string articulos, int cantidad, decimal total, DateTime fecha, DateTime hora, string estado)
        {
            this.numVenta = numVenta;
            this.usuario = usuario;
            this.articulos = articulos;
            this.cantidad = cantidad;
            this.total = total;
            this.fecha = fecha;
            this.hora = hora;
            this.estado = estado;
        }
    }
}
