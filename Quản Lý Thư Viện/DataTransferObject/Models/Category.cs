using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, Index("Unique_Category_Name", IsUnique = true), MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
