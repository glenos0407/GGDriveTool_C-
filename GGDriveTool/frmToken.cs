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
    public partial class frmToken : Form
    {
        string Version;
        string nameToken;

        public frmToken(string version)
        {
            InitializeComponent();
            Version = version;
            this.Text = "GGDrive Tool " + version;
            lbHeader.Text = this.Text;
        }

        private void open_Main()
        {
            Application.Run(new frmMain(Version, nameToken));
        }

        private void btnOKFine_Click(object sender, EventArgs e)
        {
            if(cbxNameToken.Text.Trim() == "") {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN SỬ DỤNG DRIVE", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; }

            nameToken = cbxNameToken.Text.Trim();

            Thread th = new Thread(open_Main);
            th.Start();

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDeleteToken_Click(object sender, EventArgs e)
        {
            if (cbxNameToken.Text.Trim() == "")
            {
                return;
            }

            DialogResult dr = MessageBox.Show("BẠN CÓ CHẮC MUỐN XÓA: " + cbxNameToken.Text + " ?", "Xóa Token", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {

            }
            else
            {
                return;
            }
        }

        private void cbxNameToken_Enter(object sender, EventArgs e)
        {
            btnDeleteToken.Enabled = true;
        }

        private void cbxNameToken_Leave(object sender, EventArgs e)
        {
            if(cbxNameToken.Text.Trim() == "")
            {
                btnDeleteToken.Enabled = false;
            }
        }
    }
}
