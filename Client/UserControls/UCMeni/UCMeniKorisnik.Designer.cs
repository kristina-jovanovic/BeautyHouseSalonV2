using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCMeniKorisnik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pretraziUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziProfileRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakaziTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretraziUslugeToolStripMenuItem,
            this.pretraziProfileRadnikaToolStripMenuItem,
            this.zakaziTerminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pretraziUslugeToolStripMenuItem
            // 
            this.pretraziUslugeToolStripMenuItem.Name = "pretraziUslugeToolStripMenuItem";
            this.pretraziUslugeToolStripMenuItem.Size = new System.Drawing.Size(136, 49);
            this.pretraziUslugeToolStripMenuItem.Text = "Pretraži usluge";
            // 
            // pretraziProfileRadnikaToolStripMenuItem
            // 
            this.pretraziProfileRadnikaToolStripMenuItem.Name = "pretraziProfileRadnikaToolStripMenuItem";
            this.pretraziProfileRadnikaToolStripMenuItem.Size = new System.Drawing.Size(198, 49);
            this.pretraziProfileRadnikaToolStripMenuItem.Text = "Pretraži profile radnika";
            // 
            // zakaziTerminToolStripMenuItem
            // 
            this.zakaziTerminToolStripMenuItem.Name = "zakaziTerminToolStripMenuItem";
            this.zakaziTerminToolStripMenuItem.Size = new System.Drawing.Size(136, 49);
            this.zakaziTerminToolStripMenuItem.Text = "Zakaži termine";
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdjaviSe.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOdjaviSe.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjaviSe.Location = new System.Drawing.Point(701, 3);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(123, 47);
            this.btnOdjaviSe.TabIndex = 1;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            // 
            // UCMeniKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UCMeniKorisnik";
            this.Size = new System.Drawing.Size(827, 53);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pretraziUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziProfileRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakaziTerminToolStripMenuItem;
        private System.Windows.Forms.Button btnOdjaviSe;

        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem PretraziUslugeToolStripMenuItem { get => pretraziUslugeToolStripMenuItem; set => pretraziUslugeToolStripMenuItem = value; }
        public ToolStripMenuItem PretraziProfileRadnikaToolStripMenuItem { get => pretraziProfileRadnikaToolStripMenuItem; set => pretraziProfileRadnikaToolStripMenuItem = value; }
        public ToolStripMenuItem ZakaziTerminToolStripMenuItem { get => zakaziTerminToolStripMenuItem; set => zakaziTerminToolStripMenuItem = value; }
        public Button BtnOdjaviSe { get => btnOdjaviSe; set => btnOdjaviSe = value; }
    }
}
