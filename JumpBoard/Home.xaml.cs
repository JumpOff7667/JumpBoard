using System.Windows;
using System.Windows.Controls;

namespace JumpBoard
{
    /// <summary>
    /// Interaction logic for Example.xaml
    /// </summary>
    public partial class Example : Page
    {
        public Example()
        {
            InitializeComponent();

            if (SoundboardsListView.Items.IsEmpty)
            {
                EmptyListViewTextBlock.Visibility = Visibility.Visible;
                AddDirectoryButton.Visibility = Visibility.Visible;
            }
        }
    }
}
