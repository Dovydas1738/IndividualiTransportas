using IndividualiTransportas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualiTransportas.Contracts
{
    public interface IWorkerMongoRepository
    {
        void AddOfficeWorker(OfficeWorker officeWorker);
        void AddProductionWorker(ProductionWorker productionWorker);
        Task<List<OfficeWorker>> ReadAllOfficeWorkers();
        Task<List<ProductionWorker>> ReadAllProductionWorkers();
    }
}
