using System.Windows.Forms;

namespace Client
{
    partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			pnlMain = new Panel();
			pnlMeni = new Panel();
			SuspendLayout();
			// 
			// pnlMain
			// 
			pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			pnlMain.BackgroundImage = (System.Drawing.Image)resources.GetObject("pnlMain.BackgroundImage");
			pnlMain.BackgroundImageLayout = ImageLayout.Stretch;
			pnlMain.Dock = DockStyle.Fill;
			pnlMain.Location = new System.Drawing.Point(0, 0);
			pnlMain.Margin = new Padding(4, 3, 4, 3);
			pnlMain.Name = "pnlMain";
			pnlMain.Size = new System.Drawing.Size(1076, 910);
			pnlMain.TabIndex = 0;
			// 
			// pnlMeni
			// 
			pnlMeni.Dock = DockStyle.Top;
			pnlMeni.Location = new System.Drawing.Point(0, 0);
			pnlMeni.Margin = new Padding(4, 3, 4, 3);
			pnlMeni.Name = "pnlMeni";
			pnlMeni.Size = new System.Drawing.Size(1076, 62);
			pnlMeni.TabIndex = 1;
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1076, 910);
			Controls.Add(pnlMeni);
			Controls.Add(pnlMain);
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximumSize = new System.Drawing.Size(1092, 957);
			MinimumSize = new System.Drawing.Size(1092, 949);
			Name = "FrmMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "BeautyHouse";
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Panel pnlMain;
        private Panel pnlMeni;

        public Panel PnlMain { get => pnlMain; set => pnlMain = value; }
        public Panel PnlMeni { get => pnlMeni; set => pnlMeni = value; }
    }
}

