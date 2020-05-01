using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGDriveTool
{
    public partial class frmMain : Form
    {
        string name_token;
        frmWaiting frmWait;

        public frmMain(string version, string NameToken)
        {
            InitializeComponent();
            this.Text += " " + version;
            name_token = NameToken;

            Design_frmMain();
            Design_pnlTitleBar();
        }

        private void Design_frmMain()
        {
            this.Width = 800;
            this.Height = 460;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Design_pnlTitleBar()
        {
            this.pnlTitleBar.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lbTitleBar.Text = this.Text;
            trvFolder.ImageList = imgs_TreeView;
            trvFolder.ImageIndex = 0;
        }


        private void load_folders()
        {
            api.GoogleDriveAPI gg_api = new api.GoogleDriveAPI();
            string mindType_GetAllFolders = "mimeType = 'application/vnd.google-apps.folder'";
            IList<Google.Apis.Drive.v3.Data.File> folders = gg_api.Search_Somethings(name_token, mindType_GetAllFolders);

            TreeNode rootFolder = new TreeNode("Tất Cả Thư Mục");
            rootFolder.NodeFont = new Font(new FontFamily("Consolas"), 10f, FontStyle.Bold);

            if (folders != null && folders.Count > 0)
            {
                foreach (var folder in folders)
                {
                    TreeNode tn = new TreeNode(folder.Name);
                    tn.Tag = folder.Id;
                    rootFolder.Nodes.Add(tn);
                }
            }

            trvFolder.Nodes.Add(rootFolder);
        }

        private void load_files()
        {
            api.GoogleDriveAPI gg_api = new api.GoogleDriveAPI();
            string mindType_GetAllFiles = "mimeType != 'application/vnd.google-apps.folder'";
            IList<Google.Apis.Drive.v3.Data.File> files = gg_api.Search_Somethings(name_token, mindType_GetAllFiles);

            TreeNode rootFile = new TreeNode("Tất Cả File");
            rootFile.NodeFont = new Font(new FontFamily("Consolas"), 10f, FontStyle.Bold);

            if (files != null && files.Count > 0)
            {
                foreach (var folder in files)
                {
                    TreeNode tn = new TreeNode(folder.Name);
                    tn.Tag = folder.Id;
                    rootFile.Nodes.Add(tn);
                }
            }

            trvFolder.Invoke(new MethodInvoker(delegate ()
            {
                trvFolder.Nodes.Add(rootFile);
                trvFolder.ExpandAll();
            }));
        }


        private void load_TreeView()
        {
            trvFolder.Invoke(new MethodInvoker(delegate ()
            {

                trvFolder.Nodes.Clear();

                load_folders();

                Thread th = new Thread(new ThreadStart(load_files));
                th.Start();

                trvFolder.ExpandAll();

            }));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathUpload.Text = fileDialog.FileName;
            }
        }

        private string Get_FileName_FromPath(string Path)
        {
            string[] arrListStr = txtPathUpload.Text.Split('\\');
            return arrListStr[arrListStr.Length - 1];
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (txtPathUpload.Text.Trim().Equals(""))
            {
                MessageBox.Show("BẠN CHƯA CHỌN FILE", "FILE NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string File_Name = Get_FileName_FromPath(txtPathUpload.Text);

            DialogResult dr = MessageBox.Show("BẠN CÓ MUỐN UPDATE VỚI TÊN: " + File_Name, "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.No)
            { return; }

            api.GoogleDriveAPI gg_api = new api.GoogleDriveAPI();

            Thread thread_lazy = new Thread(new ThreadStart(Open_WaitingFrm));
            thread_lazy.Start();

            gg_api.Upload_to_Root(File_Name, txtPathUpload.Text, name_token);

            load_TreeView();

            frmWait.Invoke(new MethodInvoker(delegate ()
            {
                frmWait.Close();
            }));

            MessageBox.Show("UPLOAD THÀNH CÔNG", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Open_WaitingFrm()
        {
            frmWait = new frmWaiting();
            frmWait.ShowDialog();
        }

        private void trvFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvFolder.SelectedNode.Level > 0)
            {
                try
                {
                    api.GoogleDriveAPI gg_api = new api.GoogleDriveAPI();
                    string mindType_Q = "'" + trvFolder.SelectedNode.Tag + "'" + " in parents";

                    txtFileID_Down.Text = trvFolder.SelectedNode.Tag.ToString();
                    txtFileID_Delete.Text = trvFolder.SelectedNode.Tag.ToString();

                    IList<Google.Apis.Drive.v3.Data.File> contents = gg_api.Search_Somethings(name_token, mindType_Q);

                    trvFolder.SelectedNode.Nodes.Clear();

                    if (contents != null && contents.Count > 0)
                    {
                        foreach (var content in contents)
                        {
                            TreeNode tn = new TreeNode(content.Name);
                            tn.Tag = content.Id;

                            trvFolder.SelectedNode.Nodes.Add(tn);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("File Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                trvFolder.ExpandAll();
            }
        }

        private void btnCapNhatDrive_Click(object sender, EventArgs e)
        {
            lazy_loading();
        }

        private void lazy_loading()
        {
            Thread thread_lazy = new Thread(new ThreadStart(Open_WaitingFrm));
            thread_lazy.Start();

            Thread thread_load = new Thread(() =>
            {
                Action action = () =>
                {
                    load_TreeView();
                    Thread.Sleep(1000);
                    frmWait.Invoke(new MethodInvoker(delegate ()
                    {
                        frmWait.Close();
                    }));
                };
                BeginInvoke(action);
            });

            thread_load.Start();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            lazy_loading();
            txtUser.Text = name_token;
        }

        //Click Vao O Tim Kiem
        //Set isSearch = true
        private void txtSearchFileorFolder_Enter(object sender, EventArgs e)
        {
            if (txtSearchFileorFolder.Text == "Nhập Tên File")
            {
                txtSearchFileorFolder.Clear();
                txtSearchFileorFolder.ForeColor = Color.White;

                return;
            }
        }

        //Leave O Tim Kiem
        //Set isSearch = true
        private void txtSearchFileorFolder_Leave(object sender, EventArgs e)
        {
            if (txtSearchFileorFolder.Text.Trim() == "")
            {
                txtSearchFileorFolder.Text = "Nhập Tên File";
                txtSearchFileorFolder.ForeColor = Color.Gray;

                return;
            }
        }

        private void load_search_treeView(string tenFileCanTim)
        {
            string mindTypeQ = "name contains " + "'" + tenFileCanTim + "'";
            TreeNode root;

            try
            {
                api.GoogleDriveAPI gg_api = new api.GoogleDriveAPI();
                IList<Google.Apis.Drive.v3.Data.File> contents = gg_api.Search_Somethings(name_token, mindTypeQ);

                trvFolder.Nodes.Clear();

                root = new TreeNode("Kết Quả Cho \"" + tenFileCanTim + "\"");

                if (contents != null && contents.Count > 0)
                {
                    foreach (var content in contents)
                    {
                        TreeNode tn = new TreeNode(content.Name);
                        tn.Tag = content.Id;

                        root.Nodes.Add(tn);
                    }
                }
            }
            catch
            {
                MessageBox.Show("File Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            trvFolder.Nodes.Add(root);
            trvFolder.ExpandAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Thread thread_lazy = new Thread(new ThreadStart(Open_WaitingFrm));
            thread_lazy.Start();

            Thread thread_load = new Thread(() =>
            {
                Action action = () =>
                {
                    load_search_treeView(txtSearchFileorFolder.Text);
                    Thread.Sleep(1000);
                    frmWait.Invoke(new MethodInvoker(delegate ()
                    {
                        frmWait.Close();
                    }));
                };
                BeginInvoke(action);
            });

            thread_load.Start();
        }

        private void btnUploadPro_Click(object sender, EventArgs e)
        {
            frmUploadPro fUploadPro = new frmUploadPro();
            fUploadPro.ShowDialog();
        }


        private void open_frmToken()
        {
            Application.Run(new frmToken("1.0"));
        }


        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (trvFolder.SelectedNode.Level > 0)
                {
                    frmControlDownload fcdown = new frmControlDownload(txtFileID_Down.Text.Trim(), name_token);
                    fcdown.ShowDialog();
                }
                else
                {
                    MessageBox.Show("NHẬP ID ĐỂ TẢI", "NULL ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("NHẬP ID ĐỂ TẢI", "NULL ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
