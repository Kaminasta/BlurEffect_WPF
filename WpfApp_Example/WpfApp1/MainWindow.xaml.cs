using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using BlurEffect;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BlurOn_Click(object sender, RoutedEventArgs e)
        {
            this.EnableBlur();
        }

        private void BlurOff_Click(object sender, RoutedEventArgs e)
        {
            this.DisableBlur();
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenWeb_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Kaminasta/BlurEffect_WPF",
                UseShellExecute = true
            });
        }
    }
}