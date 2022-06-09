using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tictactoev2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Player = "X";
        public int Rows = 3;
        public int Free;
        public bool GameOver = false;

        public MainWindow()
        {
            InitializeComponent();
          
            for (int i = 0; i < Rows; i++)
            {
            RowDefinition Row = new RowDefinition();
            GridLength rows = new GridLength(GameGrid.Height / Rows);
            Row.Height = rows;
            ColumnDefinition Column = new ColumnDefinition();
            GridLength cols = new GridLength(GameGrid.Width / Rows);
            Column.Width = cols;
            GameGrid.RowDefinitions.Add(Row);
            GameGrid.ColumnDefinitions.Add(Column);
            }
            Button b = new Button();
            NewGame();
        }
        public void NewGame()
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button.Content == null && GameOver == false)
            {
                if (Player == "X")
                {
                    button.Content = "X";

                    Free--;
                    Player = "O";
                }
                else if (Player == "O")
                {
                    button.Content = "O";

                    Free--;
                    Player = "X";
                }
                if (FindWinner())
                {
                    GameOver = true;
                }
                else if (Free == 0)
                {
                    GameOver = true;
                }

            }
            else if (GameOver) NewGame();


        }
        public bool FindWinner()
        {
            return true;
        }

    }
}

