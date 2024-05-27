using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        protected string bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9;
        public Form1()
        {
            InitializeComponent();
            bt1 = "";
            bt2 = "";
            bt3 = "";
            bt4 = "";
            bt5 = "";
            bt6 = "";
            bt7 = "";
            bt8 = "";
            bt9 = "";
        }

        bool isPlayerX = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void b1_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b1.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b1.Text = "O";
                isPlayerX = true;
            }
            bt1 = b1.Text;
            b1.Enabled = false;
            label4.Text = checkWin(); 
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b2.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b2.Text = "O";
                isPlayerX = true;
            }
            bt2 = b2.Text;
            b1.Enabled = false;
            label4.Text = checkWin(); 
        }


        private void b3_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b3.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b3.Text = "O";
                isPlayerX = true;
            }
            bt3 = b1.Text;
            b3.Enabled = false;
            label4.Text = checkWin(); 
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b4.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b4.Text = "O";
                isPlayerX = true;
            }
            bt4 = b4.Text;
            b4.Enabled = false;
            label4.Text = checkWin(); 
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b5.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b5.Text = "O";
                isPlayerX = true;
            }
            bt5 = b5.Text;
            b5.Enabled = false;
            label4.Text = checkWin();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b6.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b6.Text = "O";
                isPlayerX = true;
            }
            bt6 = b6.Text;
            b6.Enabled = false;
            label4.Text = checkWin();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b7.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b7.Text = "O";
                isPlayerX = true;
            }
            bt7 = b7.Text;
            b7.Enabled = false;
            label4.Text = checkWin();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b8.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b8.Text = "O";
                isPlayerX = true;
            }
            bt8 = b8.Text;
            b8.Enabled = false;
            label4.Text = checkWin();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (isPlayerX)
            {
                b9.Text = "X";
                isPlayerX = false;
            }
            else
            {
                b9.Text = "O";
                isPlayerX = true;
            }
            bt9 = b9.Text;
            b9.Enabled = false;

            label4.Text = checkWin();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit Game", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        public string checkWin()
        {
            if (bt1 != null && bt1 == bt2 && bt2 == bt3)
            {
                return $"Player {bt1} Wins!";
            }
            else if (bt1 != null && bt1 == bt4 && bt4 == bt7)
            {
                return $"Player {bt1} Wins!";
            }
            else if (bt1 != null && bt1 == bt5 && bt5 == bt9)
            {
                return $"Player {bt1} Wins!";
            }
            else if (bt4 != null && bt4 == bt5 && bt5 == bt6)
            {
                return $"Player {bt4} Wins!";
            }
            else if (bt7 != null && bt7 == bt8 && bt8 == bt9)
            {
                return $"Player {bt7} Wins!";
            }
            else if (bt2 != null && bt2 == bt5 && bt5 == bt8)
            {
                return $"Player {bt2} Wins!";
            }
            else if (bt3 != null && bt3 == bt6 && bt6 == bt9)
            {
                return $"Player {bt3} Wins!";
            }
            else if (bt3 != null && bt3 == bt5 && bt5 == bt7)
            {
                return $"Player {bt3} Wins!";
            }
            else
            {
                return "";
            }
        }

    }
}