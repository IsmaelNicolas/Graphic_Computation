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
    public partial class frmSinFunction : Form
    {
        private CSinFunction ObjSinFunction = new CSinFunction();
        public frmSinFunction()
        {
            InitializeComponent();
        }

        private void frmSinFunction_Load(object sender, EventArgs e)
        {
            ObjSinFunction.InitializeData();
            ObjSinFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSinFunction.ReadData(txtA);
            ObjSinFunction.PlotAxis(picCanvas);
            ObjSinFunction.PlotCurve(picCanvas, lstX, lstY, lstXp, lstYp);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSinFunction.InitializeData();
            ObjSinFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
