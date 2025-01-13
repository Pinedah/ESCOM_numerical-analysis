using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos
{
    internal class Derivacion
    {
        public float x0;
        public float h;
        public float Derivacion2Puntos(float x0,float h)
        {

            float derivada = (f(x0+h)-f(x0))/h;
            return derivada;
        }
        public float Derivacion3Puntos(float x0, float h)
        {

            float derivada = (-3*f(x0)+4*f(x0+h)-f(x0+2*h)) / 2*h;
            return derivada;
        }
        public float Derivacion4Puntos(float x0, float h)
        {

            float derivada = (-11 * f(x0) + 18 * f(x0 + h) - 9 * f(x0 + 2 * h) + 2 * f(x0 +3*h)) / 6 * h;
            return derivada;
        }
        float f(float x){
            float r;
            r = (float)(x * Math.Sin(Math.Sqrt(x * x)));
            return r;
        }
    }
}
