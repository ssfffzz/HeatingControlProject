using S7.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.CommonControlLib;

namespace thinger.HeatingControlProject
{
    public class PlcInfoService
    {
        /// <summary>
        /// PLC信息数据类
        /// </summary>
        /// <param name="path">ini文件路径</param>
        /// <returns></returns>
        public PlcInfo GetPlcInfoByPath(string path)
        {
            PlcInfo plcInfo = new PlcInfo();
            //读取ini文件，并封装到PlcInfo实体类对象中
            if (!File.Exists(path))
            {
                return null;
            }
            plcInfo.IPAdress = IniConfigHelper.ReadIniData("PLC信息", "IP地址", "192.168.1.100", path);
            plcInfo.CpuType = (CpuType)Enum.Parse(typeof(CpuType), IniConfigHelper.ReadIniData("PLC信息", "CPU类型", "S7200smart", path));
            plcInfo.Rack = Convert.ToInt16(IniConfigHelper.ReadIniData("PLC信息", "机架号", "0", path));
            plcInfo.Slot = Convert.ToInt16(IniConfigHelper.ReadIniData("PLC信息", "插槽号", "0", path));
            return plcInfo;
        }

        public bool SetPlcInfoToPath(PlcInfo plcInfo, string path)
        {
            bool result = true;
            result &= IniConfigHelper.WriteIniData("PLC信息", "IP地址", plcInfo.IPAdress, path);
            result &= IniConfigHelper.WriteIniData("PLC信息", "CPU类型", plcInfo.CpuType.ToString(), path);
            result &= IniConfigHelper.WriteIniData("PLC信息", "机架号", plcInfo.Rack.ToString(), path);
            result &= IniConfigHelper.WriteIniData("PLC信息", "插槽号", plcInfo.Slot.ToString(), path);
            return result;
        }


    }
}
