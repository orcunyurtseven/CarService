using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServiceSales.Entities
{
    public class Sales : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int MusteriId { get; set; }
        public decimal SalesPrice { get; set; }
        public DateTime SalesDate { get; set; }
        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
