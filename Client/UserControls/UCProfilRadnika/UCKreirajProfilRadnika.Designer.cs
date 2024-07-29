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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.lblErrorFoto = new System.Windows.Forms.Label();
            this.lblErrorOpis = new System.Windows.Forms.Label();
            this.lblErrorPrezime = new System.Windows.Forms.Label();
            this.lblErrorTipUsluge = new System.Windows.Forms.Label();
            this.lblErrorIme = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbTipUsluge = new System.Windows.Forms.ComboBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.btnFoto);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.lblErrorFoto);
            this.groupBox1.Controls.Add(this.lblErrorOpis);
            this.groupBox1.Controls.Add(this.lblErrorPrezime);
            this.groupBox1.Controls.Add(this.lblErrorTipUsluge);
            this.groupBox1.Controls.Add(this.lblErrorIme);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.cbTipUsluge);
            this.groupBox1.Controls.Add(this.txtFoto);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(179, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 517);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profil radnika";
            // 
            // btnFoto
            // 
            this.btnFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFoto.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnFoto.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFoto.Location = new System.Drawing.Point(472, 395);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(34, 30);
            this.btnFoto.TabIndex = 10;
            this.btnFoto.Text = "...";
            this.btnFoto.UseVisualStyleBackColor = false;
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtOpis.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtOpis.Location = new System.Drawing.Point(185, 235);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(279, 113);
            this.txtOpis.TabIndex = 9;
            this.txtOpis.Text = "";
            // 
            // lblErrorFoto
            // 
            this.lblErrorFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorFoto.AutoSize = true;
            this.lblErrorFoto.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFoto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFoto.Location = new System.Drawing.Point(185, 428);
            this.lblErrorFoto.Name = "lblErrorFoto";
            this.lblErrorFoto.Size = new System.Drawing.Size(41, 17);
            this.lblErrorFoto.TabIndex = 6;
            this.lblErrorFoto.Text = "label6";
            this.lblErrorFoto.Visible = false;
            // 
            // lblErrorOpis
            // 
            this.lblErrorOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorOpis.AutoSize = true;
            this.lblErrorOpis.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOpis.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOpis.Location = new System.Drawing.Point(185, 351);
            this.lblErrorOpis.Name = "lblErrorOpis";
            this.lblErrorOpis.Size = new System.Drawing.Size(41, 17);
            this.lblErrorOpis.TabIndex = 6;
            this.lblErrorOpis.Text = "label6";
            this.lblErrorOpis.Visible = false;
            // 
            // lblErrorPrezime
            // 
            this.lblErrorPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorPrezime.AutoSize = true;
            this.lblErrorPrezime.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrezime.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrezime.Location = new System.Drawing.Point(185, 138);
            this.lblErrorPrezime.Name = "lblErrorPrezime";
            this.lblErrorPrezime.Size = new System.Drawing.Size(41, 17);
            this.lblErrorPrezime.TabIndex = 6;
            this.lblErrorPrezime.Text = "label6";
            this.lblErrorPrezime.Visible = false;
            // 
            // lblErrorTipUsluge
            // 
            this.lblErrorTipUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorTipUsluge.AutoSize = true;
            this.lblErrorTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTipUsluge.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTipUsluge.Location = new System.Drawing.Point(185, 204);
            this.lblErrorTipUsluge.Name = "lblErrorTipUsluge";
            this.lblErrorTipUsluge.Size = new System.Drawing.Size(41, 17);
            this.lblErrorTipUsluge.TabIndex = 6;
            this.lblErrorTipUsluge.Text = "label6";
            this.lblErrorTipUsluge.Visible = false;
            // 
            // lblErrorIme
            // 
            this.lblErrorIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorIme.AutoSize = true;
            this.lblErrorIme.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIme.ForeColor = System.Drawing.Color.Red;
            this.lblErrorIme.Location = new System.Drawing.Point(185, 72);
            this.lblErrorIme.Name = "lblErrorIme";
            this.lblErrorIme.Size = new System.Drawing.Size(41, 17);
            this.lblErrorIme.TabIndex = 6;
            this.lblErrorIme.Text = "label6";
            this.lblErrorIme.Visible = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnSacuvaj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(360, 456);
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
            this.cbTipUsluge.Location = new System.Drawing.Point(185, 170);
            this.cbTipUsluge.Name = "cbTipUsluge";
            this.cbTipUsluge.Size = new System.Drawing.Size(281, 31);
            this.cbTipUsluge.TabIndex = 4;
            // 
            // txtFoto
            // 
            this.txtFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFoto.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtFoto.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtFoto.Location = new System.Drawing.Point(185, 395);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.ReadOnly = true;
            this.txtFoto.Size = new System.Drawing.Size(281, 30);
            this.txtFoto.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtPrezime.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPrezime.Location = new System.Drawing.Point(185, 105);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(281, 30);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtIme.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtIme.Location = new System.Drawing.Point(185, 39);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(281, 30);
            this.txtIme.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(58, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tip usluge:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(58, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fotografija:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(61, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(58, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prezime:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UCKreirajProfilRadnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.groupBox1);
            this.Name = "UCKreirajProfilRadnika";
            this.Size = new System.Drawing.Size(936, 652);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnFoto;
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
        public Button BtnFoto { get => btnFoto; set => btnFoto = value; }
        public OpenFileDialog OpenFileDialog1 { get => openFileDialog1; set => openFileDialog1 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtFoto { get => txtFoto; set => txtFoto = value; }
        public Label LblErrorFoto { get => lblErrorFoto; set => lblErrorFoto = value; }
    }
}
