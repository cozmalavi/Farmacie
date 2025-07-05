namespace Farmacie_Interfata
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private MetroFramework.Controls.MetroTile mAngajat;
        private MetroFramework.Controls.MetroTile mClient;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mAngajat = new MetroFramework.Controls.MetroTile();
            this.mClient = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mAngajat
            // 
            this.mAngajat.ActiveControl = null;
            this.mAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.mAngajat.ForeColor = System.Drawing.Color.Black;
            this.mAngajat.Location = new System.Drawing.Point(81, 193);
            this.mAngajat.Margin = new System.Windows.Forms.Padding(2);
            this.mAngajat.Name = "mAngajat";
            this.mAngajat.Size = new System.Drawing.Size(567, 47);
            this.mAngajat.TabIndex = 0;
            this.mAngajat.Text = "Angajat";
            this.mAngajat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mAngajat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mAngajat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mAngajat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mAngajat.UseCustomBackColor = true;
            this.mAngajat.UseCustomForeColor = true;
            this.mAngajat.UseSelectable = true;
            this.mAngajat.UseTileImage = true;
            this.mAngajat.Click += new System.EventHandler(this.mtAdmin_Click);
            // 
            // mClient
            // 
            this.mClient.ActiveControl = null;
            this.mClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.mClient.ForeColor = System.Drawing.Color.Black;
            this.mClient.Location = new System.Drawing.Point(81, 266);
            this.mClient.Margin = new System.Windows.Forms.Padding(2);
            this.mClient.Name = "mClient";
            this.mClient.Size = new System.Drawing.Size(567, 47);
            this.mClient.TabIndex = 1;
            this.mClient.Text = "Client";
            this.mClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mClient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mClient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mClient.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mClient.UseCustomBackColor = true;
            this.mClient.UseCustomForeColor = true;
            this.mClient.UseSelectable = true;
            this.mClient.UseTileImage = true;
            this.mClient.Click += new System.EventHandler(this.mtClient_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 509);
            this.Controls.Add(this.mAngajat);
            this.Controls.Add(this.mClient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Farmacia Lavinia";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }
    }
}
