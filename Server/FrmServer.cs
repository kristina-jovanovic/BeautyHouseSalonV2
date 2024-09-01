using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
		private readonly Controller controller;
		private Server server;
        public FrmServer(Controller controller)
        {
			this.controller = controller;
            InitializeComponent();
		}

        private void BtnStart_Click(object sender, EventArgs e)
        {
            server = new Server(controller);
            server.Start();
            lblPoruka.Text = "Server je pokrenut!";
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            lblPoruka.Text = "Server nije pokrenut!";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Stop();
            Environment.Exit(0);
        }
    }
}
