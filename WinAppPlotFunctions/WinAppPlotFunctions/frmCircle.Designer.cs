namespace WinAppPlotFunctions
{
    partial class frmCircle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstYp = new System.Windows.Forms.ListBox();
            this.lstXp = new System.Windows.Forms.ListBox();
            this.lstY = new System.Windows.Forms.ListBox();
            this.lstX = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grbTableValues = new System.Windows.Forms.GroupBox();
            this.grbOptions.SuspendLayout();
            this.grbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbCanvas.SuspendLayout();
            this.grbTableValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.btnExit);
            this.grbOptions.Controls.Add(this.btnReset);
            this.grbOptions.Controls.Add(this.btnCalculate);
            this.grbOptions.Location = new System.Drawing.Point(369, 13);
            this.grbOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grbOptions.Size = new System.Drawing.Size(267, 130);
            this.grbOptions.TabIndex = 9;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Opciones";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 87);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(217, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(25, 54);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(217, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 20);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(217, 28);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.lblRadius);
            this.grbInput.Controls.Add(this.txtRadius);
            this.grbInput.Location = new System.Drawing.Point(13, 13);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4);
            this.grbInput.Size = new System.Drawing.Size(348, 130);
            this.grbInput.TabIndex = 8;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Datos de entrada";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(23, 57);
            this.lblRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(74, 25);
            this.lblRadius.TabIndex = 3;
            this.lblRadius.Text = "Radio:";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(127, 60);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(124, 22);
            this.txtRadius.TabIndex = 0;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(43, 23);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(533, 369);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(13, 151);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(4);
            this.grbCanvas.Size = new System.Drawing.Size(623, 406);
            this.grbCanvas.TabIndex = 10;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(187, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "xp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "y";
            // 
            // lstYp
            // 
            this.lstYp.FormattingEnabled = true;
            this.lstYp.ItemHeight = 16;
            this.lstYp.Location = new System.Drawing.Point(272, 49);
            this.lstYp.Margin = new System.Windows.Forms.Padding(4);
            this.lstYp.Name = "lstYp";
            this.lstYp.Size = new System.Drawing.Size(79, 468);
            this.lstYp.TabIndex = 19;
            // 
            // lstXp
            // 
            this.lstXp.FormattingEnabled = true;
            this.lstXp.ItemHeight = 16;
            this.lstXp.Location = new System.Drawing.Point(184, 49);
            this.lstXp.Margin = new System.Windows.Forms.Padding(4);
            this.lstXp.Name = "lstXp";
            this.lstXp.Size = new System.Drawing.Size(79, 468);
            this.lstXp.TabIndex = 18;
            // 
            // lstY
            // 
            this.lstY.FormattingEnabled = true;
            this.lstY.ItemHeight = 16;
            this.lstY.Location = new System.Drawing.Point(96, 49);
            this.lstY.Margin = new System.Windows.Forms.Padding(4);
            this.lstY.Name = "lstY";
            this.lstY.Size = new System.Drawing.Size(79, 468);
            this.lstY.TabIndex = 17;
            // 
            // lstX
            // 
            this.lstX.FormattingEnabled = true;
            this.lstX.ItemHeight = 16;
            this.lstX.Location = new System.Drawing.Point(8, 50);
            this.lstX.Margin = new System.Windows.Forms.Padding(4);
            this.lstX.Name = "lstX";
            this.lstX.Size = new System.Drawing.Size(79, 468);
            this.lstX.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(283, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 25);
            this.label13.TabIndex = 15;
            this.label13.Text = "yp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "x";
            // 
            // grbTableValues
            // 
            this.grbTableValues.Controls.Add(this.lstYp);
            this.grbTableValues.Controls.Add(this.lstXp);
            this.grbTableValues.Controls.Add(this.lstY);
            this.grbTableValues.Controls.Add(this.lstX);
            this.grbTableValues.Controls.Add(this.label13);
            this.grbTableValues.Controls.Add(this.label12);
            this.grbTableValues.Controls.Add(this.label11);
            this.grbTableValues.Controls.Add(this.label10);
            this.grbTableValues.Location = new System.Drawing.Point(644, 20);
            this.grbTableValues.Margin = new System.Windows.Forms.Padding(4);
            this.grbTableValues.Name = "grbTableValues";
            this.grbTableValues.Padding = new System.Windows.Forms.Padding(4);
            this.grbTableValues.Size = new System.Drawing.Size(364, 537);
            this.grbTableValues.TabIndex = 11;
            this.grbTableValues.TabStop = false;
            this.grbTableValues.Text = "Tabla de valores";
            // 
            // frmCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 572);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbTableValues);
            this.Name = "frmCircle";
            this.Text = "frmCircle";
            this.Load += new System.EventHandler(this.frmCircle_Load);
            this.grbOptions.ResumeLayout(false);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbCanvas.ResumeLayout(false);
            this.grbTableValues.ResumeLayout(false);
            this.grbTableValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstYp;
        private System.Windows.Forms.ListBox lstXp;
        private System.Windows.Forms.ListBox lstY;
        private System.Windows.Forms.ListBox lstX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grbTableValues;
    }
}