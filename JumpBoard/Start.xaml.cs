using NAudio.Wave;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}
