using ZIMO.Entities.Abstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZIMO.Entities.Concretes
{
    public class User : IEntity
    {
        public User()
        {
            Borrows = new HashSet<Borrow>();
        }

        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(500)]
        public string Username { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Password { get; set; }

        public int? Role_Id { get; set; }

        public int? Department_Id { get; set; }

        public int Employee_Id { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Borrow> Borrows { get; set; }

        public virtual Department Department { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Role Role { get; set; }
        [NotMapped]
        public EntityState EntityState { get; set; }
    }
}
