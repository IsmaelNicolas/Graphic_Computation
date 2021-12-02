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
    public partial class frmCuadraticFunction : Form
    {
        // Composición - Un objeto de tipo CCuadraticFunction
        private CCuadraticFunction ObjCuadraticFunction = new CCuadraticFunction();

        public frmCuadraticFunction()
        {
            InitializeComponent();
        }

        private void frmCuadraticFunction_Load(object sender, EventArgs e)
        {
            ObjCuadraticFunction.InitializeData();
            ObjCuadraticFunction.InitializeControls(txtA, txtB, txtC, 
                                                        picCanvas, lstX, 
                                                        lstY, lstXp, lstYp);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCuadraticFunction.ReadData(txtA, txtB, txtC);
            ObjCuadraticFunction.PlotAxis(picCanvas);
            ObjCuadraticFunction.PlotCurve(picCanvas, lstX, lstY, 
                                            lstXp, lstYp);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCuadraticFunction.InitializeData();
            ObjCuadraticFunction.InitializeControls(txtA, txtB, txtC,
                                                        picCanvas, lstX,
                                                        lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
