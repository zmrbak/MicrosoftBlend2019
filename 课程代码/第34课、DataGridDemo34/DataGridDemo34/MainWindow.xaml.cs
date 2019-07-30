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

namespace DataGridDemo34
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //创建List数据集
        public List<RenYuanClass> ryList = new List<RenYuanClass>();

        public MainWindow()
        {
            InitializeComponent();
            AddData();
            dataGrid1.ItemsSource = ryList;
        }

        private void AddData()
        {
            ryList.Add(new RenYuanClass(1, "方怀玉", "国际航空公司", "女", 20, "本科大学生"));
            ryList.Add(new RenYuanClass(2, "纪曾方", "计算机软件设计所", "男", 19, "本科大学生"));
            ryList.Add(new RenYuanClass(3, "章伊莉", "多媒体艺术设计工作室", "女", 22, ""));
            ryList.Add(new RenYuanClass(4, "王晓鹏", "房地产咨询公司", "男", 21, "专科生"));
            ryList.Add(new RenYuanClass(5, "张继宇", "广告策划中心", "男", 25, "有2年工作经验"));
            ryList.Add(new RenYuanClass(6, "陈雨", "科技开发中心", "女", 30, "担任过公司经理"));
            ryList.Add(new RenYuanClass(7, "刘涵云", "医疗设备站", "女", 27, "担任过部门负责人"));
            ryList.Add(new RenYuanClass(8, "李肖潇", "渤海旅游公司", "男", 26, ""));
            ryList.Add(new RenYuanClass(9, "赵家铭", "自来水设备公司", "男", 31, "长期担任维修"));

        }

        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //textBlock.Text = ryList[dataGrid1.SelectedIndex].姓名;

            textBlock.Text = "";
            foreach (RenYuanClass item in dataGrid1.SelectedItems)
            {
                textBlock.Text += item.姓名;
            }

            dataGrid.ItemsSource = dataGrid1.SelectedItems;


        }
    }
}
