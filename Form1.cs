using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rsp
{
    public partial class dd : Form
    {

        List<string> cpuChoices = new List<string>() { "rock", "paper", "scissors" };
        int randomNum = 0;
        Random rnd = new Random();

        string cpuChoice;
        string playerChoice;
        int playerScore;
        int cpuScore;
        decimal gamesPlayed;
        bool resGame = false;
        

        public dd()
        {

            //gamesCount.Text = "";
            //cpuResult.Text = "0";
            // playerResult.Text = "0";
            playerChoice = "";
            cpuChoice = "";


            InitializeComponent();
        }

        private void gameNum_ValueChanged(object sender, EventArgs e)
        {

            if(gameNum.Value<=0)
            {
                MessageBox.Show("VALUE CANNOT BE NULL");
                Application.Restart();
            }
            gamesCount.Text = gameNum.Value.ToString();
            gamesPlayed = gameNum.Value;

        }

        private void startButton_MouseClick(object sender, MouseEventArgs e)
        {
            gameNum.Enabled = false;
            gamesPlayed = int.Parse(gamesCount.Text);
            paperPlayer.Enabled = true;
            rockPlayer.Enabled = true;
            ScissorsPlayer.Enabled = true;
        }

        private void paperPlayer_MouseClick(object sender, MouseEventArgs e)
        {

            paperPlayer.Location = new Point(100, 250);
            rockPlayer.Enabled = false;
            ScissorsPlayer.Enabled = false;
            playerChoice = "paper";

            randomNum = rnd.Next(cpuChoices.Count);
            string cpuChoice = cpuChoices.ElementAt(randomNum);

            if (cpuChoice == "rock")
            {
                rockCPU.Location = new Point(235, 90);
                this.cpuChoice = "rock";
            }
            if (cpuChoice == "scissors")
            {
                scissorsCPU.Location = new Point(360, 90);
                this.cpuChoice = "scissors";
            }
            if (cpuChoice == "paper")
            {
                paperCPU.Location = new Point(100, 90);
                this.cpuChoice = "paper";
            }
            paperPlayer.Enabled = false;


            checkGame();

        }

        private void rockPlayer_MouseClick(object sender, MouseEventArgs e)
        {

            rockPlayer.Location = new Point(230, 250);
            paperPlayer.Enabled = false;
            ScissorsPlayer.Enabled = false;
            playerChoice = "rock";

            randomNum = rnd.Next(cpuChoices.Count);
            string cpuChoice = cpuChoices.ElementAt(randomNum);

            if (cpuChoice == "rock")
            {
                rockCPU.Location = new Point(235, 90);
                this.cpuChoice = "rock";
            }
            if (cpuChoice == "scissors")
            {
                scissorsCPU.Location = new Point(360, 90);
                this.cpuChoice = "scissors";
            }
            if (cpuChoice == "paper")
            {
                paperCPU.Location = new Point(100, 90);
                this.cpuChoice = "paper";
            }
            rockPlayer.Enabled = false;


            checkGame();

        }

        private void ScissorsPlayer_MouseClick(object sender, MouseEventArgs e)
        {

            ScissorsPlayer.Location = new Point(360, 250);
            rockPlayer.Enabled = false;
            paperPlayer.Enabled = false;
            playerChoice = "scissors";

            randomNum = rnd.Next(cpuChoices.Count);
            string cpuChoice = cpuChoices.ElementAt(randomNum);

            if (cpuChoice == "rock")
            {
                rockCPU.Location = new Point(235, 90);
                this.cpuChoice = "rock";
            }
            if (cpuChoice == "scissors")
            {
                scissorsCPU.Location = new Point(360, 90);
                this.cpuChoice = "scissors";
            }
            if (cpuChoice == "paper")
            {
                paperCPU.Location = new Point(100, 90);
                this.cpuChoice = "paper";
            }
            ScissorsPlayer.Enabled = false;


            checkGame();

        }
        private void checkGame()
        {

            if (this.cpuChoice == "rock" && playerChoice == "rock" || this.cpuChoice == "scissors" && playerChoice == "scissors" || this.cpuChoice == "paper" && playerChoice == "paper")
            {
                MessageBox.Show("DRAW");
                resGame = true;
            }
            if (this.cpuChoice == "rock" && playerChoice == "scissors" || this.cpuChoice == "scissors" && playerChoice == "paper" || this.cpuChoice == "paper" && playerChoice == "rock")
            {
                MessageBox.Show("GAME FOR CPU");
                cpuScore++;
                cpuResult.Text = cpuScore.ToString();
                resGame = true;
            }
            if (playerChoice == "rock" && this.cpuChoice == "scissors" || playerChoice == "scissors" && this.cpuChoice == "paper" || playerChoice == "paper" && this.cpuChoice == "rock")
            {
                MessageBox.Show("GAME FOR PLAYER");
                playerScore++;
                playerResult.Text = playerScore.ToString();
                resGame = true;
            }
            Restart();


        }
        private void Restart()
        {
            if (resGame == true)
            {
                rockCPU.Location = new Point(227, 10);
                paperCPU.Location = new Point(96, 10);
                scissorsCPU.Location = new Point(358, 10);
                rockPlayer.Location = new Point(227, 299);
                paperPlayer.Location = new Point(96, 299);
                ScissorsPlayer.Location = new Point(360, 299);
                rockPlayer.Enabled = true;
                paperPlayer.Enabled = true;
                ScissorsPlayer.Enabled = true;
                resGame = false;
                gamesPlayed--;
                gamesCount.Text = gamesPlayed.ToString();
                if (gamesPlayed == 0)
                {
                    MessageBox.Show("End of Game");
                    if (cpuScore > playerScore)
                    {
                        MessageBox.Show("CPU WINS");
                    }
                    else
                    {
                        MessageBox.Show("PLAYER WINS");
                    }
                    if (cpuScore == playerScore)
                    {
                        MessageBox.Show("DRAW");
                    }
                    Application.Exit();
                }

            }
        }
    }
}
