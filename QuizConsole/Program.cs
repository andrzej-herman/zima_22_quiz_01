using QuizConsole.Obiekty;

// TWORZYMY OBIEKT TYPU (KLASY) GRA
var game = new Game();

// WYŚWIETLAMY POWITANIE
game.Welcome();


// LOSUJEMY PYTANIE
game.DrawQuestion();


// WYŚWIETLAMY PYTANIE I POBIERAMY ODP GRACZA
var playerAnswer = game.CurrentQuestion.Show();

// SPRAWDZAMY ODPOWIEDŹ GRACZA
var correct = game.CheckIfCorrect(playerAnswer);
if (correct)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("OK");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR");
}

Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine();

