using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicacion2
{
    public class Proveedor
    {
        public string Nombre;
        public int ElementosSolicitados;
        public Proveedor()
        {
            Nombre = "";
            ElementosSolicitados = 0;
        }
        public Proveedor(string Nombre, int ElementosSolicitados)
        {
            this.Nombre = Nombre;
            this.ElementosSolicitados = ElementosSolicitados;
        }
        public Proveedor(string Nombre, string ElementosSolicitados)
        {
            this.Nombre = Nombre;
            this.ElementosSolicitados = int.Parse(ElementosSolicitados);
        }
        public Proveedor(string[] DatosRecibidos)
        {
            this.Nombre = DatosRecibidos[0];
            this.ElementosSolicitados = int.Parse(DatosRecibidos[1]);
        }
    }
}
