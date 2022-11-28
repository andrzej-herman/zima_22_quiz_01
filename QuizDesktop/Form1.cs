using Quiz;

namespace QuizDesktop
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }



        void StartGame()
        {
            game = new Game();
            game.DrawQuestion();
            lblCategory.Text = $"Pytanie za {game.CurrentQuestion.Category} pkt";
            lblQuestion.Text = game.CurrentQuestion.Content;
            lblA1.Text = game.CurrentQuestion.Answers[0].Content;
            lblA2.Text = game.CurrentQuestion.Answers[1].Content;
            lblA3.Text = game.CurrentQuestion.Answers[2].Content;
            lblA4.Text = game.CurrentQuestion.Answers[3].Content;
        }
    }
}