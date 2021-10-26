using System;
namespace Winning_Test_DAL.Models
{
    public class Mongosettings
    {
        public Mongosettings()
        {
        }
        public string Connection { get; set; }
        public string DatabaseName { get; set; }
        public string ProductCollectionName { get; set; }
    }
}
