using System.Windows.Forms;

namespace Client.UserControls.UCProfilRadnika
{
    partial class UCKreirajProfilRadnika
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKreirajProfilRadnika));
			groupBox1 = new GroupBox();
			txtOpis = new RichTextBox();
			lblErrorFoto = new Label();
			lblErrorOpis = new Label();
			lblErrorPrezime = new Label();
			lblErrorTipUsluge = new Label();
			lblErrorIme = new Label();
			btnSacuvaj = new Button();
			cbTipUsluge = new ComboBox();
			txtFoto = new TextBox();
			txtPrezime = new TextBox();
			txtIme = new TextBox();
			label4 = new Label();
			label1 = new Label();
			label5 = new Label();
			label3 = new Label();
			label2 = new Label();
			openFileDialog1 = new OpenFileDialog();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.None;
			groupBox1.BackColor = System.Drawing.Color.Pink;
			groupBox1.Controls.Add(txtOpis);
			groupBox1.Controls.Add(lblErrorFoto);
			groupBox1.Controls.Add(lblErrorOpis);
			groupBox1.Controls.Add(lblErrorPrezime);
			groupBox1.Controls.Add(lblErrorTipUsluge);
			groupBox1.Controls.Add(lblErrorIme);
			groupBox1.Controls.Add(btnSacuvaj);
			groupBox1.Controls.Add(cbTipUsluge);
			groupBox1.Controls.Add(txtFoto);
			groupBox1.Controls.Add(txtPrezime);
			groupBox1.Controls.Add(txtIme);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			groupBox1.Location = new System.Drawing.Point(209, 132);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(662, 597);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Profil radnika";
			// 
			// txtOpis
			// 
			txtOpis.Anchor = AnchorStyles.None;
			txtOpis.BackColor = System.Drawing.Color.LavenderBlush;
			txtOpis.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtOpis.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtOpis.Location = new System.Drawing.Point(216, 271);
			txtOpis.Margin = new Padding(4, 3, 4, 3);
			txtOpis.Name = "txtOpis";
			txtOpis.Size = new System.Drawing.Size(325, 130);
			txtOpis.TabIndex = 9;
			txtOpis.Text = "";
			// 
			// lblErrorFoto
			// 
			lblErrorFoto.Anchor = AnchorStyles.None;
			lblErrorFoto.AutoSize = true;
			lblErrorFoto.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorFoto.ForeColor = System.Drawing.Color.Red;
			lblErrorFoto.Location = new System.Drawing.Point(216, 494);
			lblErrorFoto.Margin = new Padding(4, 0, 4, 0);
			lblErrorFoto.Name = "lblErrorFoto";
			lblErrorFoto.Size = new System.Drawing.Size(41, 17);
			lblErrorFoto.TabIndex = 6;
			lblErrorFoto.Text = "label6";
			lblErrorFoto.Visible = false;
			// 
			// lblErrorOpis
			// 
			lblErrorOpis.Anchor = AnchorStyles.None;
			lblErrorOpis.AutoSize = true;
			lblErrorOpis.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorOpis.ForeColor = System.Drawing.Color.Red;
			lblErrorOpis.Location = new System.Drawing.Point(216, 405);
			lblErrorOpis.Margin = new Padding(4, 0, 4, 0);
			lblErrorOpis.Name = "lblErrorOpis";
			lblErrorOpis.Size = new System.Drawing.Size(41, 17);
			lblErrorOpis.TabIndex = 6;
			lblErrorOpis.Text = "label6";
			lblErrorOpis.Visible = false;
			// 
			// lblErrorPrezime
			// 
			lblErrorPrezime.Anchor = AnchorStyles.None;
			lblErrorPrezime.AutoSize = true;
			lblErrorPrezime.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorPrezime.ForeColor = System.Drawing.Color.Red;
			lblErrorPrezime.Location = new System.Drawing.Point(216, 159);
			lblErrorPrezime.Margin = new Padding(4, 0, 4, 0);
			lblErrorPrezime.Name = "lblErrorPrezime";
			lblErrorPrezime.Size = new System.Drawing.Size(41, 17);
			lblErrorPrezime.TabIndex = 6;
			lblErrorPrezime.Text = "label6";
			lblErrorPrezime.Visible = false;
			// 
			// lblErrorTipUsluge
			// 
			lblErrorTipUsluge.Anchor = AnchorStyles.None;
			lblErrorTipUsluge.AutoSize = true;
			lblErrorTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorTipUsluge.ForeColor = System.Drawing.Color.Red;
			lblErrorTipUsluge.Location = new System.Drawing.Point(216, 235);
			lblErrorTipUsluge.Margin = new Padding(4, 0, 4, 0);
			lblErrorTipUsluge.Name = "lblErrorTipUsluge";
			lblErrorTipUsluge.Size = new System.Drawing.Size(41, 17);
			lblErrorTipUsluge.TabIndex = 6;
			lblErrorTipUsluge.Text = "label6";
			lblErrorTipUsluge.Visible = false;
			// 
			// lblErrorIme
			// 
			lblErrorIme.Anchor = AnchorStyles.None;
			lblErrorIme.AutoSize = true;
			lblErrorIme.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorIme.ForeColor = System.Drawing.Color.Red;
			lblErrorIme.Location = new System.Drawing.Point(216, 83);
			lblErrorIme.Margin = new Padding(4, 0, 4, 0);
			lblErrorIme.Name = "lblErrorIme";
			lblErrorIme.Size = new System.Drawing.Size(41, 17);
			lblErrorIme.TabIndex = 6;
			lblErrorIme.Text = "label6";
			lblErrorIme.Visible = false;
			// 
			// btnSacuvaj
			// 
			btnSacuvaj.Anchor = AnchorStyles.None;
			btnSacuvaj.BackColor = System.Drawing.Color.LavenderBlush;
			btnSacuvaj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnSacuvaj.Location = new System.Drawing.Point(373, 524);
			btnSacuvaj.Margin = new Padding(4, 3, 4, 3);
			btnSacuvaj.Name = "btnSacuvaj";
			btnSacuvaj.Size = new System.Drawing.Size(170, 53);
			btnSacuvaj.TabIndex = 5;
			btnSacuvaj.Text = "Sačuvaj";
			btnSacuvaj.UseVisualStyleBackColor = false;
			// 
			// cbTipUsluge
			// 
			cbTipUsluge.Anchor = AnchorStyles.None;
			cbTipUsluge.BackColor = System.Drawing.Color.LavenderBlush;
			cbTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbTipUsluge.ForeColor = System.Drawing.Color.DarkSlateBlue;
			cbTipUsluge.FormattingEnabled = true;
			cbTipUsluge.Location = new System.Drawing.Point(216, 196);
			cbTipUsluge.Margin = new Padding(4, 3, 4, 3);
			cbTipUsluge.Name = "cbTipUsluge";
			cbTipUsluge.Size = new System.Drawing.Size(327, 31);
			cbTipUsluge.TabIndex = 4;
			// 
			// txtFoto
			// 
			txtFoto.Anchor = AnchorStyles.None;
			txtFoto.BackColor = System.Drawing.Color.LavenderBlush;
			txtFoto.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtFoto.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtFoto.Location = new System.Drawing.Point(216, 456);
			txtFoto.Margin = new Padding(4, 3, 4, 3);
			txtFoto.Name = "txtFoto";
			txtFoto.Size = new System.Drawing.Size(327, 30);
			txtFoto.TabIndex = 2;
			// 
			// txtPrezime
			// 
			txtPrezime.Anchor = AnchorStyles.None;
			txtPrezime.BackColor = System.Drawing.Color.LavenderBlush;
			txtPrezime.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPrezime.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtPrezime.Location = new System.Drawing.Point(216, 121);
			txtPrezime.Margin = new Padding(4, 3, 4, 3);
			txtPrezime.Name = "txtPrezime";
			txtPrezime.Size = new System.Drawing.Size(327, 30);
			txtPrezime.TabIndex = 2;
			// 
			// txtIme
			// 
			txtIme.Anchor = AnchorStyles.None;
			txtIme.BackColor = System.Drawing.Color.LavenderBlush;
			txtIme.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtIme.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtIme.Location = new System.Drawing.Point(216, 45);
			txtIme.Margin = new Padding(4, 3, 4, 3);
			txtIme.Name = "txtIme";
			txtIme.Size = new System.Drawing.Size(327, 30);
			txtIme.TabIndex = 1;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label4.Location = new System.Drawing.Point(68, 200);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(94, 23);
			label4.TabIndex = 0;
			label4.Text = "Tip usluge:";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label1.Location = new System.Drawing.Point(68, 48);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(46, 23);
			label1.TabIndex = 0;
			label1.Text = "Ime: ";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label5.Location = new System.Drawing.Point(68, 456);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(96, 23);
			label5.TabIndex = 0;
			label5.Text = "Fotografija:";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label3.Location = new System.Drawing.Point(71, 268);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(50, 23);
			label3.TabIndex = 0;
			label3.Text = "Opis:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label2.Location = new System.Drawing.Point(68, 121);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(75, 23);
			label2.TabIndex = 0;
			label2.Text = "Prezime:";
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// UCKreirajProfilRadnika
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			Controls.Add(groupBox1);
			Margin = new Padding(4, 3, 4, 3);
			Name = "UCKreirajProfilRadnika";
			Size = new System.Drawing.Size(1092, 752);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblErrorOpis;
        private System.Windows.Forms.Label lblErrorPrezime;
        private System.Windows.Forms.Label lblErrorTipUsluge;
        private System.Windows.Forms.Label lblErrorIme;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbTipUsluge;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private TextBox txtFoto;
        private Label lblErrorFoto;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Label LblErrorOpis { get => lblErrorOpis; set => lblErrorOpis = value; }
        public Label LblErrorPrezime { get => lblErrorPrezime; set => lblErrorPrezime = value; }
        public Label LblErrorTipUsluge { get => lblErrorTipUsluge; set => lblErrorTipUsluge = value; }
        public Label LblErrorIme { get => lblErrorIme; set => lblErrorIme = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public ComboBox CbTipUsluge { get => cbTipUsluge; set => cbTipUsluge = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public RichTextBox TxtOpis { get => txtOpis; set => txtOpis = value; }
        public OpenFileDialog OpenFileDialog1 { get => openFileDialog1; set => openFileDialog1 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtFoto { get => txtFoto; set => txtFoto = value; }
        public Label LblErrorFoto { get => lblErrorFoto; set => lblErrorFoto = value; }
    }
}
