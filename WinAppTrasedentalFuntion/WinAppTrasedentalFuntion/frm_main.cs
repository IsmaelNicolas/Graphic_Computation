using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTrasedentalFuntion
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            this.cmb_funtions.Items.Add("Selecciona una funcion");
            this.cmb_funtions.Items.Add("a*sin(b*x)");
            this.cmb_funtions.Items.Add("a*cos(b*x)");
            this.cmb_funtions.Items.Add("a*tg(b*x)");
            this.cmb_funtions.Items.Add("a*sec(b*x)");
            this.cmb_funtions.Items.Add("a*csc(b*x)");
            this.cmb_funtions.Items.Add("a*cotg(b*x)");
            this.cmb_funtions.SelectedIndex = 0;

        }

        private void btn_graph_Click(object sender, EventArgs e)
        {
            CPlot obj = new CPlot();

            obj.plot_axis(canvas);
        }
    }
}
