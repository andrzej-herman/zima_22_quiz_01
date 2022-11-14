using QuizConsole.Obiekty;

// TWORZYMY OBIEKT TYPU (KLASY) GRA
var game = new Game();

// TWORZYMY OBIEKT KLASY MESSAGE
var message = new Message();

// WYŚWIETLAMY POWITANIE
message.DisplayWelcome();

while (true)
{
    // LOSUJEMY PYTANIE
    game.DrawQuestion();


    // WYŚWIETLAMY PYTANIE I POBIERAMY ODP GRACZA
    var playerAnswer = game.CurrentQuestion.Show();


    // SPRAWDZAMY ODPOWIEDŹ GRACZA
    var correct = game.CheckIfCorrect(playerAnswer);
    if (correct)
    {
        if (game.CheckIfLastQuestion())
        {
            message.DisplayWinGame();
            break;
        }
        else
            message.DisplayCorrectAnswer();
    }
    else
    {
        message.DisplayIncorrectAnswer();
        break;
    }
}

