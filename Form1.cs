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
        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (btn.Text == "")
                {
                    CheckSign(sender);
                }
            }
        }
    }
}