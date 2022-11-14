using CsvHelper.Configuration;
using ProcessOverview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessOverview.API.Mappers
{
    public sealed class ProcessMap: ClassMap<Process>
    {
        public ProcessMap()
        {
            Map(m => m.CustomerId).Name(new string[]{ "CustomerId"});
            Map(m => m.CustomerName).Name(new string[] { "CustomerName" });
            Map(m => m.MachineNr).Name(new string[] { "MachineNr" });
            Map(m => m.MachineId).Name(new string[] { "MachineId" });
            Map(m => m.MachineType).Name(new string[] { "MachineType" });
            Map(m => m.Serial).Name(new string[] { "Serial" });
            Map(m => m.ProcessName).Name(new string[] { "ProcessName" });
            Map(m => m.StartTime).Name(new string[] { "StartTime" });
            Map(m => m.EndTime).Name(new string[] { "EndTime" });
            Map(m => m.OnlineFrom).Name(new string[] { "OnlineFrom" });
            Map(m => m.WaterTempUnit).Name(new string[] { "WaterTempUnit" });
            Map(m => m.WaterTemp).Name(new string[] { "WaterTemp" });
            Map(m => m.Pump10).Name(new string[] { "Pump10" });
            Map(m => m.Pump5).Name(new string[] { "Pump5" });
            Map(m => m.DrainSensor).Name(new string[] { "DrainSensor" });
            Map(m => m.WaterLevelUnit).Name(new string[] { "WaterLevelUnit" });
            Map(m => m.WaterLevel).Name(new string[] { "WaterLevel" });            
        }
    }
}
