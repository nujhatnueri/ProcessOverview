using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ProcessOverview.Domain.Interfaces;
using ProcessOverview.Domain.Models;

namespace ProcessOverview.Domain.Services
{
    public class ProcessService : IProcessService
    {
        private readonly IProcessRepository _processRepository;
        private readonly IProcessService _processService;

        public ProcessService(IProcessRepository processRepository)
        {
            _processRepository = processRepository;            
        }

        public async Task<IEnumerable<Process>> GetAll()
        {
            return await _processRepository.GetAll();
        }

        public async Task<Process> GetById(int id)
        {
            return await _processRepository.GetById(id);
        }        

        public async Task<IEnumerable<Process>> Search(string searchString)
        {
            int intData;
            int.TryParse(Regex.Match(searchString, @"\d+").Value, out intData);
            bool? boolData = null;
            if (searchString.ToLower().Contains("on"))
                boolData = bool.Parse("True");
            else if (searchString.ToLower().Contains("off"))
                boolData = bool.Parse("False");
            return await _processRepository.Search(c => c.CustomerName.Contains(searchString) ||
                                                  (searchString.ToLower().Contains("water") || ((searchString.ToLower().Contains("temp") || (intData > 0 && c.WaterTemp.Equals(intData))) ||
                                                  (searchString.ToLower().Contains("level") || (intData > 0 && c.WaterLevel.Equals(intData))))) ||
                                                  (searchString.ToLower().Contains("pump") || ((searchString.ToLower().Contains("10") || (boolData != null && c.Pump10.Equals(boolData))) ||
                                                  (searchString.ToLower().Contains("5") || (boolData != null && c.Pump5.Equals(boolData))))) ||
                                                  (searchString.ToLower().Contains("drainsensor") || (boolData != null && c.DrainSensor.Equals(boolData))));
        }

        public void Dispose()
        {
            _processRepository?.Dispose();
        }
    }
}