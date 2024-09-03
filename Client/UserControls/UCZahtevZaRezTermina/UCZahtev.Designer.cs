using System.Windows.Forms;

namespace Client.UserControls.UCZahtevZaRezTermina
{
    partial class UCZahtev
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCZahtev));
			groupBox1 = new GroupBox();
			btnIzmeni = new Button();
			btnIzbaci = new Button();
			btnDodaj = new Button();
			dgvTermini = new DataGridView();
			lblErrorTipUsluge = new Label();
			cbTipUsluge = new ComboBox();
			label6 = new Label();
			lblErrorTermin = new Label();
			lblErrorRadnik = new Label();
			lblErrorUsluga = new Label();
			btnZakazi = new Button();
			txtNapomena = new RichTextBox();
			cbTermin = new ComboBox();
			cbRadnik = new ComboBox();
			cbUsluga = new ComboBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			btnNazad = new Button();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvTermini).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.None;
			groupBox1.BackColor = System.Drawing.Color.LightPink;
			groupBox1.Controls.Add(btnIzmeni);
			groupBox1.Controls.Add(btnIzbaci);
			groupBox1.Controls.Add(btnDodaj);
			groupBox1.Controls.Add(dgvTermini);
			groupBox1.Controls.Add(lblErrorTipUsluge);
			groupBox1.Controls.Add(cbTipUsluge);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(lblErrorTermin);
			groupBox1.Controls.Add(lblErrorRadnik);
			groupBox1.Controls.Add(lblErrorUsluga);
			groupBox1.Controls.Add(btnZakazi);
			groupBox1.Controls.Add(txtNapomena);
			groupBox1.Controls.Add(cbTermin);
			groupBox1.Controls.Add(cbRadnik);
			groupBox1.Controls.Add(cbUsluga);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			groupBox1.Location = new System.Drawing.Point(54, 127);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(981, 678);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Rezervacija termina";
			// 
			// btnIzmeni
			// 
			btnIzmeni.Anchor = AnchorStyles.None;
			btnIzmeni.BackColor = System.Drawing.Color.LavenderBlush;
			btnIzmeni.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnIzmeni.Location = new System.Drawing.Point(191, 618);
			btnIzmeni.Margin = new Padding(4, 3, 4, 3);
			btnIzmeni.Name = "btnIzmeni";
			btnIzmeni.Size = new System.Drawing.Size(170, 53);
			btnIzmeni.TabIndex = 12;
			btnIzmeni.Text = "Izmeni termin";
			btnIzmeni.UseVisualStyleBackColor = false;
			// 
			// btnIzbaci
			// 
			btnIzbaci.Anchor = AnchorStyles.None;
			btnIzbaci.BackColor = System.Drawing.Color.LavenderBlush;
			btnIzbaci.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnIzbaci.Location = new System.Drawing.Point(14, 618);
			btnIzbaci.Margin = new Padding(4, 3, 4, 3);
			btnIzbaci.Name = "btnIzbaci";
			btnIzbaci.Size = new System.Drawing.Size(170, 53);
			btnIzbaci.TabIndex = 11;
			btnIzbaci.Text = "Izbaci termin";
			btnIzbaci.UseVisualStyleBackColor = false;
			// 
			// btnDodaj
			// 
			btnDodaj.Anchor = AnchorStyles.None;
			btnDodaj.BackColor = System.Drawing.Color.LavenderBlush;
			btnDodaj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnDodaj.Location = new System.Drawing.Point(796, 241);
			btnDodaj.Margin = new Padding(4, 3, 4, 3);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(170, 53);
			btnDodaj.TabIndex = 10;
			btnDodaj.Text = "Dodaj termin";
			btnDodaj.UseVisualStyleBackColor = false;
			// 
			// dgvTermini
			// 
			dgvTermini.AllowUserToAddRows = false;
			dgvTermini.AllowUserToDeleteRows = false;
			dgvTermini.Anchor = AnchorStyles.None;
			dgvTermini.BackgroundColor = System.Drawing.Color.LavenderBlush;
			dgvTermini.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvTermini.Location = new System.Drawing.Point(14, 301);
			dgvTermini.Margin = new Padding(4, 3, 4, 3);
			dgvTermini.Name = "dgvTermini";
			dgvTermini.ReadOnly = true;
			dgvTermini.Size = new System.Drawing.Size(952, 310);
			dgvTermini.TabIndex = 9;
			// 
			// lblErrorTipUsluge
			// 
			lblErrorTipUsluge.Anchor = AnchorStyles.None;
			lblErrorTipUsluge.AutoSize = true;
			lblErrorTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorTipUsluge.ForeColor = System.Drawing.Color.Red;
			lblErrorTipUsluge.Location = new System.Drawing.Point(136, 96);
			lblErrorTipUsluge.Margin = new Padding(4, 0, 4, 0);
			lblErrorTipUsluge.Name = "lblErrorTipUsluge";
			lblErrorTipUsluge.Size = new System.Drawing.Size(41, 17);
			lblErrorTipUsluge.TabIndex = 8;
			lblErrorTipUsluge.Text = "label5";
			lblErrorTipUsluge.Visible = false;
			// 
			// cbTipUsluge
			// 
			cbTipUsluge.Anchor = AnchorStyles.None;
			cbTipUsluge.BackColor = System.Drawing.Color.LavenderBlush;
			cbTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbTipUsluge.ForeColor = System.Drawing.Color.DarkSlateBlue;
			cbTipUsluge.FormattingEnabled = true;
			cbTipUsluge.Location = new System.Drawing.Point(133, 57);
			cbTipUsluge.Margin = new Padding(4, 3, 4, 3);
			cbTipUsluge.Name = "cbTipUsluge";
			cbTipUsluge.Size = new System.Drawing.Size(348, 31);
			cbTipUsluge.TabIndex = 7;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label6.Location = new System.Drawing.Point(7, 57);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(94, 23);
			label6.TabIndex = 6;
			label6.Text = "Tip usluge:";
			// 
			// lblErrorTermin
			// 
			lblErrorTermin.Anchor = AnchorStyles.None;
			lblErrorTermin.AutoSize = true;
			lblErrorTermin.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorTermin.ForeColor = System.Drawing.Color.Red;
			lblErrorTermin.Location = new System.Drawing.Point(648, 96);
			lblErrorTermin.Margin = new Padding(4, 0, 4, 0);
			lblErrorTermin.Name = "lblErrorTermin";
			lblErrorTermin.Size = new System.Drawing.Size(41, 17);
			lblErrorTermin.TabIndex = 5;
			lblErrorTermin.Text = "label5";
			lblErrorTermin.Visible = false;
			// 
			// lblErrorRadnik
			// 
			lblErrorRadnik.Anchor = AnchorStyles.None;
			lblErrorRadnik.AutoSize = true;
			lblErrorRadnik.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorRadnik.ForeColor = System.Drawing.Color.Red;
			lblErrorRadnik.Location = new System.Drawing.Point(136, 232);
			lblErrorRadnik.Margin = new Padding(4, 0, 4, 0);
			lblErrorRadnik.Name = "lblErrorRadnik";
			lblErrorRadnik.Size = new System.Drawing.Size(41, 17);
			lblErrorRadnik.TabIndex = 5;
			lblErrorRadnik.Text = "label5";
			lblErrorRadnik.Visible = false;
			// 
			// lblErrorUsluga
			// 
			lblErrorUsluga.Anchor = AnchorStyles.None;
			lblErrorUsluga.AutoSize = true;
			lblErrorUsluga.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorUsluga.ForeColor = System.Drawing.Color.Red;
			lblErrorUsluga.Location = new System.Drawing.Point(136, 163);
			lblErrorUsluga.Margin = new Padding(4, 0, 4, 0);
			lblErrorUsluga.Name = "lblErrorUsluga";
			lblErrorUsluga.Size = new System.Drawing.Size(41, 17);
			lblErrorUsluga.TabIndex = 5;
			lblErrorUsluga.Text = "label5";
			lblErrorUsluga.Visible = false;
			// 
			// btnZakazi
			// 
			btnZakazi.Anchor = AnchorStyles.None;
			btnZakazi.BackColor = System.Drawing.Color.LavenderBlush;
			btnZakazi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnZakazi.Location = new System.Drawing.Point(796, 618);
			btnZakazi.Margin = new Padding(4, 3, 4, 3);
			btnZakazi.Name = "btnZakazi";
			btnZakazi.Size = new System.Drawing.Size(170, 53);
			btnZakazi.TabIndex = 4;
			btnZakazi.Text = "Zakaži termine";
			btnZakazi.UseVisualStyleBackColor = false;
			// 
			// txtNapomena
			// 
			txtNapomena.Anchor = AnchorStyles.None;
			txtNapomena.BackColor = System.Drawing.Color.LavenderBlush;
			txtNapomena.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtNapomena.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtNapomena.Location = new System.Drawing.Point(644, 134);
			txtNapomena.Margin = new Padding(4, 3, 4, 3);
			txtNapomena.Name = "txtNapomena";
			txtNapomena.Size = new System.Drawing.Size(319, 94);
			txtNapomena.TabIndex = 3;
			txtNapomena.Text = "";
			// 
			// cbTermin
			// 
			cbTermin.Anchor = AnchorStyles.None;
			cbTermin.BackColor = System.Drawing.Color.LavenderBlush;
			cbTermin.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbTermin.ForeColor = System.Drawing.Color.DarkSlateBlue;
			cbTermin.FormattingEnabled = true;
			cbTermin.Location = new System.Drawing.Point(644, 57);
			cbTermin.Margin = new Padding(4, 3, 4, 3);
			cbTermin.Name = "cbTermin";
			cbTermin.Size = new System.Drawing.Size(319, 31);
			cbTermin.TabIndex = 2;
			// 
			// cbRadnik
			// 
			cbRadnik.Anchor = AnchorStyles.None;
			cbRadnik.BackColor = System.Drawing.Color.LavenderBlush;
			cbRadnik.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbRadnik.ForeColor = System.Drawing.Color.DarkSlateBlue;
			cbRadnik.FormattingEnabled = true;
			cbRadnik.Location = new System.Drawing.Point(133, 193);
			cbRadnik.Margin = new Padding(4, 3, 4, 3);
			cbRadnik.Name = "cbRadnik";
			cbRadnik.Size = new System.Drawing.Size(348, 31);
			cbRadnik.TabIndex = 2;
			// 
			// cbUsluga
			// 
			cbUsluga.Anchor = AnchorStyles.None;
			cbUsluga.BackColor = System.Drawing.Color.LavenderBlush;
			cbUsluga.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			cbUsluga.ForeColor = System.Drawing.Color.DarkSlateBlue;
			cbUsluga.FormattingEnabled = true;
			cbUsluga.Location = new System.Drawing.Point(133, 123);
			cbUsluga.Margin = new Padding(4, 3, 4, 3);
			cbUsluga.Name = "cbUsluga";
			cbUsluga.Size = new System.Drawing.Size(348, 31);
			cbUsluga.TabIndex = 1;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label4.Location = new System.Drawing.Point(523, 134);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(98, 23);
			label4.TabIndex = 0;
			label4.Text = "Napomena:";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label3.Location = new System.Drawing.Point(523, 60);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(69, 23);
			label3.TabIndex = 0;
			label3.Text = "Termin:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.Location = new System.Drawing.Point(12, 196);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(68, 23);
			label2.TabIndex = 0;
			label2.Text = "Radnik:";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.Location = new System.Drawing.Point(12, 127);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(68, 23);
			label1.TabIndex = 0;
			label1.Text = "Usluga:";
			// 
			// btnNazad
			// 
			btnNazad.Anchor = AnchorStyles.None;
			btnNazad.BackColor = System.Drawing.Color.LavenderBlush;
			btnNazad.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnNazad.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnNazad.Location = new System.Drawing.Point(65, 812);
			btnNazad.Margin = new Padding(4, 3, 4, 3);
			btnNazad.Name = "btnNazad";
			btnNazad.Size = new System.Drawing.Size(170, 53);
			btnNazad.TabIndex = 13;
			btnNazad.Text = "Nazad";
			btnNazad.UseVisualStyleBackColor = false;
			btnNazad.Visible = false;
			// 
			// UCZahtev
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			Controls.Add(btnNazad);
			Controls.Add(groupBox1);
			DoubleBuffered = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "UCZahtev";
			Size = new System.Drawing.Size(1092, 903);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvTermini).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbRadnik;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTermin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErrorTermin;
        private System.Windows.Forms.Label lblErrorRadnik;
        private System.Windows.Forms.Label lblErrorUsluga;
        private Label lblErrorTipUsluge;
        private ComboBox cbTipUsluge;
        private Label label6;
        private Button btnDodaj;
        private DataGridView dgvTermini;
        private Button btnIzbaci;
        private Button btnIzmeni;
        private Button btnNazad;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public ComboBox CbRadnik { get => cbRadnik; set => cbRadnik = value; }
        public ComboBox CbUsluga { get => cbUsluga; set => cbUsluga = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox CbTermin { get => cbTermin; set => cbTermin = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Button BtnZakazi { get => btnZakazi; set => btnZakazi = value; }
        public RichTextBox TxtNapomena { get => txtNapomena; set => txtNapomena = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label LblErrorTermin { get => lblErrorTermin; set => lblErrorTermin = value; }
        public Label LblErrorRadnik { get => lblErrorRadnik; set => lblErrorRadnik = value; }
        public Label LblErrorUsluga { get => lblErrorUsluga; set => lblErrorUsluga = value; }
        public Label LblErrorTipUsluge { get => lblErrorTipUsluge; set => lblErrorTipUsluge = value; }
        public ComboBox CbTipUsluge { get => cbTipUsluge; set => cbTipUsluge = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public DataGridView DgvTermini { get => dgvTermini; set => dgvTermini = value; }
        public Button BtnIzbaci { get => btnIzbaci; set => btnIzbaci = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
    }
}
