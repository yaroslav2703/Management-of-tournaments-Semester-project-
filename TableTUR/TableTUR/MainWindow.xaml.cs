using System;
using System.Windows;
using System.Data.Entity;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Main
{
  
    public partial class MainWindow : Window
    {
        static private TournamentContext db;
        static private MainWindow ex;


      static public MainWindow EX
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

        static public TournamentContext DB
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            EX = this;
            TournamentContext db1 = new TournamentContext();
            db1.Tournaments.Load();
            db1.Teams.Load();
            DB = db1;
           
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DB.Dispose();
        }

        
    }
         
}