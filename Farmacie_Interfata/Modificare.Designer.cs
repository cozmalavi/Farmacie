using System;
using System.Windows.Forms;

namespace Farmacie_Interfata
{
    partial class FormModificaMedicament
    {
        private System.ComponentModel.IContainer components = null;

        private MetroFramework.Controls.MetroLabel lblNume;
        private MetroFramework.Controls.MetroLabel lblProducator;
        private MetroFramework.Controls.MetroLabel lblPret;
        private MetroFramework.Controls.MetroLabel lblCantitate;
        private MetroFramework.Controls.MetroLabel lblTip;

        private MetroFramework.Controls.MetroTextBox txtNume;
        private MetroFramework.Controls.MetroTextBox txtProducator;
        private MetroFramework.Controls.MetroTextBox txtPret;
        private MetroFramework.Controls.MetroTextBox txtCantitate;

        private RadioButton rbCapsula;
        private RadioButton rbInjectie;
        private RadioButton rbSirop;
        private RadioButton rbEfervescent;
        private RadioButton rbAntibiotic;

        private MetroFramework.Controls.MetroTile btnModifica;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNume = new MetroFramework.Controls.MetroLabel();
            this.lblProducator = new MetroFramework.Controls.MetroLabel();
            this.lblPret = new MetroFramework.Controls.MetroLabel();
            this.lblCantitate = new MetroFramework.Controls.MetroLabel();
            this.lblTip = new MetroFramework.Controls.MetroLabel();
            this.txtNume = new MetroFramework.Controls.MetroTextBox();
            this.txtProducator = new MetroFramework.Controls.MetroTextBox();
            this.txtPret = new MetroFramework.Controls.MetroTextBox();
            this.txtCantitate = new MetroFramework.Controls.MetroTextBox();
            this.rbCapsula = new System.Windows.Forms.RadioButton();
            this.rbInjectie = new System.Windows.Forms.RadioButton();
            this.rbSirop = new System.Windows.Forms.RadioButton();
            this.rbEfervescent = new System.Windows.Forms.RadioButton();
            this.rbAntibiotic = new System.Windows.Forms.RadioButton();
            this.btnModifica = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.Gold;
            this.lblNume.Location = new System.Drawing.Point(30, 26);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(45, 19);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblProducator
            // 
            this.lblProducator.AutoSize = true;
            this.lblProducator.ForeColor = System.Drawing.Color.Gold;
            this.lblProducator.Location = new System.Drawing.Point(30, 76);
            this.lblProducator.Name = "lblProducator";
            this.lblProducator.Size = new System.Drawing.Size(77, 19);
            this.lblProducator.TabIndex = 2;
            this.lblProducator.Text = "Comerciant";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.ForeColor = System.Drawing.Color.Gold;
            this.lblPret.Location = new System.Drawing.Point(30, 129);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(33, 19);
            this.lblPret.TabIndex = 4;
            this.lblPret.Text = "Preț";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.ForeColor = System.Drawing.Color.Gold;
            this.lblCantitate.Location = new System.Drawing.Point(30, 180);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(61, 19);
            this.lblCantitate.TabIndex = 6;
            this.lblCantitate.Text = "Cantitate";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Gold;
            this.lblTip.Location = new System.Drawing.Point(30, 220);
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
            this.txtNume.Location = new System.Drawing.Point(180, 26);
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
            // txtProducator
            // 
            // 
            // 
            // 
            this.txtProducator.CustomButton.Image = null;
            this.txtProducator.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtProducator.CustomButton.Name = "";
            this.txtProducator.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProducator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProducator.CustomButton.TabIndex = 1;
            this.txtProducator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProducator.CustomButton.UseSelectable = true;
            this.txtProducator.CustomButton.Visible = false;
            this.txtProducator.Lines = new string[0];
            this.txtProducator.Location = new System.Drawing.Point(180, 76);
            this.txtProducator.MaxLength = 32767;
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.PasswordChar = '\0';
            this.txtProducator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProducator.SelectedText = "";
            this.txtProducator.SelectionLength = 0;
            this.txtProducator.SelectionStart = 0;
            this.txtProducator.ShortcutsEnabled = true;
            this.txtProducator.Size = new System.Drawing.Size(250, 30);
            this.txtProducator.TabIndex = 3;
            this.txtProducator.UseSelectable = true;
            this.txtProducator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProducator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtPret.Location = new System.Drawing.Point(180, 129);
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
            // txtCantitate
            // 
            // 
            // 
            // 
            this.txtCantitate.CustomButton.Image = null;
            this.txtCantitate.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.txtCantitate.CustomButton.Name = "";
            this.txtCantitate.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCantitate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantitate.CustomButton.TabIndex = 1;
            this.txtCantitate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantitate.CustomButton.UseSelectable = true;
            this.txtCantitate.CustomButton.Visible = false;
            this.txtCantitate.Lines = new string[0];
            this.txtCantitate.Location = new System.Drawing.Point(180, 180);
            this.txtCantitate.MaxLength = 32767;
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.PasswordChar = '\0';
            this.txtCantitate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantitate.SelectedText = "";
            this.txtCantitate.SelectionLength = 0;
            this.txtCantitate.SelectionStart = 0;
            this.txtCantitate.ShortcutsEnabled = true;
            this.txtCantitate.Size = new System.Drawing.Size(250, 30);
            this.txtCantitate.TabIndex = 7;
            this.txtCantitate.UseSelectable = true;
            this.txtCantitate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantitate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbCapsula
            // 
            this.rbCapsula.AutoSize = true;
            this.rbCapsula.Location = new System.Drawing.Point(180, 220);
            this.rbCapsula.Name = "rbCapsula";
            this.rbCapsula.Size = new System.Drawing.Size(92, 24);
            this.rbCapsula.TabIndex = 9;
            this.rbCapsula.Text = "Capsula";
            // 
            // rbInjectie
            // 
            this.rbInjectie.AutoSize = true;
            this.rbInjectie.Location = new System.Drawing.Point(278, 220);
            this.rbInjectie.Name = "rbInjectie";
            this.rbInjectie.Size = new System.Drawing.Size(85, 24);
            this.rbInjectie.TabIndex = 10;
            this.rbInjectie.Text = "Injectie";
            // 
            // rbSirop
            // 
            this.rbSirop.AutoSize = true;
            this.rbSirop.Location = new System.Drawing.Point(369, 220);
            this.rbSirop.Name = "rbSirop";
            this.rbSirop.Size = new System.Drawing.Size(71, 24);
            this.rbSirop.TabIndex = 11;
            this.rbSirop.Text = "Sirop";
            // 
            // rbEfervescent
            // 
            this.rbEfervescent.AutoSize = true;
            this.rbEfervescent.Location = new System.Drawing.Point(180, 250);
            this.rbEfervescent.Name = "rbEfervescent";
            this.rbEfervescent.Size = new System.Drawing.Size(119, 24);
            this.rbEfervescent.TabIndex = 13;
            this.rbEfervescent.TabStop = true;
            this.rbEfervescent.Text = "Efervescent";
            // 
            // rbAntibiotic
            // 
            this.rbAntibiotic.AutoSize = true;
            this.rbAntibiotic.Location = new System.Drawing.Point(305, 250);
            this.rbAntibiotic.Name = "rbAntibiotic";
            this.rbAntibiotic.Size = new System.Drawing.Size(99, 24);
            this.rbAntibiotic.TabIndex = 14;
            this.rbAntibiotic.TabStop = true;
            this.rbAntibiotic.Text = "Antibiotic";
            // 
            // btnModifica
            // 
            this.btnModifica.ActiveControl = null;
            this.btnModifica.BackColor = System.Drawing.Color.HotPink;
            this.btnModifica.ForeColor = System.Drawing.Color.Black;
            this.btnModifica.Location = new System.Drawing.Point(30, 287);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(120, 40);
            this.btnModifica.TabIndex = 12;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModifica.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
            this.btnModifica.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnModifica.UseCustomBackColor = true;
            this.btnModifica.UseCustomForeColor = true;
            this.btnModifica.UseSelectable = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // FormModificaMedicament
            // 
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblProducator);
            this.Controls.Add(this.txtProducator);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.rbCapsula);
            this.Controls.Add(this.rbInjectie);
            this.Controls.Add(this.rbSirop);
            this.Controls.Add(this.rbEfervescent);
            this.Controls.Add(this.rbAntibiotic);
            this.Controls.Add(this.btnModifica);
            this.Name = "FormModificaMedicament";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Load += new System.EventHandler(this.FormModificaMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}