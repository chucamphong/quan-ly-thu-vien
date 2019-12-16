using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    [Table("Publishers")]
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Index("Unique_Publisher_Thumbnail", IsUnique = true)]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
