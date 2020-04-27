namespace GGDriveTool
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lbTitleBar = new System.Windows.Forms.Label();
            this.btnMinized = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.trvFolder = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileID_Delete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileID_Down = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPathUpload = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imgs_TreeView = new System.Windows.Forms.ImageList(this.components);
            this.txtSearchFileorFolder = new System.Windows.Forms.TextBox();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btnUploadPro = new System.Windows.Forms.Button();
            this.pnlTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlTitleBar.Controls.Add(this.lbTitleBar);
            this.pnlTitleBar.Controls.Add(this.btnMinized);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(846, 34);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lbTitleBar
            // 
            this.lbTitleBar.AutoSize = true;
            this.lbTitleBar.ForeColor = System.Drawing.Color.White;
            this.lbTitleBar.Location = new System.Drawing.Point(12, 11);
            this.lbTitleBar.Name = "lbTitleBar";
            this.lbTitleBar.Size = new System.Drawing.Size(95, 15);
            this.lbTitleBar.TabIndex = 2;
            this.lbTitleBar.Text = "GGDrive Tool 1.0";
            // 
            // btnMinized
            // 
            this.btnMinized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinized.FlatAppearance.BorderSize = 0;
            this.btnMinized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinized.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinized.ForeColor = System.Drawing.Color.White;
            this.btnMinized.ImageIndex = 5;
            this.btnMinized.ImageList = this.imgs_TreeView;
            this.btnMinized.Location = new System.Drawing.Point(756, 0);
            this.btnMinized.Name = "btnMinized";
            this.btnMinized.Size = new System.Drawing.Size(45, 34);
            this.btnMinized.TabIndex = 1;
            this.btnMinized.UseVisualStyleBackColor = false;
            this.btnMinized.Click += new System.EventHandler(this.btnMinized_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageList = this.imgs_TreeView;
            this.btnExit.Location = new System.Drawing.Point(801, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.btnRefesh);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchFileorFolder);
            this.panel1.Controls.Add(this.btnChangeUser);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 23);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageIndex = 3;
            this.btnSearch.ImageList = this.imgs_TreeView;
            this.btnSearch.Location = new System.Drawing.Point(211, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.BackColor = System.Drawing.Color.Teal;
            this.btnChangeUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangeUser.FlatAppearance.BorderSize = 0;
            this.btnChangeUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnChangeUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeUser.ForeColor = System.Drawing.Color.White;
            this.btnChangeUser.Location = new System.Drawing.Point(772, 0);
            this.btnChangeUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(74, 23);
            this.btnChangeUser.TabIndex = 8;
            this.btnChangeUser.Text = "Change";
            this.btnChangeUser.UseVisualStyleBackColor = false;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(560, 1);
            this.txtUser.Margin = new System.Windows.Forms.Padding(0);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(212, 23);
            this.txtUser.TabIndex = 7;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trvFolder
            // 
            this.trvFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.trvFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvFolder.ForeColor = System.Drawing.Color.White;
            this.trvFolder.Location = new System.Drawing.Point(0, 57);
            this.trvFolder.Name = "trvFolder";
            this.trvFolder.Size = new System.Drawing.Size(296, 418);
            this.trvFolder.TabIndex = 3;
            this.trvFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvFolder_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(296, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 418);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 104);
            this.panel3.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.txtFileID_Delete);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 104);
            this.panel7.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(414, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "File ID";
            // 
            // txtFileID_Delete
            // 
            this.txtFileID_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileID_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtFileID_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileID_Delete.ForeColor = System.Drawing.Color.White;
            this.txtFileID_Delete.Location = new System.Drawing.Point(94, 37);
            this.txtFileID_Delete.Name = "txtFileID_Delete";
            this.txtFileID_Delete.Size = new System.Drawing.Size(439, 23);
            this.txtFileID_Delete.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Xóa File";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel6.Controls.Add(this.btnSetting);
            this.panel6.Controls.Add(this.btnHelp);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 375);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 41);
            this.panel6.TabIndex = 8;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 41);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Cài Đặt";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(349, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(199, 41);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Phát Triển Bởi @GlenSama";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnDownload);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtFileID_Down);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 103);
            this.panel5.TabIndex = 7;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.Teal;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(414, 66);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(119, 29);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "File ID";
            // 
            // txtFileID_Down
            // 
            this.txtFileID_Down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileID_Down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtFileID_Down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileID_Down.ForeColor = System.Drawing.Color.White;
            this.txtFileID_Down.Location = new System.Drawing.Point(94, 37);
            this.txtFileID_Down.Name = "txtFileID_Down";
            this.txtFileID_Down.Size = new System.Drawing.Size(439, 23);
            this.txtFileID_Down.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tải Xuống";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel4.Controls.Add(this.btnUploadPro);
            this.panel4.Controls.Add(this.txtPathUpload);
            this.panel4.Controls.Add(this.btnUpload);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnChoseFile);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 110);
            this.panel4.TabIndex = 6;
            // 
            // txtPathUpload
            // 
            this.txtPathUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtPathUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathUpload.ForeColor = System.Drawing.Color.White;
            this.txtPathUpload.Location = new System.Drawing.Point(95, 43);
            this.txtPathUpload.Margin = new System.Windows.Forms.Padding(0);
            this.txtPathUpload.Name = "txtPathUpload";
            this.txtPathUpload.Size = new System.Drawing.Size(400, 23);
            this.txtPathUpload.TabIndex = 2;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.Color.Teal;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(415, 75);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(119, 29);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload Nhanh";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload File";
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChoseFile.FlatAppearance.BorderSize = 0;
            this.btnChoseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoseFile.Location = new System.Drawing.Point(495, 43);
            this.btnChoseFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(39, 23);
            this.btnChoseFile.TabIndex = 4;
            this.btnChoseFile.Text = "...";
            this.btnChoseFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChoseFile.UseVisualStyleBackColor = false;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đường Dẫn";
            // 
            // imgs_TreeView
            // 
            this.imgs_TreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_TreeView.ImageStream")));
            this.imgs_TreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs_TreeView.Images.SetKeyName(0, "file_ico.png");
            this.imgs_TreeView.Images.SetKeyName(1, "folder_ico.png");
            this.imgs_TreeView.Images.SetKeyName(2, "drive_ico.png");
            this.imgs_TreeView.Images.SetKeyName(3, "search_ico.png");
            this.imgs_TreeView.Images.SetKeyName(4, "reload_ico.png");
            this.imgs_TreeView.Images.SetKeyName(5, "minus_ico.png");
            this.imgs_TreeView.Images.SetKeyName(6, "X_ico.png");
            // 
            // txtSearchFileorFolder
            // 
            this.txtSearchFileorFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtSearchFileorFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchFileorFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearchFileorFolder.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFileorFolder.Location = new System.Drawing.Point(0, 0);
            this.txtSearchFileorFolder.Name = "txtSearchFileorFolder";
            this.txtSearchFileorFolder.Size = new System.Drawing.Size(211, 23);
            this.txtSearchFileorFolder.TabIndex = 9;
            this.txtSearchFileorFolder.Text = "Nhập Tên File";
            this.txtSearchFileorFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchFileorFolder.Enter += new System.EventHandler(this.txtSearchFileorFolder_Enter);
            this.txtSearchFileorFolder.Leave += new System.EventHandler(this.txtSearchFileorFolder_Leave);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRefesh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.ImageIndex = 4;
            this.btnRefesh.ImageList = this.imgs_TreeView;
            this.btnRefesh.Location = new System.Drawing.Point(255, 0);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(41, 23);
            this.btnRefesh.TabIndex = 10;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnCapNhatDrive_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserName.AutoSize = true;
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(490, 4);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(70, 15);
            this.lbUserName.TabIndex = 6;
            this.lbUserName.Text = "User Name";
            // 
            // btnUploadPro
            // 
            this.btnUploadPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUploadPro.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadPro.FlatAppearance.BorderSize = 0;
            this.btnUploadPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUploadPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadPro.Location = new System.Drawing.Point(275, 75);
            this.btnUploadPro.Margin = new System.Windows.Forms.Padding(0);
            this.btnUploadPro.Name = "btnUploadPro";
            this.btnUploadPro.Size = new System.Drawing.Size(140, 29);
            this.btnUploadPro.TabIndex = 6;
            this.btnUploadPro.Text = "Upload Nâng Cao";
            this.btnUploadPro.UseVisualStyleBackColor = false;
            this.btnUploadPro.Click += new System.EventHandler(this.btnUploadPro_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.trvFolder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "GGDrive Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinized;
        private System.Windows.Forms.Label lbTitleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvFolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChangeUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathUpload;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileID_Down;
        private System.Windows.Forms.ImageList imgs_TreeView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileID_Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchFileorFolder;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btnUploadPro;
    }
}