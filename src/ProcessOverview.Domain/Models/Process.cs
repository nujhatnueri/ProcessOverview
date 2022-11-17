using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessOverview.Domain.Models
{
    public class Process: Entity
    {
        [Name("CustomerId")]
        public int CustomerId { get; set; }
        [Name("CustomerName")]
        public string CustomerName { get; set; }
        [Name("MachineNr")]
        public string MachineNr { get; set; }
        [Name("MachineId")]
        public int MachineId { get; set; }
        [Name("MachineType")]
        public string MachineType { get; set; }
        [Name("Serial")]
        public string Serial { get; set; }
        [Name("ProcessName")]
        public string ProcessName { get; set; }
        [Name("StartTime")]
        public string StartTime { get; set; }
        [Name("EndTime")]
        public string EndTime { get; set; }
        [Name("OnlineFrom")]
        public string OnlineFrom { get; set; }
        [Name("WaterTempUnit")]
        public string WaterTempUnit { get; set; }
        [Name("WaterTemp")]
        public int WaterTemp { get; set; }
        [Name("Pump10")]
        public bool Pump10 { get; set; }
        [Name("Pump5")]
        public bool Pump5 { get; set; }
        [Name("DrainSensor")]
        public bool DrainSensor { get; set; }
        [Name("WaterLevelUnit")]
        public string WaterLevelUnit { get; set; }
        [Name("WaterLevel")]
        public int WaterLevel { get; set; }
    }
}
