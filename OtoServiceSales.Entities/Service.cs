using System;

namespace OtoServiceSales.Entities
{
    public class Service : IEntity
    {
        public int Id { get; set; }
        public string CarPlate { get; set; }
        public DateTime ServiceDate { get; set; }
        public string CarProblem { get; set; }
        public decimal ServicePrice { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string ActionTaken { get; set; }
        public bool Warranty { get; set; }
        public string Brand { get; set; }
        public string Models { get; set; }
        public string BodyType { get; set; }
        public int Km { get; set; }
        public int ChassisNo { get; set; }
        public string Note { get; set; }

    }
}
