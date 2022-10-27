using System;

namespace OtoServiceSales.Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public decimal SalesPrice { get; set; }
        public DateTime SalesDate { get; set; }
        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }



    }
}
