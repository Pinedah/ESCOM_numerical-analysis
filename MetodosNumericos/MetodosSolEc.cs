using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.ComponentModel;

namespace MetodosNumericos
{
    internal class MetodosSolEc
    {
        public int numMaxIter;
        public float errorMaximo;
        public Complex errorMaximoComplex;

        public bool metBiseccion(float a, float b)
        { // Metodo de biseccion
            float c, errorActual;
            int i;

            if(Func(a) * Func(b) > 0)
            {
                MessageBox.Show("No se puede aplicar el metodo de Biseccion", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            i = 1;
            while (i <= numMaxIter)
            {
                c = (a + b) / 2;
                errorActual = (b - a) / 2;
                if (errorActual <= errorMaximo)
                {
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + c.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                if (Func(a) * Func(c) < 0)
                    b = c;
                else
                    a = c;

                i++;
            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        public bool metMuller(Complex p0, Complex p1,Complex  p2)
        { // Metodo de biseccion
            Complex errorActual;
            int i;
            i = 1;
            Complex D,a,b,c;
            Complex p3;
            Complex negativo = new Complex(0, 0);
            while (i <= numMaxIter)
            {
                D=(p1-p2)*(p0-p2)*(p0-p2);
                a = ((p1-p2)*(FuncCom(p0)-FuncCom(p2))- (p0 - p2) * (FuncCom(p1) - FuncCom(p2)))/D;
                b = ((Complex.Pow(p0-p2,2)*(FuncCom(p1)- FuncCom(p2))) - (Complex.Pow(p1 - p2, 2) * (FuncCom(p0) - FuncCom(p2)))) / D;
                c = FuncCom(p2);

                p3 = p2 - (2 * c / (b + (b.Magnitude < negativo.Magnitude ? -1 : 1)) * Complex.Sqrt(Complex.Pow(b, 2) - 4 * a * c));
                errorActual = Complex.Abs(p3-p2);
                if (errorActual.Magnitude <= errorMaximoComplex.Magnitude)
                {
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + c.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                p0=p1; p1 = p2; p2 = p3;

                i++;
            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        float Func(float x)
        {
            float r;
            r = (float)(Math.Pow(x, 2) - 3.0);
            return r;
        }
        Complex FuncCom(Complex x)
        {
            Complex r;
            r = (Complex)(Complex.Pow(x,2) - 3);
            return r;
        }

    }
}
