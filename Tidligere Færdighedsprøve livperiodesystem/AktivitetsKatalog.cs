using System;
using System.Collections.Generic;
using System.Text;

namespace Tidligere_Færdighedsprøve_livperiodesystem
{
    class AktivitetsKatalog
    {
        public string AktivitetsNavn { get; set; }
        public string Lokation { get; set; }
        public Dictionary<int, Aktivitet> Aktiviteter { get; set; }


        public AktivitetsKatalog(string aNavn, string lokation)
        {
            AktivitetsNavn = aNavn;
            Lokation = lokation;
            Aktiviteter = new Dictionary<int, Aktivitet>()
            {
                { 1, new Aktivitet(1, 12, 18, new DateTime(2022, 5, 15, 14, 30, 0), new DateTime(2022, 5, 15, 18, 0, 0)) },
                { 2, new Aktivitet(2, 10, 15, new DateTime(2022, 5, 16, 12, 0, 0), new DateTime(2022, 5, 16, 14, 0, 0)) },
                { 3, new HoldAktivitet(3, 10, 15, new DateTime(2022, 5, 16, 12, 0, 0), new DateTime(2022, 5, 16, 14, 0, 0), "A1") }
            };
        }

        public override string ToString()
        {
            string tekst = $"Aktivitet: {AktivitetsNavn} | Lokation: {Lokation}";
            foreach (var item in Aktiviteter)
            {
                tekst = tekst +"\n"+ item;
            }
            return tekst;
        }

        #region Add for List
        // Add for Liste
        //public void AddActivity(Aktivitet aktivitet) 
        //{
        //    Aktiviteter.Add(aktivitet);
        //}
        #endregion

        public void AddActivity(int id, Aktivitet aktivitet)
        {
            Aktiviteter.Add(id, aktivitet);
            Console.WriteLine($"Aktivitet blev added | id: {id}");
            Console.WriteLine();
        }

        #region Delete for List
        // Delete for Liste
        //public void DeleteActivity(int id)
        //{
        //    Aktivitet aktivitet = Aktiviteter.Find(akt => akt.ID == id);
        //    Aktiviteter.Remove(aktivitet);
        //    Console.WriteLine($"Aktivitet {id} blev slettet");
        //    Console.WriteLine();
        //}
        #endregion

        public void DeleteActivity(Aktivitet aktivitet)
        {
            Aktiviteter.Remove(aktivitet.ID);
            Console.WriteLine($"Aktivitet {aktivitet.ID} blev slettet");
            Console.WriteLine();
        }
    }
}
 