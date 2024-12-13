using System.ComponentModel.DataAnnotations;

namespace CarSale.DAL.Entities.Base
{

    /// <summary>
    /// Базовая сущность имеет свойство id и name
    /// </summary>
    public abstract class NamedEntity : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}

