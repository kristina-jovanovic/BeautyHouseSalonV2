using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCPretrazivanje
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPretrazivanje));
			groupBox1 = new GroupBox();
			btnIzaberi = new Button();
			label1 = new Label();
			txtPretraga = new TextBox();
			dgvPodaci = new DataGridView();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvPodaci).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.None;
			groupBox1.BackColor = System.Drawing.Color.Pink;
			groupBox1.Controls.Add(btnIzaberi);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(txtPretraga);
			groupBox1.Controls.Add(dgvPodaci);
			groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			groupBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			groupBox1.Location = new System.Drawing.Point(40, 133);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(964, 527);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Pretraživanje";
			// 
			// btnIzaberi
			// 
			btnIzaberi.Anchor = AnchorStyles.None;
			btnIzaberi.BackColor = System.Drawing.Color.LavenderBlush;
			btnIzaberi.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnIzaberi.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnIzaberi.Location = new System.Drawing.Point(748, 57);
			btnIzaberi.Margin = new Padding(4, 3, 4, 3);
			btnIzaberi.Name = "btnIzaberi";
			btnIzaberi.Size = new System.Drawing.Size(170, 53);
			btnIzaberi.TabIndex = 3;
			btnIzaberi.Text = "Izaberi";
			btnIzaberi.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label1.Location = new System.Drawing.Point(50, 70);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(82, 23);
			label1.TabIndex = 2;
			label1.Text = "Pretraži...";
			// 
			// txtPretraga
			// 
			txtPretraga.Anchor = AnchorStyles.None;
			txtPretraga.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			txtPretraga.ForeColor = System.Drawing.Color.DarkSlateBlue;
			txtPretraga.Location = new System.Drawing.Point(169, 67);
			txtPretraga.Margin = new Padding(4, 3, 4, 3);
			txtPretraga.Name = "txtPretraga";
			txtPretraga.Size = new System.Drawing.Size(234, 30);
			txtPretraga.TabIndex = 1;
			// 
			// dgvPodaci
			// 
			dgvPodaci.AllowUserToAddRows = false;
			dgvPodaci.AllowUserToDeleteRows = false;
			dgvPodaci.Anchor = AnchorStyles.None;
			dgvPodaci.BackgroundColor = System.Drawing.Color.LavenderBlush;
			dgvPodaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPodaci.Location = new System.Drawing.Point(7, 140);
			dgvPodaci.Margin = new Padding(4, 3, 4, 3);
			dgvPodaci.Name = "dgvPodaci";
			dgvPodaci.ReadOnly = true;
			dgvPodaci.Size = new System.Drawing.Size(950, 381);
			dgvPodaci.TabIndex = 0;
			// 
			// UCPretrazivanje
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			Controls.Add(groupBox1);
			DoubleBuffered = true;
			Margin = new Padding(4, 3, 4, 3);
			Name = "UCPretrazivanje";
			Size = new System.Drawing.Size(1044, 674);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvPodaci).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.Button btnIzaberi;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtPretraga { get => txtPretraga; set => txtPretraga = value; }
        public DataGridView DgvPodaci { get => dgvPodaci; set => dgvPodaci = value; }
        public Button BtnIzaberi { get => btnIzaberi; set => btnIzaberi = value; }
    }
}
