namespace TicTacToeWindForm
{
    public partial class TicTacToe : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentePlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;

        public TicTacToe()
        {
            InitializeComponent();
            RestartGame();
        }



        private void CPUMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentePlayer = Player.O;
                buttons[index].Text = currentePlayer.ToString();
                buttons[index].BackColor = Color.Blue;
                buttons.RemoveAt(index);
                CheckGame();
                Timer.Stop();

            }

        }

        private void Playermove(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentePlayer = Player.X;
            button.Text = currentePlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Green;
            buttons.Remove(button);
            CheckGame();
            Timer.Start();
        }

        private void RestartBtn(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button7.Text == "X" && button5.Text == "X" && button3.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                )
            {
                Timer.Stop();
                MessageBox.Show("Player Wins ");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                RestartGame();

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button4.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button7.Text == "O" && button5.Text == "O" && button3.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                )
            {
                Timer.Stop();
                MessageBox.Show("CPU Wins ");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }



        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button btn in buttons)
            {
                btn.Enabled = true;
                btn.Text = "?";
                btn.BackColor = DefaultBackColor;
            }

        }
    }
}