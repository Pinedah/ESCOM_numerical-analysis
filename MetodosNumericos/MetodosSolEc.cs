using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.ComponentModel;
using System.Drawing.Printing;
using MathNet.Symbolics;
using System.Drawing;

namespace MetodosNumericos
{
    internal class MetodosSolEc
    {
        public int numMaxIter;
        public float errorMaximo;
        public Complex errorMaximoComplex;
        float AproxRaiz;
        Complex AproxRaizC;

        public bool metBiseccion(float a, float b, ref DataGridView dgvResultado)
        { // Metodo de biseccion
            float c, errorActual;
            int i;

            if(Func(a) * Func(b) > 0)
            {
                MessageBox.Show("No se puede aplicar el metodo de Biseccion", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("valor_c", "c");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("f_a", "f(a)");
            dgvResultado.Columns.Add("f_c", "f(c)");
            dgvResultado.Columns.Add("f_b", "f(b)");
            dgvResultado.Columns.Add("error", "Error");

            i = 1;
            while (i <= numMaxIter)
            {
                c = (a + b) / 2;
                errorActual = (b - a) / 2;

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = c;
                dgvResultado.Rows[i - 1].Cells[3].Value = b;
                dgvResultado.Rows[i - 1].Cells[4].Value = Func(a) > 0 ? '+' : '-';
                dgvResultado.Rows[i - 1].Cells[5].Value = Func(c) > 0 ? '+' : '-';
                dgvResultado.Rows[i - 1].Cells[6].Value = Func(b) > 0 ? '+' : '-';
                dgvResultado.Rows[i - 1].Cells[7].Value = errorActual;

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
        public bool metodoFalsaPosicion(float a, float b, ref DataGridView dgvResultado)
        {
            float p, ErrorAct;
            int i;
            if (Func(a) * Func(b) > 0)
            {
                MessageBox.Show("No se puede aplicar el metodo de la falsa posición", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
         
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("valor_p", "p");
            dgvResultado.Columns.Add("f_a", "f(a)");
            dgvResultado.Columns.Add("f_b", "f(b)");
            dgvResultado.Columns.Add("f_p", "f(p)");
            dgvResultado.Columns.Add("error", "Error");
            i = 1;
            while (i < numMaxIter)
            {
                
                p = b - (Func(b) * (b - a)) / (Func(b) - Func(a));

                //ErrorAct = (float)(Math.Abs(b - p) / Math.Pow((float)p, (float)2.0));
                ErrorAct = (float)(Math.Abs(b - p));

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = b;
                dgvResultado.Rows[i - 1].Cells[3].Value = p;
                dgvResultado.Rows[i - 1].Cells[4].Value = Func(a);
                dgvResultado.Rows[i - 1].Cells[5].Value = Func(p);
                dgvResultado.Rows[i - 1].Cells[6].Value = Func(b);
                dgvResultado.Rows[i - 1].Cells[7].Value = ErrorAct;


                if (ErrorAct <= errorMaximo)
                {
                    MessageBox.Show("Se obtuvo la aproximación raiz con el error deseado.\nRaiz =" + p.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                if (Func(a) * Func(p) < 0) 
                { 
                    b = p; 
                }
                else
                {
                    a = p;
                }
                i++;

            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error indicado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool metSecante(float a, float b, ref DataGridView dgvResultado)
        { // Metodo de la secante
            float c, errorActual;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("valor_c", "c");
            dgvResultado.Columns.Add("f_a", "f(a)");
            dgvResultado.Columns.Add("f_c", "f(c)");
            dgvResultado.Columns.Add("f_b", "f(b)");
            dgvResultado.Columns.Add("error", "Error");
            
            i = 1;
            while (i <= numMaxIter)
            {
                // p = a - (f(a)*(b-a))/(f(b)-f(a));
                c = a - ((Func(a) * (b-a)) / (Func(b) - Func(a)));
                errorActual = Math.Abs((c - b));
                

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = b;
                dgvResultado.Rows[i - 1].Cells[3].Value = c;
                dgvResultado.Rows[i - 1].Cells[4].Value = Func(a);
                dgvResultado.Rows[i - 1].Cells[5].Value = Func(c);
                dgvResultado.Rows[i - 1].Cells[6].Value = Func(b);
                dgvResultado.Rows[i - 1].Cells[7].Value = errorActual;


                if (errorActual <= errorMaximo)
                {
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + c.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                a = b;
                b = c;

                i++;

            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }


        public bool metMuller(Complex p0, Complex p1,Complex  p2)
        { // Metodo de Muller
            int i;
            i = 1;
            Complex D,a,b,c;
            Complex p3;
            
            Complex negativo = new Complex(0, 0);
            while (i <= numMaxIter)
            {
                D=(p1-p2)*(p0-p2)*(p0-p1);
                a = ((p1-p2)*(FuncCom(p0)-FuncCom(p2))- (p0 - p2) * (FuncCom(p1) - FuncCom(p2)))/D;
                b = ((Complex.Pow(p0-p2,2)*(FuncCom(p1)- FuncCom(p2))) - (Complex.Pow(p1 - p2, 2) * (FuncCom(p0) - FuncCom(p2)))) / D;
                c = FuncCom(p2);
                Complex discriminant = Complex.Sqrt(Complex.Pow(b, 2) - 4 * a * c);
                Complex denominator = b + (b.Real >= 0 ? discriminant : -discriminant);
                p3 = p2 - (2 * c / denominator);
                Complex error = Complex.Abs(p3 - p2);
                float errorActual = (float)error.Magnitude;
                if (errorActual <= errorMaximoComplex.Magnitude)
                {
                    float p3real = (float)p3.Real;
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + p3real.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                p0=p1; p1 = p2; p2 = p3;

                i++;
            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return  false;
        }
        public bool metMuller2(Complex p0, Complex p1, Complex p2, ref DataGridView dgvResultado)
        { // Metodo de Muller
            float ErrorAct;
            Complex p=new Complex(),a=new Complex(),b=new Complex(),c=new Complex();
            Complex Fp1MFp2 = new Complex();
            Complex Fp0MFp2= new Complex();
            Complex p0Mp2= new Complex();
            Complex p1Mp2 = new Complex();
            Complex p0Mp1 = new Complex();
            Complex divisor = new Complex();
            Complex D = new Complex();
            Complex E = new Complex();
            int i;
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_p0", "p0");
            dgvResultado.Columns.Add("valor_p1", "p1");
            dgvResultado.Columns.Add("valor_p2", "p2");
            dgvResultado.Columns.Add("p", "p");
            dgvResultado.Columns.Add("error", "Error");
            i = 1;
            while (i<=numMaxIter)
            {
                p0Mp2=Complex.Subtract(p0, p2);
                p0Mp1 = Complex.Subtract(p0, p1);
                p1Mp2=Complex.Subtract(p1, p2);
                Fp1MFp2 = Complex.Subtract(FuncCom(p1),FuncCom(p2));
                Fp0MFp2 = Complex.Subtract(FuncCom(p1), FuncCom(p2));
                divisor= Complex.Multiply(p0Mp2, p1Mp2);
                divisor = Complex.Multiply(divisor, p0Mp1);
                c=FuncCom(p2);
                b = Complex.Subtract(Complex.Multiply(Complex.Pow(p0Mp2,2), Fp1MFp2) , Complex.Multiply(Complex.Pow(p1Mp2,2), Fp0MFp2));
                b=Complex.Divide(b, divisor);

                a= Complex.Subtract(Complex.Multiply(p1Mp2,Fp0MFp2),Complex.Multiply(p0Mp2,Fp1MFp2));
                a = Complex.Divide(a,divisor);

                D = Complex.Sqrt(Complex.Subtract(Complex.Pow(b,2),Complex.Multiply(new Complex(4,0), Complex.Multiply(a,c))));
                if (Complex.Abs(Complex.Subtract(b, D)) < Complex.Abs(Complex.Add(b, D)))
                {
                    E= Complex.Add(b, D);
                }
                else
                {
                    E = Complex.Subtract(b, D);
                }
                p = Complex.Subtract(p2, Complex.Divide(Complex.Multiply(new Complex(2, 0), c), E));


                ErrorAct = (float)Complex.Abs(Complex.Divide(Complex.Multiply(new Complex(2, 0), c), E));

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = p0;
                dgvResultado.Rows[i - 1].Cells[2].Value = p1;
                dgvResultado.Rows[i - 1].Cells[3].Value = p2;
                dgvResultado.Rows[i - 1].Cells[4].Value = p;
                dgvResultado.Rows[i - 1].Cells[5].Value = ErrorAct;

                if (ErrorAct <= errorMaximo)
                {
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + p.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }
                p0 = p1;
                p1 = p2;
                p2 = p;
                i++;

            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
                
        }

        public bool metNewton(float po, ref DataGridView dgvResultado)
        {
            // Metodo de Newton
            int i;
            float pi, errorActual;

            dgvResultado.Rows.Clear(); 
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("Pi", "pi");
            dgvResultado.Columns.Add("f_Pi", "fpi");
            dgvResultado.Columns.Add("Fp_Pi", "fppi");
            dgvResultado.Columns.Add("Aprox", "aprox");
            dgvResultado.Columns.Add("error", "error");

            i = 1;
            while (i <= numMaxIter)
            {

                pi = po - (Func(po) / FuncPrima(po));
                errorActual = Math.Abs(pi - po);

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = po;
                dgvResultado.Rows[i - 1].Cells[2].Value = Func(pi);
                dgvResultado.Rows[i - 1].Cells[3].Value = FuncPrima(pi);
                dgvResultado.Rows[i - 1].Cells[4].Value = pi;
                dgvResultado.Rows[i - 1].Cells[5].Value = errorActual;
                // dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                if (errorActual <= errorMaximo)
                {
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + pi.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                po = pi;
                i++;
            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool metPFijo(float po, ref DataGridView dgvResultado)
        {
            float errorActual;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("Pi", "Pi");
            dgvResultado.Columns.Add("g_po", "g(Pi)");
            dgvResultado.Columns.Add("error", "Error");


            i = 1;
            while (i <= numMaxIter)
            {
                errorActual = Math.Abs(po - FuncPF(po));

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = po;
                dgvResultado.Rows[i - 1].Cells[2].Value = FuncPF(po);
                dgvResultado.Rows[i - 1].Cells[3].Value = errorActual;


                if (errorActual <= errorMaximo)
                {
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + po.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                po = FuncPF(po);
                i++;
            }

            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool metSteffensen(float po, ref DataGridView dgvResultado)
        {
            float errorActual, p1, p2, p;
            int i;
            
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("Po", "Po");
            dgvResultado.Columns.Add("P1", "P1");
            dgvResultado.Columns.Add("P2", "P2");
            dgvResultado.Columns.Add("P", "P");
            dgvResultado.Columns.Add("error", "Error");

            i = 1;
            while(i <= numMaxIter)
            {


                p1 = Func_G(po);
                p2 = Func_G(p1);
                p = puntoAitken(po, p1, p2);
                errorActual = Math.Abs(p - p2);

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = po;
                dgvResultado.Rows[i - 1].Cells[2].Value = p1;
                dgvResultado.Rows[i - 1].Cells[3].Value = p2;
                dgvResultado.Rows[i - 1].Cells[4].Value = p;
                dgvResultado.Rows[i - 1].Cells[5].Value = errorActual;

                if (errorActual <= errorMaximo)
                {
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + po.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                po = p;
                i++;
            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool metBiseccionAitken(float a, float b, ref DataGridView dgvResultado)
        { // Metodo de biseccion usando Aitken
            float c, errorActual, p;
            int i;
            string aS, bS, cS,pS;
            float distanciaMinima = float.MaxValue;
            float nuevoA = a, nuevoB = b;

            if (Func(a) * Func(b) > 0)
            {
                MessageBox.Show("No se puede aplicar el metodo de Biseccion", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");

            dgvResultado.Columns.Add("valor_a1", "a");
            dgvResultado.Columns.Add("valor_c1", "c1");
            dgvResultado.Columns.Add("valor_b3", "b");
            
            dgvResultado.Columns.Add("valor_a2", "a");
            dgvResultado.Columns.Add("valor_c2", "c2");
            dgvResultado.Columns.Add("valor_b2", "b");
            
            dgvResultado.Columns.Add("valor_a3", "a");
            dgvResultado.Columns.Add("valor_c3", "c3");
            dgvResultado.Columns.Add("valor_b3", "b");

            dgvResultado.Columns.Add("puntoAitken", "P");
            dgvResultado.Columns.Add("error", "Error");



            i = 1;
            while (i <= numMaxIter)
            {
                float[] arr = new float[3];
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                for (int j = 0; j < 2; j++)
                {
                    c = (a + b) / 2;
                    arr[j] = c;
                    aS = a.ToString() + " | " + (Func_G2(a) > 0 ? '+' : '-');
                    bS = b.ToString() +  " | " + (Func_G2(b) > 0 ? '+' : '-');
                    cS = c.ToString() + " | " + (Func_G2(c) > 0 ? '+' : '-');
                    int cellBaseIndex = (j == 0) ? 1 : 4;
                    dgvResultado.Rows[i - 1].Cells[cellBaseIndex].Value = aS;
                    dgvResultado.Rows[i - 1].Cells[cellBaseIndex + 1].Value = cS;
                    dgvResultado.Rows[i - 1].Cells[cellBaseIndex + 2].Value = bS;

                    if (Func_G2(a) * Func_G2(c) < 0)
                        b = c;
                    else
                        a = c;
                }
                c = (a + b) / 2;
                arr[2] = c;
                aS = a.ToString() + " | " + (Func_G2(a) > 0 ? '+' : '-');
                bS = b.ToString() + " | " + (Func_G2(b) > 0 ? '+' : '-');
                cS = c.ToString() + " | " + (Func_G2(c) > 0 ? '+' : '-');
                dgvResultado.Rows[i - 1].Cells[7].Value = aS;
                dgvResultado.Rows[i - 1].Cells[8].Value = cS;
                dgvResultado.Rows[i - 1].Cells[9].Value = bS;
                p = puntoAitken(arr[0], arr[1], arr[2]);
                pS = p.ToString() + " | " + (Func_G2(p) > 0 ? '+' : '-');
                dgvResultado.Rows[i - 1].Cells[10].Value = pS;
                distanciaMinima = float.MaxValue;

                if (Func_G2(a) * Func_G2(c) < 0)
                {
                    float distancia = Math.Abs(a - c);
                    if (distancia < distanciaMinima)
                    {
                        distanciaMinima = distancia;
                        nuevoA = a;
                        nuevoB = c;
                    }
                }

                if (Func_G2(b) * Func_G2(c) < 0)
                {
                    float distancia = Math.Abs(b - c);
                    if (distancia < distanciaMinima)
                    {
                        distanciaMinima = distancia;
                        nuevoA = c;
                        nuevoB = b;
                    }
                }

                if (Func_G2(c) * Func_G2(p) < 0)
                {
                    float distancia = Math.Abs(c - p);
                    if (distancia < distanciaMinima)
                    {
                        distanciaMinima = distancia;
                        nuevoA = c;
                        nuevoB = p;
                    }
                }
                a = nuevoA;
                b = nuevoB;
                errorActual = Math.Abs((b - a) / 2);
                dgvResultado.Rows[i - 1].Cells[11].Value = errorActual;

                if (errorActual <= errorMaximo)
                {
                    MessageBox.Show("Se obtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + p.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                i++;
            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool metSecanteAitken(float a, float b, ref DataGridView dgvResultado)
        { // Metodo de la secante
            float c, errorActual, P;
            int i;

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_a", "a");
            dgvResultado.Columns.Add("valor_b", "b");
            dgvResultado.Columns.Add("valor_c", "c");
            dgvResultado.Columns.Add("valor_PAitken", "P Aitken");
            dgvResultado.Columns.Add("error", "Error");

            i = 1;
            while (i <= numMaxIter)
            {
                // p = a - (f(a)*(b-a))/(f(b)-f(a));
                c = a - ((Func_G2(a) * (b - a)) / (Func_G2(b) - Func_G2(a)));
                errorActual = Math.Abs((c - b));

                P = puntoAitken(a, b, c);

                dgvResultado.Rows.Add();
                dgvResultado.Rows[i - 1].Cells[0].Value = i;
                dgvResultado.Rows[i - 1].Cells[1].Value = a;
                dgvResultado.Rows[i - 1].Cells[2].Value = b;
                dgvResultado.Rows[i - 1].Cells[3].Value = c;
                dgvResultado.Rows[i - 1].Cells[4].Value = P;
                dgvResultado.Rows[i - 1].Cells[5].Value = errorActual;


                if (errorActual <= errorMaximo)
                {
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + c.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                a = P;
                b = c;

                i++;

            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool deflacion(Complex p0, Complex p1, Complex p2, Complex[] arrA, ref DataGridView dgvResultado)
        {



            Complex[] arrSol = new Complex[arrA.Length-1];
            Complex[] arrAux = new Complex[arrA.Length];
            Array.Copy(arrA, arrAux, arrA.Length);
            Complex x0 = new Complex();
            float ErrorAct;
            Complex p = new Complex(), a = new Complex(), b = new Complex(), c = new Complex();
            Complex Fp1MFp2 = new Complex();
            Complex Fp0MFp2 = new Complex();
            Complex p0Mp2 = new Complex();
            Complex p1Mp2 = new Complex();
            Complex p0Mp1 = new Complex();
            Complex divisor = new Complex();
            Complex D = new Complex();
            Complex E = new Complex();

            for (int i = arrAux.Length - 1; i > 0; i--)//Le quitaste el igual a cero por que ya se llego a la ultima
            {
                Complex[] arrB = new Complex[i];              
                
                arrB[i - 1] = arrAux[i];
                

                int j = 1;
                while (j <= numMaxIter)
                {
                    p0Mp2 = Complex.Subtract(p0, p2);
                    p0Mp1 = Complex.Subtract(p0, p1);
                    p1Mp2 = Complex.Subtract(p1, p2);
                    Fp1MFp2 = Complex.Subtract(FuncComDeflacion(p1, arrAux), FuncComDeflacion(p2, arrAux));
                    Fp0MFp2 = Complex.Subtract(FuncComDeflacion(p0, arrAux), FuncComDeflacion(p2, arrAux));
                    divisor = Complex.Multiply(p0Mp2, p1Mp2);
                    divisor = Complex.Multiply(divisor, p0Mp1);
                    c = FuncComDeflacion(p2, arrAux);
                    b = Complex.Subtract(Complex.Multiply(Complex.Pow(p0Mp2, 2), Fp1MFp2), Complex.Multiply(Complex.Pow(p1Mp2, 2), Fp0MFp2));
                    b = Complex.Divide(b, divisor);

                    a = Complex.Subtract(Complex.Multiply(p1Mp2, Fp0MFp2), Complex.Multiply(p0Mp2, Fp1MFp2));
                    a = Complex.Divide(a, divisor);

                    D = Complex.Sqrt(Complex.Subtract(Complex.Pow(b, 2), Complex.Multiply(new Complex(4, 0), Complex.Multiply(a, c))));

                    
                    E = Complex.Abs(Complex.Subtract(b, D)) < Complex.Abs(Complex.Add(b, D)) ? Complex.Add(b, D) : Complex.Subtract(b, D);
                    p = Complex.Subtract(p2, Complex.Divide(Complex.Multiply(new Complex(2, 0), c), E));
                    ErrorAct = (float)Complex.Abs(Complex.Divide(Complex.Multiply(new Complex(2, 0), c), E));

                    if (ErrorAct <= errorMaximo)
                    {
                        x0 = p;

                        for (int k = i - 2; k >= 0; k--)
                        {
                            arrB[k] = arrAux[k+1] + Complex.Multiply(x0, arrB[k + 1]);
                        }
                        arrSol[arrA.Length - 1 - i] = p;
                        break;
                    }
                    p0 = p1;
                    p1 = p2;
                    p2 = p;
                    j++;
                }
                if (x0.Equals(new Complex()))
                {
                    MessageBox.Show("No se pudo obtener la aproximacion con el error deseado en la x^" + i.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                arrAux = arrB;
            }

            

            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("raiz", "Raíz");
            dgvResultado.Columns.Add("parteReal", "Parte Real");
            dgvResultado.Columns.Add("parteImag", "Parte Imaginaria");
            // formatear las medidas de las columnas
            dgvResultado.Columns["raiz"].Width = 50;
            dgvResultado.Columns["parteReal"].Width = 170;
            dgvResultado.Columns["parteImag"].Width = 170;

            for (int i = 0; i < arrSol.Length; i++)
            {
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i].Cells[0].Value = i + 1;
                dgvResultado.Rows[i].Cells[1].Value = arrSol[i].Real;
                dgvResultado.Rows[i].Cells[2].Value = arrSol[i].Imaginary;
            }

            return true;
        }


        private float Func_G2(float x)
        {
            float r;
            r = (float)(Math.Pow(x, 3) + 4*Math.Pow(x, 2) - 10);
            return r;
        }

        private float Func_G(float x)
        {
            float r;
            r = (float)Math.Sqrt(10/(x + 4));
            return r;
        }

        float puntoAitken(float a, float b, float c)
        {
            return (float)(a - (Math.Pow((b - a), 2) / (c - 2 * b + a)));
        }

        float FuncPrima(float x)
        {
            float r;
            r = (float)(2 * x);
            return r;
        }
        float Func(float x)
        {
            float r;
            //r = (float)(Math.Pow(x, 2) - 3.0);
            r = (float)(1.7 + (((32.17 / (2 * x * x))) * (((Math.Pow((Math.E), x) - Math.Pow((Math.E), -x)) / 2) - Math.Sin(x))));
            return r;
        }

        float FuncPF(float x)
        {
            float r;
            r = (float)(Math.Sqrt(25/x));
            return r;
        }
        

        Complex FuncCom(Complex x)
        {
            Complex r;
            r = (Complex)(Complex.Pow(x,2) + Complex.Multiply(x,5.365230) + 7.324772);
            return r;
        }
        Complex FuncComDeflacion(Complex x,Complex[] arrA)
        {
            Complex r = new Complex(0,0);
            for (int i = 0; i < arrA.Length; i++) {
                r = r + Complex.Multiply(arrA[i],Complex.Pow(x,i));
            }
            return r;
        }
        public static string ComplexToString(Complex complex)
        {
            // Formatear la parte imaginaria
            string imaginaryPart = complex.Imaginary >= 0 ? $"+ {complex.Imaginary}i" : $"- {-complex.Imaginary}i";

            // Combinar las partes real e imaginaria
            return $"{complex.Real} {imaginaryPart}";
        }

        public void PlotFunction(double a, double b, Func<double, double> func)
        {
            Graphics g = pictureBox1.CreateGraphics();
            float xm = pictureBox1.Width / 2;
            float ym = pictureBox1.Height / 2;
            g.TranslateTransform(xm, ym);
            g.DrawLine(Pens.Black, -xm, 0, xm, 0); // eje x
            g.DrawLine(Pens.Black, 0, -ym, 0, ym); // eje y

            float delta = 0.1f;
            float x1 = (float)a;
            float x2, y1, y2;

            while (x1 <= b)
            {
                y1 = (float)func(x1);
                x2 = x1 + delta;
                y2 = (float)func(x2);
                g.DrawLine(Pens.Blue, x1 * 10, -y1 * 10, x2 * 10, -y2 * 10);
                x1 = x2;
            }
        }

    }
}
