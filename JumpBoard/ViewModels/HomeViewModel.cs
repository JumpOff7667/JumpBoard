using System.Windows.Controls;

namespace JumpBoard.ViewModels
{
    internal class HomeViewModel
    {
        private void SoundboardsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*ListView sourceListView = e.Source as ListView;
            if (sourceListView.SelectedItem == null)
            {
                _ = SoundboardFrame.NavigationService.Navigate(new Uri("NoSoundboard.xaml", UriKind.RelativeOrAbsolute));
            }
            else
            {
                _ = SoundboardFrame.NavigationService.Navigate(new Page());
            }*/
        }
    }
}
