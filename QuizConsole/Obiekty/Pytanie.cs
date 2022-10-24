using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Obiekty
{
    public class Pytanie
    {
        public int Id { get; set; }
        public int Kategoria { get; set; }
        public string Tresc { get; set; }
        public List<Odpowiedz> Odpowiedzi { get; set; }

        public int Pokaz()
        {
            WyswietlPytanie();
            var odpGracza = Console.ReadLine();
            var czyWcisnalDobryKlawisz = SprawdzCzyDobryKlawisz(odpGracza);
            while(!czyWcisnalDobryKlawisz)
            {
                Console.Clear();
                WyswietlPytanie();
                odpGracza = Console.ReadLine();
                czyWcisnalDobryKlawisz = SprawdzCzyDobryKlawisz(odpGracza);
            }

            return int.Parse(odpGracza);
        }

        private void WyswietlPytanie()
        {
            Console.WriteLine($"Pytanie za {Kategoria} pkt");
            Console.WriteLine();
            Console.WriteLine(Tresc);
            Console.WriteLine();
            foreach (var odp in Odpowiedzi)
                Console.WriteLine($"{odp.Id}. {odp.Tresc}");

            Console.WriteLine();
            Console.Write("Naciśnij 1, 2, 3 lub 4 => ");
        }

        private bool SprawdzCzyDobryKlawisz(string odpowiedzGracza)
        {
            if (int.TryParse(odpowiedzGracza, out int liczba))
            {
                if (liczba >= 1 && liczba <= 4)
                    return true;
            }

            return false;
        }

    }
}




// 100, 200, 500, 1000, 5000