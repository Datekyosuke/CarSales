using CarSale.DAL.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarSale.DAL.Entities
{
    /// <summary>
    /// Главная сущность автомобиля имеет свойства Id, Name, Price, Model, Color, Configuration, а так же навигационное свойство Sales
    /// </summary>
    public class Car : Entity
    {
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public virtual Model Model { get; set; }
        public string Color { get; set; }
        public virtual Configuration Configuration { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
