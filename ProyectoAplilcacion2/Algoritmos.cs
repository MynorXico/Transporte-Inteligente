using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ProyectoAplicacion2
{
    public static class Algoritmos
    {
        public static double[,] Vogel(List<Fabrica> Filas, List<Proveedor> Columnas, List<double> Precios)
        {
            double[,] Matrix = new double[Filas.Count, Columnas.Count];
            List<List<double>> MatrizListas = new List<List<double>>();
            List<int> NumerosFila = new List<int>();
            List<int> NumerosColumna = new List<int>();

            List<double> Oferta = new List<double>();
            List<double> Demanda = new List<double>();

            List<double> PenalizacionCol = new List<double>();
            List<double> PenalizacionFil = new List<double>();

            for (int i = 0, elementoActual = 0; i < Filas.Count; i++)
            {
                List<double> fila = new List<double>();
                for(int j = 0; j < Columnas.Count; j++)
                {
                    fila.Add(Precios[elementoActual++]);
                }
                MatrizListas.Add(fila);
                NumerosFila.Add(MatrizListas.Count-1);
            }
            for(int i = 0; i < MatrizListas[0].Count; i++)
            {
                NumerosColumna.Add(i);
            }

            foreach (Fabrica f in Filas)
            {
                Oferta.Add(f.CantidadSolicitud);
            }
            foreach(Proveedor p in Columnas)
            {
                Demanda.Add(p.ElementosSolicitados);
            }


           

            while (MatrizListas.Count > 1 && MatrizListas[0].Count > 1)
            {
                PenalizacionCol = PenalizacionesCol(MatrizListas);
                PenalizacionFil = PenalizacionesFil(MatrizListas);
                if (PenalizacionFil.Max() > PenalizacionCol.Max())
                {
                    int fila = FilaDeMenorEnCol(MatrizListas, PosicionMayor(PenalizacionFil));
                    int columna = PosicionMayor(PenalizacionFil);

                    if (Oferta[fila] < Demanda[columna])
                    {

                        Matrix[NumerosFila[fila], NumerosColumna[columna]] = Oferta[fila];
                        Demanda[columna] = Demanda[columna] - Oferta[fila];
                        MatrizListas.RemoveAt(fila);
                        NumerosFila.RemoveAt(fila);
                        Oferta.RemoveAt(fila);
                        PenalizacionCol.RemoveAt(fila);
                    }
                    else
                    {
                        Matrix[NumerosFila[fila], NumerosColumna[columna]] = Demanda[columna];
                        Oferta[fila] = Oferta[fila] - Demanda[columna];
                        foreach (List<double> Fila in MatrizListas)
                        {
                            Fila.RemoveAt(columna);
                        }
                        NumerosColumna.RemoveAt(columna);
                        Demanda.RemoveAt(columna);
                        PenalizacionFil.RemoveAt(columna);
                    }
                }
                else
                {
                    int fila = PosicionMayor(PenalizacionCol);
                    int columna = PosicionMenor(MatrizListas[fila]);

                    if (Oferta[fila] < Demanda[columna])
                    {

                        Matrix[NumerosFila[fila], NumerosColumna[columna]] = Oferta[fila];
                        Demanda[columna] = Demanda[columna] - Oferta[fila];
                        MatrizListas.RemoveAt(fila);
                        NumerosFila.RemoveAt(fila);
                        Oferta.RemoveAt(fila);
                        PenalizacionCol.RemoveAt(fila);
                    }
                    else
                    {
                        Matrix[NumerosFila[fila], NumerosColumna[columna]] = Demanda[columna];
                        Oferta[fila] = Oferta[fila] - Demanda[columna];

                        foreach (List<double> Fila in MatrizListas)
                        {
                            Fila.RemoveAt(columna);
                        }
                        NumerosColumna.RemoveAt(columna);
                        Demanda.RemoveAt(columna);
                        PenalizacionFil.RemoveAt(columna);
                    }

                }
            }
            // Quedó una fila
            if(MatrizListas.Count ==1)
            {
                int contador = 0;
                foreach(int i in Demanda)
                {
                    Matrix[NumerosFila[0], contador++] = i;
                }
            }else
            {
                int contador = 0;   
                List<double> lst = new List<double>();
                foreach(List<double> Fila in MatrizListas)
                {
                    lst.Add(Fila[0]);
                }
                foreach (int i in lst)
                {
                    Matrix[contador++, NumerosColumna[0]] = i;
                }
            }
    

            return Matrix;
        }
        


        public static double[,] NorEste(List<Fabrica> Filas, List<Proveedor> Columnas)
        {
            double[,] Matrix = new double[Filas.Count+1, Columnas.Count+1];
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

        public static double[,] TablaResultadosVogel(double[,] Matriz, double[] Costos)
        {
            double[,] tablaFinal = new double[((Matriz.GetLength(0)) * (Matriz.GetLength(1))), 3];

            int filaActual = 0;
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    tablaFinal[filaActual, 0] = Matriz[i, j];
                    tablaFinal[filaActual, 1] = Costos[filaActual];
                    tablaFinal[filaActual, 2] = Matriz[i, j] * Costos[filaActual];
                    filaActual++;
                }
            }

            return tablaFinal;
        }
        public static double[,] TablaResultadosNorEste(double[,] Matriz, double[] Costos)
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

        private static List<double> PenalizacionesCol(List<List<double>> Matriz)
        {
            List<double> Salida = new List<double>();
            foreach(List<double> Fila in Matriz)
            {
                List<double> CopiaFila = Clone(Fila);
                CopiaFila.Sort();
                Salida.Add(Math.Abs(CopiaFila[0]-CopiaFila[1]));
            }
            return Salida;
        }
        private static List<double> PenalizacionesFil(List<List<double>> Matriz)
        {
            List<double> Salida = new List<double>();
            for(int i = 0; i < Matriz[0].Count; i++)
            {
                List<double> tmp = new List<double>();
                foreach(List<double> fila in Matriz)
                {
                    tmp.Add(fila[i]);
                }
                Salida.Add(Penalizacion(tmp));
            }
            return Salida;
        }

        private static double Penalizacion(List<double> Lista)
        {
            List<double> CopiaLista = Clone(Lista);
            CopiaLista.Sort();
            return Math.Abs(CopiaLista[0]-CopiaLista[1]);
        }
        private static int PosicionMayor(List<double> Lista)
        {
            return Lista.IndexOf(Lista.Max());
        }
        private static int PosicionMenor(List<double> Lista)
        {
            return Lista.IndexOf(Lista.Min());
        }
        private static double MenorEnCol(List<List<double>> Matrix, int colIndex)
        {
            List<double> Columna = new List<double>();
            foreach(List<double> Fila in Matrix)
            {
                Columna.Add(Fila[colIndex]);
            }
            return Columna.Min();
        }
        private static int FilaDeMenorEnCol(List<List<double>> Matrix, int colIndex)
        {
            List<double> Columna = new List<double>();
            foreach (List<double> Fila in Matrix)
            {
                Columna.Add(Fila[colIndex]);
            }
            return Columna.IndexOf(MenorEnCol(Matrix, colIndex));
        }

        public static List<double> Clone(List<double> list)
        {
            List<double> f = new List<double>();
            foreach (double d in list)
                f.Add(d);
            return f;
        }
    }
}
