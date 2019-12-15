using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required, Index("Unique_Author_Name", IsUnique = true), MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
