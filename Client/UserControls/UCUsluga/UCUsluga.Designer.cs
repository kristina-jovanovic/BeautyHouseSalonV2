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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblErrorTrajanje = new System.Windows.Forms.Label();
            this.lblErrorCena = new System.Windows.Forms.Label();
            this.lblErrorTipUsluge = new System.Windows.Forms.Label();
            this.lblErrorNaziv = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbTipUsluge = new System.Windows.Forms.ComboBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(73, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cena (€):";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trajanje u";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(73, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tip usluge:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.btnZakazi);
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.lblErrorTrajanje);
            this.groupBox1.Controls.Add(this.lblErrorCena);
            this.groupBox1.Controls.Add(this.lblErrorTipUsluge);
            this.groupBox1.Controls.Add(this.lblErrorNaziv);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.cbTipUsluge);
            this.groupBox1.Controls.Add(this.txtTrajanje);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(188, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usluga";
            // 
            // btnZakazi
            // 
            this.btnZakazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZakazi.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnZakazi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakazi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnZakazi.Location = new System.Drawing.Point(348, 360);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(146, 46);
            this.btnZakazi.TabIndex = 9;
            this.btnZakazi.Text = "Zakaži termin";
            this.btnZakazi.UseVisualStyleBackColor = false;
            this.btnZakazi.Visible = false;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnIzmeni.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnIzmeni.Location = new System.Drawing.Point(44, 360);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(146, 46);
            this.btnIzmeni.TabIndex = 8;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Visible = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnObrisi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnObrisi.Location = new System.Drawing.Point(196, 360);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(146, 46);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Visible = false;
            // 
            // lblErrorTrajanje
            // 
            this.lblErrorTrajanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorTrajanje.AutoSize = true;
            this.lblErrorTrajanje.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTrajanje.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTrajanje.Location = new System.Drawing.Point(184, 288);
            this.lblErrorTrajanje.Name = "lblErrorTrajanje";
            this.lblErrorTrajanje.Size = new System.Drawing.Size(41, 17);
            this.lblErrorTrajanje.TabIndex = 6;
            this.lblErrorTrajanje.Text = "label6";
            this.lblErrorTrajanje.Visible = false;
            // 
            // lblErrorCena
            // 
            this.lblErrorCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCena.AutoSize = true;
            this.lblErrorCena.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCena.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCena.Location = new System.Drawing.Point(184, 226);
            this.lblErrorCena.Name = "lblErrorCena";
            this.lblErrorCena.Size = new System.Drawing.Size(41, 17);
            this.lblErrorCena.TabIndex = 6;
            this.lblErrorCena.Text = "label6";
            this.lblErrorCena.Visible = false;
            // 
            // lblErrorTipUsluge
            // 
            this.lblErrorTipUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorTipUsluge.AutoSize = true;
            this.lblErrorTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTipUsluge.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTipUsluge.Location = new System.Drawing.Point(184, 161);
            this.lblErrorTipUsluge.Name = "lblErrorTipUsluge";
            this.lblErrorTipUsluge.Size = new System.Drawing.Size(41, 17);
            this.lblErrorTipUsluge.TabIndex = 6;
            this.lblErrorTipUsluge.Text = "label6";
            this.lblErrorTipUsluge.Visible = false;
            // 
            // lblErrorNaziv
            // 
            this.lblErrorNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorNaziv.AutoSize = true;
            this.lblErrorNaziv.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNaziv.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNaziv.Location = new System.Drawing.Point(184, 96);
            this.lblErrorNaziv.Name = "lblErrorNaziv";
            this.lblErrorNaziv.Size = new System.Drawing.Size(41, 17);
            this.lblErrorNaziv.TabIndex = 6;
            this.lblErrorNaziv.Text = "label6";
            this.lblErrorNaziv.Visible = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSacuvaj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSacuvaj.Location = new System.Drawing.Point(348, 360);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(146, 46);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // cbTipUsluge
            // 
            this.cbTipUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipUsluge.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipUsluge.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbTipUsluge.FormattingEnabled = true;
            this.cbTipUsluge.Location = new System.Drawing.Point(187, 127);
            this.cbTipUsluge.Name = "cbTipUsluge";
            this.cbTipUsluge.Size = new System.Drawing.Size(284, 31);
            this.cbTipUsluge.TabIndex = 4;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrajanje.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtTrajanje.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrajanje.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtTrajanje.Location = new System.Drawing.Point(187, 255);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(284, 30);
            this.txtTrajanje.TabIndex = 3;
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCena.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtCena.Location = new System.Drawing.Point(187, 193);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(284, 30);
            this.txtCena.TabIndex = 2;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtNaziv.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNaziv.Location = new System.Drawing.Point(187, 63);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(284, 30);
            this.txtNaziv.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(73, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "minutima:";
            // 
            // btnNazad
            // 
            this.btnNazad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNazad.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnNazad.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNazad.Location = new System.Drawing.Point(233, 535);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(146, 46);
            this.btnNazad.TabIndex = 9;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Visible = false;
            // 
            // UCUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCUsluga";
            this.Size = new System.Drawing.Size(895, 599);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
