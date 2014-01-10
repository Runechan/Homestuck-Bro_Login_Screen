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

namespace OhHellNo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void windowLoaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            this.Topmost = true;
        }

        private void windowTerminate(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape || e.Key == Key.Enter)
            {
                this.Close();
            }
        }

        private void mouseoverButtonHighlight(object sender, MouseEventArgs e)
        {
            (sender as Border).Opacity = .5;
        }

        private void mouseleaveButtonHighlight(object sender, MouseEventArgs e)
        {
            (sender as Border).Opacity = 0;
        }

        private void windowClose(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
