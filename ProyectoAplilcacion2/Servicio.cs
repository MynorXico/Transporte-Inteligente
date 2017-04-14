using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicacion2
{
    public struct Trato
    {
        public string Fabrica;
        public string Proveedor;
    }
    public class Servicio
    {
        int[,] Matriz;
        string[] Datos;
        List<Fabrica> Fabricas = new List<Fabrica>();
        List<Proveedor> Proveedores = new List<Proveedor>();
        List<double> Precios = new List<double>();
        public double suma
        {
            get
            {
                double suma = 0;
                for (int i = 0; i < TablaResultado.GetLength(0); i++)
                {
                    suma += TablaResultado[i,2];
                }
                return suma;
            }
        }
        public List<Trato> Tratos = new List<Trato>();
        public double[,] TablaResultado;
        private List<int> precios;

        public Servicio()
        {

        }

        public Servicio(string RutaArchivo)
        {
            Datos = ManejoArchivos.LecturaArchivo(RutaArchivo);
            int LineaActual = 1;
            while (Datos[LineaActual].Split(',')[0] != "[Proveedores]")
            {
                string[] DatosLinea = Datos[LineaActual].Split(',');
                Fabricas.Add(new Fabrica(DatosLinea));
                LineaActual++;
            }
            LineaActual++;
            while (Datos[LineaActual].Split(',')[0] != "[Costos]")
            {
                string[] DatosLinea = Datos[LineaActual].Split(',');
                Proveedores.Add(new Proveedor(DatosLinea));
                LineaActual++;
            }
            LineaActual++;
            while (true)
            {
                try
                {
                    string[] DatosLinea = Datos[LineaActual].Split(',');
                    Precios.Add(Double.Parse(DatosLinea[2]));
                    Trato t = new Trato();
                    t.Fabrica = DatosLinea[0];
                    t.Proveedor = DatosLinea[1];
                    Tratos.Add(t);
                    LineaActual++;
                }
                catch(Exception e)
                {
                    break;
                }
            }

            Matriz = Algoritmos.NorEste(Fabricas, Proveedores);

            TablaResultado = Algoritmos.TablaResultadosNorEste(Matriz, Precios.ToArray());

        }

        public Servicio(List<Fabrica> fabricas, List<Proveedor> proveedores, List<Trato> tratos, List<double> precios)
        {
            Fabricas = fabricas;
            Proveedores = proveedores;
            Tratos = tratos;
            Precios = precios;
            Matriz = Algoritmos.NorEste(Fabricas, Proveedores);
            TablaResultado = Algoritmos.TablaResultadosNorEste(Matriz, Precios.ToArray());
        }
    }
}
