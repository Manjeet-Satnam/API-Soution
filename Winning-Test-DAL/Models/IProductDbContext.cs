using System;
using MongoDB.Driver;
namespace Winning_Test_DAL.Models
{
    public interface IProductDbContext
    {

        IMongoCollection<ProductEntity> GetProductCollection();
       
    }
}
