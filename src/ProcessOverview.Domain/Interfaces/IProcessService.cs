using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProcessOverview.Domain.Models;

namespace ProcessOverview.Domain.Interfaces
{
    public interface IProcessService : IDisposable
    {
        Task<IEnumerable<Process>> GetAll();
        Task<Process> GetById(int id);        
        Task<IEnumerable<Process>> Search(string searchString);        
    }
}