using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    [Table("Users")]
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [Index("Unique_User_Email", IsUnique = true)]
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }

        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
