using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServiceSales.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Surname { get; set; }
        public int TcNo{ get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gsm { get; set; }
        public string Note { get; set; }
        public virtual Car Car { get; set; }
    }
}
