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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.lblTipUsluge = new System.Windows.Forms.Label();
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.btnZakazi);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.lblTipUsluge);
            this.groupBox1.Controls.Add(this.lblImePrezime);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profil radnika";
            // 
            // btnZakazi
            // 
            this.btnZakazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZakazi.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnZakazi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZakazi.Location = new System.Drawing.Point(469, 382);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(146, 46);
            this.btnZakazi.TabIndex = 11;
            this.btnZakazi.Text = "Zakaži termin";
            this.btnZakazi.UseVisualStyleBackColor = false;
            this.btnZakazi.Visible = false;
            // 
            // txtOpis
            // 
            this.txtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpis.BackColor = System.Drawing.Color.Pink;
            this.txtOpis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpis.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpis.Location = new System.Drawing.Point(17, 247);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ReadOnly = true;
            this.txtOpis.Size = new System.Drawing.Size(598, 181);
            this.txtOpis.TabIndex = 3;
            this.txtOpis.Text = "Opis";
            // 
            // lblTipUsluge
            // 
            this.lblTipUsluge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipUsluge.AutoSize = true;
            this.lblTipUsluge.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipUsluge.Location = new System.Drawing.Point(287, 164);
            this.lblTipUsluge.Name = "lblTipUsluge";
            this.lblTipUsluge.Size = new System.Drawing.Size(94, 23);
            this.lblTipUsluge.TabIndex = 2;
            this.lblTipUsluge.Text = "Tip usluge:";
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImePrezime.AutoSize = true;
            this.lblImePrezime.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.Location = new System.Drawing.Point(282, 74);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(107, 44);
            this.lblImePrezime.TabIndex = 1;
            this.lblImePrezime.Text = "label1";
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFoto.Location = new System.Drawing.Point(17, 29);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(249, 193);
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btnNazad
            // 
            this.btnNazad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNazad.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnNazad.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(160, 552);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(146, 46);
            this.btnNazad.TabIndex = 10;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = false;
            // 
            // UCProfilRadnikaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCProfilRadnikaPrikaz";
            this.Size = new System.Drawing.Size(895, 614);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

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
