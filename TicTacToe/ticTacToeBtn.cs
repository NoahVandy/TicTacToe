using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    class ticTacToeBtn : Button
    {
        public static int btnSize = 100;

        public ticTacToeBtn()
        {
            this.Width = this.Height = btnSize;
            this.BackColor = Color.LightGray;
            this.Text = "*";
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Helvetica", 25);
            this.Click += new EventHandler(this.ticTacToebtn);

        }

        private void ticTacToebtn(object sender, EventArgs e)
        {



        }

    }
}
