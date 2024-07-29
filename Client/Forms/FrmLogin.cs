using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void ChangePanel(Control control)
        {
            pnlLogin.Controls.Clear();
            pnlLogin.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlLogin.AutoSize = true;
            pnlLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
