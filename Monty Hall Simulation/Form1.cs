using Monty_Hall___WF.MontyHallSimulation;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Monty_Hall_Simulation
{
    public partial class Form1 : Form
    {
        private Game game;
        public int numberOfWins;


        public Form1()
        {
            InitializeComponent();

        }
        private void btnStart_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(tbNumberOfGames.Text, out int numberOfGames))
            {
                MessageBox.Show("Please enter some number of games");
                return;
            }

            bool changeDoor = cbChangeDoor.Checked;
            StartGame(numberOfGames, changeDoor);
        }

        public void StartGame(int numberOfGames, bool changeDoor)
        {
            game = new Game();
            Random random = new Random();
            numberOfWins = 0;

            for (int i = 0; i < numberOfGames; i++)
            {
                //Generate a new random door to be the "chosen" door for each game
                int chosenDoor = random.Next(1, 4);

                //Check if the player wins or not by calling the method WinOrNot.
                if (game.WinOrNot(chosenDoor, changeDoor))
                {
                    numberOfWins++;
                }
            }

            //Calculate the probability
            double probability = (double)numberOfWins / numberOfGames;

            //Result
            tbProb.Text = probability.ToString("P");
            lbWinResult.Text = numberOfWins.ToString();
            lbLossesResult.Text = (numberOfGames - numberOfWins).ToString();
        }
    }
}



