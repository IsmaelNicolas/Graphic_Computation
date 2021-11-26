
namespace WinAppStarPoligon
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.grp_controls = new System.Windows.Forms.GroupBox();
            this.btn_graph = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_model = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grp_controls.SuspendLayout();
            this.grp_model.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_controls
            // 
            this.grp_controls.Controls.Add(this.btn_graph);
            this.grp_controls.Controls.Add(this.btn_exit);
            this.grp_controls.Location = new System.Drawing.Point(12, 12);
            this.grp_controls.Name = "grp_controls";
            this.grp_controls.Size = new System.Drawing.Size(251, 83);
            this.grp_controls.TabIndex = 0;
            this.grp_controls.TabStop = false;
            this.grp_controls.Text = "Controls";
            // 
            // btn_graph
            // 
            this.btn_graph.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_graph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_graph.Location = new System.Drawing.Point(130, 19);
            this.btn_graph.Name = "btn_graph";
            this.btn_graph.Size = new System.Drawing.Size(98, 41);
            this.btn_graph.TabIndex = 0;
            this.btn_graph.Text = "Graph";
            this.btn_graph.UseVisualStyleBackColor = false;
            this.btn_graph.Click += new System.EventHandler(this.btn_graph_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.LightCoral;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(40, 19);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 41);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(269, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 400);
            this.panel1.TabIndex = 1;
            // 
            // grp_model
            // 
            this.grp_model.Controls.Add(this.pictureBox1);
            this.grp_model.Controls.Add(this.lbl_model);
            this.grp_model.Location = new System.Drawing.Point(12, 101);
            this.grp_model.Name = "grp_model";
            this.grp_model.Size = new System.Drawing.Size(251, 311);
            this.grp_model.TabIndex = 2;
            this.grp_model.TabStop = false;
            this.grp_model.Text = "Model";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(7, 20);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(0, 13);
            this.lbl_model.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 421);
            this.panel2.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 421);
            this.Controls.Add(this.grp_model);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grp_controls);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Star Poligon";
            this.grp_controls.ResumeLayout(false);
            this.grp_model.ResumeLayout(false);
            this.grp_model.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_controls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_model;
        private System.Windows.Forms.Button btn_graph;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

