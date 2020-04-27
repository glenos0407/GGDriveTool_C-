using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGDriveTool
{
    public partial class frmWaiting : Form
    {
        public frmWaiting()
        {
            InitializeComponent();

            this.Height = 60;
            this.Width = 180;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;

            timerWaiting.Start();
        }

        private void timerWaiting_Tick(object sender, EventArgs e)
        {
            if (processBarWaiting.Value == 100)
            {
                processBarWaiting.Value = 20;
            }

            processBarWaiting.Value += 10;
        }
    }
}
