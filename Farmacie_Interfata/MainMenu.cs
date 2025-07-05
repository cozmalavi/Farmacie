using FarmacieUI;
using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Farmacie_Interfata
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mtAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var angajat = new Angajat(this);
            angajat.Show();
        }

        private void mtClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formClient = new Client(this); // Creează instanța pentru client
            formClient.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
