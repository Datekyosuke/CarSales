using CarSales.Interfaces;

namespace CarSale.DAL.Entities.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}

