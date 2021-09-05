using NAudio.Wave;
using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace JumpBoard
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();
            EnumerateAudioOut();
        }

        private void EnumerateAudioOut()
        {
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                WaveOutCapabilities caps = WaveOut.GetCapabilities(n);
                FirstOutputComboBox.Items.Add(caps.ProductName); // Substract 2 from ComboBox selection index to get device number
                SecondOutputComboBox.Items.Add(caps.ProductName);
            }
        }

        private void ConfirmButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Properties.Settings.Default.FirstRun = false;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

            NavigationService ns = NavigationService.GetNavigationService(this);
            ns.Navigate(new Uri("Home.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
