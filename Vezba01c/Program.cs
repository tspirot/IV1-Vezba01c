using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezba01c
{
    // generecka klasa za artikale sa cenom bilo kog tipa
    class Artikal<T>
    {
        //konstruktor
        public Artikal()
        {
            Naziv = "";
            Cena = default(T);// default(T) vraca podrazumevanu vrednost za tip T
        }
        public string Naziv { get; set; }
        public T Cena { get; set; }
        // tostring metoda
        public override string ToString()
        {
            return string.Format("{0} - {1}", Naziv, Cena);
            //return Naziv + " - " + Cena;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // artikal sa cenom tipa int
            Artikal<int> a1 = new Artikal<int>();
            a1.Naziv = "Cokolada";
            a1.Cena = 100;
            Console.WriteLine(a1);
            // artikal sa cenom tipa decimal
            Artikal<decimal> a2 = new Artikal<decimal>();
            a2.Naziv = "Mleko";
            a2.Cena = 120.5m;
            Console.WriteLine(a2);
            //niz artikala
            Artikal<int>[] artikli = new Artikal<int>[2]; //
            artikli[0] = a1;// dodajemo artikal a1 na poziciju 0
            // generericka lista ocena ucenika
            List<int> ocene = new List<int>();
            ocene.Add(5);
            ocene.Add(4);
            ocene.Add(3);
            ocene.Add(5);
            // prikaži ocene
            foreach (int ocena in ocene)
            {
                Console.WriteLine(ocena);
            }
            // najveca ocena
            Console.WriteLine("Najveca ocena je: {0}", ocene.Max());
            // prosecna ocena
            Console.WriteLine("Prosecna ocena je: {0}", ocene.Average());
            // redni broj ucenika sa najvecom ocenom
            Console.WriteLine("Redni broj ucenika sa najvecom ocenom je: {0}", 
                ocene.IndexOf(ocene.Max()) + 1);
            // redni broj poslednjeg ucenika sa najvecom ocenom
            Console.WriteLine("Redni broj poslednjeg ucenika sa najvecom ocenom je: {0}",
                               ocene.LastIndexOf(ocene.Max()) + 1);
            // redni broj drugog ucenika sa najvecom ocenom
            Console.WriteLine("Redni broj drugog ucenika sa najvecom ocenom je: {0}",
                                              ocene.IndexOf(ocene.Max(), 1) + 1);
            // indeksi svih ucenika sa ocenom 5
            Console.WriteLine("Indeksi svih ucenika sa ocenom 5 su: ");
            for (int i = 0; i < ocene.Count; i++)
            {
                if (ocene[i] == 5)
                {
                    Console.WriteLine(i + 1);
                }
            }
            // broj ucenika sa najvecom ocenom
            Console.WriteLine("Broj ucenika sa najvecom ocenom je: {0}",
                               ocene.Count(x => x == ocene.Max()));
            // prva polovina ocena
            List<int> prvaPolovina = ocene.GetRange(0, ocene.Count / 2); // 0 - pocetni indeks, ocene.Count / 2 - broj elemenata
            // povecaj prvu polovinu ocena za 1
            for (int i = 0; i < prvaPolovina.Count; i++)
            {
                prvaPolovina[i]++;
            }
            // prikazi ocene
            foreach (int ocena in ocene)
            {
                Console.WriteLine(ocena);
            }
            //prikazi prvu polovinu ocena
            foreach (int ocena in prvaPolovina)
            {
                Console.WriteLine(ocena);
            }
            ocene.Insert(1,5); // dodaj ocenu 5 na drugo mesto
            ocene.RemoveAt(1); // ukloni ocenu sa drugog mesta
            // LANCANA LISTA imena ucenika
            LinkedList<string> imena = new LinkedList<string>();
            imena.AddLast("Pera");// dodaj na kraj
            imena.AddFirst("Mika");// dodaj na pocetak
            imena.RemoveFirst();// ukloni sa pocetka
            //prikazi imena
            foreach (string ime in imena)
            {
                Console.WriteLine(ime);
            }

            // RECNIK za kursnu listu
            Dictionary<string, decimal> kursnaLista = 
                new Dictionary<string, decimal>(); // kljuc je string, vrednost je decimal
            kursnaLista.Add("EUR", 120.5m); // dodaj kurs evra
            kursnaLista.Add("USD", 100.5m); //  dodaj kurs dolara
                                            // prikazi kursnu listu
            foreach (KeyValuePair<string,decimal> kurs in kursnaLista)
            {
                Console.WriteLine("{0} - {1}", kurs.Key, kurs.Value);
            }
            // obrisi kurs dolara
            kursnaLista.Remove("USD");
        }
    }
}
