using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.S7Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            S7NetLib s7NetLib = new S7NetLib(S7.Net.CpuType.S7200Smart, "192.168.1.100", 0, 0);
            s7NetLib.OpenPLC();
            s7NetLib.WriteDataToPLC("M20.0", true);
            byte[] bytes = s7NetLib.ReadDataToPLC(DataType.DataBlock,1,0,100);
            s7NetLib.ClosePLC();
        }
    }
}
