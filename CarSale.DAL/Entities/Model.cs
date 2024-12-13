using CarSale.DAL.Entities.Base;
using System.Collections.Generic;

namespace CarSale.DAL.Entities
{
    /// <summary>
    /// Модель автомобиля имеет свойства Id, Name, Brand а так же навигационное свойство Cars
    /// </summary>
    public class Model : NamedEntity
    {
        public virtual Brand Brand { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
