using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class XOGAME : Form
    {
        bool turn = true;
        int turn_count = 0;

        public XOGAME()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }

        private bool checkForWinner()
        {
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                MessageBox.Show("Player " + A1.Text + " 贏了!");
                disableButton();
                return true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                MessageBox.Show("Player " + B1.Text + " 贏了!");
                disableButton();
                return true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                MessageBox.Show("Player " + C1.Text + " 贏了!");
                disableButton();
                return true;
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                MessageBox.Show("Player " + A1.Text + " 贏了!");
                disableButton();
                return true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                MessageBox.Show("Player " + A2.Text + " 贏了!");
                disableButton();
                return true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                MessageBox.Show("Player " + A3.Text + " 贏了!");
                disableButton();
                return true;
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                MessageBox.Show("Player " + A1.Text + " 贏了!");
                disableButton();
                return true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                MessageBox.Show("Player " + A3.Text + " 贏了!");
                disableButton();
                return true;
            }

            // 如果平局
            if (turn_count == 9)
            {
                MessageBox.Show("It's a draw!");
                return true;
            }

            return false;
        }

        private void disableButton()
        {
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Enabled = false;
            }
            newGame.Enabled = true;
            Exit.Enabled = true;
            newGame.Text = "重置";
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Button button in Controls.OfType<Button>())
            {
                button.Enabled = true;
                button.Text = "";
            }
            newGame.Text = "重置";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
