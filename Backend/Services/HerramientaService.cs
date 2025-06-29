using MongoDB.Driver;
using ToolTrack.API.Models;

namespace ToolTrack.API.Services
{
    public class HerramientaService
    {
        private readonly IMongoCollection<Herramienta> _herramientasCollection;

        public HerramientaService(IConfiguration configuration)
        {
            var connectionString = configuration["ToolTrackDatabaseSettings:ConnectionString"];
            var databaseName = configuration["ToolTrackDatabaseSettings:DatabaseName"];
            var collectionName = configuration["ToolTrackDatabaseSettings:HerramientasCollectionName"];

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);

            _herramientasCollection = database.GetCollection<Herramienta>(collectionName);
        }

        public async Task<List<Herramienta>> GetAsync() =>
            await _herramientasCollection.Find(_ => true).ToListAsync();

        public async Task<Herramienta?> GetByIdAsync(string id) =>
            await _herramientasCollection.Find(h => h.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Herramienta herramienta) =>
            await _herramientasCollection.InsertOneAsync(herramienta);

        public async Task UpdateAsync(string id, Herramienta herramienta) =>
            await _herramientasCollection.ReplaceOneAsync(h => h.Id == id, herramienta);

        public async Task DeleteAsync(string id) =>
            await _herramientasCollection.DeleteOneAsync(h => h.Id == id);
    }
}
