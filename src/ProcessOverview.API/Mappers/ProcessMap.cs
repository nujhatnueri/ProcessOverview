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
            Map(m => m.CustomerId).Name(Constants.CSVHeaders.CustomerId);
            Map(m => m.CustomerName).Name(Constants.CSVHeaders.CustomerName);
            Map(m => m.MachineNr).Name(Constants.CSVHeaders.MachineNr);
            Map(m => m.MachineId).Name(Constants.CSVHeaders.MachineId);
            Map(m => m.MachineType).Name(Constants.CSVHeaders.MachineType);
            Map(m => m.Serial).Name(Constants.CSVHeaders.Serial);
            Map(m => m.ProcessName).Name(Constants.CSVHeaders.ProcessName);
            Map(m => m.StartTime).Name(Constants.CSVHeaders.StartTime);
            Map(m => m.EndTime).Name(Constants.CSVHeaders.EndTime);
            Map(m => m.OnlineFrom).Name(Constants.CSVHeaders.OnlineFrom);
            Map(m => m.WaterTempUnit).Name(Constants.CSVHeaders.WaterTempUnit);
            Map(m => m.WaterTemp).Name(Constants.CSVHeaders.WaterTemp);
            Map(m => m.Pump10).Name(Constants.CSVHeaders.Pump10);
            Map(m => m.Pump5).Name(Constants.CSVHeaders.Pump5);
            Map(m => m.DrainSensor).Name(Constants.CSVHeaders.DrainSensor);
            Map(m => m.WaterLevelUnit).Name(Constants.CSVHeaders.WaterLevelUnit);
            Map(m => m.WaterLevel).Name(Constants.CSVHeaders.WaterLevel);            
        }        
    }
}
