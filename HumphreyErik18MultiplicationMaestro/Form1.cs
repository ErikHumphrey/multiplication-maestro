/*
 _______  ___   __   __  _______  _______    _______  _______  _______  ___      _______  _______ 
|       ||   | |  |_|  ||       ||       |  |       ||   _   ||  _    ||   |    |       ||       |
|_     _||   | |       ||    ___||  _____|  |_     _||  |_|  || |_|   ||   |    |    ___||  _____|
  |   |  |   | |       ||   |___ | |_____     |   |  |       ||       ||   |    |   |___ | |_____ 
  |   |  |   | |       ||    ___||_____  |    |   |  |       ||  _   | |   |___ |    ___||_____  |
  |   |  |   | | ||_|| ||   |___  _____| |    |   |  |   _   || |_|   ||       ||   |___  _____| |
  |___|  |___| |_|   |_||_______||_______|    |___|  |__| |__||_______||_______||_______||_______| */

/* Author: Erik Humphrey
 * Project title: Project 18  - Get Loopy
 * Date started: December 7th
 * Executable name: HumphreyErik18MultiplicationMaestro.exe
 * Description: Game that generates simple multiplication arithmetic problems for user to solve in short amount of time, tracking score
 */

// IMPORTANT: I have the code for it to show the right answer if the user gets it wrong, but it's COMMENTED OUT. Ctrl+F "The answer was"

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumphreyErik18MultiplicationMaestro
{
    public partial class frmMathQuiz : Form
    {
        // Global declarations 
        string playerInitials;
        bool gameStarted, comboWasActive = false;
        int userAnswer, currentScore, attempts, correctAnswers, firstFactor, secondFactor, comboTimer, combo;
        Random rnd = new Random();

        public frmMathQuiz()
        {
            InitializeComponent();
        }

        private void frmMathQuiz_Load(object sender, EventArgs e)
        {
            // Idle progress bar style for looks
            prgTimeRemaining.Style = ProgressBarStyle.Marquee;
            prgTimeRemaining.MarqueeAnimationSpeed = 60;
            // Add a low starting developer high score to beat
            string[] row = {
				"500", "DEV"
			};
            var listViewItem = new ListViewItem(row);
            lvwScoreTable.Items.Add(listViewItem);
        }

        // Allow the game to be started if initials have been entered. Initials can be 1-3 characters.

        private void txtUserInitialsEntry_TextChanged(object sender, EventArgs e)
        {
            if (txtUserInitialsEntry.Text != "")
            {
                txtUserInitialsEntry.ForeColor = System.Drawing.Color.Black;
                btnStartGameGiveUp.Enabled = true;
            }
            else
            {
                txtUserInitialsEntry.ForeColor = System.Drawing.SystemColors.ActiveBorder;
                btnStartGameGiveUp.Enabled = false;
            }
        }

        private void btnStartGameGiveUp_Click(object sender, EventArgs e)
        {
            // If the game is already in progress, ask the user confirmation to reset the game.
            if (gameStarted == true)
            {
                // Pause the game
                if (tmrComboDecay.Enabled)
                {
                    comboWasActive = true;
                    tmrComboDecay.Stop();
                }
                tmrTimeRemaining.Stop();
                DialogResult wantsToReset = MessageBox.Show(
                    "Are you sure you want to reset the game?\r\nYour win/loss history will be lost!",
                    "Confirm reset",
                MessageBoxButtons.OKCancel);
                if (wantsToReset == DialogResult.OK)
                {
                    endGame();
                }
                // Resume the game
                else
                {
                    tmrTimeRemaining.Start();
                    if (comboWasActive)
                    {
                        tmrComboDecay.Start();
                        comboWasActive = false;
                    }
                }
            }
            else
            {
                playerInitials = txtUserInitialsEntry.Text;
                tmrTimeRemaining.Start();
                txtUserInitialsEntry.Enabled = false;
                btnStartGameGiveUp.Text = "Give up";
                gameStarted = txtUserProductAnswer.Enabled = true;
                txtUserProductAnswer.BorderStyle = BorderStyle.Fixed3D;
                prgTimeRemaining.Style = ProgressBarStyle.Blocks;
                prgTimeRemaining.MarqueeAnimationSpeed = 150;
                lblFirstFactor.BackColor = lblSecondFactor.BackColor = System.Drawing.SystemColors.Control;
                newProblem();
            }
        }

        // Method to generate a new problem

        void newProblem()
        {
            // Generate two random factors
            firstFactor = rnd.Next(0, 10);
            secondFactor = rnd.Next(0, 10);
            // Display them
            lblFirstFactor.Text = firstFactor.ToString();
            lblSecondFactor.Text = secondFactor.ToString();
            // Clear the answer box
            txtUserProductAnswer.Clear();
        }

        // Method to end the game, whether by running out of time or giving up

        void endGame()
        {
            MessageBox.Show("Time's up!\r\nYour score is " + currentScore + ".", "Game over", MessageBoxButtons.OK);
            // Add the player's score along with their initials to the high score table, which is sorted by Score.
            string[] row = {
				currentScore.ToString(), playerInitials
			};
            var listViewItem = new ListViewItem(row);
            lvwScoreTable.Items.Add(listViewItem);
            // Reset a bunch of stuff to start a new game
            // The first game is probably still the least buggy one because I don't have time to figure out what I didn't properly reset
            prgTimeRemaining.Style = ProgressBarStyle.Marquee;
            prgTimeRemaining.MarqueeAnimationSpeed = 60;
            prgTimeRemaining.Value = 300;
            btnStartGameGiveUp.Text = "Start game";
            txtUserProductAnswer.Enabled = btnStartGameGiveUp.Enabled = prgComboDecay.Visible = lblCombo.Visible = gameStarted = false;
            txtUserProductAnswer.Clear();
            lblFirstFactor.BackColor = lblSecondFactor.BackColor = System.Drawing.SystemColors.ControlLight;
            lblFirstFactor.Text = lblSecondFactor.Text = null;
            txtUserInitialsEntry.Enabled = true;
            txtUserInitialsEntry.Text = "INITIALS";
            txtUserInitialsEntry.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            lblCurrentScore.Text = "Score: 0";
            lblCurrentAccuracy.Text = "Accuracy: 0%";
            lblCurrentAccuracy.ForeColor = System.Drawing.Color.Black;
        }

        private void tmrTimeRemaining_Tick(object sender, EventArgs e)
        {
            if (prgTimeRemaining.Value <= 0)
            {
                tmrTimeRemaining.Stop();
                endGame();
            }
            else
            {
                prgTimeRemaining.Value--;
                // Make the combo label flicker
                if (lblCombo.ForeColor == System.Drawing.Color.Red)
                {
                    lblCombo.ForeColor = System.Drawing.Color.Tomato;
                }
                else
                {
                    lblCombo.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void txtUserProductAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow backspace and numbers 0-9
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            // User presses ENTER/RETURN key
            else if ((int)e.KeyChar == 13)
            {
                // Parse user answer as an integer
                bool userDidNotLeaveAnswerBlank;
                userDidNotLeaveAnswerBlank = Int32.TryParse(txtUserProductAnswer.Text, out userAnswer);
                attempts++;

                // Only calculate if user entered anything (otherwise a blank answer would be registered as a wrong answer)
                if (userDidNotLeaveAnswerBlank)
                    // User answer is correct
                    if (userAnswer == firstFactor * secondFactor)
                    {
                        correctAnswers++;
                        // Start a combo
                        if (tmrComboDecay.Enabled)
                        {
                            combo = 1;
                            comboTimer = 10;
                        }
                        else
                        {
                            combo++;
                            tmrComboDecay.Start();
                        }
                        // Check for combos
                        if (combo == 3)
                        {
                            lblCombo.Visible = true;
                            prgComboDecay.Visible = true;
                            prgComboDecay.Value = 100;
                        }

                        // Give the player 10 points and update the score counter
                        currentScore += 10;
                        lblCurrentScore.Text = "Score: " + currentScore;
                        if (lblCombo.Visible)
                        {
                            currentScore += 25; // Give bonus points
                            prgComboDecay.Value = 100; // Reset decay on combo
                        }
                        // Give bonus time if it doesn't exceed the maximum allowed total remaining time
                        if (360 > prgTimeRemaining.Value + 10) prgTimeRemaining.Value += 10;
                        // Instead of crashing the program, set it to the maximum
                        else prgTimeRemaining.Value = 360;
                        lblCurrentAccuracy.ForeColor = System.Drawing.Color.ForestGreen; // Make the accuracy label green
                        newProblem(); // Get a new problem

                        // lblTheAnswer.Visible = false;
                    }
                    // User answer is wrong
                    else
                    {
                        currentScore -= 5;
                        lblCurrentScore.Text = "Score: " + currentScore;
                        lblCurrentAccuracy.ForeColor = System.Drawing.Color.Red; // Make the accuracy label red
                        if (0 < prgTimeRemaining.Value - 20) prgTimeRemaining.Value -= 20; // Penalty on the time remaining
                        else prgTimeRemaining.Value = 0;
                        // Stop the combos
                        tmrComboDecay.Stop();
                        lblCombo.Visible = false;
                        prgComboDecay.Visible = false;
                        prgComboDecay.Value = 100;
                        // Show the correct answer
                        
                        /* This would be the code if I showed the answer if they got it wrong, but the user can get it wrong multiple times/question.

                        lblTheAnswer.Visible = true;
                        lblTheAnswer.Text = "The answer was " + firstFactor * secondFactor; */ 

                    }

                // Update accuracy based on the ratio of correct answers to attempts, rounded to two decimal places
                lblCurrentAccuracy.Text = "Accuracy: " + Math.Round(((float)correctAnswers / (float)attempts) * 100, 2) + "%";
            }
            // Don't accept input from any other keys
            else
            {
                e.Handled = true;
            }
        }

        private void txtUserInitialsEntry_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserInitialsEntry.Focused)
            {
                txtUserInitialsEntry.Text = "";
            }
        }

        private void txtUserInitialsEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 65-90 are A-Z upper
            // 97-112 are a-z lower (textbox CharacterCasing changes them to upper after)
            // 8 is backspace
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || ((e.KeyChar >= 97 && e.KeyChar <= 122) || (int)e.KeyChar == 8))
            {
                e.Handled = false;
            }
            /* When hitting return, perform click on Start Game button
               I wanted to make the game a time trial, so I added initials to demonstrate knowledge on the PerformClick instead of
               the user manually clicking the button, losing time. */
            else if ((int)e.KeyChar == 13)
            {
                btnStartGameGiveUp.PerformClick();
            }
            // Don't handle any other characters
            else
            {
                e.Handled = true;
            }
        }

        private void txtUserInitialsEntry_KeyDown(object sender, KeyEventArgs e)
        {
            // Allow select all shortcut
            if (e.Control && (e.KeyCode == Keys.A))
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
            // Allow cut shortcut
            else if (e.Control && (e.KeyCode == Keys.X))
            {
                if (sender != null)
                    ((TextBox)sender).Cut();
                e.Handled = true;
            }
            // Allow copy shortcut
            else if (e.Control && (e.KeyCode == Keys.C))
            {
                if (sender != null)
                    ((TextBox)sender).Copy();
                e.Handled = true;
            }
            // Allow paste shortcut
            else if (e.Control && (e.KeyCode == Keys.V))
            {
                if (sender != null)
                    ((TextBox)sender).Paste();
                e.Handled = true;
            }
        }

        private void tmrComboDecay_Tick(object sender, EventArgs e)
        {
            if (comboTimer == 0)
            {
                tmrComboDecay.Stop();
                combo = 0;
            }
            {
                comboTimer--;
            }

            if (prgComboDecay.Value <= 0)
            {
                tmrComboDecay.Stop();
                prgComboDecay.Visible = false;
                lblCombo.Visible = false;
            }

            if (0 < prgComboDecay.Value - 10)
            {
                prgComboDecay.Value -= 10;
            }
            else
            {
                prgComboDecay.Value = 0;
                tmrComboDecay.Stop();
                prgComboDecay.Visible = false;
                lblCombo.Visible = false;
            }
        }
    }
}