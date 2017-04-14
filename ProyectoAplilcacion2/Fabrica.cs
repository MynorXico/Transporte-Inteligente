using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicacion2
{
    public class Fabrica
    {
        public string Nombre;
        public int CantidadSolicitud;
        
        public Fabrica()
        {
            Nombre = "";
            CantidadSolicitud = 0;
        }
        public Fabrica(string Nombre, int CantidadSolicitud)
        {
            this.Nombre = Nombre;
            this.CantidadSolicitud = CantidadSolicitud;
        }
        public Fabrica(string Nombre, string CantidadSolicitud)
        {
            this.Nombre = Nombre;
            this.CantidadSolicitud = int.Parse(CantidadSolicitud);
        }
        public Fabrica(string[] DatosRecibidos)
        {
            this.Nombre = DatosRecibidos[0];
            this.CantidadSolicitud = int.Parse(DatosRecibidos[1]);
        }
    }
}
