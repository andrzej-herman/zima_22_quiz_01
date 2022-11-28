using Quiz;
using QuizConsole;


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
    var playerAnswer = game.CurrentQuestion.Show(game.CanUseWheel);

    // WYBÓR KOŁA PÓŁ NA PÓŁ
    if (playerAnswer == 5)
    {
        game.CanUseWheel = false;
        game.GetQuestionWithWheel();
        Console.Clear();
        playerAnswer = game.CurrentQuestion.Show(game.CanUseWheel);
    }


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

