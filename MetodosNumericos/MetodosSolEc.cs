﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    internal class MetodosSolEc
    {
        public int numMaxIter;
        public float errorMaximo;

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

        float Func(float x)
        {
            float r;
            r = (float)(Math.Pow(x, 2) - 3.0);
            return r;
        }

    }
}