using System;
using System.Windows;

namespace JumpBoard
{
    /// <summary>
    /// Interaction logic for InputDialog.xaml
    /// </summary>
    public partial class InputDialog : Window
    {
        public InputDialog(string question, string defaultAnswer = "SoundBoard")
        {
            InitializeComponent();
            QuestionLabel.Content = question;
            AnswerTextBox.Text = defaultAnswer;
        }

        private void DialogOkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            AnswerTextBox.SelectAll();
            AnswerTextBox.Focus();
        }

        public string Answer
        {
            get { return AnswerTextBox.Text; }
        }
    }
}
