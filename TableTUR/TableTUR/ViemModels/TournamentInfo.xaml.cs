using System;
using System.Collections.Generic;
using System.Windows;
using System.Data;
using System.Data.Entity;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Collections;
using System.Windows.Input;

namespace Main
{
    public partial class TournamentInfo : ResourceDictionary
    {
        static private TournamentInfo ex;

        public TournamentInfo()
        {
            InitializeComponent();
            EX = this;
        }

        static public TournamentInfo EX
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

        private void Generate(object sender, RoutedEventArgs e)
        {
            MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).Games.Clear();
            Tournament tournament = MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text);
            MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).isGenerate = true;
            TournamentInfo.EX.generate.IsEnabled = false;
            var teams = tournament.Teams;
            int count = int.Parse(tournament.Count) / 2;
            this.gamecount.Text = count.ToString();
            Team[] new_col = new Team[count * 2];

            for (int g = 0; g < count * 2; g++)
            {
                new_col[g] = null;
            }


            int[] colr = new int[count * 2];
            for (int g = 0; g < count * 2; g++)
            {
                colr[g] = -1;
            }
            int j = 0;
            Random rand = new Random();
            foreach (var t in tournament.Teams)
            {

                for (; ; )
                {
                    j = rand.Next(0, count * 2);
                    if (colr[j] == -1)
                    {
                        colr[j] = j;
                        new_col[j] = t;
                        break;
                    }
                    else
                    {
                        continue;
                    }


                }

            }

            int y = 0;

            for (int i = 0; i < count; i++)
            {

                MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).Games.Add(new Game
                {
                    Name = tournament,
                    Was = false,
                    First = new_col[y],
                    Second = new_col[y + 1]
                }
                );
                y = y + 2;
                MainWindow.DB.SaveChanges();
            }
            y = 0;

            tournament = MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text);


            foreach (var t in tournament.Games)
            {
                ListBoxItem v = new ListBoxItem();
                v.Content = t.First.Name + " VS " + t.Second.Name;
                v.Name = t.First.Name + "_VS_" + t.Second.Name;
                v.Selected += InfoGame;
                TournamentInfo.EX.gamesList.Items.Add(v);


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

        private void NextRound(object sender, RoutedEventArgs e)
        {
           
            this.newround.IsEnabled = false;
          
            var h = MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text);
           
           
                List<Team> winners = new List<Team>();
            var allgames = h.Games;
            int i = 0;
            foreach(Game y in allgames)
            {
                winners.Add(y.Winner);
                i++;
            }
            
            MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).Games.Clear();
            MainWindow.DB.SaveChanges();
            MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).Teams.Clear();
            MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).isGenerate = false;
            MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).Count_completed = 0;
            MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).Count = i.ToString();
            MainWindow.DB.SaveChanges();
            foreach (Team k in winners)
            {
                
                MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text).Teams.Add(k);
                MainWindow.DB.SaveChanges();

            }

            TournamentInfo.EX.game_completed.Text = "0";
            TournamentInfo.EX.gamecount.Text = "0";
            TournamentInfo.EX.gamesList.Items.Clear();

            if (int.Parse(h.Count) == 1)
            {
                this.generate.IsEnabled = false;
                Team win = h.Teams.FirstOrDefault();
                this.result.Text= win.Name + " стал чемпионом в турнире";
            }
            else
            {
                
                 this.generate.IsEnabled = true;
                
            }
                winners.Clear();
          i = 0;

        }

        private void CancelTournamentall(object sender, RoutedEventArgs e)
        {
            Tournament th = MainWindow.DB.Tournaments.FirstOrDefault(t => t.Title == this.title.Text);
            MainWindow.DB.Tournaments.Remove(th);
            MainWindow.DB.SaveChanges();
            MainWindow.EX.MainWin.SetResourceReference(Window.ContentProperty, "StartPage");
            ListOfTournament.EX1.label1.Content = "Выберите турнир";

        }
    }
}
