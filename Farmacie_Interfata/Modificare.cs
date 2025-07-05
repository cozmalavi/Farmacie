using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FarmacieModele;

namespace Farmacie_Interfata
{
    public partial class FormModificaMedicament : MetroFramework.Forms.MetroForm
    {
        private Medicament medicamentOriginal;
        private List<Medicament> listaMedicamente;

        public FormModificaMedicament(Medicament medicament)
        {
            InitializeComponent();
            medicamentOriginal = medicament;

            // Încarcă lista
            listaMedicamente = File.ReadAllLines("medicamente.txt")
                .Select(l => MedicamentFactory.FromFileLine(l))
                .Where(m => m != null)
                .ToList();

            IncarcaDate();
        }

        private void IncarcaDate()
        {
            if (medicamentOriginal != null)
            {
                txtNume.Text = medicamentOriginal.Nume;
                txtProducator.Text = medicamentOriginal.Comerciant;
                txtPret.Text = medicamentOriginal.Pret.ToString();
                txtCantitate.Text = medicamentOriginal.Stoc.ToString();

                switch (medicamentOriginal.Tip.ToLower())
                {
                    case "capsula":
                        rbCapsula.Checked = true;
                        break;
                    case "injectie":
                        rbInjectie.Checked = true;
                        break;
                    case "sirop":
                        rbSirop.Checked = true;
                        break;
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            ResetEtichete();

            if (!Validare(out string nume, out string producator, out double pret, out int cantitate, out string tip))
                return;

            int index = listaMedicamente.FindIndex(m =>
                m.Nume == medicamentOriginal.Nume &&
                m.Comerciant == medicamentOriginal.Comerciant);

            if (index >= 0)
            {
                Medicament mNou = tip switch
                {
                    "Capsula" => new Capsula(nume, producator, pret, cantitate),
                    "Injectie" => new Injectie(nume, producator, pret, cantitate),
                    "Sirop" => new Sirop(nume, producator, pret, cantitate),
                    _ => null
                };

                if (mNou != null)
                {
                    listaMedicamente[index] = mNou;

                    File.WriteAllLines("medicamente.txt", listaMedicamente.Select(m => m.ToFileFormat()));
                    MessageBox.Show("Modificare realizată cu succes!", "Modificare reușită!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Medicamentul nu a fost găsit pentru modificare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedTip()
        {
            if (rbCapsula.Checked) return "Capsula";
            if (rbInjectie.Checked) return "Injectie";
            if (rbSirop.Checked) return "Sirop";
            if (rbEfervescent.Checked) return "Efervescent";
            if (rbAntibiotic.Checked) return "Antibiotic";
            return "";
        }

        private bool Validare(out string nume, out string producator, out double pret, out int cantitate, out string tip)
        {
            const double PRET_MIN = 0.01;
            const int CANT_MIN = 1;
            const int CANT_MAX = 1000;

            bool ok = true;
            nume = txtNume.Text.Trim();
            producator = txtProducator.Text.Trim();
            tip = GetSelectedTip();
            pret = 0;
            cantitate = 0;

            if (string.IsNullOrWhiteSpace(nume))
            {
                SetEroare(txtNume, lblNume);
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(producator))
            {
                SetEroare(txtProducator, lblProducator);
                ok = false;
            }

            if (!double.TryParse(txtPret.Text, out pret) || pret < PRET_MIN)
            {
                SetEroare(txtPret, lblPret);
                ok = false;
            }

            if (!int.TryParse(txtCantitate.Text, out cantitate) || cantitate < CANT_MIN || cantitate > CANT_MAX)
            {
                SetEroare(txtCantitate, lblCantitate);
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(tip))
            {
                lblTip.ForeColor = Color.Red;
                rbCapsula.ForeColor = Color.Red;
                rbInjectie.ForeColor = Color.Red;
                rbSirop.ForeColor = Color.Red;
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Completează toate câmpurile corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ok;
        }

        private void SetEroare(Control control, Label label)
        {
            label.ForeColor = Color.Red;

            if (control is MetroFramework.Controls.MetroTextBox txt)
            {
                txt.UseCustomBackColor = true;
                txt.UseStyleColors = false;
                txt.BackColor = Color.Tomato;
            }
            else if (control is ComboBox cb)
            {
                cb.BackColor = Color.Tomato;
            }
        }

        private void ResetEtichete()
        {
            lblNume.ForeColor = Color.Gold;
            lblProducator.ForeColor = Color.Gold;
            lblPret.ForeColor = Color.Gold;
            lblCantitate.ForeColor = Color.Gold;
            lblTip.ForeColor = Color.Gold;

            txtNume.UseCustomBackColor = false;
            txtNume.BackColor = Color.White;

            txtProducator.UseCustomBackColor = false;
            txtProducator.BackColor = Color.White;

            txtPret.UseCustomBackColor = false;
            txtPret.BackColor = Color.White;

            txtCantitate.UseCustomBackColor = false;
            txtCantitate.BackColor = Color.White;
        }

        private void FormModificaMedicament_Load(object sender, EventArgs e)
        {
        }
    }
}