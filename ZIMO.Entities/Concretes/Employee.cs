using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZIMO.Entities.Abstractions;

namespace ZIMO.Entities.Concretes
{
    public class Employee : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "text")]
        public string Avatar { get; set; }

        public virtual User User { get; set; }

        [NotMapped]
        public EntityState EntityState { get; set; }
    }
}
