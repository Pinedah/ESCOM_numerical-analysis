using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        public bool ElimGaussiana(int n, ref float[,] Mat, ref DataGridView dgvTriangular)
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

            imprimirTriangular(n, ref Mat, ref dgvTriangular);
            return true;
        }

        /*
        public void PivoteoMaxColumna(int n, ref float[,] Mat, ref DataGridView dgvTriangular)
        {
            int i, j, r;
            int RengInterc;
            float Aux;
            float Multiplicador;
            for (i = 0; i < n - 1; i++)
            {
                RengInterc = -1;
                Aux = Math.Abs(Mat[i, j]);
                for (r = i + 1; r < n; r++)
                    if (Mat[r, i] > Aux)
                    {
                        RengInterc = r;
                        Aux = Math.Abs(Mat[r, i]);
                    }
                if (RengInterc != -1)
                    for (j = i; j <= n; j++)
                    {
                        Aux = Mat[i, j];
                        Mat[i, j] = Mat[RengInterc, j];
                        Mat[RengInterc, j] = Aux;

                    }
                if (Mat[i, i] == 0)
                    continue;
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
        }
        */

        public void PivoteoMaximoColumna(int n, ref float[,] Mat, ref DataGridView dgvTriangular)
        {
            int i, j, r;
            int RengInterc;
            float Aux;
            float Multiplicador;
            for (i = 0; i < n - 1; i++)
            {
                RengInterc = i;
                Aux = Math.Abs(Mat[i, i]);
                for (r = i + 1; r < n; r++)
                    if (Math.Abs(Mat[r, i]) > Aux)
                    {
                        RengInterc = r;
                        Aux = Math.Abs(Mat[r, i]);
                    }
                if (RengInterc != i)
                    for (j = i; j <= n; j++)
                    {
                        Aux = Mat[i, j];
                        Mat[i, j] = Mat[RengInterc, j];
                        Mat[RengInterc, j] = Aux;

                    }
                if (Mat[i, i] == 0)
                    continue;
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
            imprimirTriangular(n, ref Mat, ref dgvTriangular);
        }

        public void PivoteoEscalado(int n, ref float[,] Mat, ref DataGridView dgvTriangular)
        {
            int i, j, r;
            int RengInterc;
            float Aux;
            float Multiplicador;
            float[] Escalas = new float[n];
            for (i = 0; i < n; i++)
            {
                Aux = 0;
                for (j = 0; j < n; j++)
                    if (Math.Abs(Mat[i, j]) > Aux)
                        Aux = Math.Abs(Mat[i, j]);
                Escalas[i] = Aux;
            }
            for (i = 0; i < n - 1; i++)
            {
                RengInterc = i;
                Aux = Math.Abs(Mat[i, i] / Escalas[i]);
                for (r = i + 1; r < n; r++)
                    if (Math.Abs(Mat[r, i] / Escalas[r]) > Aux)
                    {
                        RengInterc = r;
                        Aux = Math.Abs(Mat[r, i] / Escalas[r]);
                    }
                if (RengInterc != i)
                    for (j = i; j <= n; j++)
                    {
                        Aux = Mat[i, j];
                        Mat[i, j] = Mat[RengInterc, j];
                        Mat[RengInterc, j] = Aux;

                    }
                if (Mat[i, i] == 0)
                    continue;
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
            imprimirTriangular(n, ref Mat, ref dgvTriangular);
        }



        public void SustHaciaAtras(int n, float[,] Mat, float[] ValIncognitas)
        {
            float Sum;
            int i, j;

            for (i = n - 1; i >= 0; i--)
            {
                Sum = 0;
                for (j = i + 1; j < n; j++)
                    Sum += ValIncognitas[j] * Mat[i, j];
                ValIncognitas[i] = (Mat[i, n] - Sum) / Mat[i, i];
            }
        }

        private void imprimirTriangular(int n, ref float[,] Mat, ref DataGridView dgvTriangular)
        {
            dgvTriangular.Rows.Clear();
            dgvTriangular.Columns.Clear();
            for (int i = 0; i <= n; i++)
                dgvTriangular.Columns.Add("Columna" + i, "Columna" + i);
            for (int i = 0; i < n; i++)
                dgvTriangular.Rows.Add();
            for (int i = 0; i < n; i++)
                for (int j = 0; j <= n; j++)
                    dgvTriangular.Rows[i].Cells[j].Value = Mat[i, j];
        }

        private void imprimirFinal(int n, ref float[] ValIncognitas, ref DataGridView dgvTriangular)
        {
            dgvTriangular.Rows.Clear();
            dgvTriangular.Columns.Clear();
            dgvTriangular.Columns.Add("Columna0", "Columna0");
            for (int i = 0; i < n; i++)
                dgvTriangular.Rows.Add();
            for (int i = 0; i < n; i++)
                dgvTriangular.Rows[i].Cells[0].Value = ValIncognitas[i];
        }

    }
}
