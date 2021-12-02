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
    public partial class frmRoseFourPetals : Form
    {
        private CRoseFourPetals ObjRoseFourPetals = new CRoseFourPetals();

        public frmRoseFourPetals()
        {
            InitializeComponent();
        }

        private void frmRoseFourPetals_Load(object sender, EventArgs e)
        {
            ObjRoseFourPetals.InitializeData();
            ObjRoseFourPetals.InitializeControls(txtA, picCanvas, lstX, 
                                                     lstY, lstXp, lstYp);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRoseFourPetals.ReadData(txtA);
            ObjRoseFourPetals.PlotAxis(picCanvas);
            ObjRoseFourPetals.PlotCurve(picCanvas, lstX, lstY, lstXp, lstYp);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRoseFourPetals.InitializeData();
            ObjRoseFourPetals.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
