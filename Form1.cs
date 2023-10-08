using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {

        }
        public int click = 1;
        private void CheckSign(object sender)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (click % 2 != 0)
                {
                    // Player 1
                    btn.Text = "X";
                    click++;
                }
                else
                {
                    // Player 2
                    btn.Text = "O";
                    click++;
                }
            }
        }
        public bool GameOver = false;
        public string Winner = "";
        private void CheckWinner()
        {
            if (button1_1.Text == "X" && button1_2.Text == "X" && button1_3.Text == "X")
            {
                button1_1.BackColor = Color.GreenYellow;
                button1_2.BackColor = Color.GreenYellow;
                button1_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player1";
            }
            if (button2_1.Text == "X" && button2_2.Text == "X" && button2_3.Text == "X")
            {
                button2_1.BackColor = Color.GreenYellow;
                button2_2.BackColor = Color.GreenYellow;
                button2_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player1";
            }
            if (button3_1.Text == "X" && button3_2.Text == "X" && button3_3.Text == "X")
            {
                button3_1.BackColor = Color.GreenYellow;
                button3_2.BackColor = Color.GreenYellow;
                button3_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player1";
            }
            if (button1_1.Text == "X" && button2_1.Text == "X" && button3_1.Text == "X")
            {
                button1_1.BackColor = Color.GreenYellow;
                button2_1.BackColor = Color.GreenYellow;
                button3_1.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player1";
            }
            if (button1_2.Text == "X" && button2_2.Text == "X" && button3_2.Text == "X")
            {
                button1_2.BackColor = Color.GreenYellow;
                button2_2.BackColor = Color.GreenYellow;
                button3_2.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player1";
            }
            if (button1_3.Text == "X" && button2_3.Text == "X" && button3_3.Text == "X")
            {
                button1_3.BackColor = Color.GreenYellow;
                button2_3.BackColor = Color.GreenYellow;
                button3_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player1";
            }
            if (button1_1.Text == "X" && button2_2.Text == "X" && button3_3.Text == "X")
            {
                button1_1.BackColor = Color.GreenYellow;
                button2_2.BackColor = Color.GreenYellow;
                button3_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player1";
            }
            if (button1_3.Text == "X" && button2_2.Text == "X" && button3_1.Text == "X")
            {
                button1_3.BackColor = Color.GreenYellow;
                button2_2.BackColor = Color.GreenYellow;
                button3_1.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player1";
            }


            if (button1_1.Text == "O" && button1_2.Text == "O" && button1_3.Text == "O")
            {
                button1_1.BackColor = Color.GreenYellow;
                button1_2.BackColor = Color.GreenYellow;
                button1_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player2";
            }
            if (button2_1.Text == "O" && button2_2.Text == "O" && button2_3.Text == "O")
            {
                button2_1.BackColor = Color.GreenYellow;
                button2_2.BackColor = Color.GreenYellow;
                button2_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player2";
            }
            if (button3_1.Text == "O" && button3_2.Text == "O" && button3_3.Text == "O")
            {
                button3_1.BackColor = Color.GreenYellow;
                button3_2.BackColor = Color.GreenYellow;
                button3_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player2";
            }
            if (button1_1.Text == "O" && button2_1.Text == "O" && button3_1.Text == "O")
            {
                button1_1.BackColor = Color.GreenYellow;
                button2_1.BackColor = Color.GreenYellow;
                button3_1.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player2";
            }
            if (button1_2.Text == "O" && button2_2.Text == "O" && button3_2.Text == "O")
            {
                button1_2.BackColor = Color.GreenYellow;
                button2_2.BackColor = Color.GreenYellow;
                button3_2.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player2";
            }
            if (button1_3.Text == "O" && button2_3.Text == "O" && button3_3.Text == "O")
            {
                button1_3.BackColor = Color.GreenYellow;
                button2_3.BackColor = Color.GreenYellow;
                button3_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player2";
            }
            if (button1_1.Text == "O" && button2_2.Text == "O" && button3_3.Text == "O")
            {
                button1_1.BackColor = Color.GreenYellow;
                button2_2.BackColor = Color.GreenYellow;
                button3_3.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player2";
            }
            if (button1_3.Text == "O" && button2_2.Text == "O" && button3_1.Text == "O")
            {
                button1_3.BackColor = Color.GreenYellow;
                button2_2.BackColor = Color.GreenYellow;
                button3_1.BackColor = Color.GreenYellow;
                GameOver = true;
                Winner = "Player2";
            }
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender is Button && !GameOver)
            {
                Button btn = (Button)sender;
                if (btn.Text == "")
                {
                    CheckSign(sender);
                    CheckWinner();
                    if (Winner != "")
                    {
                        switch (Winner)
                        {
                            case "Player1":
                                WinnerLabel.Text = "Player1";
                                break;
                            case "Player2":
                                WinnerLabel.Text = "Player2";
                                break;
                        }
                    }
                }
            }
        }
    }
}