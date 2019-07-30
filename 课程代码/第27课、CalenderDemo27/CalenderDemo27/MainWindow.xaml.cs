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

namespace CalenderDemo27
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

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {


            textBlock1.Text = "";

            Calendar calendar = sender as Calendar;

           if (calendar.SelectedDate!=null)
            {
                DateTime dateTime = calendar.SelectedDate.Value;

                clockDate1.Text = dateTime.ToString("yyyy-MM-dd");
            }


            foreach (var item in calendar.SelectedDates)
            {
                textBlock1.Text += item.ToString("yyyy-MM-dd") +Environment.NewLine;
            }

            
        }

        private void TextBlock_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            clockTime1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ClockDate1_Loaded(object sender, RoutedEventArgs e)
        {
            clockDate1.Text = calender1.DisplayDate.ToString("yyyy-MM-dd");
        }
    }
}
