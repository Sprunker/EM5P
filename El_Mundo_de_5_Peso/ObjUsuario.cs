using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Mundo_de_5_Peso
{
    public class ObjUsuario
    {
        public int id { set; get; }
        public string nombre { set; get; }
        public string usuario { set; get; }
        public string pass { set; get; }
        public string telefono { set; get; }
        public bool diasLab { set; get; }
        public bool horario { set; get; }

        public ObjUsuario() { }

        public ObjUsuario(string nombre, string usuario, string pass, string telefono, bool diasLab, bool horario)
        {
            this.nombre = nombre;
            this.usuario = usuario;
            this.pass = pass;
            this.telefono = telefono;
            this.diasLab = diasLab;
            this.horario = horario;
        }
    }
}
