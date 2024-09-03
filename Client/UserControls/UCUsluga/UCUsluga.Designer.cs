using System.Windows.Forms;

namespace Client.UserControls
{
	partial class UCUsluga
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUsluga));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			groupBox1 = new GroupBox();
			lblErrorFoto = new Label();
			txtFotoUsluge = new TextBox();
			lblFoto = new Label();
			btnZakazi = new Button();
			btnIzmeni = new Button();
			btnObrisi = new Button();
			lblErrorTrajanje = new Label();
			lblErrorCena = new Label();
			lblErrorTipUsluge = new Label();
			lblErrorNaziv = new Label();
			btnSacuvaj = new Button();
			cbTipUsluge = new ComboBox();
			txtTrajanje = new TextBox();
			txtCena = new TextBox();
			txtNaziv = new TextBox();
			label5 = new Label();
			btnNazad = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label1.Location = new System.Drawing.Point(78, 51);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(59, 23);
			label1.TabIndex = 0;
			label1.Text = "Naziv:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.None;
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label2.Location = new System.Drawing.Point(78, 201);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(78, 23);
			label2.TabIndex = 0;
			label2.Text = "Cena (€):";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(75, 262);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(88, 23);
			label3.TabIndex = 0;
			label3.Text = "Trajanje u";
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.None;
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label4.Location = new System.Drawing.Point(78, 125);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(94, 23);
			label4.TabIndex = 0;
			label4.Text = "Tip usluge:";
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.None;
			groupBox1.BackColor = System.Drawing.Color.Pink;
			groupBox1.Controls.Add(lblErrorFoto);
			groupBox1.Controls.Add(txtFotoUsluge);
			groupBox1.Controls.Add(lblFoto);
			groupBox1.Controls.Add(btnZakazi);
			groupBox1.Controls.Add(btnIzmeni);
			groupBox1.Controls.Add(btnObrisi);
			groupBox1.Controls.Add(lblErrorTrajanje);
			groupBox1.Controls.Add(lblErrorCena);
			groupBox1.Controls.Add(lblErrorTipUsluge);
			groupBox1.Controls.Add(lblErrorNaziv);
			groupBox1.Controls.Add(btnSacuvaj);
			groupBox1.Controls.Add(cbTipUsluge);
			groupBox1.Controls.Add(txtTrajanje);
			groupBox1.Controls.Add(txtCena);
			groupBox1.Controls.Add(txtNaziv);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			groupBox1.Location = new System.Drawing.Point(168, 135);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(631, 475);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Usluga";
			// 
			// lblErrorFoto
			// 
			lblErrorFoto.Anchor = AnchorStyles.None;
			lblErrorFoto.AutoSize = true;
			lblErrorFoto.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorFoto.ForeColor = System.Drawing.Color.Red;
			lblErrorFoto.Location = new System.Drawing.Point(208, 377);
			lblErrorFoto.Margin = new Padding(4, 0, 4, 0);
			lblErrorFoto.Name = "lblErrorFoto";
			lblErrorFoto.Size = new System.Drawing.Size(41, 17);
			lblErrorFoto.TabIndex = 12;
			lblErrorFoto.Text = "label6";
			lblErrorFoto.Visible = false;
			// 
			// txtFotoUsluge
			// 
			txtFotoUsluge.Anchor = AnchorStyles.None;
			txtFotoUsluge.BackColor = System.Drawing.Color.LavenderBlush;
			txtFotoUsluge.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtFotoUsluge.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtFotoUsluge.Location = new System.Drawing.Point(211, 339);
			txtFotoUsluge.Margin = new Padding(4, 3, 4, 3);
			txtFotoUsluge.Name = "txtFotoUsluge";
			txtFotoUsluge.Size = new System.Drawing.Size(331, 30);
			txtFotoUsluge.TabIndex = 11;
			// 
			// lblFoto
			// 
			lblFoto.Anchor = AnchorStyles.None;
			lblFoto.AutoSize = true;
			lblFoto.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblFoto.ForeColor = System.Drawing.Color.DarkSlateBlue;
			lblFoto.Location = new System.Drawing.Point(78, 339);
			lblFoto.Margin = new Padding(4, 0, 4, 0);
			lblFoto.Name = "lblFoto";
			lblFoto.Size = new System.Drawing.Size(96, 23);
			lblFoto.TabIndex = 10;
			lblFoto.Text = "Fotografija:";
			// 
			// btnZakazi
			// 
			btnZakazi.Anchor = AnchorStyles.None;
			btnZakazi.BackColor = System.Drawing.Color.LavenderBlush;
			btnZakazi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnZakazi.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnZakazi.Location = new System.Drawing.Point(406, 415);
			btnZakazi.Margin = new Padding(4, 3, 4, 3);
			btnZakazi.Name = "btnZakazi";
			btnZakazi.Size = new System.Drawing.Size(170, 53);
			btnZakazi.TabIndex = 9;
			btnZakazi.Text = "Zakaži termin";
			btnZakazi.UseVisualStyleBackColor = false;
			btnZakazi.Visible = false;
			// 
			// btnIzmeni
			// 
			btnIzmeni.Anchor = AnchorStyles.None;
			btnIzmeni.BackColor = System.Drawing.Color.LavenderBlush;
			btnIzmeni.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnIzmeni.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnIzmeni.Location = new System.Drawing.Point(51, 415);
			btnIzmeni.Margin = new Padding(4, 3, 4, 3);
			btnIzmeni.Name = "btnIzmeni";
			btnIzmeni.Size = new System.Drawing.Size(170, 53);
			btnIzmeni.TabIndex = 8;
			btnIzmeni.Text = "Izmeni";
			btnIzmeni.UseVisualStyleBackColor = false;
			btnIzmeni.Visible = false;
			// 
			// btnObrisi
			// 
			btnObrisi.Anchor = AnchorStyles.None;
			btnObrisi.BackColor = System.Drawing.Color.LavenderBlush;
			btnObrisi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnObrisi.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnObrisi.Location = new System.Drawing.Point(229, 415);
			btnObrisi.Margin = new Padding(4, 3, 4, 3);
			btnObrisi.Name = "btnObrisi";
			btnObrisi.Size = new System.Drawing.Size(170, 53);
			btnObrisi.TabIndex = 7;
			btnObrisi.Text = "Obriši";
			btnObrisi.UseVisualStyleBackColor = false;
			btnObrisi.Visible = false;
			// 
			// lblErrorTrajanje
			// 
			lblErrorTrajanje.Anchor = AnchorStyles.None;
			lblErrorTrajanje.AutoSize = true;
			lblErrorTrajanje.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorTrajanje.ForeColor = System.Drawing.Color.Red;
			lblErrorTrajanje.Location = new System.Drawing.Point(208, 310);
			lblErrorTrajanje.Margin = new Padding(4, 0, 4, 0);
			lblErrorTrajanje.Name = "lblErrorTrajanje";
			lblErrorTrajanje.Size = new System.Drawing.Size(41, 17);
			lblErrorTrajanje.TabIndex = 6;
			lblErrorTrajanje.Text = "label6";
			lblErrorTrajanje.Visible = false;
			// 
			// lblErrorCena
			// 
			lblErrorCena.Anchor = AnchorStyles.None;
			lblErrorCena.AutoSize = true;
			lblErrorCena.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorCena.ForeColor = System.Drawing.Color.Red;
			lblErrorCena.Location = new System.Drawing.Point(208, 239);
			lblErrorCena.Margin = new Padding(4, 0, 4, 0);
			lblErrorCena.Name = "lblErrorCena";
			lblErrorCena.Size = new System.Drawing.Size(41, 17);
			lblErrorCena.TabIndex = 6;
			lblErrorCena.Text = "label6";
			lblErrorCena.Visible = false;
			// 
			// lblErrorTipUsluge
			// 
			lblErrorTipUsluge.Anchor = AnchorStyles.None;
			lblErrorTipUsluge.AutoSize = true;
			lblErrorTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorTipUsluge.ForeColor = System.Drawing.Color.Red;
			lblErrorTipUsluge.Location = new System.Drawing.Point(208, 164);
			lblErrorTipUsluge.Margin = new Padding(4, 0, 4, 0);
			lblErrorTipUsluge.Name = "lblErrorTipUsluge";
			lblErrorTipUsluge.Size = new System.Drawing.Size(41, 17);
			lblErrorTipUsluge.TabIndex = 6;
			lblErrorTipUsluge.Text = "label6";
			lblErrorTipUsluge.Visible = false;
			// 
			// lblErrorNaziv
			// 
			lblErrorNaziv.Anchor = AnchorStyles.None;
			lblErrorNaziv.AutoSize = true;
			lblErrorNaziv.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblErrorNaziv.ForeColor = System.Drawing.Color.Red;
			lblErrorNaziv.Location = new System.Drawing.Point(208, 89);
			lblErrorNaziv.Margin = new Padding(4, 0, 4, 0);
			lblErrorNaziv.Name = "lblErrorNaziv";
			lblErrorNaziv.Size = new System.Drawing.Size(41, 17);
			lblErrorNaziv.TabIndex = 6;
			lblErrorNaziv.Text = "label6";
			lblErrorNaziv.Visible = false;
			// 
			// btnSacuvaj
			// 
			btnSacuvaj.Anchor = AnchorStyles.None;
			btnSacuvaj.BackColor = System.Drawing.Color.LavenderBlush;
			btnSacuvaj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnSacuvaj.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnSacuvaj.Location = new System.Drawing.Point(406, 415);
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
			cbTipUsluge.Location = new System.Drawing.Point(211, 125);
			cbTipUsluge.Margin = new Padding(4, 3, 4, 3);
			cbTipUsluge.Name = "cbTipUsluge";
			cbTipUsluge.Size = new System.Drawing.Size(331, 31);
			cbTipUsluge.TabIndex = 4;
			// 
			// txtTrajanje
			// 
			txtTrajanje.Anchor = AnchorStyles.None;
			txtTrajanje.BackColor = System.Drawing.Color.LavenderBlush;
			txtTrajanje.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtTrajanje.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtTrajanje.Location = new System.Drawing.Point(211, 272);
			txtTrajanje.Margin = new Padding(4, 3, 4, 3);
			txtTrajanje.Name = "txtTrajanje";
			txtTrajanje.Size = new System.Drawing.Size(331, 30);
			txtTrajanje.TabIndex = 3;
			// 
			// txtCena
			// 
			txtCena.Anchor = AnchorStyles.None;
			txtCena.BackColor = System.Drawing.Color.LavenderBlush;
			txtCena.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtCena.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtCena.Location = new System.Drawing.Point(211, 201);
			txtCena.Margin = new Padding(4, 3, 4, 3);
			txtCena.Name = "txtCena";
			txtCena.Size = new System.Drawing.Size(331, 30);
			txtCena.TabIndex = 2;
			// 
			// txtNaziv
			// 
			txtNaziv.Anchor = AnchorStyles.None;
			txtNaziv.BackColor = System.Drawing.Color.LavenderBlush;
			txtNaziv.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtNaziv.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtNaziv.Location = new System.Drawing.Point(211, 51);
			txtNaziv.Margin = new Padding(4, 3, 4, 3);
			txtNaziv.Name = "txtNaziv";
			txtNaziv.Size = new System.Drawing.Size(331, 30);
			txtNaziv.TabIndex = 1;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.None;
			label5.AutoSize = true;
			label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label5.Location = new System.Drawing.Point(78, 288);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(89, 23);
			label5.TabIndex = 0;
			label5.Text = "minutima:";
			// 
			// btnNazad
			// 
			btnNazad.Anchor = AnchorStyles.None;
			btnNazad.BackColor = System.Drawing.Color.LavenderBlush;
			btnNazad.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnNazad.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnNazad.Location = new System.Drawing.Point(221, 617);
			btnNazad.Margin = new Padding(4, 3, 4, 3);
			btnNazad.Name = "btnNazad";
			btnNazad.Size = new System.Drawing.Size(170, 53);
			btnNazad.TabIndex = 9;
			btnNazad.Text = "Nazad";
			btnNazad.UseVisualStyleBackColor = false;
			btnNazad.Visible = false;
			// 
			// UCUsluga
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			Controls.Add(btnNazad);
			Controls.Add(groupBox1);
			DoubleBuffered = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "UCUsluga";
			Size = new System.Drawing.Size(942, 691);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTrajanje;
		private System.Windows.Forms.TextBox txtCena;
		private System.Windows.Forms.TextBox txtNaziv;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbTipUsluge;
		private Label lblErrorTrajanje;
		private Label lblErrorCena;
		private Label lblErrorTipUsluge;
		private Label lblErrorNaziv;
		private Button btnSacuvaj;
		private Button btnIzmeni;
		private Button btnObrisi;
		private Button btnNazad;
		private Button btnZakazi;
		private Label lblErrorFoto;
		private TextBox txtFotoUsluge;
		private Label lblFoto;

		public Label Label1 { get => label1; set => label1 = value; }
		public Label Label2 { get => label2; set => label2 = value; }
		public Label Label3 { get => label3; set => label3 = value; }
		public Label Label4 { get => label4; set => label4 = value; }
		public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
		public TextBox TxtTrajanje { get => txtTrajanje; set => txtTrajanje = value; }
		public TextBox TxtCena { get => txtCena; set => txtCena = value; }
		public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
		public Label Label5 { get => label5; set => label5 = value; }
		public ComboBox CbTipUsluge { get => cbTipUsluge; set => cbTipUsluge = value; }
		public Label LblErrorTrajanje { get => lblErrorTrajanje; set => lblErrorTrajanje = value; }
		public Label LblErrorCena { get => lblErrorCena; set => lblErrorCena = value; }
		public Label LblErrorTipUsluge { get => lblErrorTipUsluge; set => lblErrorTipUsluge = value; }
		public Label LblErrorNaziv { get => lblErrorNaziv; set => lblErrorNaziv = value; }
		public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
		public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
		public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
		public Button BtnNazad { get => btnNazad; set => btnNazad = value; }
		public Button BtnZakazi { get => btnZakazi; set => btnZakazi = value; }
		public Label LblFoto { get => lblFoto; set => lblFoto = value; }
		public Label LblErrorFoto { get => lblErrorFoto; set => lblErrorFoto = value; }
		public TextBox TxtFotoUsluge { get => txtFotoUsluge; set => txtFotoUsluge = value; }
	}
}
