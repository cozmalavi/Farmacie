namespace Farmacie_Interfata
{
    partial class FormAdaugaMedicament
    {
        private System.ComponentModel.IContainer components = null;

        private MetroFramework.Controls.MetroLabel lblNume;
        private MetroFramework.Controls.MetroLabel lblComerciant;
        private MetroFramework.Controls.MetroLabel lblPret;
        private MetroFramework.Controls.MetroLabel lblStoc;
        private MetroFramework.Controls.MetroLabel lblTip;

        private MetroFramework.Controls.MetroTextBox txtNume;
        private MetroFramework.Controls.MetroTextBox txtComerciant;
        private MetroFramework.Controls.MetroTextBox txtPret;
        private MetroFramework.Controls.MetroTextBox txtStoc;

        private System.Windows.Forms.ComboBox cmbTip;
        private MetroFramework.Controls.MetroTile btnAdauga;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNume = new MetroFramework.Controls.MetroLabel();
            this.lblComerciant = new MetroFramework.Controls.MetroLabel();
            this.lblPret = new MetroFramework.Controls.MetroLabel();
            this.lblStoc = new MetroFramework.Controls.MetroLabel();
            this.lblTip = new MetroFramework.Controls.MetroLabel();
            this.txtNume = new MetroFramework.Controls.MetroTextBox();
            this.txtComerciant = new MetroFramework.Controls.MetroTextBox();
            this.txtPret = new MetroFramework.Controls.MetroTextBox();
            this.txtStoc = new MetroFramework.Controls.MetroTextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.Gold;
            this.lblNume.Location = new System.Drawing.Point(30, 31);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(45, 19);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblComerciant
            // 
            this.lblComerciant.AutoSize = true;
            this.lblComerciant.ForeColor = System.Drawing.Color.Gold;
            this.lblComerciant.Location = new System.Drawing.Point(30, 89);
            this.lblComerciant.Name = "lblComerciant";
            this.lblComerciant.Size = new System.Drawing.Size(77, 19);
            this.lblComerciant.TabIndex = 2;
            this.lblComerciant.Text = "Comerciant";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.ForeColor = System.Drawing.Color.Gold;
            this.lblPret.Location = new System.Drawing.Point(30, 140);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(33, 19);
            this.lblPret.TabIndex = 4;
            this.lblPret.Text = "Preț";
            // 
            // lblStoc
            // 
            this.lblStoc.AutoSize = true;
            this.lblStoc.ForeColor = System.Drawing.Color.Gold;
            this.lblStoc.Location = new System.Drawing.Point(30, 191);
            this.lblStoc.Name = "lblStoc";
            this.lblStoc.Size = new System.Drawing.Size(34, 19);
            this.lblStoc.TabIndex = 6;
            this.lblStoc.Text = "Stoc";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Gold;
            this.lblTip.Location = new System.Drawing.Point(30, 245);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(104, 19);
            this.lblTip.TabIndex = 8;
            this.lblTip.Text = "Tip medicament";
            // 
            // txtNume
            // 
            // 
            // 
            // 
            this.txtNume.CustomButton.Image = null;
            this.txtNume.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtNume.CustomButton.Name = "";
            this.txtNume.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNume.CustomButton.TabIndex = 1;
            this.txtNume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNume.CustomButton.UseSelectable = true;
            this.txtNume.CustomButton.Visible = false;
            this.txtNume.Lines = new string[0];
            this.txtNume.Location = new System.Drawing.Point(180, 31);
            this.txtNume.MaxLength = 32767;
            this.txtNume.Name = "txtNume";
            this.txtNume.PasswordChar = '\0';
            this.txtNume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNume.SelectedText = "";
            this.txtNume.SelectionLength = 0;
            this.txtNume.SelectionStart = 0;
            this.txtNume.ShortcutsEnabled = true;
            this.txtNume.Size = new System.Drawing.Size(250, 30);
            this.txtNume.TabIndex = 1;
            this.txtNume.UseSelectable = true;
            this.txtNume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComerciant
            // 
            // 
            // 
            // 
            this.txtComerciant.CustomButton.Image = null;
            this.txtComerciant.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtComerciant.CustomButton.Name = "";
            this.txtComerciant.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtComerciant.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComerciant.CustomButton.TabIndex = 1;
            this.txtComerciant.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComerciant.CustomButton.UseSelectable = true;
            this.txtComerciant.CustomButton.Visible = false;
            this.txtComerciant.Lines = new string[0];
            this.txtComerciant.Location = new System.Drawing.Point(180, 89);
            this.txtComerciant.MaxLength = 32767;
            this.txtComerciant.Name = "txtComerciant";
            this.txtComerciant.PasswordChar = '\0';
            this.txtComerciant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComerciant.SelectedText = "";
            this.txtComerciant.SelectionLength = 0;
            this.txtComerciant.SelectionStart = 0;
            this.txtComerciant.ShortcutsEnabled = true;
            this.txtComerciant.Size = new System.Drawing.Size(250, 30);
            this.txtComerciant.TabIndex = 3;
            this.txtComerciant.UseSelectable = true;
            this.txtComerciant.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComerciant.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPret
            // 
            // 
            // 
            // 
            this.txtPret.CustomButton.Image = null;
            this.txtPret.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtPret.CustomButton.Name = "";
            this.txtPret.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPret.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPret.CustomButton.TabIndex = 1;
            this.txtPret.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPret.CustomButton.UseSelectable = true;
            this.txtPret.CustomButton.Visible = false;
            this.txtPret.Lines = new string[0];
            this.txtPret.Location = new System.Drawing.Point(180, 140);
            this.txtPret.MaxLength = 32767;
            this.txtPret.Name = "txtPret";
            this.txtPret.PasswordChar = '\0';
            this.txtPret.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPret.SelectedText = "";
            this.txtPret.SelectionLength = 0;
            this.txtPret.SelectionStart = 0;
            this.txtPret.ShortcutsEnabled = true;
            this.txtPret.Size = new System.Drawing.Size(250, 30);
            this.txtPret.TabIndex = 5;
            this.txtPret.UseSelectable = true;
            this.txtPret.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPret.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStoc
            // 
            // 
            // 
            // 
            this.txtStoc.CustomButton.Image = null;
            this.txtStoc.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtStoc.CustomButton.Name = "";
            this.txtStoc.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtStoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStoc.CustomButton.TabIndex = 1;
            this.txtStoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStoc.CustomButton.UseSelectable = true;
            this.txtStoc.CustomButton.Visible = false;
            this.txtStoc.Lines = new string[0];
            this.txtStoc.Location = new System.Drawing.Point(180, 191);
            this.txtStoc.MaxLength = 32767;
            this.txtStoc.Name = "txtStoc";
            this.txtStoc.PasswordChar = '\0';
            this.txtStoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStoc.SelectedText = "";
            this.txtStoc.SelectionLength = 0;
            this.txtStoc.SelectionStart = 0;
            this.txtStoc.ShortcutsEnabled = true;
            this.txtStoc.Size = new System.Drawing.Size(250, 30);
            this.txtStoc.TabIndex = 7;
            this.txtStoc.UseSelectable = true;
            this.txtStoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbTip
            // 
            this.cmbTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTip.Location = new System.Drawing.Point(180, 245);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(250, 28);
            this.cmbTip.TabIndex = 9;
            // 
            // btnAdauga
            // 
            this.btnAdauga.ActiveControl = null;
            this.btnAdauga.BackColor = System.Drawing.Color.HotPink;
            this.btnAdauga.ForeColor = System.Drawing.Color.Black;
            this.btnAdauga.Location = new System.Drawing.Point(350, 300);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(107, 44);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdauga.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
            this.btnAdauga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnAdauga.UseCustomBackColor = true;
            this.btnAdauga.UseCustomForeColor = true;
            this.btnAdauga.UseSelectable = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // FormAdaugaMedicament
            // 
            this.ClientSize = new System.Drawing.Size(480, 370);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblComerciant);
            this.Controls.Add(this.txtComerciant);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.lblStoc);
            this.Controls.Add(this.txtStoc);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.btnAdauga);
            this.Name = "FormAdaugaMedicament";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Load += new System.EventHandler(this.FormAdaugaMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}