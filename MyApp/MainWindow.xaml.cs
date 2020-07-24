using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity; //Esto se agrego
using Avalonia.Markup.Xaml;

namespace MyApp
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void GreetButton_Click(object sender, RoutedEventArgs e)
        {
            //Getting Controls references
            var nameControl = this.FindControl<TextBox>("NameTextBox");
            var messageControl = this.FindControl<TextBlock>("MessageLabel");

            //Setting the value
            messageControl.Text = $"Hello {nameControl.Text} !!!";
        }
    }
}