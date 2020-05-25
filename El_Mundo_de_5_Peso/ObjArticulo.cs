using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Mundo_de_5_Peso
{
    class ObjArticulo
    {
        public int codigo { set; get; }
        public string nombre { set; get; }
        public int cantidad { set; get; }
        public decimal precio { set; get; }
        public string detalles { set; get; }
        public string imagen { set; get; }

        public ObjArticulo() { }

        public ObjArticulo(int codigo, string nombre, int cantidad, decimal precio, string detalles, string imagen)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.detalles = detalles;
            this.imagen = imagen;
        }
    }
}
