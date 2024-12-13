using CarSale.DAL.Entities.Base;
using System;

namespace CarSale.DAL.Entities
{
    /// <summary>
    /// Продажа(сделка) имеет свойства Cars, SaleDate, Quantity, TotalPrice
    /// </summary>
    public class Sale : Entity
    {
        public virtual Car Cars {  get; set; }
        public DateTime SaleDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
