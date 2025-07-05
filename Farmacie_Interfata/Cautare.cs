using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FarmacieModele;

namespace Farmacie_Interfata
{
    public partial class FormCautaMedicament : MetroFramework.Forms.MetroForm
    {
        private List<Medicament> listaMedicamente;

        public FormCautaMedicament()
        {
            InitializeComponent();

            if (File.Exists("medicamente.txt"))
            {
                listaMedicamente = File.ReadAllLines("medicamente.txt")
                    .Select(l => MedicamentFactory.FromFileLine(l))
                    .Where(m => m != null)
                    .ToList();
            }
            else
            {
                listaMedicamente = new List<Medicament>();
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim().ToLower();
            string tip = txtTip.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(nume) && string.IsNullOrWhiteSpace(tip))
            {
                MessageBox.Show("Foloseste una din cele doua metode de cautare.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rezultate = listaMedicamente.Where(m =>
                (!string.IsNullOrWhiteSpace(nume) && m.Nume.ToLower().Contains(nume)) ||
                (!string.IsNullOrWhiteSpace(tip) && m.Tip.ToLower().Equals(tip))
            ).ToList();

            if (rezultate.Count == 0)
            {
                MessageBox.Show("Nu exista acest medicament.", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridRezultate.DataSource = null;
                return;
            }

            gridRezultate.DataSource = null;
            gridRezultate.DataSource = rezultate.Select(m => new
            {
                m.Tip,
                m.Nume,
                m.Comerciant,
                m.Pret,
                m.Stoc
            }).ToList();
        }

        private void FormCautaMedicament_Load(object sender, EventArgs e)
        {
            gridRezultate.DataSource = null;
        }

        private void gridRezultate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTip_Click(object sender, EventArgs e)
        {

        }

        private void lblNume_Click(object sender, EventArgs e)
        {

        }
    }
}