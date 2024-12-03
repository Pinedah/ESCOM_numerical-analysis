using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosNumericos
{
    internal class EcuacionesDiferenciales
    {


        public float metodoDeEuler(float condicion, float h, float error)
        {
            float res = 0;

            float yi = euler(condicion, h);

            for (int i = 0; i < 1000; i++)
                res = euler(yi, h);
            
            return res;
        }
        float euler(float yi, float h)
        {
            float r = 0;
            r = yi + h * f(yi);
            return r;
        }

        public float metodoDeTaylor(float condicion, float h, float error)
        {
            float res = 0;

            return res;
        }
        float taylor2(float yi, float h)
        {
            float r = 0;
            r = yi + h * f(yi) + (h * h / 2) * f_prima(yi);
            return r;
        }

        float f(float y)
        {
            // dy/dt = -k*sqrt(y)
            // con k = 0.06
            float r;
            r = (float)(-0.06f * Math.Sqrt(y));
            return r;
        }
        float f_prima(float x)
        {
            // d2y/dt2 = k^2 / 2
            float r;
            r = (float)((0.06f*0.06f)/2.0f);
            return r;
        }
    }
}
