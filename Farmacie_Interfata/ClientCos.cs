using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FarmacieModele;

namespace FarmacieUI
{
    public partial class ClientCos : MetroFramework.Forms.MetroForm
    {
        private List<Medicament> cosMedicamente;

        public ClientCos(List<Medicament> cos)
        {
            InitializeComponent();
            this.cosMedicamente = cos;
            AfiseazaCos();
        }

        private void AfiseazaCos()
        {
            gridCos.DataSource = null;
            gridCos.DataSource = cosMedicamente.Select(m => new
            {
                m.Nume,
                m.Tip,
                m.Comerciant,
                m.Pret,
                Cantitate = m.Stoc,
                Total = m.Pret * m.Stoc
            }).ToList();
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            // Update stocuri in fisierul principal
            if (System.IO.File.Exists("medicamente.txt"))
            {
                var toateMedicamentele = System.IO.File.ReadAllLines("medicamente.txt")
                    .Select(l => MedicamentFactory.FromFileLine(l))
                    .Where(m => m != null)
                    .ToList();

                foreach (var cumparat in cosMedicamente)
                {
                    var gasit = toateMedicamentele.FirstOrDefault(m => m.Nume == cumparat.Nume && m.Comerciant == cumparat.Comerciant);
                    if (gasit != null && gasit.Stoc >= cumparat.Stoc)
                    {
                        gasit.Stoc -= cumparat.Stoc;
                    }
                }

                System.IO.File.WriteAllLines("medicamente.txt", toateMedicamentele.Select(m => m.ToFileFormat()));
            }

            MessageBox.Show("Cumpărăturile au fost finalizate cu succes!", "Mulțumim!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cosMedicamente.Clear();
            this.Close();
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (gridCos.SelectedRows.Count > 0)
            {
                string nume = gridCos.SelectedRows[0].Cells["Nume"].Value.ToString();
                string producator = gridCos.SelectedRows[0].Cells["Comerciant"].Value.ToString();

                Medicament deModificat = cosMedicamente.FirstOrDefault(m =>
                    m.Nume == nume && m.Comerciant == producator);

                if (deModificat != null)
                {
                    var form = new ClientModificaProdusCos(deModificat, (cantitateNoua) =>
                    {
                        deModificat.Stoc = cantitateNoua;
                        AfiseazaCos(); // Actualizează grila
                    });
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selectează un medicament din coș pentru editare.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormClientCos_Load(object sender, EventArgs e)
        {
            AfiseazaCos();
        }
    }
}
