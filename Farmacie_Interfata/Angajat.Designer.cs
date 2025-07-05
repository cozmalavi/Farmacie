using System.Windows.Forms;

namespace Farmacie_Interfata
{
    partial class Angajat
    {
        private MetroFramework.Controls.MetroTile mtAdauga;
        private MetroFramework.Controls.MetroTile mtModifica;
        private MetroFramework.Controls.MetroTile mtCautare;
        private MetroFramework.Controls.MetroTile mtResetLista;
        private MetroFramework.Controls.MetroButton metroButtonInapoi;
        private MetroFramework.Controls.MetroGrid metroGridMedicamente;
        private MetroFramework.Controls.MetroTile mtSterge;
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtAdauga = new MetroFramework.Controls.MetroTile();
            this.mtModifica = new MetroFramework.Controls.MetroTile();
            this.mtCautare = new MetroFramework.Controls.MetroTile();
            this.mtResetLista = new MetroFramework.Controls.MetroTile();
            this.metroButtonInapoi = new MetroFramework.Controls.MetroButton();
            this.metroGridMedicamente = new MetroFramework.Controls.MetroGrid();
            this.mtSterge = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMedicamente)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAdauga
            // 
            this.mtAdauga.ActiveControl = null;
            this.mtAdauga.BackColor = System.Drawing.Color.HotPink;
            this.mtAdauga.ForeColor = System.Drawing.Color.Black;
            this.mtAdauga.Location = new System.Drawing.Point(23, 63);
            this.mtAdauga.Name = "mtAdauga";
            this.mtAdauga.Size = new System.Drawing.Size(139, 40);
            this.mtAdauga.TabIndex = 0;
            this.mtAdauga.Text = "Adaugare";
            this.mtAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdauga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAdauga.UseCustomBackColor = true;
            this.mtAdauga.UseCustomForeColor = true;
            this.mtAdauga.UseSelectable = true;
            this.mtAdauga.Click += new System.EventHandler(this.mtAdauga_Click);
            // 
            // mtModifica
            // 
            this.mtModifica.ActiveControl = null;
            this.mtModifica.BackColor = System.Drawing.Color.HotPink;
            this.mtModifica.ForeColor = System.Drawing.Color.Black;
            this.mtModifica.Location = new System.Drawing.Point(192, 63);
            this.mtModifica.Name = "mtModifica";
            this.mtModifica.Size = new System.Drawing.Size(122, 40);
            this.mtModifica.TabIndex = 1;
            this.mtModifica.Text = "Modificare";
            this.mtModifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtModifica.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtModifica.UseCustomBackColor = true;
            this.mtModifica.UseCustomForeColor = true;
            this.mtModifica.UseSelectable = true;
            this.mtModifica.Click += new System.EventHandler(this.mtModifica_Click);
            // 
            // mtCautare
            // 
            this.mtCautare.ActiveControl = null;
            this.mtCautare.BackColor = System.Drawing.Color.HotPink;
            this.mtCautare.ForeColor = System.Drawing.Color.Black;
            this.mtCautare.Location = new System.Drawing.Point(513, 63);
            this.mtCautare.Name = "mtCautare";
            this.mtCautare.Size = new System.Drawing.Size(114, 40);
            this.mtCautare.TabIndex = 2;
            this.mtCautare.Text = "Cautare";
            this.mtCautare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCautare.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCautare.UseCustomBackColor = true;
            this.mtCautare.UseCustomForeColor = true;
            this.mtCautare.UseSelectable = true;
            this.mtCautare.Click += new System.EventHandler(this.mtCautare_Click);
            // 
            // mtResetLista
            // 
            this.mtResetLista.ActiveControl = null;
            this.mtResetLista.BackColor = System.Drawing.Color.HotPink;
            this.mtResetLista.ForeColor = System.Drawing.Color.Black;
            this.mtResetLista.Location = new System.Drawing.Point(351, 63);
            this.mtResetLista.Name = "mtResetLista";
            this.mtResetLista.Size = new System.Drawing.Size(122, 40);
            this.mtResetLista.TabIndex = 4;
            this.mtResetLista.Text = "Actualizare";
            this.mtResetLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtResetLista.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtResetLista.UseCustomBackColor = true;
            this.mtResetLista.UseCustomForeColor = true;
            this.mtResetLista.UseSelectable = true;
            this.mtResetLista.Click += new System.EventHandler(this.mtActualizare_Click);
            // 
            // metroButtonInapoi
            // 
            this.metroButtonInapoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.metroButtonInapoi.ForeColor = System.Drawing.Color.White;
            this.metroButtonInapoi.Location = new System.Drawing.Point(847, 523);
            this.metroButtonInapoi.Name = "metroButtonInapoi";
            this.metroButtonInapoi.Size = new System.Drawing.Size(126, 35);
            this.metroButtonInapoi.TabIndex = 6;
            this.metroButtonInapoi.Text = "Iesire";
            this.metroButtonInapoi.UseCustomBackColor = true;
            this.metroButtonInapoi.UseSelectable = true;
            this.metroButtonInapoi.Click += new System.EventHandler(this.metroButtonInapoi_Click);
            // 
            // metroGridMedicamente
            // 
            this.metroGridMedicamente.AllowUserToAddRows = false;
            this.metroGridMedicamente.AllowUserToResizeRows = false;
            this.metroGridMedicamente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGridMedicamente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.metroGridMedicamente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridMedicamente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridMedicamente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMedicamente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridMedicamente.ColumnHeadersHeight = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMedicamente.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridMedicamente.EnableHeadersVisualStyles = false;
            this.metroGridMedicamente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.metroGridMedicamente.GridColor = System.Drawing.Color.HotPink;
            this.metroGridMedicamente.Location = new System.Drawing.Point(23, 121);
            this.metroGridMedicamente.Name = "metroGridMedicamente";
            this.metroGridMedicamente.ReadOnly = true;
            this.metroGridMedicamente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMedicamente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridMedicamente.RowHeadersWidth = 62;
            this.metroGridMedicamente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMedicamente.RowTemplate.Height = 35;
            this.metroGridMedicamente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMedicamente.Size = new System.Drawing.Size(765, 400);
            this.metroGridMedicamente.TabIndex = 7;
            // 
            // mtSterge
            // 
            this.mtSterge.ActiveControl = null;
            this.mtSterge.BackColor = System.Drawing.Color.HotPink;
            this.mtSterge.ForeColor = System.Drawing.Color.Black;
            this.mtSterge.Location = new System.Drawing.Point(675, 63);
            this.mtSterge.Name = "mtSterge";
            this.mtSterge.Size = new System.Drawing.Size(113, 40);
            this.mtSterge.TabIndex = 8;
            this.mtSterge.Text = "Ștergere";
            this.mtSterge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSterge.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSterge.UseCustomBackColor = true;
            this.mtSterge.UseCustomForeColor = true;
            this.mtSterge.UseSelectable = true;
            this.mtSterge.Click += new System.EventHandler(this.mtSterge_Click);
            // 
            // Angajat
            // 
            this.ClientSize = new System.Drawing.Size(1009, 600);
            this.Controls.Add(this.mtAdauga);
            this.Controls.Add(this.mtModifica);
            this.Controls.Add(this.mtCautare);
            this.Controls.Add(this.mtResetLista);
            this.Controls.Add(this.metroButtonInapoi);
            this.Controls.Add(this.metroGridMedicamente);
            this.Controls.Add(this.mtSterge);
            this.Name = "Angajat";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Load += new System.EventHandler(this.FormAdministrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridMedicamente)).EndInit();
            this.ResumeLayout(false);

        }

    }
}