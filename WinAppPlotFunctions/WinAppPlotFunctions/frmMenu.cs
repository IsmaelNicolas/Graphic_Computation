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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCuadraticFunction_Click(object sender, EventArgs e)
        {
            frmCuadraticFunction frmObject = new frmCuadraticFunction();
            frmObject.Show();
        }

        private void btnSinFunction_Click(object sender, EventArgs e)
        {
            frmSinFunction frmObject = new frmSinFunction();
            frmObject.Show();
        }

        private void btnRoseFourPetals_Click(object sender, EventArgs e)
        {
            frmRoseFourPetals frmObject = new frmRoseFourPetals();
            frmObject.Show();
        }

        private void btnRationalFunction_Click(object sender, EventArgs e)
        {
            frmRationalFunction frmObject = new frmRationalFunction();
            frmObject.Show();
        }

        private void btnParametricFunction_Click(object sender, EventArgs e)
        {
            frmParametricFunction frmObject = new frmParametricFunction();
            frmObject.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            frmCircle frmObject = new frmCircle();
            frmObject.Show();
        }
    }
}
