using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace thinger.HeatingControlProject
{
    /// <summary>
    /// S7通信库二次封装类
    /// </summary>
    public class S7NetLib
    {
        private Plc s7netlib = null;//字段
        public CpuType CpuType { get; set; }
        public string IPAddress { get; set; }
        public short Rack { get; set; }//机架号
        public short Slot { get; set; }//槽号

        public S7NetLib(CpuType cpuType, string ipAddress, short rack, short slot)
        {
            this.CpuType = cpuType;
            this.IPAddress = ipAddress;
            this.Rack = rack;
            this.Slot = slot;
        }

        /// <summary>
        /// 打开PLC连接
        /// </summary>
        public void OpenPLC()
        {
            if (this.s7netlib == null)
            {
                this.s7netlib = new Plc(CpuType, IPAddress, Rack, Slot);
            }
            if (!this.s7netlib.IsConnected)
            {
                this.s7netlib.ReadTimeout = 1000;
                this.s7netlib.WriteTimeout = 1000;
                this.s7netlib.Open();
            }
        }
        /// <summary>
        /// 关闭PLC连接
        /// </summary>
        public void ClosePLC()
        {
            if (this.s7netlib != null && this.s7netlib.IsConnected)
            {
                this.s7netlib.Close();
            }
        }

        /// <summary>
        /// 写入单个数据
        /// </summary>
        /// <param name="varAddress">地址</param>
        /// <param name="varValuee">数值</param>
        public void WriteDataToPLC(string varAddress,object varValuee)
        {
            OpenPLC();
            lock (this)
            {
                this.s7netlib.Write(varAddress, varValuee);
            }         
        }

        /// <summary>
        /// 从PLC中批量读取数据
        /// </summary>
        /// <param name="dataType">存储区类型</param>
        /// <param name="db">DB号</param>
        /// <param name="startByteAdr">开始字节地址</param>
        /// <param name="count">读取的数量</param>
        /// <returns>返回字节数组</returns>
        public byte[] ReadDataFromPLC(DataType dataType, int db, int startByteAdr, int count)
        {
            OpenPLC();
            lock (this)
            {
                byte[] result = this.s7netlib.ReadBytes(dataType, db, startByteAdr, count);
                return result;
            }         
        }


    }
}
