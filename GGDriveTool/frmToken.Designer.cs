namespace GGDriveTool
{
    partial class frmToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToken));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOKFine = new System.Windows.Forms.Button();
            this.cbxNameToken = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbxAutoNameToken = new System.Windows.Forms.CheckBox();
            this.btnDeleteToken = new System.Windows.Forms.Button();
            this.imgs_Token = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 32);
            this.panel1.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(358, 32);
            this.lbHeader.TabIndex = 3;
            this.lbHeader.Text = "GGDrive Tool 1.0";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(358, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOKFine
            // 
            this.btnOKFine.BackColor = System.Drawing.Color.Teal;
            this.btnOKFine.FlatAppearance.BorderSize = 0;
            this.btnOKFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKFine.ForeColor = System.Drawing.Color.White;
            this.btnOKFine.Location = new System.Drawing.Point(13, 0);
            this.btnOKFine.Margin = new System.Windows.Forms.Padding(0);
            this.btnOKFine.Name = "btnOKFine";
            this.btnOKFine.Size = new System.Drawing.Size(367, 41);
            this.btnOKFine.TabIndex = 1;
            this.btnOKFine.Text = "OK";
            this.btnOKFine.UseVisualStyleBackColor = false;
            this.btnOKFine.Click += new System.EventHandler(this.btnOKFine_Click);
            // 
            // cbxNameToken
            // 
            this.cbxNameToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.cbxNameToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNameToken.ForeColor = System.Drawing.Color.White;
            this.cbxNameToken.FormattingEnabled = true;
            this.cbxNameToken.Location = new System.Drawing.Point(13, 73);
            this.cbxNameToken.Margin = new System.Windows.Forms.Padding(4);
            this.cbxNameToken.Name = "cbxNameToken";
            this.cbxNameToken.Size = new System.Drawing.Size(345, 29);
            this.cbxNameToken.TabIndex = 2;
            this.cbxNameToken.Enter += new System.EventHandler(this.cbxNameToken_Enter);
            this.cbxNameToken.Leave += new System.EventHandler(this.cbxNameToken_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOKFine);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 58);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name Token";
            // 
            // ckbxAutoNameToken
            // 
            this.ckbxAutoNameToken.AutoSize = true;
            this.ckbxAutoNameToken.ForeColor = System.Drawing.Color.White;
            this.ckbxAutoNameToken.Location = new System.Drawing.Point(13, 110);
            this.ckbxAutoNameToken.Name = "ckbxAutoNameToken";
            this.ckbxAutoNameToken.Size = new System.Drawing.Size(184, 25);
            this.ckbxAutoNameToken.TabIndex = 5;
            this.ckbxAutoNameToken.Text = "Auto Join Name Token";
            this.ckbxAutoNameToken.UseVisualStyleBackColor = true;
            // 
            // btnDeleteToken
            // 
            this.btnDeleteToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteToken.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteToken.Enabled = false;
            this.btnDeleteToken.FlatAppearance.BorderSize = 0;
            this.btnDeleteToken.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDeleteToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteToken.ForeColor = System.Drawing.Color.White;
            this.btnDeleteToken.ImageIndex = 0;
            this.btnDeleteToken.ImageList = this.imgs_Token;
            this.btnDeleteToken.Location = new System.Drawing.Point(358, 73);
            this.btnDeleteToken.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteToken.Name = "btnDeleteToken";
            this.btnDeleteToken.Size = new System.Drawing.Size(27, 29);
            this.btnDeleteToken.TabIndex = 2;
            this.btnDeleteToken.UseVisualStyleBackColor = false;
            this.btnDeleteToken.Click += new System.EventHandler(this.btnDeleteToken_Click);
            // 
            // imgs_Token
            // 
            this.imgs_Token.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_Token.ImageStream")));
            this.imgs_Token.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs_Token.Images.SetKeyName(0, "delete_ico.png");
            // 
            // frmToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(394, 200);
            this.Controls.Add(this.btnDeleteToken);
            this.Controls.Add(this.ckbxAutoNameToken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbxNameToken);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmToken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GGDrive Tool";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOKFine;
        private System.Windows.Forms.ComboBox cbxNameToken;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbxAutoNameToken;
        private System.Windows.Forms.Button btnDeleteToken;
        private System.Windows.Forms.ImageList imgs_Token;
    }
}