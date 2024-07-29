using System.Windows.Forms;

namespace Client.UserControls.UCZahtevZaRezTermina
{
    partial class UCZakazivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCZakazivanje));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRadnik = new System.Windows.Forms.ComboBox();
            this.btnOdbij = new System.Windows.Forms.Button();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.dgvZahtevi = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.cbRadnik);
            this.groupBox1.Controls.Add(this.btnOdbij);
            this.groupBox1.Controls.Add(this.btnIzbaci);
            this.groupBox1.Controls.Add(this.btnOdobri);
            this.groupBox1.Controls.Add(this.dgvZahtevi);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvPodaci);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Location = new System.Drawing.Point(31, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 652);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zakazivanje termina";
            // 
            // cbRadnik
            // 
            this.cbRadnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRadnik.BackColor = System.Drawing.Color.LavenderBlush;
            this.cbRadnik.FormattingEnabled = true;
            this.cbRadnik.Location = new System.Drawing.Point(155, 32);
            this.cbRadnik.Name = "cbRadnik";
            this.cbRadnik.Size = new System.Drawing.Size(201, 31);
            this.cbRadnik.TabIndex = 17;
            // 
            // btnOdbij
            // 
            this.btnOdbij.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdbij.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOdbij.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdbij.Location = new System.Drawing.Point(528, 600);
            this.btnOdbij.Name = "btnOdbij";
            this.btnOdbij.Size = new System.Drawing.Size(146, 46);
            this.btnOdbij.TabIndex = 16;
            this.btnOdbij.Text = "Odbij zahteve";
            this.btnOdbij.UseVisualStyleBackColor = false;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbaci.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnIzbaci.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaci.Location = new System.Drawing.Point(6, 567);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(146, 46);
            this.btnIzbaci.TabIndex = 14;
            this.btnIzbaci.Text = "Izbaci zahtev";
            this.btnIzbaci.UseVisualStyleBackColor = false;
            // 
            // btnOdobri
            // 
            this.btnOdobri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdobri.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOdobri.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdobri.Location = new System.Drawing.Point(680, 600);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(146, 46);
            this.btnOdobri.TabIndex = 13;
            this.btnOdobri.Text = "Odobri zahteve";
            this.btnOdobri.UseVisualStyleBackColor = false;
            // 
            // dgvZahtevi
            // 
            this.dgvZahtevi.AllowUserToAddRows = false;
            this.dgvZahtevi.AllowUserToDeleteRows = false;
            this.dgvZahtevi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvZahtevi.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvZahtevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtevi.Location = new System.Drawing.Point(6, 366);
            this.dgvZahtevi.Name = "dgvZahtevi";
            this.dgvZahtevi.ReadOnly = true;
            this.dgvZahtevi.Size = new System.Drawing.Size(820, 195);
            this.dgvZahtevi.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDodaj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDodaj.Location = new System.Drawing.Point(680, 314);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(146, 46);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj zahtev";
            this.btnDodaj.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radnik:";
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPodaci.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Location = new System.Drawing.Point(6, 72);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.Size = new System.Drawing.Size(820, 236);
            this.dgvPodaci.TabIndex = 0;
            // 
            // UCZakazivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.groupBox1);
            this.Name = "UCZakazivanje";
            this.Size = new System.Drawing.Size(895, 786);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.DataGridView dgvZahtevi;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnOdbij;
        private System.Windows.Forms.ComboBox cbRadnik;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public DataGridView DgvPodaci { get => dgvPodaci; set => dgvPodaci = value; }
        public DataGridView DgvZahtevi { get => dgvZahtevi; set => dgvZahtevi = value; }
        public Button BtnIzbaci { get => btnIzbaci; set => btnIzbaci = value; }
        public Button BtnOdobri { get => btnOdobri; set => btnOdobri = value; }
        public Button BtnOdbij { get => btnOdbij; set => btnOdbij = value; }
        public ComboBox CbRadnik { get => cbRadnik; set => cbRadnik = value; }
    }
}
