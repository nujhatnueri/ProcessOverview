using CsvHelper;
using ProcessOverview.API.Mappers;
using ProcessOverview.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProcessOverview.API.Repositories
{
    public class CsvParserService : ICsvParserRepository
    {
        public List<Process> ReadCsvFileToProcessModel(string path)
        {
            try
            {
                using (var reader = new StreamReader(path, Encoding.Default))
                using (var csvReader = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                {                    
                    csvReader.Context.RegisterClassMap<ProcessMap>();
                    var records = csvReader.GetRecords<Process>().ToList();
                    return records;                    
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e)
            {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
