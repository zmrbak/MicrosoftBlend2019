using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridDemo34
{
    public class RenYuanClass
    {
        public RenYuanClass(int 编号, string 姓名, string 单位, string 性别, int 年龄,   string 备注)
        {
            this.编号 = 编号;
            this.姓名 = 姓名;
            this.年龄 = 年龄;
            this.单位 = 单位;
            this.性别 = 性别;
            this.备注 = 备注;
        }

        public int 编号 { get; set; }
        public string 姓名 { get; set; }
        public int 年龄 { get; set; }
        public string 性别 { get; set; }
        public string 单位 { get; set; }
        public string 备注 { get; set; }
    }
}
