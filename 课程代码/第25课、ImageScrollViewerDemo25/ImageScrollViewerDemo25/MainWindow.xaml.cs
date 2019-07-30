using Microsoft.Win32;
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

namespace ImageScrollViewerDemo25
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件|*.jpg|所有文件|*.*";
            openFileDialog.Title = "请选择图片文件";
            if (openFileDialog.ShowDialog() == true)
            {
                //image1.Source = new ImageSourceConverter()
                //    .ConvertFromString(openFileDialog.FileName)
                //    as ImageSource;
                image1.Source = new BitmapImage(new Uri(openFileDialog.FileName, UriKind.Absolute));

            }
        }
    }
}
