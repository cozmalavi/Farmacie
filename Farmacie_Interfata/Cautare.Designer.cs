using System.Windows.Forms;

namespace Farmacie_Interfata
{
    partial class FormCautaMedicament
    {
        private System.ComponentModel.IContainer components = null;

        private MetroFramework.Controls.MetroLabel lblNume;
        private MetroFramework.Controls.MetroLabel lblTip;
        private MetroFramework.Controls.MetroTextBox txtNume;
        private MetroFramework.Controls.MetroTextBox txtTip;
        private MetroFramework.Controls.MetroTile btnCauta;
        private System.Windows.Forms.DataGridView gridRezultate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNume = new MetroFramework.Controls.MetroLabel();
            this.lblTip = new MetroFramework.Controls.MetroLabel();
            this.txtNume = new MetroFramework.Controls.MetroTextBox();
            this.txtTip = new MetroFramework.Controls.MetroTextBox();
            this.gridRezultate = new System.Windows.Forms.DataGridView();
            this.btnCauta = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.ForeColor = System.Drawing.Color.Gold;
            this.lblNume.Location = new System.Drawing.Point(30, 60);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(195, 19);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Introdu numele medicamentului";
            this.lblNume.Click += new System.EventHandler(this.lblNume_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Gold;
            this.lblTip.Location = new System.Drawing.Point(30, 100);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(177, 19);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Introdu tipul medicamentului";
            this.lblTip.Click += new System.EventHandler(this.lblTip_Click);
            // 
            // txtNume
            // 
            // 
            // 
            // 
            this.txtNume.CustomButton.Image = null;
            this.txtNume.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.txtNume.CustomButton.Name = "";
            this.txtNume.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNume.CustomButton.TabIndex = 1;
            this.txtNume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNume.CustomButton.UseSelectable = true;
            this.txtNume.CustomButton.Visible = false;
            this.txtNume.Lines = new string[0];
            this.txtNume.Location = new System.Drawing.Point(259, 63);
            this.txtNume.MaxLength = 32767;
            this.txtNume.Name = "txtNume";
            this.txtNume.PasswordChar = '\0';
            this.txtNume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNume.SelectedText = "";
            this.txtNume.SelectionLength = 0;
            this.txtNume.SelectionStart = 0;
            this.txtNume.ShortcutsEnabled = true;
            this.txtNume.Size = new System.Drawing.Size(291, 23);
            this.txtNume.TabIndex = 1;
            this.txtNume.UseSelectable = true;
            this.txtNume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTip
            // 
            // 
            // 
            // 
            this.txtTip.CustomButton.Image = null;
            this.txtTip.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.txtTip.CustomButton.Name = "";
            this.txtTip.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTip.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTip.CustomButton.TabIndex = 1;
            this.txtTip.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTip.CustomButton.UseSelectable = true;
            this.txtTip.CustomButton.Visible = false;
            this.txtTip.Lines = new string[0];
            this.txtTip.Location = new System.Drawing.Point(259, 100);
            this.txtTip.MaxLength = 32767;
            this.txtTip.Name = "txtTip";
            this.txtTip.PasswordChar = '\0';
            this.txtTip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTip.SelectedText = "";
            this.txtTip.SelectionLength = 0;
            this.txtTip.SelectionStart = 0;
            this.txtTip.ShortcutsEnabled = true;
            this.txtTip.Size = new System.Drawing.Size(291, 23);
            this.txtTip.TabIndex = 3;
            this.txtTip.UseSelectable = true;
            this.txtTip.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTip.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gridRezultate
            // 
            this.gridRezultate.AllowUserToAddRows = false;
            this.gridRezultate.AllowUserToDeleteRows = false;
            this.gridRezultate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridRezultate.BackgroundColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridRezultate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridRezultate.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridRezultate.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridRezultate.EnableHeadersVisualStyles = false;
            this.gridRezultate.GridColor = System.Drawing.Color.DeepPink;
            this.gridRezultate.Location = new System.Drawing.Point(23, 161);
            this.gridRezultate.Name = "gridRezultate";
            this.gridRezultate.ReadOnly = true;
            this.gridRezultate.RowHeadersWidth = 62;
            this.gridRezultate.Size = new System.Drawing.Size(823, 310);
            this.gridRezultate.TabIndex = 5;
            this.gridRezultate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRezultate_CellContentClick);
            // 
            // btnCauta
            // 
            this.btnCauta.ActiveControl = null;
            this.btnCauta.BackColor = System.Drawing.Color.HotPink;
            this.btnCauta.ForeColor = System.Drawing.Color.Black;
            this.btnCauta.Location = new System.Drawing.Point(378, 504);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(143, 43);
            this.btnCauta.Text = "Caută";
            this.btnCauta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCauta.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
            this.btnCauta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnCauta.UseCustomBackColor = true;
            this.btnCauta.UseCustomForeColor = true;
            this.btnCauta.UseSelectable = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // FormCautaMedicament
            // 
            this.ClientSize = new System.Drawing.Size(914, 612);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.gridRezultate);
            this.Name = "FormCautaMedicament";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Load += new System.EventHandler(this.FormCautaMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRezultate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}