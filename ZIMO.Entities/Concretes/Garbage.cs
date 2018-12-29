using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZIMO.Entities.Abstractions;

namespace ZIMO.Entities.Concretes
{
    public class Garbage : IEntity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Item_Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Stock_Id { get; set; }

        public int Quantity { get; set; }

        public virtual Item Item { get; set; }

        public virtual Stock Stock { get; set; }

        [NotMapped]
        public EntityState EntityState { get; set; }
    }
}
