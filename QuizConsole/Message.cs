using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole
{
    public class Message
    {
        // metoda wyświetlająca planszę początkową
        public void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("WITAJ W QUIZIE WIEDZY");
            Console.WriteLine("Spróbuj odpowiedzieć na 5 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
            Console.WriteLine("Nacisnij ENTER aby rozpocząć grę ...");
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayIncorrectAnswer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Niestety, to nie jest prawidłowa odpowiedź");
            Console.WriteLine("Spróbuj zagrać jeszcze raz");
            Console.WriteLine("KONIEC GRY");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        public void DisplayCorrectAnswer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Brawo, to jest dobra odpowiedź !!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Naciśnij ENTER aby zobaczyć następne pytanie ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Console.Clear();
        }

        internal void DisplayWinGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Brawo, Wygrałaś/eś cały quiz. Jesteś mistrzem!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
