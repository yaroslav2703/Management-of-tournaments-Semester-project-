using System;
using System.Collections.Generic;
using System.Windows;
using System.Data;
using System.Data.Entity;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace Main
{
     partial  class First : ResourceDictionary
     {
      

        public First()
        {
            InitializeComponent();
        }

        private void Bn2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.EX.MainWin.SetResourceReference(Window.ContentProperty, "NewTournament");
            NewTournament.Number = 0;
            NewTournament.Number_max = 0;



        }

        private void Bn1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.EX.MainWin.SetResourceReference(Window.ContentProperty, "ListOfTournament");
            ListOfTournament.EX1.ListofTournament.Children.Clear();
            var All_tournaments = MainWindow.DB.Tournaments;
            foreach (var t in All_tournaments)
            {
                Button new_button = new Button();
                new_button.Content = t.Title;
                //new_button.Name = t.Title;
                new_button.Click += New_button_Click;
                ListOfTournament.EX1.ListofTournament.Children.Add(new_button);


            }



        }

        private void New_button_Click(object sender, RoutedEventArgs e)
        {
            ListOfTournament.EX1.label1.SetResourceReference(Label.ContentProperty, "TournamentInfo");
            Button button = (Button)e.Source;
            var tournaments = MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == (string)button.Content);
            TournamentInfo.EX.title.Text = tournaments.Title;
            int q = int.Parse(tournaments.Count) / 2;
            TournamentInfo.EX.gamecount.Text = q.ToString();
            TournamentInfo.EX.game_completed.Text = tournaments.Count_completed.ToString();

            TournamentInfo.EX.result.Text = " ";

            int d = int.Parse(tournaments.Count) / 2;
            if (d == tournaments.Count_completed)
            {
                TournamentInfo.EX.newround.IsEnabled = true;
            }
            if (tournaments.isGenerate == false)
            {
                TournamentInfo.EX.generate.IsEnabled = true;
            }
            else
            {
                TournamentInfo.EX.generate.IsEnabled = false;
            }
           
            TournamentInfo.EX.gamesList.Items.Clear();
            Tournament tournament = MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == tournaments.Title);


            foreach (var t in tournament.Games)
            {

                ListBoxItem v = new ListBoxItem();
                v.Content = t.First.Name + " VS " + t.Second.Name;
                v.Name = t.First.Name + "_VS_" + t.Second.Name;
                v.Selected += InfoGame;
                TournamentInfo.EX.gamesList.Items.Add(v);

            }


            if (int.Parse(tournament.Count) == 1)
            {
                TournamentInfo.EX.newround.IsEnabled = false;
                TournamentInfo.EX.generate.IsEnabled = false;
                var h = MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == TournamentInfo.EX.title.Text);

                Team win = h.Teams.FirstOrDefault();

                TournamentInfo.EX.result.Text = win.Name + " стал чемпионом в турнире";
            }


        }

        private void InfoGame(object sender, RoutedEventArgs e)
        {
            InfoOfGameWindow infoOfGameWindow1 = new InfoOfGameWindow();
            ListBoxItem listBoxItem = (ListBoxItem)e.Source;
            infoOfGameWindow1.Show();



            string vr;
            string ch = " VS ";
            string first;
            string second;
            vr = (string)listBoxItem.Content;

            int indexOfChar = vr.IndexOf(ch);
            int i = vr.Length - 2;
            first = vr.Substring(0, indexOfChar);
            second = vr.Substring(indexOfChar + 4);

            Game game = MainWindow.DB.Games.FirstOrDefault(a => (a.First.Name == first) && (a.Second.Name == second));
            if (game.Was == true)
            {
                if (game.Winner == game.First)
                {
                    InfoOfGameWindow.EX.check1.IsChecked = true;
                }
                else if (game.Winner == game.Second)
                {
                    InfoOfGameWindow.EX.check2.IsChecked = true;
                }

            }

            InfoOfGameWindow.EX.firstt.Text = game.First.Name;
            InfoOfGameWindow.EX.secondt.Text = game.Second.Name;

        }

     }
}
