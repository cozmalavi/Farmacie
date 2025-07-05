using System;
using System.Drawing;
using System.Windows.Forms;

namespace FarmacieUI
{
    partial class ClientCos
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView gridCos;
        private MetroFramework.Controls.MetroTile btnFinalizeaza;
        private MetroFramework.Controls.MetroTile btnEditeaza;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.gridCos = new System.Windows.Forms.DataGridView();
            this.btnFinalizeaza = new MetroFramework.Controls.MetroTile();
            this.btnEditeaza = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.gridCos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCos
            // 
            this.gridCos.AllowUserToAddRows = false;
            this.gridCos.AllowUserToDeleteRows = false;
            this.gridCos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCos.BackgroundColor = System.Drawing.Color.Pink;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.HotPink;
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = SystemColors.Highlight;
            headerStyle.SelectionForeColor = SystemColors.HighlightText;
            headerStyle.WrapMode = DataGridViewTriState.True;
            this.gridCos.ColumnHeadersDefaultCellStyle = headerStyle;
            this.gridCos.ColumnHeadersHeight = 34;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.MistyRose;
            cellStyle.Font = new Font("Segoe UI", 10F);
            cellStyle.ForeColor = SystemColors.ControlText;
            cellStyle.SelectionBackColor = Color.DeepPink;
            cellStyle.SelectionForeColor = Color.White;
            cellStyle.WrapMode = DataGridViewTriState.False;
            this.gridCos.DefaultCellStyle = cellStyle;

            this.gridCos.EnableHeadersVisualStyles = false;
            this.gridCos.GridColor = Color.DeepPink;
            this.gridCos.Location = new Point(54, 146); 
            this.gridCos.Name = "gridCos";
            this.gridCos.ReadOnly = true;
            this.gridCos.RowHeadersWidth = 62;
            this.gridCos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridCos.Size = new Size(555, 244); 
            this.gridCos.TabIndex = 0;

            // 
            // btnFinalizeaza
            // 
            this.btnFinalizeaza.ActiveControl = null;
            this.btnFinalizeaza.BackColor = System.Drawing.Color.HotPink;
            this.btnFinalizeaza.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizeaza.Location = new System.Drawing.Point(633, 282);
            this.btnFinalizeaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalizeaza.Name = "btnFinalizeaza";
            this.btnFinalizeaza.Size = new System.Drawing.Size(221, 41);
            this.btnFinalizeaza.TabIndex = 1;
            this.btnFinalizeaza.Text = "Finalizează Cumpărăturile";
            this.btnFinalizeaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinalizeaza.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnFinalizeaza.UseCustomBackColor = true;
            this.btnFinalizeaza.UseCustomForeColor = true;
            this.btnFinalizeaza.UseSelectable = true;
            this.btnFinalizeaza.Click += new System.EventHandler(this.btnCumpara_Click);
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.ActiveControl = null;
            this.btnEditeaza.BackColor = System.Drawing.Color.HotPink;
            this.btnEditeaza.ForeColor = System.Drawing.Color.Black;
            this.btnEditeaza.Location = new System.Drawing.Point(633, 225);
            this.btnEditeaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(221, 41);
            this.btnEditeaza.TabIndex = 2;
            this.btnEditeaza.Text = "Editează produs";
            this.btnEditeaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditeaza.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnEditeaza.UseCustomBackColor = true;
            this.btnEditeaza.UseCustomForeColor = true;
            this.btnEditeaza.UseSelectable = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // ClientCos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 511);
            this.Controls.Add(this.gridCos);
            this.Controls.Add(this.btnFinalizeaza);
            this.Controls.Add(this.btnEditeaza);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientCos";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Coșul de cumpărături";
            this.Load += new System.EventHandler(this.FormClientCos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCos)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
