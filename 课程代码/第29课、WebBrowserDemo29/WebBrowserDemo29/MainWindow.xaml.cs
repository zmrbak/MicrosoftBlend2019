using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WebBrowserDemo29
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null) return;

            ComboBoxItem comboBoxItem = comboBox.SelectedItem as ComboBoxItem;
            if (comboBoxItem == null) return;

            switch(comboBoxItem.Content.ToString())
            {
                case "淘宝":
                    webBrowser1.Navigate("http://www.taobao.com");
                    break;
                case "百度":
                    webBrowser1.Navigate("http://www.baidu.com");
                    break;
                default:
                    webBrowser1.Navigate("http://www.360.cn");
                    break;

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start(textBox1.Text);
        }
    }
}
