using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppPlotFunctions
{
    class CCircle
    {
        // Datos miembro - Atributos de la clase.
        // Coeficientes numéricos de la ecuación.
        private float mR;
        // Activar el modo gráfico de Windows con GDI+ 
        // GDI+ (Graphic Device Interface with COM+ Technology).
        private Graphics mGraph;
        // Factor de escalamiento para hacer un Zoom In/Zoom Out.
        private const float SF = 20;
        // Pluma para graficar en el lienzo (canvas).
        private Pen ObjPen;
        // Arreglo de puntos (pixeles) de tipo Estructura Punto Plotante.
        private PointF[] mP = new PointF[361];
        // Valores de 'x' y de 'y'.
        private float mX, mY;
        // Valores de 'xp' y 'yp'.
        private float mXp, mYp;
        // Intervalos de la función.
        private float I1, I2;

        // Propiedades - Descriptores de acceso (getters y setters).
        // => Parallel Process (Sockets) Parallel Programing
        // Multiplayer - Videojuegos.
        // Capa de Transporte (puertos)
        // Protocolo TCP/IP
        public float R { get => mR; set => mR = value; }

        // Constructores de la clase.
        // Constructor por defecto.
        public CCircle()
        {
            R = 0.0f;
            mX = 0.0f; mY = 0.0f;
            mXp = 0.0f; mYp = 0.0f;
        }

        // Funciones miembro - Métodos de la clase.
        // Función para leer el coeficiente numérico de la amplitud.
        public void ReadData(TextBox txtRadius)
        {
            R = float.Parse(txtRadius.Text);
        }
        // Función para graficar los ejes coordenados.
        // Resolución de 400x300 - picCanvas (lienzo)
        // Centro Trasladado.
        // Cp(200,150)
        public void PlotAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Black);
            // Eje horizontal - eje x.
            mGraph.DrawLine(ObjPen, 0, 150, 400, 150);
            // Eje vertical - eje y.
            mGraph.DrawLine(ObjPen, 200, 0, 200, 300);
        }
        //Función para evaluar la función cuadrática.
        public void EvaluateFunction(ListBox lstX, ListBox lstY,
                                     ListBox lstXp, ListBox lstYp)
        {            
            float i; // Contador para controlar la función. // i - ángulo theta
            int j;   // Contador para controlar el arreglo de puntos. // mP[361]:0,1,...360
            // Dominio (theta): [0, 360]
            // h = 1 grado (1*PI/180) rad (delta theta), tamaño de paso
            // Cp(200,150) Centro Trasladado.
            I1 = 0.0f; I2 = 2 * (float)Math.PI;
            for (i = I1, j = 0; i <= I2; i += (float)Math.PI / 180.0f, j++)
            {
                // Tabla de valores del mundo real.
                //r = mA * (float)Math.Cos(2 * i);
                // Fórmulas de transformación de coordenadas polares a rectangulares.
                mX = R * (float)Math.Cos(i); lstX.Items.Add(mX.ToString());
                mY = R * (float)Math.Sin(i); lstY.Items.Add(mY.ToString());
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + 200); lstXp.Items.Add(mXp.ToString());
                mYp = (float)((-1) * mY * SF + 150); lstYp.Items.Add(mYp.ToString());
                // Arreglo de puntos de  tipo flotante.
                mP[j] = new PointF(mXp, mYp);
            }
        }

        //Función para evaluar la función cuadrática.
        public void EvaluateFunction(float r,
                                     ListBox lstX, ListBox lstY,
                                     ListBox lstXp, ListBox lstYp)
        {
            float i; // Contador para controlar la función. // i - ángulo theta
            int j;   // Contador para controlar el arreglo de puntos. // mP[361]:0,1,...360
            // Dominio (theta): [0, 360]
            // h = 1 grado (1*PI/180) rad (delta theta), tamaño de paso
            // Cp(200,150) Centro Trasladado.
            I1 = 0.0f; I2 = 2 * (float)Math.PI;
            for (i = I1, j = 0; i <= I2; i += (float)Math.PI / 180.0f, j++)
            {
                // Tabla de valores del mundo real.
                //r = mA * (float)Math.Cos(2 * i);
                // Fórmulas de transformación de coordenadas polares a rectangulares.
                mX = r * (float)Math.Cos(i); lstX.Items.Add(mX.ToString());
                mY = r * (float)Math.Sin(i); lstY.Items.Add(mY.ToString());
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + 200); lstXp.Items.Add(mXp.ToString());
                mYp = (float)((-1) * mY * SF + 150); lstYp.Items.Add(mYp.ToString());
                // Arreglo de puntos de  tipo flotante.
                mP[j] = new PointF(mXp, mYp);
            }
        }
        
        // Función para graficar la curva.
        public void PlotCurve(PictureBox picCanvas, ListBox lstX,
                              ListBox lstY, ListBox lstXp, ListBox lstYp)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Blue);
            mP = new PointF[361];

            EvaluateFunction(lstX, lstY, lstXp, lstYp);

            mGraph.DrawCurve(ObjPen, mP);
        }

        // Función para graficar la curva.
        public void PlotCurve(float r, PictureBox picCanvas, ListBox lstX,
                              ListBox lstY, ListBox lstXp, ListBox lstYp)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Blue);
            mP = new PointF[361];

            EvaluateFunction(r, lstX, lstY, lstXp, lstYp);

            mGraph.DrawCurve(ObjPen, mP);
        }

        public void InitializeData()
        {
            R = 0.0f;
            mX = 0.0f; mY = 0.0f;
            mXp = 0.0f; mYp = 0.0f;
        }

        public void InitializeControls(TextBox txtRadius, PictureBox picCanvas,
                                       ListBox lstX, ListBox lstY,
                                       ListBox lstXp, ListBox lstYp)
        {
            txtRadius.Text = ""; picCanvas.Refresh();
            lstX.Items.Clear(); lstY.Items.Clear();
            lstXp.Items.Clear(); lstYp.Items.Clear();
        }

    }
}
