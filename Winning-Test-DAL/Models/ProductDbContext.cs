using System;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
namespace Winning_Test_DAL.Models
{
    public class ProductDbContext: IProductDbContext
    {
        private MongoClient _mongoClient { get; set; }
        private IMongoDatabase _db { get; set; }
        private readonly IMongoCollection<ProductEntity> _product;
        public ProductDbContext(IOptions<Mongosettings> configuration)
        {
            //Note: Codecommented because not using MongoDB

           // _mongoClient = new MongoClient(configuration.Value.Connection);
           // _db = _mongoClient.GetDatabase(configuration.Value.DatabaseName);
           // _product = _db.GetCollection<ProductEntity>(configuration.Value.ProductCollectionName);
        }

        public IMongoCollection<ProductEntity> GetProductCollection() => _product;
        

    }
}
