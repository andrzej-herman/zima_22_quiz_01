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

        public void PokazPytanieGraczowi()
        {
            //Console.WriteLine("Pytanie za " + p.Kategoria + " pkt");
            Console.WriteLine($"Pytanie za {Kategoria} pkt");
            Console.WriteLine();
            Console.WriteLine(Tresc);
            Console.WriteLine();
            foreach (var odp in Odpowiedzi)
            {
                Console.WriteLine($"{odp.Id}. {odp.Tresc}");
            }
            Console.WriteLine();
            Console.Write("Naciśnij 1, 2, 3 lub 4 => ");
        }

        //public int DodajLiczby(int x, int y)
        //{
        //    return x + y;
        //}
    }
}




// 100, 200, 500, 1000, 5000