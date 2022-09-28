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

namespace SpeedTestWritting
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

        private void statrTest_Click(object sender, RoutedEventArgs e)
        {
            textBoxExample.Text = "Привет Тарас. Давай работай!";
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            textBoxExample.Clear();
            textBoxInput.Clear();
            timeChoice.SelectedIndex = -1;
            
        }
    }
}
