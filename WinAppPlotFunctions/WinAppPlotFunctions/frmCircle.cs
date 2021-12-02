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
    public partial class frmCircle : Form
    {
        CCircle ObjCCircle = new CCircle();
        public frmCircle()
        {
            InitializeComponent();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            ObjCCircle.InitializeData();
            ObjCCircle.InitializeControls(txtRadius, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCCircle.ReadData(txtRadius);
            ObjCCircle.PlotAxis(picCanvas);
            ObjCCircle.PlotCurve(picCanvas, lstX, lstY, lstXp, lstYp);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCCircle.InitializeData();
            ObjCCircle.InitializeControls(txtRadius, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
