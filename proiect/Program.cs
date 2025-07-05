using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FarmacieModele;

namespace proiect
{
    class Program
    {
        // Tablou in scara
        static Medicament[] medicamente = new Medicament[100];
        static int index = 0;

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int optiune;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------- FARMACIE ------------------");
                Console.WriteLine("1. Angajat");
                Console.WriteLine("2. Client");
                Console.WriteLine("0. Ieșire");
                Console.Write("Alegeți o optiune: ");
                optiune = int.Parse(Console.ReadLine());

                switch (optiune)
                {
                    case 1:
                        Angajat();
                        break;
                    case 2:
                        Client();
                        break;
                }

            } while (optiune != 0);
        }

        static void Angajat()
        {
            Console.Clear();
            Console.WriteLine("Angajat");
            Console.Write("Introduceți parola: ");
            int parola = int.Parse(Console.ReadLine());

            if (parola != 0000)
            {
                Console.WriteLine("Parolă greșită!");
                Console.ReadKey();
                return;
            }

            int opt;
            do
            {
                Console.Clear();
                Console.WriteLine("--- ANGAJAT ---");
                Console.WriteLine("1. Introdu medicament nou");
                Console.WriteLine("2. Afișează medicamente");
                Console.WriteLine("0. Înapoi");
                Console.Write("Alegere: ");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1: AdaugaMedicament(); break;
                    case 2: AfiseazaMedicamenteDinFisier(); break;
                }

            } while (opt != 0);
        }

        static void Client()
        {
            List<Medicament> cos = new List<Medicament>();
            int opt;
            do
            {
                Console.Clear();
                Console.WriteLine("--- CLIENT ---");
                Console.WriteLine("1. Caută medicament");
                Console.WriteLine("2. Finalizează cumpărăturile");
                Console.WriteLine("0. Înapoi");
                Console.Write("Alegere: ");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.Write("Denumire: ");
                        string nume = Console.ReadLine().ToLower();

                        Console.WriteLine("Tip medicament:");
                        Console.WriteLine("1. Capsula");
                        Console.WriteLine("2. Injectie");
                        Console.WriteLine("3. Sirop");
                        Console.WriteLine("4. Efervescent");
                        Console.WriteLine("5. Antibiotic");
                        Console.Write("Alege tipul: ");
                        int tipOpt = int.Parse(Console.ReadLine());

                        string tip = "";
                        if (tipOpt == 1) tip = "capsula";
                        else if (tipOpt == 2) tip = "injectie";
                        else if(tipOpt == 3) tip = "sirop";
                        else if(tipOpt == 4) tip = "efervescent";
                        else if(tipOpt == 5) tip = "antibiotic";
         

                        bool gasit = false;
                        // cautare fisier
                        List<string> toateLiniile = new List<string>(File.ReadAllLines("medicamente.txt"));
                        for (int i = 0; i < toateLiniile.Count; i++)
                        {
                            string linie = toateLiniile[i];
                            string[] v = linie.Split(',');
                            if (v.Length == 5)
                            {
                                string tipMed = v[0].ToLower();
                                string numeMed = v[1].ToLower();

                                if (tipMed == tip && numeMed.Contains(nume))
                                {
                                    gasit = true;
                                    double pret = double.Parse(v[3]);
                                    int cantitate = int.Parse(v[4]);

                                    Console.WriteLine($"Medicament găsit:");
                                    Console.WriteLine($"Tip: {v[0]}, Nume: {v[1]}, Comerciant: {v[2]}, Preț: {pret:F2} LEI, Cantitate: {cantitate} buc");

                                    if (cantitate == 0)
                                    {
                                        Console.WriteLine("Stoc epuizat.");
                                        break;
                                    }

                                    Console.Write("Doriți să adăugați în coș? (y/n): ");
                                    string raspuns = Console.ReadLine().ToLower();

                                    if (raspuns == "y")
                                    {
                                        Medicament med = null;
                                        if (tip == "capsula") med = new Capsula(v[1], v[2], pret, 1);
                                        else if (tip == "injectie") med = new Injectie(v[1], v[2], pret, 1);
                                        else if (tip == "sirop") med = new Sirop(v[1], v[2], pret, 1);
                                        else if (tip == "efervescent") med = new Efervescent(v[1], v[2], pret, 1);
                                        else if (tip == "antibiotic") med = new Antibiotic(v[1], v[2], pret, 1);

                                        if (med != null)
                                        {
                                            cos.Add(med);
                                            cantitate -= 1;
                                            toateLiniile[i] = $"{v[0]},{v[1]},{v[2]},{v[3]},{cantitate}";
                                            File.WriteAllLines("medicamente.txt", toateLiniile);

                                            Console.WriteLine("Produsul a fost adăugat în coș.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Medicamentul nu a putut fi adăugat in coș. Stoc epuizat!");
                                    }

                                    break;
                                }
                            }
                        }

                        if (!gasit)
                        {
                            Console.WriteLine("Medicamentul nu a fost găsit.");
                        }

                        Console.ReadKey();
                        break;

                    case 2:
                        double total = 0;
                        Console.Clear();
                        Console.WriteLine("=== Chitanță ===");
                        foreach (var m in cos)
                        {
                            Console.WriteLine(m);
                            total += m.Pret;
                        }
                        Console.WriteLine($"Total de plată: {total:F2} LEI");
                        Console.ReadKey();
                        break;
                }
            } while (opt != 0);
        }

        static void AdaugaMedicament()
        {
            Console.Clear();
            Console.WriteLine("Tip medicament: ");
            Console.WriteLine("1. Capsula");
            Console.WriteLine("2. Injectie");
            Console.WriteLine("3. Sirop");
            Console.WriteLine("4. Efervescent");
            Console.WriteLine("5. Antibiotic");
            Console.Write("Alege tipul: ");
            int tip = int.Parse(Console.ReadLine());
            // citire tastatura
            Console.Write("Nume: ");
            string nume = Console.ReadLine();
            Console.Write("Comerciant: ");
            string comerciant = Console.ReadLine();
            Console.Write("Preț: ");
            double pret = double.Parse(Console.ReadLine());
            Console.Write("Stoc: ");
            int stoc = int.Parse(Console.ReadLine());

            Medicament m = null;
            switch (tip)
            {
                case 1: m = new Capsula(nume, comerciant, pret, stoc); break;
                case 2: m = new Injectie(nume, comerciant, pret, stoc); break;
                case 3: m = new Sirop(nume, comerciant, pret, stoc); break;
                case 4: m = new Efervescent(nume, comerciant, pret, stoc); break;
                case 5: m = new Antibiotic(nume, comerciant, pret, stoc); break;
            }
            // salvare in tablou
            medicamente[index++] = m;
            //salvare fisier
            File.AppendAllText("medicamente.txt", m.ToFileFormat() + Environment.NewLine);
            Console.WriteLine("Stoc actualizat!");
            Console.ReadKey();
        }

        static void AfiseazaMedicamenteDinFisier()
        {
            Console.Clear();
            if (File.Exists("medicamente.txt"))
            {
                foreach (string linie in File.ReadAllLines("medicamente.txt"))
                {
                    // cautare
                    string[] v = linie.Split(',');
                    if (v.Length == 5)
                    {
                        double pret = double.Parse(v[3]);
                        int stoc = int.Parse(v[4]);
                        Medicament m = null;

                        switch (v[0].ToLower())
                        {
                            case "capsula": m = new Capsula(v[1], v[2], pret, stoc); break;
                            case "injectie": m = new Injectie(v[1], v[2], pret, stoc); break;
                            case "sirop": m = new Sirop(v[1], v[2], pret, stoc); break;
                            case "efervescent": m = new Efervescent(v[1], v[2], pret, stoc); break;
                            case "antibiotic": m = new Antibiotic(v[1], v[2], pret, stoc); break;
                        }

                        if (m != null)
                            Console.WriteLine(m);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nu există medicamente in stoc!");
            }
            Console.ReadKey();
        }
    }
}
