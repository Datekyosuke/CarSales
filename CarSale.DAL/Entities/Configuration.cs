using CarSale.DAL.Entities.Base;
using System.Collections.Generic;

namespace CarSale.DAL.Entities
{
    /// <summary>
    /// Конфигурация автомобиля имеет свойства Id и Name, а так же навигационное свойство Cars
    /// </summary>
    public class Configuration : NamedEntity
    {
        public virtual ICollection<Car> Cars { get; set; }
    }
}
