using FarmacieModele;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FarmacieUI
{
    public partial class ClientModificaProdusCos : MetroFramework.Forms.MetroForm
    {
        private Medicament produs;
        private Action<int> onModificat;

        public ClientModificaProdusCos(Medicament produsSelectat, Action<int> callback)
        {
            InitializeComponent();
            produs = produsSelectat;
            onModificat = callback;

            lblProdus.Text = $"{produs.Nume} - {produs.Tip}";
            txtCantitate.Text = produs.Stoc.ToString();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantitate.Text.Trim(), out int nouaCantitate) || nouaCantitate < 1)
            {
                MessageBox.Show("Introdu o cantitate validă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            onModificat?.Invoke(nouaCantitate);
            this.Close();
        }

    }
}
