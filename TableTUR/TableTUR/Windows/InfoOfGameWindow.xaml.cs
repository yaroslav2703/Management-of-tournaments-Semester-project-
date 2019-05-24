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
using System.Windows.Shapes;

namespace Main
{
  
    public partial class InfoOfGameWindow : Window
    {
        static private InfoOfGameWindow ex;

        static public InfoOfGameWindow EX
        {
            get
            {
                return ex;
            }

            set
            {
                ex = value;
            }
        }

        public InfoOfGameWindow()
        {
            InitializeComponent();
            EX = this;
        }

        private void Winner_on_Click(object sender, RoutedEventArgs e)
        {
            if ((check1.IsChecked != true) && (check2.IsChecked != true))
            {
                MessageBox.Show("Выберите победителя ");
                return;

            }
            int aa = int.Parse(MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == TournamentInfo.EX.title.Text).Count)/2;
            if (MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == TournamentInfo.EX.title.Text).Count_completed<aa)
            {
                MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == TournamentInfo.EX.title.Text).Count_completed++;
                MainWindow.DB.SaveChanges();
            }
          
            var tournaments = MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == TournamentInfo.EX.title.Text);
            TournamentInfo.EX.game_completed.Text = tournaments.Count_completed.ToString();
            int d = int.Parse(tournaments.Count)/2;
            if (d == tournaments.Count_completed)
            {
                TournamentInfo.EX.newround.IsEnabled = true;
            }
            Game game = MainWindow.DB.Games.FirstOrDefault(a => (a.First.Name == firstt.Text) && (a.Second.Name == secondt.Text));
            if (check1.IsChecked == true)
            {
                MainWindow.DB.Games.FirstOrDefault(a => (a.First.Name == firstt.Text) && (a.Second.Name == secondt.Text)).Winner = game.First;
                MainWindow.DB.Games.FirstOrDefault(a => (a.First.Name == firstt.Text) && (a.Second.Name == secondt.Text)).Was = true;
                MainWindow.DB.SaveChanges();
               

                    this.Close();
            }
            else if (check2.IsChecked == true)
            {
                MainWindow.DB.Games.FirstOrDefault(a => (a.First.Name == firstt.Text) && (a.Second.Name == secondt.Text)).Winner = game.Second;
                MainWindow.DB.Games.FirstOrDefault(a => (a.First.Name == firstt.Text) && (a.Second.Name == secondt.Text)).Was = true;
                MainWindow.DB.SaveChanges();
               

                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите победителя ");
                return;
            }

        }
    }

   




}
