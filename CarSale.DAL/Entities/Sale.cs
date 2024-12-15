using CarSale.DAL.Entities.Base;
using System;

namespace CarSale.DAL.Entities
{
    /// <summary>
    /// Продажа(сделка) имеет свойства Cars, SaleDate, Quantity, TotalPrice
    /// </summary>
    public class Sale : Entity
    {
        public virtual Car Car {  get; set; }
        public DateTime SaleDate { get; set; }
    }
}
