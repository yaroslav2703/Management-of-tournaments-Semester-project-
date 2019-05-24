using System.Windows;
using System.Data.Entity;
using System.Windows.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Main
{
    public partial class NewTournament : ResourceDictionary
    {
        static public Tournament t1;
        static private NewTournament ex;
        static public int Number;
        static public int Number_max;
       

        static public NewTournament EX
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

        public NewTournament()
        {
            InitializeComponent();
            t1 = new Tournament();
            EX = this;
            Number = 0;
            Number_max = 0;
          

        }

        private void OnStart_Click(object sender, RoutedEventArgs e)
        {
            if ((title.Text == "") || (count.Text == "") || (type.Text == "") || (Number != Number_max) || Number_max == 0)
            {
                return;
            }

            t1.Title = title.Text;
            t1.Type = type.Text;
            t1.Count = count.Text;
            t1.Count_completed = 0;
            t1.isGenerate = false;
            MainWindow.DB.Tournaments.Add(t1);


            MainWindow.DB.SaveChanges();



            MainWindow.EX.MainWin.SetResourceReference(Window.ContentProperty, "StartPage");

          

            t1 = new Tournament();
            Number = 0;
            Number_max = 0;
        }

      

        private void AddTeam(object sender, RoutedEventArgs e)
        {
            if (count.Text != "")
            {
                Number_max = int.Parse(count.Text);
                if (Number < Number_max)
                {
                    AddWindow window1 = new AddWindow();
                    window1.Show();
                }

            }



        }

      
    }
}