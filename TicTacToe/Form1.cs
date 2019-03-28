using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static ticTacToeBtn[,] grid = new ticTacToeBtn[3, 3];

        bool xTurn = true;
        int drawCount = 0;

        public Form1()
        {
            InitializeComponent();
            ticTacToeBtn tic_btn = new ticTacToeBtn();

            int x = 0, y = 0;
            Point loc = new Point(x, y);

            //initialize the grid with buttons
            for(int r = 0; r < 3; r++)
            {
                for(int c = 0; c < 3; c++)
                {
                    x = 110 * r;
                    y = 110 * c;
                    grid[r, c] = new ticTacToeBtn();
                    this.Controls.Add(grid[ r , c ]);
                    grid[r, c].Location = new Point( x , y );
                    grid[r, c].Click += new EventHandler(button_Click);

                }

                y = 0;
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            //capture sender
            ticTacToeBtn t = (ticTacToeBtn)sender;

            if (xTurn)
            {
                t.Text = "X";
                t.BackColor = Color.LightPink;
            }
            else
            {
                t.Text = "O";
                t.BackColor = Color.LightBlue;
            }
            xTurn = !xTurn;

            t.Enabled = false;
            drawCount++;

            if(isWinner() == true)
            {
                MessageBox.Show("Winner!");
                resetBoard();
            }

            if(drawCount == 9 && isWinner() == false)
            {
                MessageBox.Show("its a draw");
                resetBoard();
            }


        }


        public bool isWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if(grid[i, 0].Text == grid[i, 1].Text && grid[i, 1].Text == grid[i, 2].Text && grid[i, 0].Text != "*")
                {
                    return true;
                }
                if(grid[0, i].Text == grid[1, i].Text && grid[1, i].Text == grid[2, i].Text && grid[0, i].Text != "*")
                {
                    return true;
                }
                if(grid[0,0].Text == grid[1,1].Text && grid[1,1].Text == grid[2, 2].Text && grid[0, 0].Text != "*")
                {
                    return true;
                }
                if (grid[0, 2].Text == grid[1, 1].Text && grid[1, 1].Text == grid[2, 0].Text && grid[0, 2].Text != "*")
                {
                    return true;
                }
            }

           return false;
        }

        public void resetBoard()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    grid[r, c].Text = "*";
                    grid[r, c].BackColor = Color.LightGray;
                }

               
            }
            drawCount = 0;
        }
    }
}
