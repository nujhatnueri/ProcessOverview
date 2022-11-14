using ProcessOverview.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessOverview.API.Repositories
{
    public interface ICsvParserRepository
    {
        List<Process> ReadCsvFileToProcessModel(string path);
    }
}
