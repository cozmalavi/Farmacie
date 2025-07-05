namespace FarmacieUI
{
    partial class ClientModificaProdusCos
    {
        private System.ComponentModel.IContainer components = null;

        private MetroFramework.Controls.MetroLabel lblTitlu;
        private MetroFramework.Controls.MetroLabel lblProdus;
        private MetroFramework.Controls.MetroLabel lblCantitate;
        private MetroFramework.Controls.MetroTextBox txtCantitate;
        private MetroFramework.Controls.MetroTile btnModifica;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.lblTitlu = new MetroFramework.Controls.MetroLabel();
            this.lblProdus = new MetroFramework.Controls.MetroLabel();
            this.lblCantitate = new MetroFramework.Controls.MetroLabel();
            this.txtCantitate = new MetroFramework.Controls.MetroTextBox();
            this.btnModifica = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitlu.Location = new System.Drawing.Point(23, 26);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(250, 25);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Modifică cantitatea";
            // 
            // lblProdus
            // 
            this.lblProdus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblProdus.Location = new System.Drawing.Point(23, 76);
            this.lblProdus.Name = "lblProdus";
            this.lblProdus.Size = new System.Drawing.Size(300, 23);
            this.lblProdus.TabIndex = 1;
            this.lblProdus.Text = "Nume produs";
            // 
            // lblCantitate
            // 
            this.lblCantitate.Location = new System.Drawing.Point(23, 116);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(120, 23);
            this.lblCantitate.TabIndex = 2;
            this.lblCantitate.Text = "Noua cantitate:";
            // 
            // txtCantitate
            // 
            // 
            // 
            // 
            this.txtCantitate.CustomButton.Image = null;
            this.txtCantitate.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txtCantitate.CustomButton.Name = "";
            this.txtCantitate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCantitate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantitate.CustomButton.TabIndex = 1;
            this.txtCantitate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantitate.CustomButton.UseSelectable = true;
            this.txtCantitate.CustomButton.Visible = false;
            this.txtCantitate.Lines = new string[0];
            this.txtCantitate.Location = new System.Drawing.Point(149, 116);
            this.txtCantitate.MaxLength = 32767;
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.PasswordChar = '\0';
            this.txtCantitate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantitate.SelectedText = "";
            this.txtCantitate.SelectionLength = 0;
            this.txtCantitate.SelectionStart = 0;
            this.txtCantitate.ShortcutsEnabled = true;
            this.txtCantitate.Size = new System.Drawing.Size(100, 25);
            this.txtCantitate.TabIndex = 3;
            this.txtCantitate.UseSelectable = true;
            this.txtCantitate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantitate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnModifica
            // 
            this.btnModifica.ActiveControl = null;
            this.btnModifica.BackColor = System.Drawing.Color.HotPink;
            this.btnModifica.ForeColor = System.Drawing.Color.Black;
            this.btnModifica.Location = new System.Drawing.Point(23, 160);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(120, 38);
            this.btnModifica.TabIndex = 4;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifica.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnModifica.UseCustomBackColor = true;
            this.btnModifica.UseCustomForeColor = true;
            this.btnModifica.UseSelectable = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // ClientModificaProdusCos
            // 
            this.ClientSize = new System.Drawing.Size(369, 235);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblProdus);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.btnModifica);
            this.Name = "ClientModificaProdusCos";
            this.Text = "Modifică produs";
            this.ResumeLayout(false);

        }

    }
}
