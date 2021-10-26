using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Winning_Test_DAL.Models
{
    
    public class RatingEntity
    {
      
        public RatingEntity()
        {
        }
         public string name { get; set; }
          public string type { get; set; }
         public double value { get; set; }
  
    }
}
