using CarSale.DAL.Entities.Base;
using System.Collections.Generic;

namespace CarSale.DAL.Entities
{
    /// <summary>
    /// Бренд автомобиля имеет свойства Id и Name, а так же навигационное свойство Model
    /// </summary>
    public class Brand : NamedEntity
    {
        public virtual ICollection<Model> Models { get; set; }
    }
}
