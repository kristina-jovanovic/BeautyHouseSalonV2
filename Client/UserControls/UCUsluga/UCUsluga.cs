using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
	public partial class UCUsluga : UserControl
	{
		public UCMode mode;

		public UCUsluga(UCMode mode)
		{
			InitializeComponent();
			this.mode = mode;
			PrepareUC();
		}

		private void PrepareUC()
		{
			switch (mode)
			{
				case UCMode.DodajNovi:
					break;
				case UCMode.Prikazi:
					txtNaziv.Enabled = false;
					txtCena.Enabled = false;
					txtTrajanje.Enabled = false;
					cbTipUsluge.Enabled = false;
					txtFotoUsluge.Enabled = false;
					btnObrisi.Visible = true;
					btnIzmeni.Visible = true;
					btnNazad.Visible = true;
					break;
			}
		}
	}
}
