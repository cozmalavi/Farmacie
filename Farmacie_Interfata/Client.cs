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

    public partial class Client: Form
    {
        private Form mainMenu;
        List<Medicament> listaMedicamente = new List<Medicament>();
        List<Medicament> cosCumparaturi = new List<Medicament>();

        public Client(Form menu)
        {
            InitializeComponent();
            this.mainMenu = menu;
            IncarcaDate();
        }

        private void IncarcaDate()
        {
            if (File.Exists("medicamente.txt"))
            {
                listaMedicamente = File.ReadAllLines("medicamente.txt")
                    .Select(l => MedicamentFactory.FromFileLine(l))
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
                m.Comerciant,
                m.Pret,
                Stoc = m.Stoc
            }).ToList();
        }

        private void mtCauta_Click(object sender, EventArgs e)
        {
            var form = new ClientCauta((medicamentSelectat) =>
            {
                if (medicamentSelectat != null)
                {
                    // Creează o copie cu cantitate = 1
                    var medicamentInCos = MedicamentFactory.Create(medicamentSelectat.Tip, medicamentSelectat.Nume, medicamentSelectat.Comerciant, medicamentSelectat.Pret, 1);

                    cosCumparaturi.Add(medicamentInCos);
                    MessageBox.Show("Medicament adăugat în coș!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });

            form.ShowDialog();
        }

        private void mtCos_Click(object sender, EventArgs e)
        {
            if (cosCumparaturi.Count == 0)
            {
                MessageBox.Show("Coșul este gol.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var form = new ClientCos(cosCumparaturi);
            form.FormClosed += (s, args) => IncarcaDate();
            form.ShowDialog();
        }

        private void metroButtonInapoi_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }
    }
}
