namespace TicTacToe_Game
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            restartGame();
        }

        private void CPUmove(object sender, EventArgs e)
        {
            if(buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                CheckGame();
                CpuTimer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            buttons.Remove(button);
            CheckGame();
            CpuTimer.Start();
        }

        private void RestarGame(object sender, EventArgs e)
        {
            restartGame();  
        }
        private void CheckGame()
        {

        }
        private void restartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9};
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }
    }
}