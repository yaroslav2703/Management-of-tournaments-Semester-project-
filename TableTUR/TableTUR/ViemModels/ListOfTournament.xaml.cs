using System;
using System.Collections.Generic;
using System.Windows;
using System.Data;
using System.Data.Entity;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Configuration;

namespace Main
{
   public partial class ListOfTournament : ResourceDictionary
    {
        static private ListOfTournament ex1;

        public ListOfTournament()
        {
            InitializeComponent();
            EX1 = this;


        }



        static public ListOfTournament EX1
        {
            get
            {
                return ex1;
            }

            set
            {
                ex1 = value;
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow.EX.MainWin.SetResourceReference(Window.ContentProperty, "StartPage");
        }

        private void AddT(object sender, RoutedEventArgs e)
        {
            MainWindow.EX.MainWin.SetResourceReference(Window.ContentProperty, "NewTournament");
        }

       
    }
}