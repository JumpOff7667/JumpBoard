using System;
using System.Windows;

namespace JumpBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (Properties.Settings.Default.FirstRun)
            {
                MainFrame.NavigationService.Navigate(new Uri("Start.xaml", UriKind.RelativeOrAbsolute));
            } else
            {
                MainFrame.NavigationService.Navigate(new Uri("Home.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
