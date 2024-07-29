using System.Windows.Forms;

namespace Client.UserControls
{
    partial class UCMeniVlasnik
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
            this.meniVlasnik = new System.Windows.Forms.MenuStrip();
            this.uslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeNoveUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretrazivanjeUslugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajProfilRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretraziProfileRadnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakaziTerminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretrazivanjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pretrazivanjeUslugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pretrazivanjeProfilaRadnikaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.meniVlasnik.SuspendLayout();
            this.SuspendLayout();
            // 
            // meniVlasnik
            // 
            this.meniVlasnik.BackColor = System.Drawing.Color.LavenderBlush;
            this.meniVlasnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meniVlasnik.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniVlasnik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uslugeToolStripMenuItem,
            this.radniciToolStripMenuItem,
            this.terminiToolStripMenuItem,
            this.pretrazivanjeToolStripMenuItem1});
            this.meniVlasnik.Location = new System.Drawing.Point(0, 0);
            this.meniVlasnik.Name = "meniVlasnik";
            this.meniVlasnik.Size = new System.Drawing.Size(827, 53);
            this.meniVlasnik.TabIndex = 5;
            this.meniVlasnik.Text = "menuStrip1";
            // 
            // uslugeToolStripMenuItem
            // 
            this.uslugeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeNoveUslugeToolStripMenuItem,
            this.izmenaUslugeToolStripMenuItem,
            this.brisanjeUslugeToolStripMenuItem,
            this.pretrazivanjeUslugaToolStripMenuItem});
            this.uslugeToolStripMenuItem.Name = "uslugeToolStripMenuItem";
            this.uslugeToolStripMenuItem.Size = new System.Drawing.Size(75, 49);
            this.uslugeToolStripMenuItem.Text = "Usluge";
            // 
            // kreiranjeNoveUslugeToolStripMenuItem
            // 
            this.kreiranjeNoveUslugeToolStripMenuItem.Name = "kreiranjeNoveUslugeToolStripMenuItem";
            this.kreiranjeNoveUslugeToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.kreiranjeNoveUslugeToolStripMenuItem.Text = "Kreiranje nove usluge";
            // 
            // izmenaUslugeToolStripMenuItem
            // 
            this.izmenaUslugeToolStripMenuItem.Name = "izmenaUslugeToolStripMenuItem";
            this.izmenaUslugeToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.izmenaUslugeToolStripMenuItem.Text = "Izmena usluge";
            // 
            // brisanjeUslugeToolStripMenuItem
            // 
            this.brisanjeUslugeToolStripMenuItem.Name = "brisanjeUslugeToolStripMenuItem";
            this.brisanjeUslugeToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.brisanjeUslugeToolStripMenuItem.Text = "Brisanje usluge";
            // 
            // pretrazivanjeUslugaToolStripMenuItem
            // 
            this.pretrazivanjeUslugaToolStripMenuItem.Name = "pretrazivanjeUslugaToolStripMenuItem";
            this.pretrazivanjeUslugaToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.pretrazivanjeUslugaToolStripMenuItem.Text = "Pretraživanje usluga";
            // 
            // radniciToolStripMenuItem
            // 
            this.radniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajProfilRadnikaToolStripMenuItem,
            this.pretraziProfileRadnikaToolStripMenuItem});
            this.radniciToolStripMenuItem.Name = "radniciToolStripMenuItem";
            this.radniciToolStripMenuItem.Size = new System.Drawing.Size(80, 49);
            this.radniciToolStripMenuItem.Text = "Radnici";
            // 
            // kreirajProfilRadnikaToolStripMenuItem
            // 
            this.kreirajProfilRadnikaToolStripMenuItem.Name = "kreirajProfilRadnikaToolStripMenuItem";
            this.kreirajProfilRadnikaToolStripMenuItem.Size = new System.Drawing.Size(256, 28);
            this.kreirajProfilRadnikaToolStripMenuItem.Text = "Kreiraj profil radnika";
            // 
            // pretraziProfileRadnikaToolStripMenuItem
            // 
            this.pretraziProfileRadnikaToolStripMenuItem.Name = "pretraziProfileRadnikaToolStripMenuItem";
            this.pretraziProfileRadnikaToolStripMenuItem.Size = new System.Drawing.Size(256, 28);
            this.pretraziProfileRadnikaToolStripMenuItem.Text = "Pretraži profile radnika";
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakaziTerminToolStripMenuItem});
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(82, 49);
            this.terminiToolStripMenuItem.Text = "Termini";
            // 
            // zakaziTerminToolStripMenuItem
            // 
            this.zakaziTerminToolStripMenuItem.Name = "zakaziTerminToolStripMenuItem";
            this.zakaziTerminToolStripMenuItem.Size = new System.Drawing.Size(194, 28);
            this.zakaziTerminToolStripMenuItem.Text = "Zakaži termine";
            // 
            // pretrazivanjeToolStripMenuItem1
            // 
            this.pretrazivanjeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretrazivanjeUslugaToolStripMenuItem1,
            this.pretrazivanjeProfilaRadnikaToolStripMenuItem1});
            this.pretrazivanjeToolStripMenuItem1.Name = "pretrazivanjeToolStripMenuItem1";
            this.pretrazivanjeToolStripMenuItem1.Size = new System.Drawing.Size(123, 49);
            this.pretrazivanjeToolStripMenuItem1.Text = "Pretraživanje";
            // 
            // pretrazivanjeUslugaToolStripMenuItem1
            // 
            this.pretrazivanjeUslugaToolStripMenuItem1.Name = "pretrazivanjeUslugaToolStripMenuItem1";
            this.pretrazivanjeUslugaToolStripMenuItem1.Size = new System.Drawing.Size(298, 28);
            this.pretrazivanjeUslugaToolStripMenuItem1.Text = "Pretraživanje usluga";
            // 
            // pretrazivanjeProfilaRadnikaToolStripMenuItem1
            // 
            this.pretrazivanjeProfilaRadnikaToolStripMenuItem1.Name = "pretrazivanjeProfilaRadnikaToolStripMenuItem1";
            this.pretrazivanjeProfilaRadnikaToolStripMenuItem1.Size = new System.Drawing.Size(298, 28);
            this.pretrazivanjeProfilaRadnikaToolStripMenuItem1.Text = "Pretraživanje profila radnika";
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdjaviSe.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOdjaviSe.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjaviSe.Location = new System.Drawing.Point(699, 3);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(125, 47);
            this.btnOdjaviSe.TabIndex = 6;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = false;
            // 
            // UCMeniVlasnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.meniVlasnik);
            this.Name = "UCMeniVlasnik";
            this.Size = new System.Drawing.Size(827, 53);
            this.meniVlasnik.ResumeLayout(false);
            this.meniVlasnik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip meniVlasnik;
        private System.Windows.Forms.ToolStripMenuItem uslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeNoveUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretrazivanjeUslugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajProfilRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretraziProfileRadnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakaziTerminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretrazivanjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pretrazivanjeUslugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pretrazivanjeProfilaRadnikaToolStripMenuItem1;
        private System.Windows.Forms.Button btnOdjaviSe;

        public MenuStrip MeniVlasnik { get => meniVlasnik; set => meniVlasnik = value; }
        public ToolStripMenuItem UslugeToolStripMenuItem { get => uslugeToolStripMenuItem; set => uslugeToolStripMenuItem = value; }
        public ToolStripMenuItem KreiranjeNoveUslugeToolStripMenuItem { get => kreiranjeNoveUslugeToolStripMenuItem; set => kreiranjeNoveUslugeToolStripMenuItem = value; }
        public ToolStripMenuItem IzmenaUslugeToolStripMenuItem { get => izmenaUslugeToolStripMenuItem; set => izmenaUslugeToolStripMenuItem = value; }
        public ToolStripMenuItem BrisanjeUslugeToolStripMenuItem { get => brisanjeUslugeToolStripMenuItem; set => brisanjeUslugeToolStripMenuItem = value; }
        public ToolStripMenuItem PretrazivanjeUslugaToolStripMenuItem { get => pretrazivanjeUslugaToolStripMenuItem; set => pretrazivanjeUslugaToolStripMenuItem = value; }
        public ToolStripMenuItem RadniciToolStripMenuItem { get => radniciToolStripMenuItem; set => radniciToolStripMenuItem = value; }
        public ToolStripMenuItem KreirajProfilRadnikaToolStripMenuItem { get => kreirajProfilRadnikaToolStripMenuItem; set => kreirajProfilRadnikaToolStripMenuItem = value; }
        public ToolStripMenuItem PretraziProfileRadnikaToolStripMenuItem { get => pretraziProfileRadnikaToolStripMenuItem; set => pretraziProfileRadnikaToolStripMenuItem = value; }
        public ToolStripMenuItem TerminiToolStripMenuItem { get => terminiToolStripMenuItem; set => terminiToolStripMenuItem = value; }
        public ToolStripMenuItem ZakaziTerminToolStripMenuItem { get => zakaziTerminToolStripMenuItem; set => zakaziTerminToolStripMenuItem = value; }
        public ToolStripMenuItem PretrazivanjeToolStripMenuItem1 { get => pretrazivanjeToolStripMenuItem1; set => pretrazivanjeToolStripMenuItem1 = value; }
        public ToolStripMenuItem PretrazivanjeUslugaToolStripMenuItem1 { get => pretrazivanjeUslugaToolStripMenuItem1; set => pretrazivanjeUslugaToolStripMenuItem1 = value; }
        public ToolStripMenuItem PretrazivanjeProfilaRadnikaToolStripMenuItem1 { get => pretrazivanjeProfilaRadnikaToolStripMenuItem1; set => pretrazivanjeProfilaRadnikaToolStripMenuItem1 = value; }
        public Button BtnOdjaviSe { get => btnOdjaviSe; set => btnOdjaviSe = value; }
    }
}
