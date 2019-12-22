using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    [Table("Authors")]
    public class Author : IEntity
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index("Unique_Author_Name", IsUnique = true)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Browsable(false)]
        public ICollection<Book> Books { get; set; }
    }
}
