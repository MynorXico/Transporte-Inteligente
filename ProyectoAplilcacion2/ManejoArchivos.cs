using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProyectoAplicacion2
{
    class ManejoArchivos
    {
        public static string[] LecturaArchivo(string RutaArchivo)
        {
            return File.ReadAllLines(RutaArchivo);
        }
    }
}
