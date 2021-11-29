using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinAppStarPoligon
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_graph_Click(object sender, EventArgs e)
        {
            CStarPoligon obj_poligon = new CStarPoligon();
            obj_poligon.plot_figure(this.pic_canvas,this.label1);
        }
    }
}
