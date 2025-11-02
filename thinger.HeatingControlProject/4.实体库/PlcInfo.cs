using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.HeatingControlProject
{
    public class PlcInfo
    {
        public string IPAdress { get; set; }//IP地址
        public CpuType CpuType { get; set; }//PLC类型
        public short Rack { get; set; }//机架号
        public short Slot { get; set; }//插槽号

    }
}
