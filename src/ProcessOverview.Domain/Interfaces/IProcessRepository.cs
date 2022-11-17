using System.Collections.Generic;
using System.Threading.Tasks;
using ProcessOverview.Domain.Models;

namespace ProcessOverview.Domain.Interfaces
{
    public interface IProcessRepository : IRepository<Process>
    {
        new Task<List<Process>> GetAll();
        new Task<Process> GetById(int id);
        Task<IEnumerable<Process>> Search(string searchedValue);
    }
}