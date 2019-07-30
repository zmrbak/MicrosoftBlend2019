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

namespace ComboBoxDemo21
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

            ComboBoxItem comboBoxItem = ((ComboBoxItem)(comboBox.SelectedItem));
            if (comboBoxItem == null) return;

            this.textBlock1.Text = ((ComboBoxItem)(comboBox.SelectedItem)).Content.ToString();
            ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.textBlock1.Text = comboBox1.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
