using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualiTransportas.Contracts;
using IndividualiTransportas.Models;
using MongoDB.Driver;

namespace IndividualiTransportas.Repositories
{
    public class WorkerMongoRepository : IWorkerMongoRepository
    {
        private IMongoCollection<OfficeWorker> _officeWorkers;
        private IMongoCollection<ProductionWorker> _productionWorkers;

        public WorkerMongoRepository(IMongoClient mongoClient)
        {
            _officeWorkers = mongoClient.GetDatabase("officeWorkers").GetCollection<OfficeWorker>("allOfficeWorkers");
            _productionWorkers = mongoClient.GetDatabase("productionWorkers").GetCollection<ProductionWorker>("allProductionWorkers");
        }

        public async Task<List<OfficeWorker>> ReadAllOfficeWorkers()
        {
            return await _officeWorkers.Find<OfficeWorker>(x => true).ToListAsync();
        }

        public async Task<List<ProductionWorker>> ReadAllProductionWorkers()
        {
            return await _productionWorkers.Find<ProductionWorker>(x => true).ToListAsync();
        }

        public void AddOfficeWorker(OfficeWorker officeWorker)
        {
            _officeWorkers.InsertOne(officeWorker);
        }

        public void AddProductionWorker(ProductionWorker productionWorker)
        {
            _productionWorkers.InsertOne(productionWorker);
        }

    }
}
