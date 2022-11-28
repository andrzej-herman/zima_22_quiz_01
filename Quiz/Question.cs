using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        public int Show(bool canUseWheel)
        {
            ShowQuestion(canUseWheel);
            var odpGracza = Console.ReadLine();
            var czyWcisnalDobryKlawisz = SprawdzCzyDobryKlawisz(odpGracza, canUseWheel);
            while (!czyWcisnalDobryKlawisz)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Nacianąłeś nieprawidowy klawisz!!!");
                Console.ForegroundColor = ConsoleColor.White;
                ShowQuestion(canUseWheel);
                odpGracza = Console.ReadLine();
                czyWcisnalDobryKlawisz = SprawdzCzyDobryKlawisz(odpGracza, canUseWheel);
            }

            if (odpGracza.ToLower() == "p")
                return 5;

            return int.Parse(odpGracza);
        }

        private void ShowQuestion(bool canUseWheel)
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
            var message = canUseWheel
                ? "Naciśnij 1, 2, 3 lub 4, albo P wykorzystać pół na pół => "
                : "Naciśnij 1, 2, 3 lub 4 => ";

            Console.WriteLine(message);

        }

        private bool SprawdzCzyDobryKlawisz(string odpowiedzGracza, bool canUseWheel)
        {
            if (canUseWheel)
            {
                if (odpowiedzGracza.ToLower() == "P".ToLower())
                    return true;
            }

            if (int.TryParse(odpowiedzGracza, out int liczba))
            {
                if (liczba >= 1 && liczba <= 4)
                    return true;
            }

            return false;
        }
    }
}
