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
        private const float SF = 100; // SCALE FACTOR
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

        private void initialize_data()
        {
            //OuterPoligon.AddLast(new PointF(0.0f, 0.0f ));
            //OuterPoligon.AddLast(new PointF(1.0f , 0.0f));

        }


        private void calculate_points(LinkedList<PointF> link,PointF origin,float module, double[] deg)
        {

            double[] angles = deg;
            Func<int, int> r = (x) => (int)Math.Round((double)(x / 3));
            int i, j, n, k;

           // if(angles[0] == 3 * Math.PI / 10)
            //{
                i = 0; j = 2; n = 1; k = 0;
                link.AddLast(new PointF(0.0f, 0.0f));
                link.AddLast(new PointF(1, 0.0f));
            //}
            /*else
            {
                i = 0; j = 1; n = 1; k = 0;
                link.AddLast(new PointF(0.0f, 0.0f));
            }*/
            

            while (j < 10)
            {
                if (j != 6)
                {
                    i = i > 3 ? 0 : i += 1;
                    n = n > 3 ? 0 : n += 1;
                    link.AddLast(new PointF(
                            link.ElementAt(j - 1).X + ((int)Math.Pow(-1, k)) * ((int)Math.Pow(-1, r(i))) * (float)Math.Sin(angles[r(n)]),
                            link.ElementAt(j - 1).Y + ((int)Math.Pow(-1, k)) * (float)Math.Cos(angles[r(n)])
                    ));

                    j++;
                }
                else
                {
                    link.AddLast(new PointF(0, link.ElementAt(j - 1).Y));
                    j++; i = 0; n = 1; k = 1;
                }

            }

            foreach (PointF p in link)
            {
                link.Find(p).Value = new PointF((p.X*module + origin.X) * SF, (p.Y*module + origin.Y) * SF);
            }

        }

        public void plot_figure(PictureBox canvas, Label control)
        {
            Graph = canvas.CreateGraphics();
            Brush aBrush = (Brush)Brushes.Red;
            Brush aBrush1 = (Brush)Brushes.Blue;
            Pencil = new Pen(Color.Black, 3);
            PointF origin = new PointF(1.25f, 0);
            
            double[] deg = { 3 * Math.PI / 10, Math.PI / 10 };
            double[] deg1 = { 2 * Math.PI / 5, Math.PI / 5 };

            calculate_points(OuterPoligon, origin, 1, deg );
            calculate_points(InnerPoligon, new PointF(origin.X + 0.325f,origin.Y + 1) ,0.35f,deg);
            //calculate_points(MiddlePoligon, new PointF(origin.X + 0.5f,origin.Y + 0.5f) ,0.63f,deg);


            Graph.DrawPolygon(Pencil, OuterPoligon.ToArray());
            Graph.DrawPolygon(Pencil, InnerPoligon.ToArray());
            //Graph.DrawPolygon(Pencil, MiddlePoligon.ToArray());


            Func<int, int> r = (x) => (int)Math.Round((double)(x/3));
            int i = 0,j=0,n=1;

            foreach (var p in MiddlePoligon)
            {
                control.Text += (p.X/SF).ToString() + "," + (p.Y / SF).ToString() + "\n"; 
            }

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
                    j++;i = 2;n = 1;
                    control.Text += "Cambio"+ "\n";
                }
                
            }
        }

        #endregion


    }
}
