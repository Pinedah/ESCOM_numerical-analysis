using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos
{
    internal class SistemasEcuaciones
    {
        public int NumIncognitas;
        public float[,] MatrizAumentada;

        private void imprimirMatriz(int n, ref float[,] MatrizA)
        {
            for (int k = 0; k < NumIncognitas; k++)
            {
                for (int l = 0; l <= NumIncognitas; l++)
                {
                    Console.Write(MatrizA[k, l] + ' ');
                }
                Console.WriteLine("");
            }
        }

        public bool ElimGaussiana(int n, ref float[,] Mat)
        {

            Console.Write("panke");
            imprimirMatriz(n, ref Mat);

            int i, j, r;
            float Multiplicador;
            
            for (i = 0; i < n - 1; i++)
            {
                for (r = i + 1; r < n; r++)
                {
                    Multiplicador = -Mat[r, i] / Mat[i, i];
                    Mat[r, i] = 0;
                    for (j = i + 1; j <= n; j++)
                    {
                        Mat[r, j] = Multiplicador * Mat[i, j] + Mat[r, j];
                    }
                }
            }

            return true;
        }

    }
}
