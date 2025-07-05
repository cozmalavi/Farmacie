using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmacieModele
{
    public enum TipMedicament { Capsula, Injectie, Sirop, Efervescent, Antibiotic }
    public abstract class Medicament
    {
        public string Tip => this.GetType().Name;
        // proprietati auto-implemented
        public string Nume { get; set; }
        public string Comerciant { get; set; }
        public double Pret { get; set; }
        public int Stoc { get; set; }

        protected Medicament(string nume, string comerciant, double pret, int stoc)
        {
            Nume = nume;
            Comerciant = comerciant;
            Pret = pret;
            Stoc = stoc;
        }

        public override string ToString() =>
            $"Tip: {Tip}, Nume: {Nume}, Comerciant: {Comerciant}, Preț: {Pret:F2} LEI, Stoc: {Stoc} buc";

        public string ToFileFormat() =>
            $"{Tip},{Nume},{Comerciant},{Pret},{Stoc}";
    }
}
