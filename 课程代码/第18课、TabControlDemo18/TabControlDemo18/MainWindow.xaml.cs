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

namespace TabControlDemo18
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Backgroundcolor_GotFocus(object sender, RoutedEventArgs e)
        {
            TabItem tabItem = sender as TabItem;
            if (tabItem == null) return;

            MessageBox.Show(tabItem.Header.ToString());

        }

        private void tabItem(object sender, RoutedEventArgs e)
        {

        }
    }
}
