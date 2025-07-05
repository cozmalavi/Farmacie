using System.Windows.Forms;

namespace FarmacieUI
{
    partial class Client
    {
        private MetroFramework.Controls.MetroTile mtCautare;
        private MetroFramework.Controls.MetroTile mtCos;
        private MetroFramework.Controls.MetroButton metroButtonInapoi;
        private MetroFramework.Controls.MetroGrid metroGridMedicamente;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtCautare = new MetroFramework.Controls.MetroTile();
            this.mtCos = new MetroFramework.Controls.MetroTile();
            this.metroButtonInapoi = new MetroFramework.Controls.MetroButton();
            this.metroGridMedicamente = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMedicamente)).BeginInit();
            this.SuspendLayout();
            // 
            // mtCautare
            // 
            this.mtCautare.ActiveControl = null;
            this.mtCautare.BackColor = System.Drawing.Color.HotPink;
            this.mtCautare.ForeColor = System.Drawing.Color.Black;
            this.mtCautare.Location = new System.Drawing.Point(716, 55);
            this.mtCautare.Name = "mtCautare";
            this.mtCautare.Size = new System.Drawing.Size(198, 41);
            this.mtCautare.TabIndex = 0;
            this.mtCautare.Text = "Cautare";
            this.mtCautare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCautare.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCautare.UseCustomBackColor = true;
            this.mtCautare.UseCustomForeColor = true;
            this.mtCautare.UseSelectable = true;
            this.mtCautare.Click += new System.EventHandler(this.mtCauta_Click);
            // 
            // mtCos
            // 
            this.mtCos.ActiveControl = null;
            this.mtCos.BackColor = System.Drawing.Color.HotPink;
            this.mtCos.ForeColor = System.Drawing.Color.Black;
            this.mtCos.Location = new System.Drawing.Point(716, 124);
            this.mtCos.Name = "mtCos";
            this.mtCos.Size = new System.Drawing.Size(198, 40);
            this.mtCos.TabIndex = 2;
            this.mtCos.Text = "Finalizeaza cumparaturile";
            this.mtCos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCos.UseCustomBackColor = true;
            this.mtCos.UseCustomForeColor = true;
            this.mtCos.UseSelectable = true;
            this.mtCos.Click += new System.EventHandler(this.mtCos_Click);
            // 
            // metroButtonInapoi
            // 
            this.metroButtonInapoi.BackColor = System.Drawing.Color.HotPink;
            this.metroButtonInapoi.ForeColor = System.Drawing.Color.Black;
            this.metroButtonInapoi.Location = new System.Drawing.Point(12, 24);
            this.metroButtonInapoi.Name = "metroButtonInapoi";
            this.metroButtonInapoi.Size = new System.Drawing.Size(75, 30);
            this.metroButtonInapoi.TabIndex = 3;
            this.metroButtonInapoi.Text = "Înapoi";
            this.metroButtonInapoi.UseCustomBackColor = true;
            this.metroButtonInapoi.UseCustomForeColor = true;
            this.metroButtonInapoi.UseSelectable = true;
            this.metroButtonInapoi.Click += new System.EventHandler(this.metroButtonInapoi_Click);
            // 
            // metroGridMedicamente
            // 
            this.metroGridMedicamente.AllowUserToAddRows = false;
            this.metroGridMedicamente.AllowUserToResizeRows = false;
            this.metroGridMedicamente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.metroGridMedicamente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridMedicamente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridMedicamente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMedicamente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMedicamente.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridMedicamente.EnableHeadersVisualStyles = false;
            this.metroGridMedicamente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.metroGridMedicamente.GridColor = System.Drawing.Color.HotPink;
            this.metroGridMedicamente.Location = new System.Drawing.Point(131, 33);
            this.metroGridMedicamente.Name = "metroGridMedicamente";
            this.metroGridMedicamente.ReadOnly = true;
            this.metroGridMedicamente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMedicamente.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridMedicamente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMedicamente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMedicamente.Size = new System.Drawing.Size(542, 382);
            this.metroGridMedicamente.TabIndex = 4;
            // 
            // Client
            // 
            this.ClientSize = new System.Drawing.Size(963, 451);
            this.Controls.Add(this.mtCautare);
            this.Controls.Add(this.mtCos);
            this.Controls.Add(this.metroButtonInapoi);
            this.Controls.Add(this.metroGridMedicamente);
            this.Name = "Client";
            this.Text = "Client - Vizualizare și Cumpărare";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMedicamente)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
