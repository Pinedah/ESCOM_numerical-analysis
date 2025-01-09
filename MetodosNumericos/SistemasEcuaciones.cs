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

        public bool ElimGaussiana(int n, ref float[,] Mat)
        {
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
