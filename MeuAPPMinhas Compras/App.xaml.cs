﻿using MeuAPPMinhas_Compras.Helpers;

namespace MeuAPPMinhas_Compras
{
    public partial class App : Application
    {
        static SQliteDatabaseHelper _db;

        public static SQliteDatabaseHelper Db
        {

            get

            {
                if (_db == null)

                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3"               
                        );

                    _db = new SQliteDatabaseHelper(path);

                }
                return _db;


            }



        }

        public App()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");


            // MainPage = new AppShell();
            MainPage = new NavigationPage(new Views.ListaProduto());

        }
    }
}
