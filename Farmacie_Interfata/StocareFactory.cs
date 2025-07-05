using System;

namespace FarmacieModele
{
    public static class MedicamentFactory
    {
        public static Medicament FromFileLine(string linie)
        {
            var tokens = linie.Split(',');
            if (tokens.Length != 5) return null;

            string tip = tokens[0].ToLower();
            string nume = tokens[1];
            string comerciant = tokens[2];

            if (!double.TryParse(tokens[3], out double pret)) return null;
            if (!int.TryParse(tokens[4], out int stoc)) return null;

            return tip switch
            {
                "capsula" => new Capsula(nume, comerciant, pret, stoc),
                "injectie" => new Injectie(nume, comerciant, pret, stoc),
                "sirop" => new Sirop(nume, comerciant, pret, stoc),
                "efervescent" => new Efervescent(nume, comerciant, pret, stoc),
                "antibiotic" => new Antibiotic(nume, comerciant, pret, stoc),
                _ => null
            };
        }

        public static Medicament Create(string tip, string nume, string comerciant, double pret, int stoc)
        {
            tip = tip.ToLower();
            return tip switch
            {
                "capsula" => new Capsula(nume, comerciant, pret, stoc),
                "injectie" => new Injectie(nume, comerciant, pret, stoc),
                "sirop" => new Sirop(nume, comerciant, pret, stoc),
                "efervescent" => new Efervescent(nume, comerciant, pret, stoc),
                "antibiotic" => new Antibiotic(nume, comerciant, pret, stoc),
                _ => null
            };
        }
    }
}
