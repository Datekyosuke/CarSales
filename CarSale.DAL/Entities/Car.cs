using CarSale.DAL.Entities.Base;
using System.Collections.Generic;

namespace CarSale.DAL.Entities
{
    /// <summary>
    /// Главная сущность автомобиля имеет свойства Id, Name, Price, Model, Color, Configuration, а так же навигационное свойство Sales
    /// </summary>
    public class Car : Entity
    {
        public string Color { get; set; }
        public virtual Configuration Configuration { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
