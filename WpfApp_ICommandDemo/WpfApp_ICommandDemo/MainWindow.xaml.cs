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

namespace WpfApp_ICommandDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int counter = 0;
        public MainWindow()
        {

            InitializeComponent();
            CounterTextBlock.Text = counter.ToString();

        }
        public void IncrementCounter(object sender, RoutedEventArgs e)
        {
            counter++;

            CounterTextBlock.Text = counter.ToString();

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                counter++;

                CounterTextBlock.Text = counter.ToString();
            }

        }
    }
}

