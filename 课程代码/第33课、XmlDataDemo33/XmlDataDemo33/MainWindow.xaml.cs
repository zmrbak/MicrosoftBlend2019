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

namespace XmlDataDemo33
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
            BindingExpression bindingExpression1 = this.textBox1.GetBindingExpression(TextBox.TextProperty);
            bindingExpression1.UpdateSource();

            BindingExpression bindingExpression2 = this.textBox2.GetBindingExpression(TextBox.TextProperty);
            bindingExpression2.UpdateSource();

            BindingExpression bindingExpression3 = this.textBox3.GetBindingExpression(TextBox.TextProperty);
            bindingExpression3.UpdateSource();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            XmlDataProvider xmlDataProvider = this.FindResource("人员信息表DataSource") as XmlDataProvider;
            xmlDataProvider.Document.Save("renyuanxinxibiao.xml");
            MessageBox.Show("保存成功！");
        }
    }
}
