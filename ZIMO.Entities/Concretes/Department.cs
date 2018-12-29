using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZIMO.Entities.Abstractions;

namespace ZIMO.Entities.Concretes
{
    public class Department : IEntity
    {
        public Department()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        [NotMapped]
        public EntityState EntityState { get; set; }
    }
}
