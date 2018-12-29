using ZIMO.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZIMO.Entities.Concretes
{
    public class Stock : IEntity
    {
        public Stock()
        {
            Borrows = new HashSet<Borrow>();
            Garbages = new HashSet<Garbage>();
        }
        public int Id { get; set; }

        public int? Item_Id { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        public virtual ICollection<Borrow> Borrows { get; set; }

        public virtual ICollection<Garbage> Garbages { get; set; }

        public virtual Item Item { get; set; }
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
}
