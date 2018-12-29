using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ZIMO.Entities.Abstractions;

namespace ZIMO.Entities.Concretes
{
    public class Item : IEntity
    {
        public Item()
        {
            Borrows = new HashSet<Borrow>();
            Garbages = new HashSet<Garbage>();
            Stocks = new HashSet<Stock>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Borrow> Borrows { get; set; }

        public virtual ICollection<Garbage> Garbages { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }

        [NotMapped]
        public EntityState EntityState { get; set; }

        [NotMapped]
        public int InStock
        {
            get
            {
                if (this.Stocks.Count != 0)
                    return Stocks.Sum(x => (int) x.Quantity);
                return 0;
            }
        }

        [NotMapped]
        public int Borroweds
        {
            get
            {
                if (this.Borrows.Count != 0)
                    return Borrows.Sum(x => (int)x.Quantity);
                return 0;
            }
        }
    }
}
