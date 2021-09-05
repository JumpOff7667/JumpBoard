using System.Windows.Controls;

namespace JumpBoard
{
    /// <summary>
    /// Interaction logic for Example.xaml
    /// </summary>
    public partial class Home : Page
    {
        ViewModels.HomeViewModel VM = new();

        public Home()
        {
            InitializeComponent();
            RefreshListView();

            DataContext = VM;
        }

        private void RefreshListView()
        {
            SoundboardsListView.Items.Clear();
            foreach (Soundboard soundboard in SoundboardsManager.GetInstance().Soundboards)
            {
                _ = SoundboardsListView.Items.Add(soundboard.Name);
            }
        }


    }
}
