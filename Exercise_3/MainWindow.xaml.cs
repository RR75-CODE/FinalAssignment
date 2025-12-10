using System.Windows;

namespace Exercise_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        InitializeComponent();
        }
        private void MainEngine_Checked(object sender, RoutedEventArgs e)
        {
            MainEngine.Content = "Engine On";

            Audio.IsEnabled = true;
            Wipers.IsEnabled = true;
            AC.IsEnabled = true;

            Audio.IsChecked = true;
            Wipers.IsChecked = true;
            AC.IsChecked = true;
        }
        private void MainEngine_Unchecked(object sender, RoutedEventArgs e)
        {
            MainEngine.Content = "Engine Off";

            Audio.IsEnabled = false;
            Wipers.IsEnabled = false;
            AC.IsEnabled = false;

            Audio.IsChecked = false;
            Wipers.IsChecked = false;
            AC.IsChecked = false;
        }
        private void MainEngine_Indeterminate(object sender, RoutedEventArgs e)
        {
            MainEngine.Content = "Ignition";

            Audio.IsEnabled = true;
            Wipers.IsEnabled = true;

            AC.IsEnabled = false;

            Audio.IsChecked = true;
            Wipers.IsChecked = true;
            AC.IsChecked = false;
        }
    }

}
