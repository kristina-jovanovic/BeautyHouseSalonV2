namespace Server
{
    partial class FrmServer
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
			btnStart = new System.Windows.Forms.Button();
			btnStop = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			lblPoruka = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// btnStart
			// 
			btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
			btnStart.BackColor = System.Drawing.Color.LavenderBlush;
			btnStart.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnStart.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnStart.Location = new System.Drawing.Point(108, 104);
			btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnStart.Name = "btnStart";
			btnStart.Size = new System.Drawing.Size(170, 53);
			btnStart.TabIndex = 0;
			btnStart.Text = "Pokreni server";
			btnStart.UseVisualStyleBackColor = false;
			btnStart.Click += BtnStart_Click;
			// 
			// btnStop
			// 
			btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
			btnStop.BackColor = System.Drawing.Color.LavenderBlush;
			btnStop.Enabled = false;
			btnStop.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			btnStop.ForeColor = System.Drawing.Color.DarkSlateBlue;
			btnStop.Location = new System.Drawing.Point(369, 104);
			btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			btnStop.Name = "btnStop";
			btnStop.Size = new System.Drawing.Size(170, 53);
			btnStop.TabIndex = 1;
			btnStop.Text = "Zaustavi server";
			btnStop.UseVisualStyleBackColor = false;
			btnStop.Click += BtnStop_Click;
			// 
			// label1
			// 
			label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			label1.AutoSize = true;
			label1.BackColor = System.Drawing.Color.Transparent;
			label1.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			label1.Location = new System.Drawing.Point(19, 358);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(529, 36);
			label1.TabIndex = 2;
			label1.Text = "© Kristina Jovanović 2020/0013";
			// 
			// lblPoruka
			// 
			lblPoruka.Anchor = System.Windows.Forms.AnchorStyles.None;
			lblPoruka.AutoSize = true;
			lblPoruka.BackColor = System.Drawing.Color.Transparent;
			lblPoruka.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			lblPoruka.ForeColor = System.Drawing.Color.DarkSlateBlue;
			lblPoruka.Location = new System.Drawing.Point(222, 204);
			lblPoruka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			lblPoruka.Name = "lblPoruka";
			lblPoruka.Size = new System.Drawing.Size(169, 23);
			lblPoruka.TabIndex = 4;
			lblPoruka.Text = "Server nije pokrenut!";
			// 
			// FrmServer
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.White;
			BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			ClientSize = new System.Drawing.Size(652, 410);
			Controls.Add(lblPoruka);
			Controls.Add(label1);
			Controls.Add(btnStop);
			Controls.Add(btnStart);
			DoubleBuffered = true;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			MaximumSize = new System.Drawing.Size(668, 449);
			MinimumSize = new System.Drawing.Size(668, 449);
			Name = "FrmServer";
			Text = "BeautyHouse";
			FormClosing += FrmServer_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoruka;
    }
}

