using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessOverview.API
{
    public static class Constants
    {
        public class CSVHeaders
            {
            public const string CustomerId = "CustomerId";
            public const string CustomerName = "CustomerName";
            public const string MachineNr = "MachineNr";
            public const string MachineId = "MachineId";
            public const string MachineType = "MachineType";
            public const string Serial = "Serial";
            public const string ProcessName = "ProcessName";
            public const string StartTime = "StartTime";
            public const string EndTime = "EndTime";
            public const string OnlineFrom = "OnlineFrom";
            public const string WaterTempUnit = "WaterTempUnit";
            public const string WaterTemp = "WaterTemp";
            public const string Pump10 = "Pump10";
            public const string Pump5 = "Pump5";
            public const string DrainSensor = "DrainSensor";
            public const string WaterLevelUnit = "WaterLevelUnit";
            public const string WaterLevel = "WaterLevel";
        }
    }
}
