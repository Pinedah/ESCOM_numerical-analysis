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


        public void metodoRK4Sistema(float a, float b, int N, int m, float[] condicionesIniciales, Func<float, float[], float[]> sistemaEcuaciones, ref DataGridView dgvResultado)
        {
            // Paso 1: Determinar h
            float h = (b - a) / N;

            // Inicializar t y w
            float t = a;
            float[] w = new float[m];
            Array.Copy(condicionesIniciales, w, m);

            // Configurar el DataGridView
            dgvResultado.Rows.Clear();
            dgvResultado.Columns.Clear();
            dgvResultado.Columns.Add("iteracion", "i");
            dgvResultado.Columns.Add("valor_t", "t");

            for (int j = 1; j <= m; j++)
            {
                dgvResultado.Columns.Add($"w{j}", $"w{j}");
                dgvResultado.Columns.Add($"k1_{j}", $"k1_{j}");
                dgvResultado.Columns.Add($"k2_{j}", $"k2_{j}");
                dgvResultado.Columns.Add($"k3_{j}", $"k3_{j}");
                dgvResultado.Columns.Add($"k4_{j}", $"k4_{j}");
            }

            // Paso 2: Salida inicial
            dgvResultado.Rows.Add();
            dgvResultado.Rows[0].Cells[0].Value = 0; // Iteración
            dgvResultado.Rows[0].Cells[1].Value = t; // Valor inicial de t
            for (int j = 0; j < m; j++)
            {
                dgvResultado.Rows[0].Cells[2 + j * 5].Value = w[j]; // Valores iniciales de wj
            }

            // Iteraciones
            for (int i = 1; i <= N; i++)
            {
                float[] k1 = new float[m];
                float[] k2 = new float[m];
                float[] k3 = new float[m];
                float[] k4 = new float[m];
                float[] wTemp = new float[m];

                // Paso 5: Calcular k1
                float[] f1 = sistemaEcuaciones(t, w);
                for (int j = 0; j < m; j++)
                {
                    k1[j] = h * f1[j];
                }

                // Paso 6: Calcular k2
                for (int j = 0; j < m; j++)
                {
                    wTemp[j] = w[j] + 0.5f * k1[j];
                }
                float[] f2 = sistemaEcuaciones(t + 0.5f * h, wTemp);
                for (int j = 0; j < m; j++)
                {
                    k2[j] = h * f2[j];
                }

                // Paso 7: Calcular k3
                for (int j = 0; j < m; j++)
                {
                    wTemp[j] = w[j] + 0.5f * k2[j];
                }
                float[] f3 = sistemaEcuaciones(t + 0.5f * h, wTemp);
                for (int j = 0; j < m; j++)
                {
                    k3[j] = h * f3[j];
                }

                // Paso 8: Calcular k4
                for (int j = 0; j < m; j++)
                {
                    wTemp[j] = w[j] + k3[j];
                }
                float[] f4 = sistemaEcuaciones(t + h, wTemp);
                for (int j = 0; j < m; j++)
                {
                    k4[j] = h * f4[j];
                }

                // Paso 9: Actualizar w
                for (int j = 0; j < m; j++)
                {
                    w[j] = w[j] + (k1[j] + 2 * k2[j] + 2 * k3[j] + k4[j]) / 6;
                }

                // Paso 10: Actualizar t
                t = a + i * h;

                // Paso 11: Salida
                dgvResultado.Rows.Add();
                dgvResultado.Rows[i].Cells[0].Value = i; // Iteración
                dgvResultado.Rows[i].Cells[1].Value = t; // Valor de t
                for (int j = 0; j < m; j++)
                {
                    dgvResultado.Rows[i].Cells[2 + j * 5].Value = w[j];    // Valor de wj
                    dgvResultado.Rows[i].Cells[3 + j * 5].Value = k1[j];   // Valor de k1,j
                    dgvResultado.Rows[i].Cells[4 + j * 5].Value = k2[j];   // Valor de k2,j
                    dgvResultado.Rows[i].Cells[5 + j * 5].Value = k3[j];   // Valor de k3,j
                    dgvResultado.Rows[i].Cells[6 + j * 5].Value = k4[j];   // Valor de k4,j
                }
            }
        }
        public float[] sistemaEcuaciones(float t, float[] w)
        {
            // w[0] = u1(t), w[1] = u2(t)
            float u1 = w[0];
            float u2 = w[1];

            // Definimos las ecuaciones del sistema
            float u1Prima = u2; // u'_1(t) = u2(t)
            float u2Prima = (float)(Math.Exp(2 * t) * Math.Sin(t)) - 2 * u1 + 2 * u2; // u'_2(t)

            return new float[] { u1Prima, u2Prima };
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
