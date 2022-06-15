using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe_v3
{
    public partial class Form1 : Form
    {
        public int FreeSpace;
        public int BoardSize;
        public string[] Player = {"X","O","~","Z","@"};
        public int PlayerCurrent;
        public int PlayerCount;
        public Button[][] buttons;
        public bool Winner;
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateBoard(int size)
        {
            buttons = new Button[size][];
            for (int i = 0; i < size; i++)
            {
                Button[] buttonscol = new Button[size];
                for (int j = 0; j < size; j++)
                {
                    Button newbutton = new Button();
                    newbutton.Location = new System.Drawing.Point(i*(400/size), j*(400/size));
                    newbutton.Name = $"newbtn{i}{j}";
                    newbutton.Size = new System.Drawing.Size((400/size),(400/size));
                    newbutton.TabIndex = i+j;
                    newbutton.Text = String.Empty;
                    newbutton.UseVisualStyleBackColor = true;
                    newbutton.Click += new EventHandler(BoardClick);
                    buttonscol[j] = newbutton;
                    gb1.Controls.Add(newbutton);
                }
                buttons[i] = buttonscol;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            gb1.Controls.Clear();
            BoardSize = (int)nudBoardSize.Value;
            FreeSpace = BoardSize * BoardSize;
            PlayerCurrent = 0;
            Winner = false;
            lblWin.Text = String.Empty;
            PlayerCount = (int)nudPlayerCount.Value;
            btnStart.Text = "Restart";
            CreateBoard(BoardSize);
        }
        private void BoardClick(object sender,EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked.Text == String.Empty && Winner==false)
            {
                clicked.Text = Player[PlayerCurrent];


                FreeSpace--;
                Winner = CheckWinner();
                if (Winner)
                {
                    lblWin.Text = $"Player {Player[PlayerCurrent]} won";
                }
                else if (FreeSpace == 0)
                {
                    lblWin.Text = "Draw";
                }
                if (PlayerCurrent == PlayerCount-1)
                {
                    PlayerCurrent = 0;
                }
                else PlayerCurrent++;
            }
        }

        public bool CheckWinner()
        {
            bool winner = false;
            for (int i = 0; i < BoardSize; i++)
            {
                int similar = 0;
                for (int j = 0; j < BoardSize-1; j++)
                {
                    if (buttons[i][j].Text == buttons[i][j + 1].Text && buttons[i][j].Text!=String.Empty) similar++;
                }
                if (similar == BoardSize - 1)
                {
                    winner = true;
                    for (int j=0; j<BoardSize;j++)
                    {
                        buttons[i][j].BackColor = Color.Green;
                    }
                }
            }
            for (int i = 0; i < BoardSize; i++)
            {
                int similar = 0;
                for (int j = 0; j < BoardSize - 1; j++)
                {
                    if (buttons[j][i].Text == buttons[j+1][i].Text && buttons[j][i].Text != String.Empty) similar++;
                }
                if (similar == BoardSize - 1)
                {
                    winner = true;
                    for (int j = 0; j < BoardSize; j++)
                    {
                        buttons[j][i].BackColor = Color.Green;
                    }
                }
            }
            int similardiag = 0;
            for (int i=0; i < BoardSize-1; i++)
            {
                if (buttons[i][i].Text == buttons[i + 1][i + 1].Text && buttons[i][i].Text != String.Empty) similardiag++;
            }
            if (similardiag == BoardSize - 1)
            {
                winner = true;
                for (int i = 0; i < BoardSize; i++)
                {
                    buttons[i][i].BackColor = Color.Green;
                }
            }
            similardiag = 0;
            for (int i = BoardSize -1; i > 0; i--)
            {
                if (buttons[i][BoardSize-i-1].Text == buttons[i -1][BoardSize-i].Text && buttons[i][BoardSize-i-1].Text != String.Empty) similardiag++;
            }
            if (similardiag == BoardSize - 1)
            {
                winner = true;
                for (int i = BoardSize - 1; i >= 0; i--)
                {
                    buttons[i][BoardSize - i - 1].BackColor = Color.Green;
                }
                }
            return winner;
        }
    }
}
