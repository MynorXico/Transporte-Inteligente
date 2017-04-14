using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAplicacion2
{
    public static class Algoritmos
    {
        public static int[,] NorEste(List<Fabrica> Filas, List<Proveedor> Columnas)
        {
            int[,] Matrix = new int[Filas.Count+1, Filas.Count+1];
            int ColumnaActual = 0;
            int FilaActual = 0;

            for(int i = 0; i < Columnas.Count; i++)
            {
                Matrix[Matrix.GetLength(0) - 1, i] = Columnas[i].ElementosSolicitados;
            }
            for (int i = 0; i < Filas.Count; i++)
            {
                Matrix[i,Matrix.GetLength(1) - 1] = Filas[i].CantidadSolicitud;
            }

            while (FilaActual < Filas.Count && ColumnaActual < Columnas.Count)
            {
                if (Matrix[FilaActual, Columnas.Count] > Matrix[Filas.Count, ColumnaActual])
                {
                    Matrix[FilaActual, ColumnaActual] = Matrix[Filas.Count, ColumnaActual];
                    Matrix[FilaActual, Columnas.Count] -= Matrix[Filas.Count, ColumnaActual];
                    ColumnaActual++;
                }
                else
                {
                    Matrix[FilaActual, ColumnaActual] = Matrix[FilaActual, Columnas.Count];
                    Matrix[Filas.Count, ColumnaActual] -= Matrix[FilaActual, Columnas.Count];
                    FilaActual++;
                }
            }
            

            // LLenar  matriz con datos
            return Matrix;

        }
        public static void imprimirMatriz(int[,] Matriz)
        {
            for(int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0;  j < Matriz.GetLength(1); j++)
                {
                    Console.WriteLine(Matriz[i,j]+" ");
                }
                Console.WriteLine("\n");
            }
        }
        public static double[,] TablaResultadosNorEste(int[,] Matriz, double[] Costos)
        {
            double[,] tablaFinal = new double[((Matriz.GetLength(0)-1)*(Matriz.GetLength(1)-1)), 3];

            int filaActual = 0;
            for (int i = 0; i < Matriz.GetLength(0)-1; i++)
            {
                for(int j = 0; j < Matriz.GetLength(1)-1; j++)
                {
                    tablaFinal[filaActual, 0] = Matriz[i,j];
                    tablaFinal[filaActual, 1] = Costos[filaActual];
                    tablaFinal[filaActual, 2] = Matriz[i, j] * Costos[filaActual];
                    filaActual++;
                }
            }

            return tablaFinal;
        }
    }
}
