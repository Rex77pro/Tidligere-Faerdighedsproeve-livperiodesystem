using System;

namespace Tidligere_Færdighedsprøve_livperiodesystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aktivitet A1 = new Aktivitet(1, 12, 18, new DateTime(2022, 5, 15, 14, 30, 0), new DateTime(2022, 5, 15, 18, 0, 0));
            //Console.WriteLine(A1);


            AktivitetsKatalog katalog = new AktivitetsKatalog("Frisbee golf", " Græsplænen");
            
            try
            {
                Console.WriteLine(katalog);
                Console.WriteLine();

                katalog.DeleteActivity(1);
                Console.WriteLine(katalog);
                Console.WriteLine();
                katalog.AddActivity(new Aktivitet(1, 12, 15, new DateTime(2022, 5, 15, 14, 30, 0), new DateTime(2022, 5, 15, 12, 0, 0)));
                // new Aktivitet(ID, MinimumAlder, MaksAlder, new DateTime(År, Måned, Dag, Time, Minut, Sekund)
                Console.WriteLine(katalog);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
        }
    }
}
