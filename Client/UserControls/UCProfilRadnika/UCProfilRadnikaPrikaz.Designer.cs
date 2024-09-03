using System.Windows.Forms;

namespace Client.UserControls.UCProfilRadnika
{
    partial class UCProfilRadnikaPrikaz
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProfilRadnikaPrikaz));
			groupBox1 = new GroupBox();
			btnZakazi = new Button();
			txtOpis = new RichTextBox();
			lblTipUsluge = new Label();
			lblImePrezime = new Label();
			pbFoto = new PictureBox();
			btnNazad = new Button();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.None;
			groupBox1.BackColor = System.Drawing.Color.Pink;
			groupBox1.Controls.Add(btnZakazi);
			groupBox1.Controls.Add(txtOpis);
			groupBox1.Controls.Add(lblTipUsluge);
			groupBox1.Controls.Add(lblImePrezime);
			groupBox1.Controls.Add(pbFoto);
			groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			groupBox1.Location = new System.Drawing.Point(167, 129);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(724, 501);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Profil radnika";
			// 
			// btnZakazi
			// 
			btnZakazi.Anchor = AnchorStyles.None;
			btnZakazi.BackColor = System.Drawing.Color.LavenderBlush;
			btnZakazi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnZakazi.Location = new System.Drawing.Point(547, 441);
			btnZakazi.Margin = new Padding(4, 3, 4, 3);
			btnZakazi.Name = "btnZakazi";
			btnZakazi.Size = new System.Drawing.Size(170, 53);
			btnZakazi.TabIndex = 11;
			btnZakazi.Text = "Zakaži termin";
			btnZakazi.UseVisualStyleBackColor = false;
			btnZakazi.Visible = false;
			// 
			// txtOpis
			// 
			txtOpis.Anchor = AnchorStyles.None;
			txtOpis.BackColor = System.Drawing.Color.Pink;
			txtOpis.BorderStyle = BorderStyle.None;
			txtOpis.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtOpis.Location = new System.Drawing.Point(20, 285);
			txtOpis.Margin = new Padding(4, 3, 4, 3);
			txtOpis.Name = "txtOpis";
			txtOpis.ReadOnly = true;
			txtOpis.Size = new System.Drawing.Size(698, 209);
			txtOpis.TabIndex = 3;
			txtOpis.Text = "Opis";
			// 
			// lblTipUsluge
			// 
			lblTipUsluge.Anchor = AnchorStyles.None;
			lblTipUsluge.AutoSize = true;
			lblTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblTipUsluge.Location = new System.Drawing.Point(335, 189);
			lblTipUsluge.Margin = new Padding(4, 0, 4, 0);
			lblTipUsluge.Name = "lblTipUsluge";
			lblTipUsluge.Size = new System.Drawing.Size(94, 23);
			lblTipUsluge.TabIndex = 2;
			lblTipUsluge.Text = "Tip usluge:";
			// 
			// lblImePrezime
			// 
			lblImePrezime.Anchor = AnchorStyles.None;
			lblImePrezime.AutoSize = true;
			lblImePrezime.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			lblImePrezime.Location = new System.Drawing.Point(329, 85);
			lblImePrezime.Margin = new Padding(4, 0, 4, 0);
			lblImePrezime.Name = "lblImePrezime";
			lblImePrezime.Size = new System.Drawing.Size(107, 44);
			lblImePrezime.TabIndex = 1;
			lblImePrezime.Text = "label1";
			// 
			// pbFoto
			// 
			pbFoto.Anchor = AnchorStyles.None;
			pbFoto.Location = new System.Drawing.Point(20, 33);
			pbFoto.Margin = new Padding(4, 3, 4, 3);
			pbFoto.Name = "pbFoto";
			pbFoto.Size = new System.Drawing.Size(290, 223);
			pbFoto.TabIndex = 0;
			pbFoto.TabStop = false;
			// 
			// btnNazad
			// 
			btnNazad.Anchor = AnchorStyles.None;
			btnNazad.BackColor = System.Drawing.Color.LavenderBlush;
			btnNazad.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnNazad.Location = new System.Drawing.Point(187, 637);
			btnNazad.Margin = new Padding(4, 3, 4, 3);
			btnNazad.Name = "btnNazad";
			btnNazad.Size = new System.Drawing.Size(170, 53);
			btnNazad.TabIndex = 10;
			btnNazad.Text = "Nazad";
			btnNazad.UseVisualStyleBackColor = false;
			// 
			// UCProfilRadnikaPrikaz
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			Controls.Add(btnNazad);
			Controls.Add(groupBox1);
			DoubleBuffered = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "UCProfilRadnikaPrikaz";
			Size = new System.Drawing.Size(1044, 708);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Label lblTipUsluge;
        private System.Windows.Forms.Label lblImePrezime;
        private System.Windows.Forms.PictureBox pbFoto;
        private Button btnNazad;
        private Button btnZakazi;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public RichTextBox TxtOpis { get => txtOpis; set => txtOpis = value; }
        public Label LblTipUsluge { get => lblTipUsluge; set => lblTipUsluge = value; }
        public Label LblImePrezime { get => lblImePrezime; set => lblImePrezime = value; }
        public PictureBox PbFoto { get => pbFoto; set => pbFoto = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
        public Button BtnZakazi { get => btnZakazi; set => btnZakazi = value; }
    }
}
