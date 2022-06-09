using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace tictactoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Player ="X";

        public int Free = 9;
        public bool GameOver = false;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();

        }
        public void NewGame()
        {
            GameOver = false;
            Free = 9;
            Player = "X";
            Button00.Content = null;
            Button00.Background = Brushes.LightGray;
            Button01.Content = null;
            Button01.Background = Brushes.LightGray;
            Button02.Content = null;
            Button02.Background = Brushes.LightGray;
            Button10.Content = null;      
            Button10.Background = Brushes.LightGray;
            Button11.Content = null;     
            Button11.Background = Brushes.LightGray;
            Button12.Content = null;      
            Button12.Background = Brushes.LightGray;
            Button20.Content = null;     
            Button20.Background = Brushes.LightGray;
            Button21.Content = null;      
            Button21.Background = Brushes.LightGray;
            Button22.Content = null;      
            Button22.Background = Brushes.LightGray;
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
            bool anserw = false;
            if (Button00.Content == Button01.Content && Button00.Content == Button02.Content && Button00.Content!=null)
            {
                Button00.Background = Brushes.Green;
                Button01.Background = Brushes.Green;
                Button02.Background = Brushes.Green;
                anserw = true;
            }
            if (Button10.Content == Button11.Content && Button10.Content == Button12.Content && Button10.Content != null)
            {
                Button10.Background = Brushes.Green;
                Button11.Background = Brushes.Green;
                Button12.Background = Brushes.Green;
                anserw = true;
            }
            if (Button20.Content == Button21.Content && Button20.Content == Button22.Content && Button20.Content != null)
            {
                Button20.Background = Brushes.Green;
                Button21.Background = Brushes.Green;
                Button22.Background = Brushes.Green;
                anserw = true;
            }
            if (Button00.Content == Button10.Content && Button00.Content == Button20.Content && Button00.Content != null)
            {
                Button00.Background = Brushes.Green;
                Button10.Background = Brushes.Green;
                Button20.Background = Brushes.Green;
                anserw = true;
            }
            if (Button01.Content == Button11.Content && Button01.Content == Button21.Content && Button01.Content != null)
            {
                Button01.Background = Brushes.Green;
                Button11.Background = Brushes.Green;
                Button21.Background = Brushes.Green;
                anserw = true;
            }
            if (Button02.Content == Button12.Content && Button02.Content == Button22.Content && Button02.Content != null)
            {
                Button02.Background = Brushes.Green;
                Button12.Background = Brushes.Green;
                Button22.Background = Brushes.Green;
                anserw = true;
            }
            if (Button00.Content == Button11.Content && Button00.Content == Button22.Content && Button00.Content != null)
            {
                Button00.Background = Brushes.Green;
                Button11.Background = Brushes.Green;
                Button22.Background = Brushes.Green;
                anserw = true;
            }
            if (Button02.Content == Button11.Content && Button02.Content == Button20.Content && Button02.Content != null)
            {
                Button02.Background = Brushes.Green;
                Button11.Background = Brushes.Green;
                Button20.Background = Brushes.Green;
                anserw = true;
            }
            if (anserw)
            {
                return true;
            }
            else return false;
        }
    }
}
