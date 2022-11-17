using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProcessOverview.API.Repositories;
using ProcessOverview.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProcessOverview.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessController : ControllerBase
    {
        private readonly ILogger<ProcessController> _logger;

        public ProcessController(ILogger<ProcessController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Process> Get()
        {
            var csvParserService = new CsvParserService();
            string fileName = "ProcessData.csv";
            var path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            return csvParserService.ReadCsvFileToProcessModel(path);
        }        
    }
}
