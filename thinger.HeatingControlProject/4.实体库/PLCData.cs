using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.HeatingControlProject
{
    public class PLCData
    {
        public bool FeedPumpState { get; set; }
        public bool AddPumpState { get; set; }
        public bool AirPumpState { get; set; }
        public bool CirclePumpState { get; set; }
        public bool OutValveState { get; set; }
        public bool SystemState { get; set; }
        public float PressureIn { get; set; }
        public float PressureOut { get; set; }
        public float TempIn { get; set; }
        public float TempOut { get; set; }
        public float PressureBoiler { get; set; }
        public float LevelBoiler { get; set; }
        public float TempBoiler { get; set; }
        public float LevelTank { get; set; }
      






    }
}
