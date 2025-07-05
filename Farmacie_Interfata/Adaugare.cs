using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FarmacieModele;

namespace Farmacie_Interfata
{
    public partial class FormAdaugaMedicament : MetroFramework.Forms.MetroForm
    {
        private const double PRET_MIN = 1;
        private const int STOC_MIN = 1;
        private const int STOC_MAX = 1000;

        public FormAdaugaMedicament()
        {
            InitializeComponent();

            cmbTip.Items.AddRange(new string[] { "Capsula", "Injectie", "Sirop", "Efervescent", "Antibiotic" });
            cmbTip.SelectedIndex = 0;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetEtichete();

            if (!Validare(out string nume, out string comerciant, out double pret, out int stoc, out string tip))
                return;

            Medicament mNou = tip switch
            {
                "Capsula" => new Capsula(nume, comerciant, pret, stoc),
                "Injectie" => new Injectie(nume, comerciant, pret, stoc),
                "Sirop" => new Sirop(nume, comerciant, pret, stoc),
                "Efervescent" => new Efervescent(nume, comerciant, pret, stoc),
                "Antibiotic" => new Antibiotic(nume, comerciant, pret, stoc),
                _ => null
            };

            if (mNou != null)
            {
                File.AppendAllText("medicamente.txt", mNou.ToFileFormat() + Environment.NewLine);
                MessageBox.Show("Medicamentul a fost adaugat!", "Adăugare finalizată!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool Validare(out string nume, out string comerciant, out double pret, out int stoc, out string tip)
        {
            bool ok = true;
            nume = txtNume.Text.Trim();
            comerciant = txtComerciant.Text.Trim();
            tip = cmbTip.SelectedItem?.ToString();
            pret = 0;
            stoc = 0;

            if (string.IsNullOrWhiteSpace(nume))
            {
                SetEroare(txtNume, lblNume);
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(comerciant))
            {
                SetEroare(txtComerciant, lblComerciant);
                ok = false;
            }

            if (!double.TryParse(txtPret.Text, out pret) || pret < PRET_MIN)
            {
                SetEroare(txtPret, lblPret);
                ok = false;
            }

            if (!int.TryParse(txtStoc.Text, out stoc) || stoc < STOC_MIN || stoc > STOC_MAX)
            {
                SetEroare(txtStoc, lblStoc);
                ok = false;
            }

            if (string.IsNullOrWhiteSpace(tip))
            {
                SetEroare(cmbTip, lblTip);
                ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Introdu datele corect.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            lblComerciant.ForeColor = Color.Gold;
            lblPret.ForeColor = Color.Gold;
            lblStoc.ForeColor = Color.Gold;
            lblTip.ForeColor = Color.Gold;

            txtNume.UseCustomBackColor = false;
            txtNume.BackColor = Color.White;

            txtComerciant.UseCustomBackColor = false;
            txtComerciant.BackColor = Color.White;

            txtPret.UseCustomBackColor = false;
            txtPret.BackColor = Color.White;

            txtStoc.UseCustomBackColor = false;
            txtStoc.BackColor = Color.White;

            cmbTip.BackColor = Color.White;
        }

        private void FormAdaugaMedicament_Load(object sender, EventArgs e)
        {
            // Inițializări dacă este necesar
        }
    }
}