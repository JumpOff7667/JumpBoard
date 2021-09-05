using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace JumpBoard
{
    /// <summary>
    /// Interaction logic for NoSoundboard.xaml
    /// </summary>
    public partial class NoSoundboard : Page
    {
        public NoSoundboard()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            string folderPath = "";
            string soundboardName = "";

            FolderBrowserDialog folderBrowserDialog1 = new();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            InputDialog inputDialog = new("Please enter the soundboard name:");
            if (inputDialog.ShowDialog() == true)
            {
                soundboardName = inputDialog.Answer;
            }

            SoundboardsManager sbManager = SoundboardsManager.GetInstance();
            sbManager.Soundboards.Add(new Soundboard(soundboardName, folderPath));
        }
    }
}
