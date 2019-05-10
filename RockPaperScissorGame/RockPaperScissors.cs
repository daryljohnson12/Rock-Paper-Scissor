using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorGame

{
    /* Name: Daryl Johnson
     * Date: 1/29/2019
     * Project: Rock Paper and Scissor
     * Description: This is a rock paper scissor game that is one player
    */

    public partial class RockPaperScissors : Form
    {
        int compChoice;
        int playerScore = 0;
        int computerScore = 0;
        
     

        public RockPaperScissors()
        {
            InitializeComponent();

        }
 
           
        
        private void ComputerNumber() // Used to generate a random number.
        {
            // Method used to generate a number for the computers pick.
            // 1 = paper 2 = rock and 3 = scissors

            Random rand = new Random(); // Generates random number from 1 to 3
            compChoice = rand.Next(1, 4);
            if (compChoice == 1)
            {
                computerTextBox.Text = "Paper"; // Puts the word Paper into the computerTextBox.
            }
            else if (compChoice == 2)
            {
                computerTextBox.Text = "Rock"; // Puts the word Rock into the computerTextBox.
            }
            else if (compChoice == 3)
            {
                computerTextBox.Text = "Scissors"; // Puts the word Scissors into the computerTextBox. 
            }

        }
        private string PlayerName(string name) // Used to get the players name.
        {
            return name; // Used to return players name.
                       
        }
      
            
        
        private void DecideWinner()// Method used to decide the winner of the round.
        {
            
                if (playerPickTextBox.Text == "Rock" && computerTextBox.Text == "Scissors")

                {
                    winnerTextBox.Text = nameTextBox.Text + " You WIN";
                    playerScore ++;
                }
                else if (playerPickTextBox.Text == "Scissors" && computerTextBox.Text == "Rock")
                {
                    winnerTextBox.Text = nameTextBox.Text + " You Lose";
                    computerScore++;
                }
                else if (playerPickTextBox.Text == "Scissors" && computerTextBox.Text == "Paper")
                {
                    winnerTextBox.Text = nameTextBox.Text + " You WIN";
                    playerScore ++;
                }
                else if (playerPickTextBox.Text == "Paper" && computerTextBox.Text == "Scissors")
                {
                    winnerTextBox.Text = nameTextBox.Text + " You Lose";
                    computerScore ++;
                }
                else if (playerPickTextBox.Text == "Paper" && computerTextBox.Text == "Rock")
                {
                    winnerTextBox.Text = nameTextBox.Text + " You WIN";
                    playerScore ++;
                }
                else if (playerPickTextBox.Text == "Rock" && computerTextBox.Text == "Paper")
                {
                    winnerTextBox.Text = nameTextBox.Text + " You Lose";
                    computerScore ++;
                }
                else if (((playerPickTextBox.Text == "Paper") && (computerTextBox.Text == "Paper"))
                    || ((playerPickTextBox.Text == "Rock") && (computerTextBox.Text == "Rock")) ||
                    ((playerPickTextBox.Text == "Scissors") && (computerTextBox.Text == "Scissors")))
                {
                    winnerTextBox.Text = nameTextBox.Text + " It's a Tie";
                    MessageBox.Show("Play Again You Tied");
                    TryAgain();
                }

        }
      
        private void Score() // Method used to keep track of the score. 
        {
            playerScoreTextBox.Text = ("You score is " + playerScore); // Prints the player score.
            computerScoreTextBox.Text = ("Computer score is " + computerScore); // Prints the computers score.
        }
       
        private void WinLoss() // Method used to decide winner of the game.
        {
            if (playerScore > computerScore) 
            {
                MessageBox.Show(nameTextBox.Text + " You WIN");
            }
            else if (computerScore > playerScore)
            {
                MessageBox.Show("Sorry " + nameTextBox.Text + " Computer Wins");
            }
            else if (playerScore == computerScore)
            {
                MessageBox.Show(nameTextBox.Text + " You Tied!!");
            }
        }
       
        private void TryAgain()// This method is used if their is a tie to reset the text boxes.
        {   // Clears the TextBox controls.
            playerPickTextBox.Text = "";
            computerTextBox.Text = "";
            winnerTextBox.Text = "";
           
            // Resets the focus.
            playerPickTextBox.Focus();
        } 
       
        private void ClearReset()  // This method is used to start over again. 
        {
            // Clears the TextBox controls.
            nameTextBox.Text = "";
            playerPickTextBox.Text = "";
            computerTextBox.Text = "";
            winnerTextBox.Text = "";

            // Resets the focus.
            nameTextBox.Focus();
        }
                       
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Uses the ClearReset method to reset the game.
            ClearReset();
        }

       
        // This method is used to exit the game and tell you who won.
        private void exitButton_Click(object sender, EventArgs e)
        {
            WinLoss(); // Method that decides winner.
            this.Close();// Close the form.
        }

        private void Paper() // Puts the word paper into the playerPickTextBox.
        {
            playerPickTextBox.Text = "Paper"; // Puts the word paper into the playerPickTextBox.
           
        }
        private void Rock() // Puts the word rock into the playerPickTextBox.
        {
            playerPickTextBox.Text = "Rock"; // Puts the word rock into the playerPickTextBox.
           
        }
        private void Scissor() // Puts the word scissors into the playerPickTextBox.
        {
            playerPickTextBox.Text = "Scissors"; // Puts the word scissors into the playerPickTextBox.
        }

        private void rockPictureBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "") // Makes sure that the nameTextBox is not empty. 
            {
                MessageBox.Show("You must enter your name!!!");
                nameTextBox.Focus(); // Sets the focus back to the nameTextBox.
            }
            else
            {
                PlayerName(nameTextBox.Text); // Uses the PlayerName method.
                Rock(); // Uses the rock method.
                ComputerNumber(); // Uses the ComputerNumber method to get a random number.
                DecideWinner(); // Uses the DecideWinner method to decide who won the round.
                Score(); // Uses the Score method to keep track of the score.
            }
        }

        private void paperPictureBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "") // Makes sure that the nameTextBox is not empty.
            {
                MessageBox.Show("You must enter your name!!!");
                nameTextBox.Focus(); // Sets the focus back to the nameTextBox
            }
            else
            {
                PlayerName(nameTextBox.Text); // Uses the PlayerName method.
                Paper(); // Uses the paper method.
                ComputerNumber(); // Uses the ComputerNumber method to get a random number.
                DecideWinner(); // Uses the DecideWinner method to decide who won the round.
                Score(); // Uses the Score method to keep track of the score.
            }
        }

        private void scissorPictureBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "") // Makes sure that the nameTextBox is not empty.
            {
                MessageBox.Show("You must enter your name!!!");
                nameTextBox.Focus(); // Sets the focus back to the nameTextBox.
            }
            else
            {
                PlayerName(nameTextBox.Text);// Uses the PlayerName method.
                Scissor(); // Uses the scissor method.
                ComputerNumber(); // Uses the ComputerNumber method to get a random number.
                DecideWinner(); // Uses the DecideWinner method to decide who won the round.
                Score(); // Uses the Score method to keep track of the score.
            }
        }
    }
}
