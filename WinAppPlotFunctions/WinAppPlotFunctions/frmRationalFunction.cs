using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPlotFunctions
{
    public partial class frmRationalFunction : Form
    {
        CRationalFunction ObjRationalFunction = new CRationalFunction();
        public frmRationalFunction()
        {
            InitializeComponent();
        }

        private void frmRationalFunction_Load(object sender, EventArgs e)
        {
            ObjRationalFunction.InitializeData();
            ObjRationalFunction.InitializeControls(picCanvas, lstX,
                lstY, lstXp, lstYp);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRationalFunction.PlotAxis(picCanvas);
            ObjRationalFunction.PlotCurve(picCanvas, lstX, lstY, lstXp, lstYp);
            ObjRationalFunction.PlotAsimptotes(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRationalFunction.InitializeData();
            ObjRationalFunction.InitializeControls(picCanvas, lstX,
                lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
