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
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        static public string vr;
        public AddWindow()
        {
            InitializeComponent();
        }

        private void AddTeam(object sender, RoutedEventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Введите название команды");
                return;
            }
            int indexOfChar = name.Text.IndexOf(" ");
            if (indexOfChar != -1)
            {
                MessageBox.Show("В названии команды не может быть пробелов");
                return;
            }


            ListBoxItem newtextBlock = new ListBoxItem();
            newtextBlock.Content = NewTournament.Number + 1 + ". " + name.Text;
            NewTournament.EX.teamsList.Items.Add(newtextBlock); 
            NewTournament.Number++;
            Team new_team = new Team();
            new_team.Name = name.Text;
            MainWindow.DB.Teams.Add(new_team);
            MainWindow.DB.SaveChanges();
            NewTournament.t1.Teams.Add(new_team);

            this.Close();

        }

        


    }
}
