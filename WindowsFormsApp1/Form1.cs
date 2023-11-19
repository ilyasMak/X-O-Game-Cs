using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        static public int compt = 0;
        public String Player1 = "Player 1", Player2 = "Player 2";
        public int[,]p = new int[3,3];
        public Boolean changePly1 = false, changePly2 = false; 
        public Form1()
        {
            InitializeComponent();
            initialiser(); 


        }

        public void initialiser()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    p[i, j] = -(i + 3 * j + 1);
                }
            }
        }

        public Boolean WhoWins() {
            for(int i =0; i<3; i++)
            {
                if (p[i,0] == p[i,1] && p[i,0] == p[i,2])  return true;
                if (p[0, i] == p[1, i] && p[0, i] == p[2, i]) return true;
            }
            if (p[0, 0] == p[1,1] && p[0,0] == p[2,2]) return true;
            if (p[0, 2] == p[1, 1] && p[1, 1] == p[2, 0]) return true;
            return false; 

        }

        public void writeXO(Button button, int c, int x, int y)
        {

            if (!WhoWins()) { 

                if (c % 2 == 1)
            {
                button.ForeColor = Color.Red;
                button.Text = "X";
                p[x, y] = 1;

                if (WhoWins()) {  Lwinner.Text = Player1 + " wins"; this.BackColor =Color.Red; };

            }
            else
            { button.ForeColor = Color.Blue;
                button.Text = "O";
                p[x, y] = 0;
                if (WhoWins()) {  Lwinner.Text = Player2 + " wins"; this.BackColor = Color.Blue; }



            }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            compt++;
            writeXO(B00, compt,0,0);
            B00.Click -= button1_Click;

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            compt++;
            writeXO(B01, compt,0,1);
            B01.Click -= button1_Click_1;
        }

        private void B02_Click(object sender, EventArgs e)
        {
            compt++;
            writeXO(B02, compt,0,2);
            B02.Click -= B02_Click;
        }

        private void B10_Click(object sender, EventArgs e)
        {
            compt++;
            writeXO(B10, compt,1,0);
            B10.Click -= B10_Click;

        }

        private void B11_Click(object sender, EventArgs e)
        {
            compt++;
            writeXO(B11, compt,1,1);
            B11.Click -= B11_Click;
        }

        private void B12_Click(object sender, EventArgs e)
        {
            compt++;
            writeXO(B12, compt,1,2);
            B12.Click -= B12_Click;

        }

        private void B20_Click(object sender, EventArgs e)
        {
            compt++;
            writeXO(B20, compt,2,0);
            B20.Click -= B20_Click;

        }

        private void B21_Click(object sender, EventArgs e)
        {
            compt++;
            writeXO(B21, compt,2,1);
            B21.Click -= B21_Click;

        }

        private void B22_Click(object sender, EventArgs e)
        {
            compt++;
            writeXO(B22, compt,2,2);
            B22.Click -= B22_Click;
        }

        private void TBply2_TextChanged(object sender, EventArgs e)
        {
            if (changePly2 == false)
            {
                changePly2= true;
                TBply2.Text = TBply2.Text.Replace("Player 2", "");
                TBply2.SelectionStart = TBply2.TextLength;

            }
            if (TBply2.Text != "") Player2= TBply2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Breplay_Click(object sender, EventArgs e)
        {
            compt =0; 
            Lwinner.Text = "";
            B00.Text = ""; B01.Text = ""; B02.Text = ""; B10.Text = ""; B11.Text = ""; B12.Text = ""; B20.Text = ""; B21.Text = ""; B22.Text = "";
            B00.Click += button1_Click; ; B01.Click += button1_Click_1; B02.Click += B02_Click;
            B10.Click += B10_Click; B11.Click += B11_Click; B12.Click += B12_Click;
            B20.Click += B20_Click; B21.Click += B21_Click; B22.Click += B22_Click;
            this.BackColor = Color.White;
            initialiser();
        }

        private void Lwinner_Click(object sender, EventArgs e)
        {

        }

        private void TBply1_TextChanged(object sender, EventArgs e)
        {
            if(changePly1==false)
            {
                changePly1 = true;
                TBply1.Text = TBply1.Text.Replace("Player 1" , "");
                TBply1.SelectionStart = TBply1.TextLength;

            }
           if(TBply1.Text!="") Player1 = TBply1.Text;
        }
    }
}
