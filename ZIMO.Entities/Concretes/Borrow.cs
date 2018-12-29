using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZIMO.Entities.Abstractions;

namespace ZIMO.Entities.Concretes
{
    public class Borrow : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Item_Id { get; set; }

        public int User_Id { get; set; }

        public int Stock_Id { get; set; }

        public bool IsReturn { get; set; }

        public DateTime BorrowTime { get; set; }

        public DateTime? ReturnTime { get; set; }

        public int? Quantity { get; set; }

        public virtual Item Item { get; set; }

        public virtual User User { get; set; }

        public virtual Stock Stock { get; set; }

        [NotMapped]
        public EntityState EntityState { get; set; }
    }
}
