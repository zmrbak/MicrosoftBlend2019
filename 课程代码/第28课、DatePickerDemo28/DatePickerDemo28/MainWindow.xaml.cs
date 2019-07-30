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

namespace DatePickerDemo28
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

        private void DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            DatePicker datePicker = sender as DatePicker;
            if (datePicker == null) return;

            textBlock1.Text += "DatePicker_CalendarClosed"+Environment.NewLine;
        }

        private void DatePicker_CalendarOpened(object sender, RoutedEventArgs e)
        {
            DatePicker datePicker = sender as DatePicker;
            if (datePicker == null) return;

            textBlock1.Text += "DatePicker_CalendarOpened" + Environment.NewLine;

        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = sender as DatePicker;
            if (datePicker == null) return;

            if (textBlock1 == null) return;

            textBlock1.Text += "DatePicker_SelectedDateChanged" + Environment.NewLine;

            textBlock1.Text +=datePicker.SelectedDate.Value.ToShortDateString();

        }
    }
}
