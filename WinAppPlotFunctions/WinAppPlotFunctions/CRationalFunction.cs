using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppPlotFunctions
{
    class CRationalFunction
    {
        // Datos miembro - Atributos de la clase.        
        // Activar el modo gráfico de Windows con GDI+ 
        // GDI+ (Graphic Device Interface with COM+ Technology).
        private Graphics mGraph;
        // Factor de escalamiento para hacer un Zoom In/Zoom Out.
        private const float SF = 20;
        // Pluma para graficar en el lienzo (canvas).
        private Pen ObjPen;
        // Arreglo de puntos (pixeles) de tipo Estructura Punto Plotante.
        //private PointF[] mP1 = new PointF[790];
        //private PointF[] mP2 = new PointF[381];
        //private PointF[] mP3 = new PointF[790];
        private PointF[] mP1;
        private PointF[] mP2;
        private PointF[] mP3;
        // Valores de 'x' y de 'y'.
        private float mX, mY;
        // Valores de 'xp' y 'yp'.
        private float mXp, mYp;
        // Intervalos de la función.
        private float I1, I2, I3, I4, I5, I6;

        // Constructores de la clase.
        // Constructor por defecto.
        public CRationalFunction()
        {            
            mX = 0.0f; mY = 0.0f; mXp = 0.0f; mYp = 0.0f;
        }

        // Funciones miembro - Métodos de la clase.        
        // Función para graficar los ejes coordenados.
        // Resolución de 400x300 - picCanvas (lienzo)
        // Centro Trasladado.
        // Cp(200,150)
        public void PlotAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Black);
            // Eje horizontal - eje x (a lo ancho-width).
            mGraph.DrawLine(ObjPen, 0, 150, 400, 150);
            // Eje vertical - eje y (a lo largo-height).
            mGraph.DrawLine(ObjPen, 200, 0, 200, 300);
        }
        // Función para graficar las asíntotas.
        public void PlotAsimptotes(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Red);
            // Asíntota: x = -2 (Paralela al eje vertical)
            // P1(-2, 0); P2(-2,300)
            mGraph.DrawLine(ObjPen, (-2) * SF + 200, 0, (-2) * SF + 200, 300);
            // Asíntota: x = 2 (Paralela al eje vertical)
            // P1(2, 0); P2(2,300)
            mGraph.DrawLine(ObjPen, 2 * SF + 200, 0, 2 * SF + 200, 300);
            // Asíntota: y = 1 (Paralela al eje horizontal)
            // P1(0, 1); P2(400,1)
            mGraph.DrawLine(ObjPen, 0, (-1) * 1 * SF + 150, 400, (-1) * 1 * SF + 150);
        }
        //Función para evaluar la función cuadrática.
        public void EvaluateFunction(ListBox lstX, ListBox lstY,
                                     ListBox lstXp, ListBox lstYp)
        {
            float i; // Contador para controlar la función (valor de x).
            int j;   // Contador para controlar el arreglo de puntos.

            // D1: [-10,-2)
            I1 = -10.0f; I2 = -2.1f;
            // Enteros - 7.9 puntos aprox 8 (Unidades); h = 1 (7 ptos) (centímetros)
            // Decimas - 79 (80-1) puntos aprox 80 (Decenas); h = 0.1 (milímetros)
            // -10,-9.9,-9.8,...-9.5,...,-9 (10 ptos)
            // -10,-9,...,-3 (70ptos)
            // -3,-2.9,-2.8,...,-2.1 (9 ptos)
            // -10,-9,...,-3,-2.9,-2.8,...,-2.1
            // Centésimas - 790 puntos (Centenas); h = 0.01
            // h = 0.01 (tamaño de paso o delta x) valor se define en centésimas
            for (i = I1, j = 0; i <= I2; i += 0.01f, j++)
            {
                // Tabla de valores del mundo real.
                mX = i; lstX.Items.Add(mX.ToString());
                mY = ((float)Math.Pow(mX, 2) - 1) / ((float)Math.Pow(mX, 2) - 4); lstY.Items.Add(mY.ToString());
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + 200); lstXp.Items.Add(mXp.ToString());
                mYp = (float)((-1) * mY * SF + 150); lstYp.Items.Add(mYp.ToString());
                // Arreglo de puntos de  tipo flotante.
                mP1[j] = new PointF(mXp, mYp);
            }
            // D2: (-2,2)
            // Enteros - 3.81 aproximadamente 4 puntos (3ptos)            
            // Decimas - 38.1 puntos+el cero(1pto) 40 puntos
            // -1,0,1 (20 ptos)
            // -1,-1,1,-1,2,...-1.9 (9 ptos)
            // 1,1.1,1.2,...,1.9 (9 ptos)
            // Centésimas - 381 (380+1) puntos (incluye el cero)
            // h = 0.01 (tamaño de paso o delta x)
            I3 = -1.9f; I4 = 1.9f;
            for (i = I3, j = 0; i <= I4; i += 0.01f, j++)
            {
                // Tabla de valores del mundo real.
                mX = i; lstX.Items.Add(mX.ToString());
                mY = ((float)Math.Pow(mX, 2) - 1) / ((float)Math.Pow(mX, 2) - 4); lstY.Items.Add(mY.ToString());
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + 200); lstXp.Items.Add(mXp.ToString());
                mYp = (float)((-1) * mY * SF + 150); lstYp.Items.Add(mYp.ToString());
                // Arreglo de puntos de  tipo flotante.
                mP2[j] = new PointF(mXp, mYp);
            }
            // D3: (2,10]
            // Enteros (Unidades) - 7.9 puntos aprox 8 (7ptos) 80 puntos
            // Decimas - 79 puntos
            // Centésimas - 790 puntos
            // h = 0.01 (tamaño de paso o delta x)
            I5 = 2.1f; I6 = 10.0f;
            for (i = I5, j = 0; i <= I6; i += 0.01f, j++)
            {
                // Tabla de valores del mundo real.
                mX = i; lstX.Items.Add(mX.ToString());
                mY = ((float)Math.Pow(mX, 2) - 1) / ((float)Math.Pow(mX, 2) - 4); lstY.Items.Add(mY.ToString());
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + 200); lstXp.Items.Add(mXp.ToString());
                mYp = (float)((-1) * mY * SF + 150); lstYp.Items.Add(mYp.ToString());
                // Arreglo de puntos de  tipo flotante.
                mP3[j] = new PointF(mXp, mYp);
            }
        }

        // Función para graficar la curva.
        public void PlotCurve(PictureBox picCanvas, ListBox lstX,
                              ListBox lstY, ListBox lstXp, ListBox lstYp)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Blue);
            mP1 = new PointF[790];
            mP2 = new PointF[381];
            mP3 = new PointF[790];

            EvaluateFunction(lstX, lstY, lstXp, lstYp);

            mGraph.DrawCurve(ObjPen, mP1);
            mGraph.DrawCurve(ObjPen, mP2);
            mGraph.DrawCurve(ObjPen, mP3);
        }

        public void InitializeData()
        {            
            mX = 0.0f; mY = 0.0f; mXp = 0.0f; mYp = 0.0f;
        }

        public void InitializeControls(PictureBox picCanvas,
                                       ListBox lstX, ListBox lstY,
                                       ListBox lstXp, ListBox lstYp)
        {            
            picCanvas.Refresh();
            lstX.Items.Clear(); lstY.Items.Clear(); lstXp.Items.Clear(); lstYp.Items.Clear();
        }
    }
}
