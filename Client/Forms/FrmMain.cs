using Client.UserControls;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        private Korisnik korisnik;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }

        public void ChangePanel(Control control, bool clear = true)
        {
            if (clear)
            {
                pnlMain.Controls.Clear();
            }
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public void SetMenu(Control control)
        {
            pnlMeni.Controls.Clear();
            pnlMeni.Controls.Add(control);
            control.Dock = DockStyle.Top;
            pnlMeni.AutoSize = true;
        }
    }
}
