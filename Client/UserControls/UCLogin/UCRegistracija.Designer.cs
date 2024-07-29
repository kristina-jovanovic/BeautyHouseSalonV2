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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.dtpDatumRodj = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrujSe = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.lblErrorIme = new System.Windows.Forms.Label();
            this.lblErrorPrezime = new System.Windows.Forms.Label();
            this.lblErrorBrTel = new System.Windows.Forms.Label();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorDatumRodj = new System.Windows.Forms.Label();
            this.txtBrTel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(41, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(41, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Broj telefona:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(42, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Korisničko ime:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(43, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lozinka:";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtIme.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIme.Location = new System.Drawing.Point(184, 35);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(287, 30);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPrezime.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPrezime.Location = new System.Drawing.Point(183, 94);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(287, 30);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(184, 272);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(287, 30);
            this.txtKorisnickoIme.TabIndex = 4;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtLozinka.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLozinka.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtLozinka.Location = new System.Drawing.Point(185, 333);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(287, 30);
            this.txtLozinka.TabIndex = 5;
            // 
            // dtpDatumRodj
            // 
            this.dtpDatumRodj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDatumRodj.CalendarForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpDatumRodj.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dtpDatumRodj.CalendarTitleBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpDatumRodj.CalendarTitleForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpDatumRodj.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpDatumRodj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumRodj.Location = new System.Drawing.Point(184, 392);
            this.dtpDatumRodj.Name = "dtpDatumRodj";
            this.dtpDatumRodj.Size = new System.Drawing.Size(287, 30);
            this.dtpDatumRodj.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(42, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Datum rođenja:";
            // 
            // btnRegistrujSe
            // 
            this.btnRegistrujSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrujSe.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRegistrujSe.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrujSe.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRegistrujSe.Location = new System.Drawing.Point(278, 464);
            this.btnRegistrujSe.Name = "btnRegistrujSe";
            this.btnRegistrujSe.Size = new System.Drawing.Size(146, 46);
            this.btnRegistrujSe.TabIndex = 7;
            this.btnRegistrujSe.Text = "Registruj se";
            this.btnRegistrujSe.UseVisualStyleBackColor = false;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOtkazi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOtkazi.Location = new System.Drawing.Point(90, 464);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(146, 46);
            this.btnOtkazi.TabIndex = 8;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // lblErrorIme
            // 
            this.lblErrorIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorIme.AutoSize = true;
            this.lblErrorIme.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIme.ForeColor = System.Drawing.Color.Red;
            this.lblErrorIme.Location = new System.Drawing.Point(181, 68);
            this.lblErrorIme.Name = "lblErrorIme";
            this.lblErrorIme.Size = new System.Drawing.Size(41, 17);
            this.lblErrorIme.TabIndex = 9;
            this.lblErrorIme.Text = "label7";
            this.lblErrorIme.Visible = false;
            // 
            // lblErrorPrezime
            // 
            this.lblErrorPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorPrezime.AutoSize = true;
            this.lblErrorPrezime.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrezime.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrezime.Location = new System.Drawing.Point(180, 127);
            this.lblErrorPrezime.Name = "lblErrorPrezime";
            this.lblErrorPrezime.Size = new System.Drawing.Size(41, 17);
            this.lblErrorPrezime.TabIndex = 9;
            this.lblErrorPrezime.Text = "label7";
            this.lblErrorPrezime.Visible = false;
            // 
            // lblErrorBrTel
            // 
            this.lblErrorBrTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorBrTel.AutoSize = true;
            this.lblErrorBrTel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBrTel.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBrTel.Location = new System.Drawing.Point(180, 187);
            this.lblErrorBrTel.Name = "lblErrorBrTel";
            this.lblErrorBrTel.Size = new System.Drawing.Size(41, 17);
            this.lblErrorBrTel.TabIndex = 9;
            this.lblErrorBrTel.Text = "label7";
            this.lblErrorBrTel.Visible = false;
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorUsername.AutoSize = true;
            this.lblErrorUsername.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsername.Location = new System.Drawing.Point(181, 305);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(41, 17);
            this.lblErrorUsername.TabIndex = 9;
            this.lblErrorUsername.Text = "label7";
            this.lblErrorUsername.Visible = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(181, 366);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(41, 17);
            this.lblErrorPassword.TabIndex = 9;
            this.lblErrorPassword.Text = "label7";
            this.lblErrorPassword.Visible = false;
            // 
            // lblErrorDatumRodj
            // 
            this.lblErrorDatumRodj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorDatumRodj.AutoSize = true;
            this.lblErrorDatumRodj.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDatumRodj.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDatumRodj.Location = new System.Drawing.Point(181, 425);
            this.lblErrorDatumRodj.Name = "lblErrorDatumRodj";
            this.lblErrorDatumRodj.Size = new System.Drawing.Size(41, 17);
            this.lblErrorDatumRodj.TabIndex = 9;
            this.lblErrorDatumRodj.Text = "label7";
            this.lblErrorDatumRodj.Visible = false;
            // 
            // txtBrTel
            // 
            this.txtBrTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrTel.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtBrTel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrTel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBrTel.Location = new System.Drawing.Point(183, 154);
            this.txtBrTel.Mask = "\\0600000000";
            this.txtBrTel.Name = "txtBrTel";
            this.txtBrTel.Size = new System.Drawing.Size(287, 30);
            this.txtBrTel.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(42, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email adresa:";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(181, 246);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(41, 17);
            this.lblErrorEmail.TabIndex = 9;
            this.lblErrorEmail.Text = "label7";
            this.lblErrorEmail.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtEmail.Location = new System.Drawing.Point(184, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(287, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.txtBrTel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblErrorDatumRodj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblErrorPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblErrorUsername);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblErrorEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblErrorBrTel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblErrorPrezime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblErrorIme);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.btnOtkazi);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.btnRegistrujSe);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.dtpDatumRodj);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtLozinka);
            this.groupBox1.Location = new System.Drawing.Point(217, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 525);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // UCRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.groupBox1);
            this.Name = "UCRegistracija";
            this.Size = new System.Drawing.Size(943, 646);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
