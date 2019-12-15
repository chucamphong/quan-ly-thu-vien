using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Index("Unique_Book_Thumbnail", IsUnique = true), MaxLength(100), Column(TypeName = "varchar")]
        public string Thumbnail { get; set; }

        [Required]
        public virtual ICollection<Author> Authors { get; set; }

        [Required]
        public virtual ICollection<Publisher> Publishers { get; set; }

        [Required]
        public virtual ICollection<Category> Categories { get; set; }

        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
