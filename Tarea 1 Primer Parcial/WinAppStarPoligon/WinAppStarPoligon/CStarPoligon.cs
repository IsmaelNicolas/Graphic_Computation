using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppStarPoligon
{
    class CStarPoligon
    {

        #region Data Members

        private LinkedList<PointF> mOuterPoligon = new LinkedList<PointF>();
        private LinkedList<PointF> mMiddlePoligon = new LinkedList<PointF>();
        private LinkedList<PointF> mInnerPoligon = new LinkedList<PointF>();
        private Graphics mGraph;
        private const float SF = 50; // SCALE FACTOR
        private Pen mPencil;
        #endregion

        #region Getters and Setters

        public LinkedList<PointF> OuterPoligon { get => mOuterPoligon; set => mOuterPoligon = value; }
        public Graphics Graph { get => mGraph; set => mGraph = value; }
        public Pen Pencil { get => mPencil; set => mPencil = value; }
        public LinkedList<PointF> MiddlePoligon { get => mMiddlePoligon; set => mMiddlePoligon = value; }
        public LinkedList<PointF> InnerPoligon { get => mInnerPoligon; set => mInnerPoligon = value; }

        #endregion


        #region Constructor
        public CStarPoligon()
        {
            initialize_data();
        }
        #endregion

        #region Methods

        public void initialize_data()
        {
            float[] sin = { (float)Math.Sin(3 * Math.PI / 10) , (float)Math.Sin(Math.PI / 10) };
            float[] cos = { (float)Math.Cos(3 * Math.PI / 10) , (float)Math.Cos(Math.PI / 10) };
            OuterPoligon.AddLast(new PointF(0.0f, 0.0f ));
            OuterPoligon.AddLast(new PointF(1.0f , 0.0f));
            //OuterPoligon.AddLast( new PointF( (1+ (float)Math.Sin(3*Math.PI/10) )*SF , ((float)Math.Cos(3 * Math.PI / 10))*SF));

            int n = 0,k=0;
            Func<int, int> s = (x) => Math.Abs((int)Math.Round(Math.Sin(x)));

            for (int i = 2,j=0; i<4; i++,j++)
            {
                
                OuterPoligon.AddLast(new PointF(
                    OuterPoligon.ElementAt(i - 1).X + ((float)Math.Pow(-1,k))*sin[n],
                    OuterPoligon.ElementAt(i - 1).Y + cos[n] 
                ));

                n = s(j+1);
                k = s(j);
            }

        }

        public void plot_figure(PictureBox canvas,Label control)
        {
            Graph = canvas.CreateGraphics();
            Brush aBrush = (Brush)Brushes.Red;
            Brush aBrush1 = (Brush)Brushes.Blue;
            Pencil = new Pen(Color.Blue);
            foreach(PointF p in OuterPoligon)
            {
                control.Text += p.ToString() +"\n";
            }
            //control.Text = OuterPoligon.ToString();
            //Graph.FillRectangle(aBrush, Points.ElementAt(0).X, Points.ElementAt(0).Y,SF, SF);
            //foreach(PointF p in OuterPoligon)
            //{
            //    Graph.FillRectangle(aBrush1, p.X*SF, p.Y *SF, 3, 3);
            //}
            //Graph.DrawPolygon(Pencil, OuterPoligon.ToArray());
            //Graph.DrawLine(Pencil, OuterPoligon.ElementAt(0), OuterPoligon.ElementAt(1));
            //Graph.FillRectangle(aBrush, OuterPoligon.ElementAt(1).X *SF, OuterPoligon.ElementAt(1).Y *SF, 3, 3);
            Func<int, int> r = (x) => (int)Math.Round((double)(x/3));
            int i = 0,j=0,n=1;
            while (j<9) 
            {
                if (j != 4){
                    i = i > 3 ? 0 : i += 1;
                    n = n > 3 ? 0 : n += 1;
                    control.Text += r(i).ToString() +"," + r(n).ToString() + "\n";
                    j++;
                }
                else
                {
                    j++;i = 0;n = 1;
                    control.Text += "Cambio"+ "\n";
                }
                
            }
        }

        #endregion


    }
}
