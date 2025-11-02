using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using thinger.DataConvertLib;

namespace thinger.HeatingControlProject
{
    public class PLCDataService
    {
        S7NetLib s7Net = null;
        /// <summary>
        /// 打开PLC连接
        /// </summary>
        /// <param name="plcInfo"></param>
        /// <exception cref="Exception"></exception>
        public void Connect(PlcInfo plcInfo)
        {
            try
            {
                this.s7Net = new S7NetLib(plcInfo.CpuType, plcInfo.IPAdress, plcInfo.Rack, plcInfo.Slot);
                this.s7Net.OpenPLC();
            }
            catch (Exception ex)
            {
                throw new Exception("PLC通信连接失败" + ex.Message);
            }
        }
        /// <summary>
        /// 关闭PLC连接
        /// </summary>
        public void DisConnect()
        {
            if (this.s7Net != null)
            {
                this.s7Net.ClosePLC();
            }
        }
        /// <summary>
        /// 读取PLC数据
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public PLCData GetPlcData()
        {
            int length = 36;
            try
            {
                byte[] result = this.s7Net.ReadDataFromPLC(S7.Net.DataType.DataBlock, 1, 0, length);
                if (result != null && result.Length == length)
                {
                    //解析布尔数据
                    PLCData pLCData = new PLCData();
                    pLCData.FeedPumpState = BitLib.GetBitFromByteArray(result, 0, 0);
                    pLCData.AddPumpState = BitLib.GetBitFromByteArray(result, 0, 1);
                    pLCData.AirPumpState = BitLib.GetBitFromByteArray(result, 0, 2);
                    pLCData.CirclePumpState = BitLib.GetBitFromByteArray(result, 0, 3);
                    pLCData.OutValveState = BitLib.GetBitFromByteArray(result, 0, 4);
                    pLCData.SystemState = BitLib.GetBitFromByteArray(result, 0, 5);
                    //解析浮点数据
                    pLCData.PressureIn = FloatLib.GetFloatFromByteArray(result, 4);
                    pLCData.PressureOut = FloatLib.GetFloatFromByteArray(result, 8);
                    pLCData.TempIn = FloatLib.GetFloatFromByteArray(result, 12);
                    pLCData.TempOut = FloatLib.GetFloatFromByteArray(result, 16);
                    pLCData.PressureBoiler = FloatLib.GetFloatFromByteArray(result, 20);
                    pLCData.LevelBoiler = FloatLib.GetFloatFromByteArray(result, 24);
                    pLCData.TempBoiler = FloatLib.GetFloatFromByteArray(result, 28);
                    pLCData.LevelTank = FloatLib.GetFloatFromByteArray(result, 32);
                    return pLCData;
                }
                else
                    throw new Exception("PLC读取数据不正确");
            }
            catch (Exception ex)
            {
                throw new Exception("读取PLC信息失败" + ex.Message);

            }
        }
        /// <summary>
        /// 进水泵控制
        /// </summary>
        /// <param name="state"></param>
        /// <exception cref="Exception"></exception>
        public void FeedPumpControl(bool state)
        {
            if (this.s7Net != null)
            {
                string address = state ? "DB1.DBX100.0" : "DB1.DBX100.1";
                this.s7Net.WriteDataToPLC(address, true);
                Thread.Sleep(100);
                this.s7Net.WriteDataToPLC(address, false);
            }
            else
                throw new Exception("PLC未连接，请先打开PLC再操作");   
        }
        /// <summary>
        /// 加水泵控制
        /// </summary>
        /// <param name="state"></param>
        /// <exception cref="Exception"></exception>
        public void AddPumpControl(bool state)
        {
            if (this.s7Net != null)
            {
                string address = state ? "DB1.DBX100.2" : "DB1.DBX100.3";
                this.s7Net.WriteDataToPLC(address, true);
                Thread.Sleep(100);
                this.s7Net.WriteDataToPLC(address, false);
            }
            else
                throw new Exception("PLC未连接，请先打开PLC再操作");
        }
        /// <summary>
        /// 燃气泵控制
        /// </summary>
        /// <param name="state"></param>
        /// <exception cref="Exception"></exception>
        public void AirPumpControl(bool state)
        {
            if (this.s7Net != null)
            {
                string address = state ? "DB1.DBX100.4" : "DB1.DBX100.5";
                this.s7Net.WriteDataToPLC(address, true);
                Thread.Sleep(100);
                this.s7Net.WriteDataToPLC(address, false);
            }
            else
                throw new Exception("PLC未连接，请先打开PLC再操作");
        }
        /// <summary>
        /// 循环泵控制
        /// </summary>
        /// <param name="state"></param>
        /// <exception cref="Exception"></exception>
        public void CirclePumpControl(bool state)
        {
            if (this.s7Net != null)
            {
                string address = state ? "DB1.DBX100.6" : "DB1.DBX100.7";
                this.s7Net.WriteDataToPLC(address, true);
                Thread.Sleep(100);
                this.s7Net.WriteDataToPLC(address, false);
            }
            else
                throw new Exception("PLC未连接，请先打开PLC再操作");
        }
        /// <summary>
        /// 出水阀控制
        /// </summary>
        /// <param name="state"></param>
        /// <exception cref="Exception"></exception>
        public void OutValveControl(bool state)
        {
            if (this.s7Net != null)
            {
                string address = state ? "DB1.DBX101.0" : "DB1.DBX101.1";
                this.s7Net.WriteDataToPLC(address, true);
                Thread.Sleep(100);
                this.s7Net.WriteDataToPLC(address, false);
            }
            else
                throw new Exception("PLC未连接，请先打开PLC再操作");
        }

    }
}
