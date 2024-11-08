﻿using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Complex.Solvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

    }
}