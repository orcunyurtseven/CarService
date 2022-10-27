using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServiceSales.Entities
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Models{ get; set; }
        public string BodyType { get; set; }
        public int ModelsYear{ get; set; }
        public bool Sale { get; set; }
        public string Notes{ get; set; }
        public virtual Brand Brand { get; set; } // Connection between vehicle class and brand class 



    }
}
