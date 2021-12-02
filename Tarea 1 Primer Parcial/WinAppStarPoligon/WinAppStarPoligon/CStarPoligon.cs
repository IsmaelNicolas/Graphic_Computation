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

        private void calculate_points(LinkedList<PointF> link, float init, float module , PointF origin)
        {
            init = init*(float)Math.PI/180.0f;
            float deg = 36* (float)Math.PI / 180.0f;
            link.AddLast( new PointF((float)Math.Cos(init), (float)Math.Sin(init)) );
            float aux = init + deg;
            for(int i = 0; i < 10; i++)
            {
                link.AddLast(new  PointF((float)Math.Cos(aux), (float)Math.Sin(aux))  );
                aux += deg;
            }
            foreach (PointF p in link)
            {
                link.Find(p).Value = new PointF(p.X * module* SF + origin.X, p.Y * module* SF + origin.Y);
            }

        }

      
        public void plot_figure(PictureBox canvas)
        {
            Graph = canvas.CreateGraphics();
            Brush aBrush = (Brush)Brushes.Red;
            Brush aBrush1 = (Brush)Brushes.Blue;
            Pencil = new Pen(Color.Black, 3);
            var Pen1 = new Pen(Color.Blue, 3);
            PointF origin = new PointF(canvas.Width/2,canvas.Height/2);
            
            calculate_points(OuterPoligon, 0 , 2, origin);
            calculate_points(MiddlePoligon, 18 ,1.35f, origin);
            calculate_points(InnerPoligon, 0 , 0.75f, origin);

            Graph.DrawPolygon(Pencil, OuterPoligon.ToArray());
            //Graph.DrawPolygon(Pencil, InnerPoligon.ToArray());
            //Graph.DrawPolygon(Pencil, MiddlePoligon.ToArray());

            for (int i = 0; i < 10; i++)
            {
                Graph.DrawLine(Pen1, OuterPoligon.ElementAt(i), MiddlePoligon.ElementAt(i));
                Graph.DrawLine( Pen1, MiddlePoligon.ElementAt(i), OuterPoligon.ElementAt(i+1));
                Graph.DrawLine( Pen1, MiddlePoligon.ElementAt(i), InnerPoligon.ElementAt(i+1));
                Graph.DrawLine( Pen1, MiddlePoligon.ElementAt(i), InnerPoligon.ElementAt(i));
                Graph.DrawLine( Pen1, InnerPoligon.ElementAt(i), origin);
            }
           
        }

        #endregion


    }
}
