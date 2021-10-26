using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Winning_Test_DAL.Models
{
    
    public class ProductEntity
    {
        public ProductEntity() { }


        public int id { get; set; }
        public string sku { get; set; }
         public string name { get; set; }
         public decimal? price { get; set; }
         public AttributeEntity attribute { get; set; }
        
    }
        
 }
      

