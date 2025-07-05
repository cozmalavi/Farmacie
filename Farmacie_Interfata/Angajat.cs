using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FarmacieModele;

namespace Farmacie_Interfata
{
    public partial class Angajat : MetroFramework.Forms.MetroForm
    {
        private Form mainMenu;
        List<Medicament> listaMedicamente = new List<Medicament>();

        public Angajat(Form meniuPrincipal)
        {
            InitializeComponent();
            mainMenu = meniuPrincipal;
            IncarcaDate();
        }

        private void IncarcaDate()
        {
            if (File.Exists("medicamente.txt"))
            {
                listaMedicamente = File.ReadAllLines("medicamente.txt")
                    .Select(linie => MedicamentFactory.FromFileLine(linie))
                    .Where(m => m != null)
                    .ToList();

                AfiseazaMetroGrid(listaMedicamente);
            }
        }

        private void AfiseazaMetroGrid(List<Medicament> medicamente)
        {
            metroGridMedicamente.DataSource = medicamente.Select(m => new
            {
                m.Tip,
                m.Nume,
                Comerciant = m.Comerciant,
                m.Pret,
                Stoc = m.Stoc
            }).ToList();
        }

        private void mtAdauga_Click(object sender, EventArgs e)
        {
            var form = new FormAdaugaMedicament();
            form.ShowDialog();
            IncarcaDate();
        }

        private void mtModifica_Click(object sender, EventArgs e)
        {
            if (metroGridMedicamente.SelectedRows.Count > 0)
            {
                string nume = metroGridMedicamente.SelectedRows[0].Cells["Nume"].Value.ToString();
                string comerciant = metroGridMedicamente.SelectedRows[0].Cells["Comerciant"].Value.ToString();

                // Încarcă lista
                var medicamente = File.ReadAllLines("medicamente.txt")
                    .Select(l => MedicamentFactory.FromFileLine(l))
                    .Where(m => m != null)
                    .ToList();

                // Caută medicamentul după nume + comerciant
                Medicament deModificat = medicamente.FirstOrDefault(m =>
                    m.Nume == nume && m.Comerciant == comerciant);

                if (deModificat != null)
                {
                    var form = new FormModificaMedicament(deModificat);
                    form.ShowDialog();
                    AfiseazaMedicamente(); // reîncarcă tabelul
                }
            }
            else
            {
                MessageBox.Show("Selectează un medicament din listă.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AfiseazaMedicamente()
        {
            var medicamente = File.ReadAllLines("medicamente.txt")
                .Select(l => MedicamentFactory.FromFileLine(l))
                .Where(m => m != null)
                .ToList();

            metroGridMedicamente.DataSource = null;
            metroGridMedicamente.DataSource = medicamente
                .Select(m => new { m.Tip, m.Nume, m.Comerciant, m.Pret, m.Stoc })
                .ToList();
        }

        private void mtCautare_Click(object sender, EventArgs e)
        {
            var form = new FormCautaMedicament();
            form.ShowDialog();
        }

        private void mtDisponibile_Click(object sender, EventArgs e)
        {
            var disponibile = listaMedicamente.Where(m => m.Stoc > 0).ToList();
            AfiseazaMetroGrid(disponibile);
        }

        private void mtActualizare_Click(object sender, EventArgs e)
        {
            IncarcaDate();
        }

        private void mtSterge_Click(object sender, EventArgs e)
        {
            if (metroGridMedicamente.SelectedRows.Count > 0)
            {
                string nume = metroGridMedicamente.SelectedRows[0].Cells["Nume"].Value.ToString();
                string comerciant = metroGridMedicamente.SelectedRows[0].Cells["Comerciant"].Value.ToString();

                DialogResult confirmare = MessageBox.Show(
                    $"Sigur vrei să ștergi medicamentul '{nume}' de la '{comerciant}'?",
                    "Confirmare ștergere",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmare == DialogResult.Yes)
                {
                    listaMedicamente = listaMedicamente
                        .Where(m => !(m.Nume == nume && m.Comerciant == comerciant))
                        .ToList();

                    File.WriteAllLines("medicamente.txt", listaMedicamente.Select(m => m.ToFileFormat()));
                    IncarcaDate();
                }
            }
            else
            {
                MessageBox.Show("Selectează un medicament din listă.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroButtonInapoi_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }


        private void FormAdministrator_Load(object sender, EventArgs e)
        {

        }

        private void metroGridMedicamente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}