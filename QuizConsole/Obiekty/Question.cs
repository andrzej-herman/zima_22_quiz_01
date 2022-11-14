using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Obiekty
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        public int Show()
        {
            ShowQuestion();
            var odpGracza = Console.ReadLine();
            var czyWcisnalDobryKlawisz = SprawdzCzyDobryKlawisz(odpGracza);
            while(!czyWcisnalDobryKlawisz)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Nacianąłeś nieprawidowy klawisz!!!");
                Console.ForegroundColor = ConsoleColor.White;
                ShowQuestion();
                odpGracza = Console.ReadLine();
                czyWcisnalDobryKlawisz = SprawdzCzyDobryKlawisz(odpGracza);
            }

            return int.Parse(odpGracza);
        }

        private void ShowQuestion()
        {
            Console.WriteLine($"Pytanie za {Category} pkt");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var answer in Answers)
            {
                if (answer.IsVisible)
                    Console.WriteLine($"{answer.DisplayOrder}. {answer.Content}");
            }
                

            Console.WriteLine();
            Console.Write("Naciśnij 1, 2, 3 lub 4, albo P wykorzystać pół na pół => ");
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




// 100, 200, 300, 400, 500, 750, 1000