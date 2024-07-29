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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.lblErrorTipUsluge = new System.Windows.Forms.Label();
            this.cbTipUsluge = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErrorTermin = new System.Windows.Forms.Label();
            this.lblErrorRadnik = new System.Windows.Forms.Label();
            this.lblErrorUsluga = new System.Windows.Forms.Label();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.cbTermin = new System.Windows.Forms.ComboBox();
            this.cbRadnik = new System.Windows.Forms.ComboBox();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.btnIzmeni);
            this.groupBox1.Controls.Add(this.btnIzbaci);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.dgvTermini);
            this.groupBox1.Controls.Add(this.lblErrorTipUsluge);
            this.groupBox1.Controls.Add(this.cbTipUsluge);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblErrorTermin);
            this.groupBox1.Controls.Add(this.lblErrorRadnik);
            this.groupBox1.Controls.Add(this.lblErrorUsluga);
            this.groupBox1.Controls.Add(this.btnZakazi);
            this.groupBox1.Controls.Add(this.txtNapomena);
            this.groupBox1.Controls.Add(this.cbTermin);
            this.groupBox1.Controls.Add(this.cbRadnik);
            this.groupBox1.Controls.Add(this.cbUsluga);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(46, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 588);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezervacija termina";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnIzmeni.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(164, 536);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(146, 46);
            this.btnIzmeni.TabIndex = 12;
            this.btnIzmeni.Text = "Izmeni termin";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbaci.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnIzbaci.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaci.Location = new System.Drawing.Point(12, 536);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(146, 46);
            this.btnIzbaci.TabIndex = 11;
            this.btnIzbaci.Text = "Izbaci termin";
            this.btnIzbaci.UseVisualStyleBackColor = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDodaj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(682, 209);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(146, 46);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj termin";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTermini.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(12, 261);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.Size = new System.Drawing.Size(816, 269);
            this.dgvTermini.TabIndex = 9;
            // 
            // lblErrorTipUsluge
            // 
            this.lblErrorTipUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorTipUsluge.AutoSize = true;
            this.lblErrorTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTipUsluge.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTipUsluge.Location = new System.Drawing.Point(117, 83);
            this.lblErrorTipUsluge.Name = "lblErrorTipUsluge";
            this.lblErrorTipUsluge.Size = new System.Drawing.Size(41, 17);
            this.lblErrorTipUsluge.TabIndex = 8;
            this.lblErrorTipUsluge.Text = "label5";
            this.lblErrorTipUsluge.Visible = false;
            // 
            // cbTipUsluge
            // 
            this.cbTipUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipUsluge.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipUsluge.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbTipUsluge.FormattingEnabled = true;
            this.cbTipUsluge.Location = new System.Drawing.Point(114, 49);
            this.cbTipUsluge.Name = "cbTipUsluge";
            this.cbTipUsluge.Size = new System.Drawing.Size(299, 31);
            this.cbTipUsluge.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tip usluge:";
            // 
            // lblErrorTermin
            // 
            this.lblErrorTermin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorTermin.AutoSize = true;
            this.lblErrorTermin.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTermin.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTermin.Location = new System.Drawing.Point(555, 83);
            this.lblErrorTermin.Name = "lblErrorTermin";
            this.lblErrorTermin.Size = new System.Drawing.Size(41, 17);
            this.lblErrorTermin.TabIndex = 5;
            this.lblErrorTermin.Text = "label5";
            this.lblErrorTermin.Visible = false;
            // 
            // lblErrorRadnik
            // 
            this.lblErrorRadnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorRadnik.AutoSize = true;
            this.lblErrorRadnik.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRadnik.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRadnik.Location = new System.Drawing.Point(117, 201);
            this.lblErrorRadnik.Name = "lblErrorRadnik";
            this.lblErrorRadnik.Size = new System.Drawing.Size(41, 17);
            this.lblErrorRadnik.TabIndex = 5;
            this.lblErrorRadnik.Text = "label5";
            this.lblErrorRadnik.Visible = false;
            // 
            // lblErrorUsluga
            // 
            this.lblErrorUsluga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorUsluga.AutoSize = true;
            this.lblErrorUsluga.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorUsluga.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsluga.Location = new System.Drawing.Point(117, 141);
            this.lblErrorUsluga.Name = "lblErrorUsluga";
            this.lblErrorUsluga.Size = new System.Drawing.Size(41, 17);
            this.lblErrorUsluga.TabIndex = 5;
            this.lblErrorUsluga.Text = "label5";
            this.lblErrorUsluga.Visible = false;
            // 
            // btnZakazi
            // 
            this.btnZakazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZakazi.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnZakazi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakazi.Location = new System.Drawing.Point(682, 536);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(146, 46);
            this.btnZakazi.TabIndex = 4;
            this.btnZakazi.Text = "Zakaži termine";
            this.btnZakazi.UseVisualStyleBackColor = false;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNapomena.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtNapomena.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNapomena.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNapomena.Location = new System.Drawing.Point(552, 116);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(274, 82);
            this.txtNapomena.TabIndex = 3;
            this.txtNapomena.Text = "";
            // 
            // cbTermin
            // 
            this.cbTermin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTermin.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbTermin.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTermin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbTermin.FormattingEnabled = true;
            this.cbTermin.Location = new System.Drawing.Point(552, 49);
            this.cbTermin.Name = "cbTermin";
            this.cbTermin.Size = new System.Drawing.Size(274, 31);
            this.cbTermin.TabIndex = 2;
            // 
            // cbRadnik
            // 
            this.cbRadnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRadnik.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbRadnik.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRadnik.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbRadnik.FormattingEnabled = true;
            this.cbRadnik.Location = new System.Drawing.Point(114, 167);
            this.cbRadnik.Name = "cbRadnik";
            this.cbRadnik.Size = new System.Drawing.Size(299, 31);
            this.cbRadnik.TabIndex = 2;
            // 
            // cbUsluga
            // 
            this.cbUsluga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUsluga.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbUsluga.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsluga.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(114, 107);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(299, 31);
            this.cbUsluga.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Napomena:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Termin:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Radnik:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usluga:";
            // 
            // btnNazad
            // 
            this.btnNazad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNazad.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnNazad.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnNazad.Location = new System.Drawing.Point(56, 704);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(146, 46);
            this.btnNazad.TabIndex = 13;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Visible = false;
            // 
            // UCZahtev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCZahtev";
            this.Size = new System.Drawing.Size(936, 783);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);

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
