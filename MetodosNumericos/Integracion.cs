using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Complex.Solvers;
using Microsoft.FSharp.Data.UnitSystems.SI.UnitNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    internal class Integracion
    {
        public float a;
        public float b;
        public int n; // numero de intervalos

        public float metodoTrapecio(float x0, float xn, int numSubInt)
        {
            

            float h;
            float sumatoria = 0;
            float xi;
            
            a = x0;
            b = xn;
            n = numSubInt;
            h = (b - a) / n;

            for (int i = 1; i < n; i++)
            {
                sumatoria += f(a + i*h);
            }
            sumatoria *= h;
            sumatoria += h * (f(a) + f(b)) / 2;

            return sumatoria;
        }

        // metodo de simpson 1/3
        // integral = (h/3)*(f_0 + 4*Sum(f_2i-1) + 2*Sum(f_2i) + f_n)
        public float metodoSimpson1_3(float x0, float xn, int k)
        {
            float h;
            float Sum1, Sum2;

            n = 2 * k;
            a = x0;
            b = xn;
            h = (b - a) / n;

            Sum1 = 0;
            for(int i = 1; i <= k; i++)
            {
                Sum1 += f(a + (2*i - 1) * h);
            }
            Sum1 *= 4;

            Sum2 = 0;
            for (int i = 1; i <= k - 1; i++)
            {
                Sum2 += f(a + 2 * i * h);
            }
            Sum2 *= 2;

            float resultado = (h / 3) * (f(a) + Sum1 + Sum2 + f(b));
            return resultado;
        }

        public float metodoSimpson3_8(float x0, float xn, int k)
        {
            float h;
            float sum1, sum2, sum3, integral;
            n = 3 * k;
            a = x0;
            b = xn;
            h = (b - a) / n;

            sum1 = 0;
            for (int i = 1; i <= k; i++)
            {
                sum1 += f(a + (3 * i - 2) * h);
            }
            sum1 *= 3;

            sum2 = 0;
            for (int i = 1; i <= k; i++)
            {
                sum2 += f(a + (3 * i - 1) * h);
            }
            sum2 *= 3;

            sum3 = 0;
            for (int i = 1; i < k; i++)
            {
                sum3 += f(a + 3 * i * h);
            }
            sum3 *= 2;
            integral = (3 * h / 8) * (f(a) + sum1 + sum2 + sum3 + f(b));
            return integral;
        }

        public float TrapecioDoble(float a, float b, float c, float d, int n, int m)
        {
            float hx, hy, x0, xn, y0, ym, result = 0, sum1, sum2;
            int i, j;
            hx = (b - a) / n; 
            hy = (d - c)/m;

            x0 = a;
            xn = b;
            y0 = c;
            ym = d;

            sum1 = 0;
            for(j=1; j<m; j++)
            {
                sum1 += f2(x0, y0 + hy * j);
            }
            sum1 += (f2(x0, y0) + f2(x0, d)) / 2;
            sum1 /= 2;
            result = sum1;

            sum1 = 0;
            for (i = 1; i < n; i++)
                sum1 += f2(x0 + hx * i, y0);

            for (i = 1; i < n; i++)
                sum1 += f2(x0 + hx * i, ym);

            sum1 /= 2;

            sum2 = 0;
            for (i = 1; i < n; i++)
                for (j = 1; j < m; j++)
                    sum2 += f2(x0 + hx * i, y0 + hy * j);

            result += sum1 + sum2;

            sum1 = sum2 = 0;
            for (j = 1; j < m; j++)
                sum1 += f2(xn, y0 + hy * j);

            sum1 += f2(xn, y0) / 2 + f2(xn, ym) / 2;
            sum1 /= 2;

            result += sum1;
            result *= hx;
            result *= hy;


            return result;
        }
        public float metodoSimpson1_3Doble(float x0, float xn, float y0, float yn, int kx, int ky)
        {
            float n = 2 * kx;
            float m = 2 * ky;
            float hx = (xn - x0) / n;
            float hy = (yn - y0) / m;
            float resultado = 0.0f;
            float sum1, sum2,sum3;
            sum1 = sum2 = sum3 = 0;
            resultado += f2(x0, y0);
            for (int j = 1; j <= ky; j++)
            {
                sum1 += f2(x0, y0 + (2 * j - 1) * hy);
            }
            sum1 *= 4;
            resultado += sum1;
            sum1 = 0;

            for (int j = 1; j < ky; j++)
            {
                sum1 += f2(x0, y0 + 2 * j * hy);
            }
            sum1 *= 2;
            resultado += sum1;
            resultado += f2(x0, yn);
            sum1 = 0;
            for (int i = 1; i <= kx; i++)
            {
                sum1 += f2(x0 + (2 * i - 1) * hx, y0);
                sum1 += f2(x0 + (2 * i - 1) * hx, yn);
                for (int j = 1; j <= ky; j++)
                    sum2 += f2(x0 + (2 * i - 1) * hx, y0 + (2 * j - 1) * hy);
                for (int j = 1; j < ky; j++)
                    sum3 += f2(x0 + (2 * i - 1) * hx, y0 + 2 * j * hy);
                resultado += (4 * (sum1 + 4 * sum2 + 2 * sum3));
                sum1 = sum2 = sum3 = 0;
            }
            
         
            for(int i = 1; i<kx; i++)
            {
                sum1 += f2(x0+2*i*hx,y0);
                sum1 += f2(x0 + 2 * i * hx, yn);
                for (int j = 1; j <= ky; j++)
                    sum2 += f2(x0 + 2 * i * hx,y0 + (2 * j - 1) * hy);
                for (int j = 1; j < ky; j++)
                    sum3 += f2(x0 + 2 * i * hx, y0 + 2 * j * hy);
                resultado += (2 * (sum1 + 4 * sum2 + 2 * sum3));
                sum1 = sum2 = sum3 = 0;
            }

            resultado += f2(xn, y0);
            for (int j = 1; j <= ky; j++)
            {
                sum1 += f2(xn, y0 + (2 * j - 1) * hy);
            }
            sum1 *= 4;
            resultado += sum1;
            sum1 = 0;

            for (int j = 1; j < ky; j++)
            {
                sum1 += f2(xn, y0 + 2 * j * hy);
            }
            sum1 *= 2;
            resultado += sum1;
            sum1 = 0;

            resultado += f2(xn, yn);
            resultado *= (hx * hy / 9.0f);
            return resultado;

        }

        public float newton_cottes(float a, float b)
        {
            float resultado = 0;
            float h = (b - a) / 4;

            resultado = (4.0f/3.0f)*(h)*(2*f_newtonCottes(a + h) - f_newtonCottes(a + 2*h) + 2*f_newtonCottes(a + 3*h));

            return resultado;
        }

        /*
        public float romberg(float a, float b, float errorMaximo, ref DataGridView dgv)
        {
            float resultado = 0;
            float errorActual = 0;

            float h = (b - a)/2;
            //int n = (b-a) / h;

            int n = 1;
            while (errorActual <= errorMaximo)
            {
                float j0 = metodoTrapecio(a, b, n);
                float j1 = metodoTrapecio(a, b, n+1);

                float romberg = j1 + (j1 - j0) / 3;
            }

            return resultado;
        }*/

        public float cuadraturaAdaptiva(float a, float b, float errorMaximo)
        {
            
            float mid = (float)(a + b) / 2.0f;

            float S = SimpsonSimple1_3(a, b);
            float S1 = SimpsonSimple1_3(a, mid);
            float S2 = SimpsonSimple1_3(mid, b);

            float error = Math.Abs(S - (S1 + S2)) / 15.0f;

            if (error <= errorMaximo)
            {
                return S1 + S2 + error;
            }

            return cuadraturaAdaptiva(a, mid, errorMaximo / 2.0f) + cuadraturaAdaptiva(mid, b, errorMaximo / 2.0f);

        }
        public float SimpsonSimple1_3(float a, float b)
        {
            float h = (b - a) / 2.0f;
            return (h / 3.0f) * (f(a) + 4 * f(a + h) + f(b));
        }

        public float cuadraturaGaussiana(float a, float b)
        {
            // Usando el quinto polinomio de Legendre
            // P(x) = 1/8 * (63x^5 - 70x^3 + 15x)
            // Con raices: x1 = -0.9061798549, x2 = -0.5384693101, x3 = 0, x4 = 0.5384693101, x5 = 0.9061798459
            // Con coeficientes: c1 = 0.2369268850, c2 = 0.4786286705, c3 = 0.5688888889, c4 = 0.4786286705, c5 = 0.2369268850

            // f(x) = e^x * sin(x)
            // x = (b - a) / 2 * t + (a + b) / 2
            float res = 0;

            float x1 = -0.9061798549f;
            float x2 = -0.5384693101f;
            float x3 = 0;
            float x4 = 0.5384693101f;
            float x5 = 0.9061798459f;

            float c1 = 0.2369268850f;
            float c2 = 0.4786286705f;
            float c3 = 0.5688888889f;
            float c4 = 0.4786286705f;
            float c5 = 0.2369268850f;

            res = (b - a) / 2 * (c1 * f_legendre((b - a) / 2 * x1 + (a + b) / 2) +
                                 c2 * f_legendre((b - a) / 2 * x2 + (a + b) / 2) +
                                 c3 * f_legendre((b - a) / 2 * x3 + (a + b) / 2) +
                                 c4 * f_legendre((b - a) / 2 * x4 + (a + b) / 2) +
                                 c5 * f_legendre((b - a) / 2 * x5 + (a + b) / 2));


            return res;
        }
        public float Romberg(float a, float b, int n, float error, ref DataGridView dgvResultado)
        {
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();

            dgvResultado.Columns.Add("iteracion", "K");
            for (int i = 1; i <= n; i++)
            {
                dgvResultado.Columns.Add($"K{i}", $"h^{i}");
            }

            double[,] R = new double[n, n];
            double h = b - a;
            R[0, 0] = (h / 2) * (fRomberg(a) + fRomberg(b));

            dgvResultado.Rows.Add();
            dgvResultado.Rows[0].Cells[0].Value = 1;
            dgvResultado.Rows[0].Cells[1].Value = R[0, 0];
            for (int i = 1; i <= n; i++)
            {
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i].Cells[0].Value = i + 1;
                double sum = 0;
                int numPuntos = (int)Math.Pow(2, i - 1);
                for (int k = 1; k <= numPuntos; k++)
                {
                    sum += fRomberg(a + (k - 0.5) * h);
                }
                R[i, 0] = 0.5 * (R[i - 1, 0] + h * sum);
                dgvResultado.Rows[i].Cells[1].Value = R[i, 0];

                
                for (int j = 1; j <= i; j++)
                {
                    R[i, j] = R[i, j - 1] + (R[i, j - 1] - R[i - 1, j - 1]) / (Math.Pow(4, j) - 1);
                    dgvResultado.Rows[i].Cells[j + 1].Value = R[i, j];
                }

                
                if (i > 0 && Math.Abs(R[i, i] - R[i - 1, i - 1]) < error)
                {
                    float result = (float)R[i, i];
                    
                    return result;
                }
                h /= 2;
            }

            float finalResult = (float)R[n - 1, n - 1];
            
            return finalResult;
        }
        float f2(float x, float y)
        {
            float r;
            r = (float)(Math.Sqrt(x*x + y*y) * Math.Sin(Math.Sqrt(x*x + y*y)));
            return r;
        }

        float f(float x)
        {
            float r;
            r = (float) (x * Math.Sin(x));
            return r;
        }
        float f_newtonCottes(float x)
        {
            float r;
            r = (float)(x*x - 3*x - 1);
            // r = (float)(x * Math.Sin(x));
            return r;
        }
        float f_legendre(float x)
        {
            float r;
            r = (float)(Math.Pow(Math.E, x)*Math.Sin(x));
            return r;
        }
        private double fRomberg(double x)
        { 
            return x*Math.Sin(x);
        }

    }
}
