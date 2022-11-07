using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Obiekty
{
    public class Game
    {
        public Game()
        {
            // USTAWIAMY POCZĄTKOWĄ KATEGORIĘ
            CurrentCategory = 100;

            
            // TWORZYMY BAZE PYTAŃ
            CreateQuestions();

            // TWORZYMY GENERATOR LICZB PSEUDOLOSOWYCH
            Random = new Random();
        }


        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }


        // metoda wyświetlająca planszę początkową
        public void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("WITAJ W QUIZIE WIEDZY");
            Console.WriteLine("Spróbuj odpowiedzieć na 5 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
        }

        // metoda tworząca całą bazę pytań
        private void CreateQuestions()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\questions.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                Questions = JsonConvert.DeserializeObject<List<Question>>(json);
            }
        }

        // metoda losująca jedno pytanie ze wszystkich z aktualnej kategorii
        public void DrawQuestion()
        {
            var questions = Questions.Where(q => q.Category == CurrentCategory).ToList();
            var digit = Random.Next(0, questions.Count);

            var question = questions[digit];
            question.Answers = question.Answers.OrderBy(a => Random.Next()).ToList();
            var index = 1;
            foreach (var answer in question.Answers)
            {
                answer.DisplayOrder = index;
                index++;
            }

            CurrentQuestion = question;
        }

        // metoda sprawdzająca czy odpowiedz Gracza jest poprawna
        public bool CheckIfCorrect(int playerAnswer)
        {
            var answer = CurrentQuestion.Answers.FirstOrDefault(a => a.DisplayOrder == playerAnswer);
            return answer.IsCorrect;
        }
    }
}
