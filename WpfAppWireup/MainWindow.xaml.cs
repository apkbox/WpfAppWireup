// --------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------

namespace WpfAppWireup
{
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructors and Destructors

        public MainWindow()
        {
            this.DataContext = this;
            this.ClickMeCommand = new ClickMeCommand();
            this.InitializeComponent();
        }

        #endregion

        #region Public Properties

        public ICommand ClickMeCommand { get; private set; }

        #endregion
    }
}
