using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCRegistracija
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRegistracija));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtIme = new TextBox();
			txtPrezime = new TextBox();
			txtKorisnickoIme = new TextBox();
			txtLozinka = new TextBox();
			dtpDatumRodj = new DateTimePicker();
			label6 = new Label();
			btnRegistrujSe = new Button();
			btnOtkazi = new Button();
			lblErrorIme = new Label();
			lblErrorPrezime = new Label();
			lblErrorBrTel = new Label();
			lblErrorUsername = new Label();
			lblErrorPassword = new Label();
			lblErrorDatumRodj = new Label();
			txtBrTel = new MaskedTextBox();
			label7 = new Label();
			lblErrorEmail = new Label();
			txtEmail = new TextBox();
			groupBox1 = new GroupBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label1.Location = new System.Drawing.Point(49, 44);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(42, 23);
			label1.TabIndex = 0;
			label1.Text = "Ime:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label2.Location = new System.Drawing.Point(48, 112);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(75, 23);
			label2.TabIndex = 0;
			label2.Text = "Prezime:";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label3.Location = new System.Drawing.Point(48, 181);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(110, 23);
			label3.TabIndex = 0;
			label3.Text = "Broj telefona:";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label4.Location = new System.Drawing.Point(49, 320);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(128, 23);
			label4.TabIndex = 0;
			label4.Text = "Korisničko ime:";
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label5.Location = new System.Drawing.Point(50, 388);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(74, 23);
			label5.TabIndex = 0;
			label5.Text = "Lozinka:";
			// 
			// txtIme
			// 
			txtIme.Anchor = AnchorStyles.None;
			txtIme.BackColor = System.Drawing.Color.LavenderBlush;
			txtIme.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtIme.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtIme.Location = new System.Drawing.Point(215, 40);
			txtIme.Margin = new Padding(4, 3, 4, 3);
			txtIme.Name = "txtIme";
			txtIme.Size = new System.Drawing.Size(334, 30);
			txtIme.TabIndex = 1;
			// 
			// txtPrezime
			// 
			txtPrezime.Anchor = AnchorStyles.None;
			txtPrezime.BackColor = System.Drawing.Color.LavenderBlush;
			txtPrezime.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPrezime.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtPrezime.Location = new System.Drawing.Point(214, 108);
			txtPrezime.Margin = new Padding(4, 3, 4, 3);
			txtPrezime.Name = "txtPrezime";
			txtPrezime.Size = new System.Drawing.Size(334, 30);
			txtPrezime.TabIndex = 2;
			// 
			// txtKorisnickoIme
			// 
			txtKorisnickoIme.Anchor = AnchorStyles.None;
			txtKorisnickoIme.BackColor = System.Drawing.Color.LavenderBlush;
			txtKorisnickoIme.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtKorisnickoIme.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtKorisnickoIme.Location = new System.Drawing.Point(215, 314);
			txtKorisnickoIme.Margin = new Padding(4, 3, 4, 3);
			txtKorisnickoIme.Name = "txtKorisnickoIme";
			txtKorisnickoIme.Size = new System.Drawing.Size(334, 30);
			txtKorisnickoIme.TabIndex = 4;
			// 
			// txtLozinka
			// 
			txtLozinka.Anchor = AnchorStyles.None;
			txtLozinka.BackColor = System.Drawing.Color.LavenderBlush;
			txtLozinka.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtLozinka.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtLozinka.Location = new System.Drawing.Point(216, 384);
			txtLozinka.Margin = new Padding(4, 3, 4, 3);
			txtLozinka.Name = "txtLozinka";
			txtLozinka.PasswordChar = '*';
			txtLozinka.Size = new System.Drawing.Size(334, 30);
			txtLozinka.TabIndex = 5;
			// 
			// dtpDatumRodj
			// 
			dtpDatumRodj.Anchor = AnchorStyles.None;
			dtpDatumRodj.CalendarForeColor = System.Drawing.Color.DarkSlateBlue;
			dtpDatumRodj.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
			dtpDatumRodj.CalendarTitleBackColor = System.Drawing.Color.DarkSlateBlue;
			dtpDatumRodj.CalendarTitleForeColor = System.Drawing.Color.DarkSlateBlue;
			dtpDatumRodj.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateBlue;
			dtpDatumRodj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dtpDatumRodj.Location = new System.Drawing.Point(215, 452);
			dtpDatumRodj.Margin = new Padding(4, 3, 4, 3);
			dtpDatumRodj.Name = "dtpDatumRodj";
			dtpDatumRodj.Size = new System.Drawing.Size(334, 30);
			dtpDatumRodj.TabIndex = 6;
			// 
			// label6
			// 
			label6.Anchor = AnchorStyles.None;
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label6.Location = new System.Drawing.Point(49, 452);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(129, 23);
			label6.TabIndex = 0;
			label6.Text = "Datum rođenja:";
			// 
			// btnRegistrujSe
			// 
			btnRegistrujSe.Anchor = AnchorStyles.None;
			btnRegistrujSe.BackColor = System.Drawing.Color.LavenderBlush;
			btnRegistrujSe.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnRegistrujSe.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnRegistrujSe.Location = new System.Drawing.Point(324, 535);
			btnRegistrujSe.Margin = new Padding(4, 3, 4, 3);
			btnRegistrujSe.Name = "btnRegistrujSe";
			btnRegistrujSe.Size = new System.Drawing.Size(170, 53);
			btnRegistrujSe.TabIndex = 7;
			btnRegistrujSe.Text = "Registruj se";
			btnRegistrujSe.UseVisualStyleBackColor = false;
			// 
			// btnOtkazi
			// 
			btnOtkazi.Anchor = AnchorStyles.None;
			btnOtkazi.BackColor = System.Drawing.Color.LavenderBlush;
			btnOtkazi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnOtkazi.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnOtkazi.Location = new System.Drawing.Point(105, 535);
			btnOtkazi.Margin = new Padding(4, 3, 4, 3);
			btnOtkazi.Name = "btnOtkazi";
			btnOtkazi.Size = new System.Drawing.Size(170, 53);
			btnOtkazi.TabIndex = 8;
			btnOtkazi.Text = "Otkaži";
			btnOtkazi.UseVisualStyleBackColor = false;
			// 
			// lblErrorIme
			// 
			lblErrorIme.Anchor = AnchorStyles.None;
			lblErrorIme.AutoSize = true;
			lblErrorIme.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorIme.ForeColor = System.Drawing.Color.Red;
			lblErrorIme.Location = new System.Drawing.Point(211, 78);
			lblErrorIme.Margin = new Padding(4, 0, 4, 0);
			lblErrorIme.Name = "lblErrorIme";
			lblErrorIme.Size = new System.Drawing.Size(41, 17);
			lblErrorIme.TabIndex = 9;
			lblErrorIme.Text = "label7";
			lblErrorIme.Visible = false;
			// 
			// lblErrorPrezime
			// 
			lblErrorPrezime.Anchor = AnchorStyles.None;
			lblErrorPrezime.AutoSize = true;
			lblErrorPrezime.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorPrezime.ForeColor = System.Drawing.Color.Red;
			lblErrorPrezime.Location = new System.Drawing.Point(210, 147);
			lblErrorPrezime.Margin = new Padding(4, 0, 4, 0);
			lblErrorPrezime.Name = "lblErrorPrezime";
			lblErrorPrezime.Size = new System.Drawing.Size(41, 17);
			lblErrorPrezime.TabIndex = 9;
			lblErrorPrezime.Text = "label7";
			lblErrorPrezime.Visible = false;
			// 
			// lblErrorBrTel
			// 
			lblErrorBrTel.Anchor = AnchorStyles.None;
			lblErrorBrTel.AutoSize = true;
			lblErrorBrTel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorBrTel.ForeColor = System.Drawing.Color.Red;
			lblErrorBrTel.Location = new System.Drawing.Point(210, 216);
			lblErrorBrTel.Margin = new Padding(4, 0, 4, 0);
			lblErrorBrTel.Name = "lblErrorBrTel";
			lblErrorBrTel.Size = new System.Drawing.Size(41, 17);
			lblErrorBrTel.TabIndex = 9;
			lblErrorBrTel.Text = "label7";
			lblErrorBrTel.Visible = false;
			// 
			// lblErrorUsername
			// 
			lblErrorUsername.Anchor = AnchorStyles.None;
			lblErrorUsername.AutoSize = true;
			lblErrorUsername.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorUsername.ForeColor = System.Drawing.Color.Red;
			lblErrorUsername.Location = new System.Drawing.Point(211, 352);
			lblErrorUsername.Margin = new Padding(4, 0, 4, 0);
			lblErrorUsername.Name = "lblErrorUsername";
			lblErrorUsername.Size = new System.Drawing.Size(41, 17);
			lblErrorUsername.TabIndex = 9;
			lblErrorUsername.Text = "label7";
			lblErrorUsername.Visible = false;
			// 
			// lblErrorPassword
			// 
			lblErrorPassword.Anchor = AnchorStyles.None;
			lblErrorPassword.AutoSize = true;
			lblErrorPassword.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorPassword.ForeColor = System.Drawing.Color.Red;
			lblErrorPassword.Location = new System.Drawing.Point(211, 422);
			lblErrorPassword.Margin = new Padding(4, 0, 4, 0);
			lblErrorPassword.Name = "lblErrorPassword";
			lblErrorPassword.Size = new System.Drawing.Size(41, 17);
			lblErrorPassword.TabIndex = 9;
			lblErrorPassword.Text = "label7";
			lblErrorPassword.Visible = false;
			// 
			// lblErrorDatumRodj
			// 
			lblErrorDatumRodj.Anchor = AnchorStyles.None;
			lblErrorDatumRodj.AutoSize = true;
			lblErrorDatumRodj.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorDatumRodj.ForeColor = System.Drawing.Color.Red;
			lblErrorDatumRodj.Location = new System.Drawing.Point(211, 490);
			lblErrorDatumRodj.Margin = new Padding(4, 0, 4, 0);
			lblErrorDatumRodj.Name = "lblErrorDatumRodj";
			lblErrorDatumRodj.Size = new System.Drawing.Size(41, 17);
			lblErrorDatumRodj.TabIndex = 9;
			lblErrorDatumRodj.Text = "label7";
			lblErrorDatumRodj.Visible = false;
			// 
			// txtBrTel
			// 
			txtBrTel.Anchor = AnchorStyles.None;
			txtBrTel.BackColor = System.Drawing.Color.LavenderBlush;
			txtBrTel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtBrTel.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtBrTel.Location = new System.Drawing.Point(214, 178);
			txtBrTel.Margin = new Padding(4, 3, 4, 3);
			txtBrTel.Mask = "\\0600000000";
			txtBrTel.Name = "txtBrTel";
			txtBrTel.Size = new System.Drawing.Size(334, 30);
			txtBrTel.TabIndex = 10;
			// 
			// label7
			// 
			label7.Anchor = AnchorStyles.None;
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label7.Location = new System.Drawing.Point(49, 249);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(113, 23);
			label7.TabIndex = 0;
			label7.Text = "Email adresa:";
			// 
			// lblErrorEmail
			// 
			lblErrorEmail.Anchor = AnchorStyles.None;
			lblErrorEmail.AutoSize = true;
			lblErrorEmail.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorEmail.ForeColor = System.Drawing.Color.Red;
			lblErrorEmail.Location = new System.Drawing.Point(211, 284);
			lblErrorEmail.Margin = new Padding(4, 0, 4, 0);
			lblErrorEmail.Name = "lblErrorEmail";
			lblErrorEmail.Size = new System.Drawing.Size(41, 17);
			lblErrorEmail.TabIndex = 9;
			lblErrorEmail.Text = "label7";
			lblErrorEmail.Visible = false;
			// 
			// txtEmail
			// 
			txtEmail.Anchor = AnchorStyles.None;
			txtEmail.BackColor = System.Drawing.Color.LavenderBlush;
			txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtEmail.Location = new System.Drawing.Point(215, 246);
			txtEmail.Margin = new Padding(4, 3, 4, 3);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new System.Drawing.Size(334, 30);
			txtEmail.TabIndex = 4;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.None;
			groupBox1.BackColor = System.Drawing.Color.Pink;
			groupBox1.Controls.Add(txtBrTel);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(lblErrorDatumRodj);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(lblErrorPassword);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(lblErrorUsername);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(lblErrorEmail);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(lblErrorBrTel);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(lblErrorPrezime);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(lblErrorIme);
			groupBox1.Controls.Add(txtIme);
			groupBox1.Controls.Add(btnOtkazi);
			groupBox1.Controls.Add(txtPrezime);
			groupBox1.Controls.Add(btnRegistrujSe);
			groupBox1.Controls.Add(txtKorisnickoIme);
			groupBox1.Controls.Add(dtpDatumRodj);
			groupBox1.Controls.Add(txtEmail);
			groupBox1.Controls.Add(txtLozinka);
			groupBox1.Location = new System.Drawing.Point(253, 121);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(570, 606);
			groupBox1.TabIndex = 11;
			groupBox1.TabStop = false;
			// 
			// UCRegistracija
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			Controls.Add(groupBox1);
			DoubleBuffered = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "UCRegistracija";
			Size = new System.Drawing.Size(1100, 745);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.DateTimePicker dtpDatumRodj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrujSe;
        private System.Windows.Forms.Button btnOtkazi;
        private Label lblErrorIme;
        private Label lblErrorPrezime;
        private Label lblErrorBrTel;
        private Label lblErrorUsername;
        private Label lblErrorPassword;
        private Label lblErrorDatumRodj;
        private MaskedTextBox txtBrTel;
        private Label label7;
        private Label lblErrorEmail;
        private TextBox txtEmail;
        private GroupBox groupBox1;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
        public TextBox TxtLozinka { get => txtLozinka; set => txtLozinka = value; }
        public DateTimePicker DtpDatumRodj { get => dtpDatumRodj; set => dtpDatumRodj = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Button BtnRegistrujSe { get => btnRegistrujSe; set => btnRegistrujSe = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Label LblErrorIme { get => lblErrorIme; set => lblErrorIme = value; }
        public Label LblErrorPrezime { get => lblErrorPrezime; set => lblErrorPrezime = value; }
        public Label LblErrorBrTel { get => lblErrorBrTel; set => lblErrorBrTel = value; }
        public Label LblErrorUsername { get => lblErrorUsername; set => lblErrorUsername = value; }
        public Label LblErrorPassword { get => lblErrorPassword; set => lblErrorPassword = value; }
        public Label LblErrorDatumRodj { get => lblErrorDatumRodj; set => lblErrorDatumRodj = value; }
        public MaskedTextBox TxtBrTel { get => txtBrTel; set => txtBrTel = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label LblErrorEmail { get => lblErrorEmail; set => lblErrorEmail = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
    }
}
