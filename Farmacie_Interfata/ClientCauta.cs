using FarmacieModele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmacieUI
{
    public partial class ClientCauta: Form
    {

        private List<Medicament> listaMedicamente;
        private readonly Action<Medicament> callback;

        public ClientCauta(Action<Medicament> callback)
        {
            InitializeComponent();
            this.callback = callback;

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

        private void FormCautaMedicament_Load(object sender, EventArgs e)
        {
            gridRezultate.DataSource = null;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim().ToLower();
            string tip = txtTip.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(nume) && string.IsNullOrWhiteSpace(tip))
            {
                MessageBox.Show("Introdu cel puțin un criteriu de căutare.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rezultate = listaMedicamente.Where(m =>
                (!string.IsNullOrWhiteSpace(nume) && m.Nume.ToLower().Contains(nume)) ||
                (!string.IsNullOrWhiteSpace(tip) && m.Tip.ToLower().Equals(tip))
            ).ToList();

            if (rezultate.Count == 0)
            {
                MessageBox.Show("Nu s-au găsit medicamente.", "Rezultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridRezultate.DataSource = null;
                return;
            }

            gridRezultate.DataSource = null;
            gridRezultate.DataSource = rezultate.Select(m => new
            {
                m.Tip,
                m.Nume,
                Producator = m.Comerciant,
                m.Pret,
                Cantiate = m.Stoc
            }).ToList();
        }

        private void btnAdaugaInCos_Click(object sender, EventArgs e)
        {
            if (gridRezultate.SelectedRows.Count > 0)
            {
                string nume = gridRezultate.SelectedRows[0].Cells["Nume"].Value.ToString();
                string producator = gridRezultate.SelectedRows[0].Cells["Producator"].Value.ToString();

                var medicament = listaMedicamente.FirstOrDefault(m =>
                    m.Nume == nume && m.Comerciant == producator);

                if (medicament != null && medicament.Stoc > 0)
                {
                    callback?.Invoke(medicament); // trimite către FormClient
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Medicamentul selectat nu este disponibil.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selectează un medicament din listă.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClientCauta_Load(object sender, EventArgs e)
        {

        }
    }
}
