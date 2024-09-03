using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLogin));
			txtKorisnickoIme = new TextBox();
			label1 = new Label();
			label2 = new Label();
			txtLozinka = new TextBox();
			btnPrijava = new Button();
			btnRegistracija = new Button();
			label3 = new Label();
			lblErrorUsername = new Label();
			lblErrorPassword = new Label();
			groupBox1 = new GroupBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// txtKorisnickoIme
			// 
			txtKorisnickoIme.Anchor = AnchorStyles.None;
			txtKorisnickoIme.BackColor = System.Drawing.Color.LavenderBlush;
			txtKorisnickoIme.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtKorisnickoIme.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtKorisnickoIme.Location = new System.Drawing.Point(211, 52);
			txtKorisnickoIme.Margin = new Padding(4, 3, 4, 3);
			txtKorisnickoIme.Name = "txtKorisnickoIme";
			txtKorisnickoIme.Size = new System.Drawing.Size(202, 33);
			txtKorisnickoIme.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label1.Location = new System.Drawing.Point(38, 52);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(140, 26);
			label1.TabIndex = 1;
			label1.Text = "Korisničko ime:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label2.Location = new System.Drawing.Point(38, 147);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(84, 26);
			label2.TabIndex = 2;
			label2.Text = "Lozinka:";
			// 
			// txtLozinka
			// 
			txtLozinka.Anchor = AnchorStyles.None;
			txtLozinka.BackColor = System.Drawing.Color.LavenderBlush;
			txtLozinka.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtLozinka.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtLozinka.Location = new System.Drawing.Point(209, 143);
			txtLozinka.Margin = new Padding(4, 3, 4, 3);
			txtLozinka.Name = "txtLozinka";
			txtLozinka.PasswordChar = '*';
			txtLozinka.Size = new System.Drawing.Size(202, 33);
			txtLozinka.TabIndex = 3;
			// 
			// btnPrijava
			// 
			btnPrijava.Anchor = AnchorStyles.None;
			btnPrijava.BackColor = System.Drawing.Color.LavenderBlush;
			btnPrijava.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnPrijava.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnPrijava.Location = new System.Drawing.Point(63, 264);
			btnPrijava.Margin = new Padding(4, 3, 4, 3);
			btnPrijava.Name = "btnPrijava";
			btnPrijava.Size = new System.Drawing.Size(170, 53);
			btnPrijava.TabIndex = 4;
			btnPrijava.Text = "Prijavi se";
			btnPrijava.UseVisualStyleBackColor = false;
			// 
			// btnRegistracija
			// 
			btnRegistracija.Anchor = AnchorStyles.None;
			btnRegistracija.BackColor = System.Drawing.Color.LavenderBlush;
			btnRegistracija.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnRegistracija.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnRegistracija.Location = new System.Drawing.Point(262, 264);
			btnRegistracija.Margin = new Padding(4, 3, 4, 3);
			btnRegistracija.Name = "btnRegistracija";
			btnRegistracija.Size = new System.Drawing.Size(170, 53);
			btnRegistracija.TabIndex = 5;
			btnRegistracija.Text = "Registruj se";
			btnRegistracija.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label3.Location = new System.Drawing.Point(267, 231);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(129, 26);
			label3.TabIndex = 6;
			label3.Text = "Nemaš nalog?";
			// 
			// lblErrorUsername
			// 
			lblErrorUsername.Anchor = AnchorStyles.None;
			lblErrorUsername.AutoSize = true;
			lblErrorUsername.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorUsername.ForeColor = System.Drawing.Color.Red;
			lblErrorUsername.Location = new System.Drawing.Point(205, 93);
			lblErrorUsername.Margin = new Padding(4, 0, 4, 0);
			lblErrorUsername.Name = "lblErrorUsername";
			lblErrorUsername.Size = new System.Drawing.Size(61, 26);
			lblErrorUsername.TabIndex = 7;
			lblErrorUsername.Text = "label4";
			lblErrorUsername.Visible = false;
			// 
			// lblErrorPassword
			// 
			lblErrorPassword.Anchor = AnchorStyles.None;
			lblErrorPassword.AutoSize = true;
			lblErrorPassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorPassword.ForeColor = System.Drawing.Color.Red;
			lblErrorPassword.Location = new System.Drawing.Point(205, 185);
			lblErrorPassword.Margin = new Padding(4, 0, 4, 0);
			lblErrorPassword.Name = "lblErrorPassword";
			lblErrorPassword.Size = new System.Drawing.Size(61, 26);
			lblErrorPassword.TabIndex = 7;
			lblErrorPassword.Text = "label4";
			lblErrorPassword.Visible = false;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.None;
			groupBox1.BackColor = System.Drawing.Color.Pink;
			groupBox1.Controls.Add(lblErrorPassword);
			groupBox1.Controls.Add(txtKorisnickoIme);
			groupBox1.Controls.Add(lblErrorUsername);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(btnRegistracija);
			groupBox1.Controls.Add(txtLozinka);
			groupBox1.Controls.Add(btnPrijava);
			groupBox1.Location = new System.Drawing.Point(245, 162);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(518, 338);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			// 
			// UCLogin
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			Controls.Add(groupBox1);
			DoubleBuffered = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "UCLogin";
			Size = new System.Drawing.Size(1044, 674);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label label3;
        private Label lblErrorUsername;
        private Label lblErrorPassword;
        private GroupBox groupBox1;

        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtLozinka { get => txtLozinka; set => txtLozinka = value; }
        public Button BtnPrijava { get => btnPrijava; set => btnPrijava = value; }
        public Button BtnRegistracija { get => btnRegistracija; set => btnRegistracija = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label LblErrorUsername { get => lblErrorUsername; set => lblErrorUsername = value; }
        public Label LblErrorPassword { get => lblErrorPassword; set => lblErrorPassword = value; }
    }
}
