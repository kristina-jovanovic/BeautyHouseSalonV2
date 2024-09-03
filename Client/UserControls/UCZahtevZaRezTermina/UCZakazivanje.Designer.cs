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
			groupBox1 = new GroupBox();
			cbRadnik = new ComboBox();
			btnOdbij = new Button();
			btnIzbaci = new Button();
			btnOdobri = new Button();
			dgvZahtevi = new DataGridView();
			btnDodaj = new Button();
			label1 = new Label();
			dgvPodaci = new DataGridView();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvZahtevi).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.None;
			groupBox1.BackColor = System.Drawing.Color.Pink;
			groupBox1.Controls.Add(cbRadnik);
			groupBox1.Controls.Add(btnOdbij);
			groupBox1.Controls.Add(btnIzbaci);
			groupBox1.Controls.Add(btnOdobri);
			groupBox1.Controls.Add(dgvZahtevi);
			groupBox1.Controls.Add(btnDodaj);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(dgvPodaci);
			groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			groupBox1.Location = new System.Drawing.Point(36, 128);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(971, 752);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Zakazivanje termina";
			// 
			// cbRadnik
			// 
			cbRadnik.Anchor = AnchorStyles.None;
			cbRadnik.BackColor = System.Drawing.Color.LavenderBlush;
			cbRadnik.FormattingEnabled = true;
			cbRadnik.Location = new System.Drawing.Point(181, 37);
			cbRadnik.Margin = new Padding(4, 3, 4, 3);
			cbRadnik.Name = "cbRadnik";
			cbRadnik.Size = new System.Drawing.Size(234, 31);
			cbRadnik.TabIndex = 17;
			// 
			// btnOdbij
			// 
			btnOdbij.Anchor = AnchorStyles.None;
			btnOdbij.BackColor = System.Drawing.Color.LavenderBlush;
			btnOdbij.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnOdbij.Location = new System.Drawing.Point(616, 692);
			btnOdbij.Margin = new Padding(4, 3, 4, 3);
			btnOdbij.Name = "btnOdbij";
			btnOdbij.Size = new System.Drawing.Size(170, 53);
			btnOdbij.TabIndex = 16;
			btnOdbij.Text = "Odbij zahteve";
			btnOdbij.UseVisualStyleBackColor = false;
			// 
			// btnIzbaci
			// 
			btnIzbaci.Anchor = AnchorStyles.None;
			btnIzbaci.BackColor = System.Drawing.Color.LavenderBlush;
			btnIzbaci.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnIzbaci.Location = new System.Drawing.Point(7, 654);
			btnIzbaci.Margin = new Padding(4, 3, 4, 3);
			btnIzbaci.Name = "btnIzbaci";
			btnIzbaci.Size = new System.Drawing.Size(170, 53);
			btnIzbaci.TabIndex = 14;
			btnIzbaci.Text = "Izbaci zahtev";
			btnIzbaci.UseVisualStyleBackColor = false;
			// 
			// btnOdobri
			// 
			btnOdobri.Anchor = AnchorStyles.None;
			btnOdobri.BackColor = System.Drawing.Color.LavenderBlush;
			btnOdobri.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnOdobri.Location = new System.Drawing.Point(793, 692);
			btnOdobri.Margin = new Padding(4, 3, 4, 3);
			btnOdobri.Name = "btnOdobri";
			btnOdobri.Size = new System.Drawing.Size(170, 53);
			btnOdobri.TabIndex = 13;
			btnOdobri.Text = "Odobri zahteve";
			btnOdobri.UseVisualStyleBackColor = false;
			// 
			// dgvZahtevi
			// 
			dgvZahtevi.AllowUserToAddRows = false;
			dgvZahtevi.AllowUserToDeleteRows = false;
			dgvZahtevi.Anchor = AnchorStyles.None;
			dgvZahtevi.BackgroundColor = System.Drawing.Color.LavenderBlush;
			dgvZahtevi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvZahtevi.Location = new System.Drawing.Point(7, 422);
			dgvZahtevi.Margin = new Padding(4, 3, 4, 3);
			dgvZahtevi.Name = "dgvZahtevi";
			dgvZahtevi.ReadOnly = true;
			dgvZahtevi.Size = new System.Drawing.Size(957, 225);
			dgvZahtevi.TabIndex = 4;
			// 
			// btnDodaj
			// 
			btnDodaj.Anchor = AnchorStyles.None;
			btnDodaj.BackColor = System.Drawing.Color.LavenderBlush;
			btnDodaj.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnDodaj.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnDodaj.Location = new System.Drawing.Point(793, 362);
			btnDodaj.Margin = new Padding(4, 3, 4, 3);
			btnDodaj.Name = "btnDodaj";
			btnDodaj.Size = new System.Drawing.Size(170, 53);
			btnDodaj.TabIndex = 3;
			btnDodaj.Text = "Dodaj zahtev";
			btnDodaj.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label1.Location = new System.Drawing.Point(64, 40);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(68, 23);
			label1.TabIndex = 2;
			label1.Text = "Radnik:";
			// 
			// dgvPodaci
			// 
			dgvPodaci.AllowUserToAddRows = false;
			dgvPodaci.AllowUserToDeleteRows = false;
			dgvPodaci.Anchor = AnchorStyles.None;
			dgvPodaci.BackgroundColor = System.Drawing.Color.LavenderBlush;
			dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPodaci.Location = new System.Drawing.Point(7, 83);
			dgvPodaci.Margin = new Padding(4, 3, 4, 3);
			dgvPodaci.Name = "dgvPodaci";
			dgvPodaci.ReadOnly = true;
			dgvPodaci.Size = new System.Drawing.Size(957, 272);
			dgvPodaci.TabIndex = 0;
			// 
			// UCZakazivanje
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			Controls.Add(groupBox1);
			DoubleBuffered = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "UCZakazivanje";
			Size = new System.Drawing.Size(1044, 907);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvZahtevi).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
			ResumeLayout(false);
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
