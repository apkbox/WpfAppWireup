// --------------------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for App.xaml
// </summary>
// --------------------------------------------------------------------------------

namespace WpfAppWireup
{
    using System;
    using System.Windows;

    using WpfAppWireup.Model;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Methods

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            Factory.Instance = new MyFactory();
            this.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
        }

        #endregion
    }
}
