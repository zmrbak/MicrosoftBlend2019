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

namespace ListBoxDemo22
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox == null) return;

            this.textBlock1.Text = "";
            foreach (Object item in listBox.SelectedItems)
            {
                ListBoxItem listBoxItem = item as ListBoxItem;
                if(listBoxItem!= null)
                {
                    this.textBlock1.Text += listBoxItem.Content.ToString();
                    continue;
                }

                Button button = item as Button;
                if (button != null)
                {
                    this.textBlock1.Text += button.Content.ToString();
                    continue;
                }


            }
        }
    }
}
