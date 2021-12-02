using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WinAppTrasedentalFuntion
{
    class CPlot
    {

        #region Data members
        private LinkedList<PointF> mPoints = new LinkedList<PointF>();
        private const float SF = 100; // SCALE FACTOR
        private Graphics mGraph;
        private Pen mPencil;
        #endregion

        #region Getters and Setters
        public LinkedList<PointF> Points { get => mPoints; set => mPoints = value; }
        public Graphics Graph { get => mGraph; set => mGraph = value; }
        public Pen Pencil { get => mPencil; set => mPencil = value; }

        #endregion

        #region Constructor
        public CPlot()
        {

        }

        #endregion

        #region Methods
        public void plot_axis(PictureBox canvas)
        {
            Graph = canvas.CreateGraphics();
            Pencil = new Pen(Color.LightGray, 1);
            float[] dashValues = { 10, 5};
            Pencil.DashPattern = dashValues;

            Graph.DrawLine(Pencil,
                new PointF(canvas.Width / 2, 0),
                new PointF(canvas.Width / 2, canvas.Height)
            );
            Graph.DrawLine(Pencil,
                new PointF(0,canvas.Height/2),
                new PointF(canvas.Width, canvas.Height/2)
            );
        }
        #endregion

    }
}
