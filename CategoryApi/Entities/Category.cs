using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryApi.Entities
{
    public class Category
    {
        public Category()
        {
           
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsMiniTruck { get; set; }
        public int CategoryOrder { get; set; }
       
    }
}
