using CarSale.DAL.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSale.DAL.Entities
{
    /// <summary>
    /// Конфигурация автомобиля имеет свойства Id, Name, Price, а так же навигационноые свойство Cars и Model
    /// </summary>
    public class Configuration : NamedEntity
    {
        public virtual ICollection<Car> Cars { get; set; }
        public virtual Model Model { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}
