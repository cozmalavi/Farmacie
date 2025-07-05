using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmacieModele
{
    public class Antibiotic : Medicament
    {
        public Antibiotic(string nume, string comerciant, double pret, int stoc)
            : base(nume, comerciant, pret, stoc) { }
    }
}
