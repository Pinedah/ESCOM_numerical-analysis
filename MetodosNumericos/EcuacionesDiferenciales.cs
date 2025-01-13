using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    internal class EcuacionesDiferenciales
    {


        public float metodoDeEuler(float condicion, float a, float b, float n, ref DataGridView dgvResultado)
        {
            float res = 0;
            float h = (b - a) / n;
            float t = a;
            float w = condicion;
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_ti", "ti");
            dgvResultado.Columns.Add("valor_wi", "wi");
            dgvResultado.Rows.Add();
            dgvResultado.Rows[0].Cells[0].Value = 0;
            dgvResultado.Rows[0].Cells[1].Value = t;
            dgvResultado.Rows[0].Cells[2].Value = w;
            for (int i = 1; i <= n; i++)
            {
                w = w + h * f(t,w);
                t = a + i * h;
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i].Cells[0].Value = i;
                dgvResultado.Rows[i].Cells[1].Value = t;
                dgvResultado.Rows[i].Cells[2].Value = w;
            }

            return w;
        }

        public float metodoDeTaylor(float condicion, float a, float b, float n, ref DataGridView dgvResultado)
        {
            float h = (b - a) / n; // Tamaño de paso
            float t = a;           // Valor inicial de t
            float w = condicion;   // Condición inicial
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_ti", "ti");
            dgvResultado.Columns.Add("valor_wi", "wi");

            // Primera fila: valores iniciales
            dgvResultado.Rows.Add();
            dgvResultado.Rows[0].Cells[0].Value = 0;
            dgvResultado.Rows[0].Cells[1].Value = t;
            dgvResultado.Rows[0].Cells[2].Value = w;

            for (int i = 1; i <= n; i++)
            {
                // Taylor de orden 2: w(i+1) = w(i) + h*f(t(i), w(i)) + (h^2/2)*f'(t(i), w(i))
                float fValue = f(t, w);         // f(t, w)
                float fPrimeValue = f_prima(t, w); // f'(t, w)
                w = w + h * fValue + (h * h / 2) * fPrimeValue;
                t = a + i * h; // Actualizamos t para la siguiente iteración

                // Añadimos los resultados a la tabla
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i].Cells[0].Value = i;
                dgvResultado.Rows[i].Cells[1].Value = t;
                dgvResultado.Rows[i].Cells[2].Value = w;
            }

            return w; // Retornamos el último valor calculado
        }


        public float metodoDeRK4(float condicion, float a, float b, float n, ref DataGridView dgvResultado)
        {
            float h = (b - a) / n; // Tamaño de paso
            float t = a;           // Valor inicial de t
            float w = condicion;   // Condición inicial

            // Configurar DataGridView
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_ti", "ti");
            dgvResultado.Columns.Add("valor_wi", "wi");
            dgvResultado.Columns.Add("k1", "k1");
            dgvResultado.Columns.Add("k2", "k2");
            dgvResultado.Columns.Add("k3", "k3");
            dgvResultado.Columns.Add("k4", "k4");

            // Primera fila: valores iniciales
            dgvResultado.Rows.Add();
            dgvResultado.Rows[0].Cells[0].Value = 0; // Iteración
            dgvResultado.Rows[0].Cells[1].Value = t; // Valor inicial de t
            dgvResultado.Rows[0].Cells[2].Value = w; // Valor inicial de w
            dgvResultado.Rows[0].Cells[3].Value = ""; // k1 vacío
            dgvResultado.Rows[0].Cells[4].Value = ""; // k2 vacío
            dgvResultado.Rows[0].Cells[5].Value = ""; // k3 vacío
            dgvResultado.Rows[0].Cells[6].Value = ""; // k4 vacío

            for (int i = 1; i <= n; i++)
            {
                // Cálculo de las constantes k
                float k1 = h * f(t, w);
                float k2 = h * f(t + h / 2, w + k1 / 2);
                float k3 = h * f(t + h / 2, w + k2 / 2);
                float k4 = h * f(t + h, w + k3);

                // Actualización de w y t
                w = w + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                t = a + i * h;

                // Añadimos los resultados a la tabla
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i].Cells[0].Value = i;      // Iteración
                dgvResultado.Rows[i].Cells[1].Value = t;      // Valor de t
                dgvResultado.Rows[i].Cells[2].Value = w;      // Valor de w
                dgvResultado.Rows[i].Cells[3].Value = k1;     // k1
                dgvResultado.Rows[i].Cells[4].Value = k2;     // k2
                dgvResultado.Rows[i].Cells[5].Value = k3;     // k3
                dgvResultado.Rows[i].Cells[6].Value = k4;     // k4
            }

            return w; // Retornamos el último valor calculado
        }


        public float metodoDeHeun(float condicion, float a, float b, float n, ref DataGridView dgvResultado)
        {
            float h = (b - a) / n; // Tamaño del paso
            float t = a;           // Valor inicial de t
            float w = condicion;   // Condición inicial

            // Configurar el DataGridView
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_ti", "ti");
            dgvResultado.Columns.Add("valor_wi", "wi");

            // Primera fila: valores iniciales
            dgvResultado.Rows.Add();
            dgvResultado.Rows[0].Cells[0].Value = 0; // Iteración
            dgvResultado.Rows[0].Cells[1].Value = t; // Valor inicial de t
            dgvResultado.Rows[0].Cells[2].Value = w; // Valor inicial de w

            for (int i = 1; i <= n; i++)
            {
                // Calcular f(t_i, w_i)
                float f1 = f(t, w);


                // Actualizar w usando la fórmula proporcionada
                w = w + (h / 4) * (f1 + 3 * f(t+2*h/3,w+2*h/3*f(t+h/3,w+h/3*f1)));
                t = a + i * h;

                // Agregar resultados al DataGridView
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i].Cells[0].Value = i;      // Iteración
                dgvResultado.Rows[i].Cells[1].Value = t;      // Valor de t
                dgvResultado.Rows[i].Cells[2].Value = w;      // Valor de w
            }

            return w; // Retornamos el último valor calculado
        }






        float f(float y, float w)
        {
            // dy/dt = -k*sqrt(y)
            // con k = 0.06
            float r;
            r = (float)(w- y*y +1);
            return r;
        }
        float f_prima(float y, float w)
        {
            float r;
            r = (float)(w - y * y + 1-2*y);
            return r;
        }
    }
}
