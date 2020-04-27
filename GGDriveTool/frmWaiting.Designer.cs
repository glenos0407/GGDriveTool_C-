namespace GGDriveTool
{
    partial class frmWaiting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWaiting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.processBarWaiting = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timerWaiting = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.processBarWaiting);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 80);
            this.panel1.TabIndex = 0;
            // 
            // processBarWaiting
            // 
            this.processBarWaiting.animated = true;
            this.processBarWaiting.animationIterval = 5;
            this.processBarWaiting.animationSpeed = 50;
            this.processBarWaiting.BackColor = System.Drawing.Color.WhiteSmoke;
            this.processBarWaiting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("processBarWaiting.BackgroundImage")));
            this.processBarWaiting.Dock = System.Windows.Forms.DockStyle.Left;
            this.processBarWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.processBarWaiting.ForeColor = System.Drawing.Color.SeaGreen;
            this.processBarWaiting.LabelVisible = false;
            this.processBarWaiting.LineProgressThickness = 5;
            this.processBarWaiting.LineThickness = 5;
            this.processBarWaiting.Location = new System.Drawing.Point(0, 0);
            this.processBarWaiting.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.processBarWaiting.MaxValue = 100;
            this.processBarWaiting.Name = "processBarWaiting";
            this.processBarWaiting.ProgressBackColor = System.Drawing.Color.LightGray;
            this.processBarWaiting.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(151)))), ((int)(((byte)(243)))));
            this.processBarWaiting.Size = new System.Drawing.Size(80, 80);
            this.processBarWaiting.TabIndex = 0;
            this.processBarWaiting.Value = 0;
            // 
            // timerWaiting
            // 
            this.timerWaiting.Tick += new System.EventHandler(this.timerWaiting_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui Lòng Đợi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmWaiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 80);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWaiting";
            this.Text = "frmWaiting";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar processBarWaiting;
        private System.Windows.Forms.Timer timerWaiting;
        private System.Windows.Forms.Label label1;
    }
}