//   *********  请勿修改此文件   *********
//   此文件由设计工具再生成。更改
//   此文件可能会导致错误。
namespace Expression.Blend.SampleData.人员信息表SampleDataSource
{
    using System; 
    using System.ComponentModel;

// 若要在生产应用程序中显著减小示例数据涉及面，则可以设置
// DISABLE_SAMPLE_DATA 条件编译常量并在运行时禁用示例数据。
#if DISABLE_SAMPLE_DATA
    internal class renyuans { }
#else

    public class renyuans : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public renyuans()
        {
            try
            {
                Uri resourceUri = new Uri("SampleData/人员信息表SampleDataSource/人员信息表SampleDataSource.xaml", UriKind.RelativeOrAbsolute);
                System.Windows.Application.LoadComponent(this, resourceUri);
            }
            catch
            {
            }
        }

        private renyuanCollection _renyuanCollection = new renyuanCollection();

        public renyuanCollection renyuanCollection
        {
            get
            {
                return this._renyuanCollection;
            }
        }
    }

    public class renyuan : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private double _编号 = 0;

        public double 编号
        {
            get
            {
                return this._编号;
            }

            set
            {
                if (this._编号 != value)
                {
                    this._编号 = value;
                    this.OnPropertyChanged("编号");
                }
            }
        }

        private string _姓名 = string.Empty;

        public string 姓名
        {
            get
            {
                return this._姓名;
            }

            set
            {
                if (this._姓名 != value)
                {
                    this._姓名 = value;
                    this.OnPropertyChanged("姓名");
                }
            }
        }

        private string _地址 = string.Empty;

        public string 地址
        {
            get
            {
                return this._地址;
            }

            set
            {
                if (this._地址 != value)
                {
                    this._地址 = value;
                    this.OnPropertyChanged("地址");
                }
            }
        }
    }

    public class renyuanCollection : System.Collections.ObjectModel.ObservableCollection<renyuan>
    { 
    }
#endif
}
