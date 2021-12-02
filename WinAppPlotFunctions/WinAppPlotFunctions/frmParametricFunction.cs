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
    public partial class frmParametricFunction : Form
    {
        CParametricFunction ObjParametricFunction = new CParametricFunction();
        public frmParametricFunction()
        {
            InitializeComponent();
        }

        private void frmParametricFunction_Load(object sender, EventArgs e)
        {
            ObjParametricFunction.InitializeData();
            ObjParametricFunction.InitializeControls(picCanvas, lstX, lstY,
                lstXp, lstYp);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjParametricFunction.PlotAxis(picCanvas);
            ObjParametricFunction.PlotCurve(picCanvas, lstX, lstY, lstXp, lstYp);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjParametricFunction.InitializeData();
            ObjParametricFunction.InitializeControls(picCanvas, lstX, lstY,
                lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
