using System;

namespace OtoServiceSales.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool Active { get; set; }
        public DateTime AddDate { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
