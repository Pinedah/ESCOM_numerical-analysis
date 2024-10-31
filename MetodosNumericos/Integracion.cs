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
            // validar que el usuario no haga mamadas con N

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

        float f(float x)
        {
            float r;
            r = (float) (x * Math.Sin(x));
            return r;
        }
    }
}
