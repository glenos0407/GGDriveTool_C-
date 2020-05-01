using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGDriveTool
{
    public partial class frmControlDownload : Form
    {
        string IdFile;
        string name_token;
        frmWaiting frmWait;

        public frmControlDownload(string idFile, string nameToken)
        {
            InitializeComponent();
            name_token = nameToken;
            IdFile = idFile;
            setPathSave();
        }

        private void setPathSave()
        {
            api.GoogleDriveAPI gg_api = new api.GoogleDriveAPI();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName += gg_api.getFileName_ID(IdFile, name_token);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathDownload.Text = saveFileDialog.FileName;
            }
        }

        private void btnChangePath_Click(object sender, EventArgs e)
        {
            setPathSave();
        }

        private string getPathSave(string path)
        {
            string[] arrListStr = path.Split('\\');
            string temp = "";

            for (int i = 0; i < arrListStr.Length -1; i++)
            {
                temp += arrListStr[i] + "\\";
            }

            return temp;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Open_WaitingFrm()
        {
            frmWait = new frmWaiting();
            frmWait.ShowDialog();
        }

        private int download_File()
        {
            api.GoogleDriveAPI gg_api = new api.GoogleDriveAPI();
            return gg_api.DownloadGoogleFile(IdFile, getPathSave(txtPathDownload.Text), name_token);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Thread thread_lazy = new Thread(new ThreadStart(Open_WaitingFrm));
            thread_lazy.Start();

            int result = download_File();

            frmWait.Invoke(new MethodInvoker(delegate ()
            {
                frmWait.Close();
            }));

            if (result == 1)
            {
                MessageBox.Show("DOWNLOAD THÀNH CÔNG","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("DOWNLOAD FAILED", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                if(dr == DialogResult.Retry)
                {
                    btnSave_Click(sender, e);
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
