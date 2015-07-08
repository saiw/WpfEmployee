﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfEmployee.ViewModel;

/*TEst the github modify */


namespace WpfEmployee
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow widow = new MainWindow();
            
            var viewModel = new MainWindowViewModel();// initailize once 
            widow.DataContext = viewModel;

            widow.Show(); //twice 
        }
    }
}
