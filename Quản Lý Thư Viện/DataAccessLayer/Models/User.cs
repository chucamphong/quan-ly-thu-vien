using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(8), MaxLength(30)]
        public string Name { get; set; }

        [Required, Index("Unique_Email", IsUnique = true), MinLength(8), MaxLength(255), Column(TypeName = "varchar")]
        public string Email { get; set; }

        [Required, MaxLength(255), Column(TypeName = "varchar")]
        public string Password { get; set; }
    }
}
