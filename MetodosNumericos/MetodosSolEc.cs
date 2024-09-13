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
                dgvResultado.Rows[i - 1].Cells[3].Value = c;
                dgvResultado.Rows[i - 1].Cells[4].Value = Func(a);
                dgvResultado.Rows[i - 1].Cells[5].Value = Func(c);
                dgvResultado.Rows[i - 1].Cells[6].Value = Func(b);
                dgvResultado.Rows[i - 1].Cells[7].Value = errorActual;
                // dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


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
                dgvResultado.Rows[i - 1].Cells[2].Value = c;
                dgvResultado.Rows[i - 1].Cells[3].Value = c;
                dgvResultado.Rows[i - 1].Cells[4].Value = Func(a);
                dgvResultado.Rows[i - 1].Cells[5].Value = Func(c);
                dgvResultado.Rows[i - 1].Cells[6].Value = Func(b);
                dgvResultado.Rows[i - 1].Cells[7].Value = errorActual;
                // dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


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
                string result;
                Complex discriminant = Complex.Sqrt(Complex.Pow(b, 2) - 4 * a * c);
                Complex denominator = b + (b.Real >= 0 ? discriminant : -discriminant);
                p3 = p2 - (2 * c / denominator);
                Complex error = Complex.Abs(p3 - p2);
                double errorActual = error.Magnitude;
                if (errorActual <= errorMaximoComplex.Magnitude)
                {
                    double p3real = p3.Real;
                    MessageBox.Show("Se obvtuvo la aproximacion a la raiz con el error deseado. \nRaiz = " + p3real.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                p0=p1; p1 = p2; p2 = p3;

                i++;
            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error deseado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
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
            Complex Aux = new Complex();
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
            return false;
                
        }
        public bool metodoFalsaPosicion(float a, float b)
        {
            float p, ErrorAct;
            int i;
            if (Func(a) * Func(b) > 0)
            {
                MessageBox.Show("No se puede aplicar el metodo de la falsa posición", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            i = 1;
            while (i < numMaxIter)
            {
                p = b - (Func(b) * (b - a)) / (Func(b) - Func(a));
                ErrorAct = (float)(Math.Abs(b - p) / Math.Pow((double)p, (double)2.0));
                if (ErrorAct <= errorMaximo)
                {
                    MessageBox.Show("Se obtuvo la aproximación raiz con el error deseado.\nRaiz =" + p.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                if (Func(a) * Func(p) < 0) { b = p; }
                else
                {
                    a = p;
                }
                i++;

            }
            MessageBox.Show("No se pudo obtener la aproximacion con el error indicado.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool metNewton(float po, ref DataGridView dgvResultado)
        {
            // Metodo de Newton
            int i;
            float pi, errorActual;

            dgvResultado.Rows.Clear();
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
                dgvResultado.Rows[i - 1].Cells[2].Value = Func(po);
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

        float FuncPrima(float x)
        {
            float r;
            r = (float)(2 * x);
            return r;
        }
        float Func(float x)
        {
            float r;
            r = (float)(Math.Pow(x, 2) - 3.0);
            return r;
        }

        float FuncPF(float x)
        {
            float r;
            r = (float)(x - (Math.Pow(x, 3) + 4 * x * x - 10) / (3 * x * x + 8 * x));
            return r;
        }
        

        Complex FuncCom(Complex x)
        {
            Complex r;
            r = (Complex)(Complex.Pow(x,2) - 3);
            return r;
        }
        public static string ComplexToString(Complex complex)
        {
            // Formatear la parte imaginaria
            string imaginaryPart = complex.Imaginary >= 0 ? $"+ {complex.Imaginary}i" : $"- {-complex.Imaginary}i";

            // Combinar las partes real e imaginaria
            return $"{complex.Real} {imaginaryPart}";
        }

    }
}
