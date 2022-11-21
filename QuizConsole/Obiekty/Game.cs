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
            // TWORZYMY BAZE PYTAŃ
            CreateQuestions();

            // TWORZYMY GENERATOR LICZB PSEUDOLOSOWYCH
            Random = new Random();

            // LISTA WSZYSTKICH KATEGORII
            Categories = Questions.Select(x => x.Category).Distinct().OrderBy(c => c).ToList();

            // USTAWIAMY POCZĄTKOWĄ KATEGORIĘ
            CurrentCategory = Categories[CategoryIndex];

            // USTAWIAMY ŻE GRACZ MOŻE UŻYĆ KOŁA RATUNKOWEGO
            CanUseWheel = true;
        }


        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }
        public List<int> Categories { get; set; }
        public int CategoryIndex { get; set; }
        public bool CanUseWheel { get; set; }


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

        // metoda sprawdzająca czy to nie było ostatnie pytanie
        public bool CheckIfLastQuestion()
        {
            if (CategoryIndex == 6) return true;
            CategoryIndex++;
            CurrentCategory = Categories[CategoryIndex];
            return false;
        }


        public void GetQuestionWithWheel()
        {
            var badAnswers = CurrentQuestion.Answers.Where(a => !a.IsCorrect);
            badAnswers = badAnswers.OrderBy(a => Random.Next());
            var toReduce = badAnswers.Take(2).ToList();
            CurrentQuestion.Answers.Remove(toReduce[0]);
            CurrentQuestion.Answers.Remove(toReduce[1]);
        }
    }
}
