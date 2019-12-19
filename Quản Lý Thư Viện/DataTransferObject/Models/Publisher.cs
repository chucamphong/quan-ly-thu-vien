using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    [Table("Publishers")]
    public class Publisher : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Index("Unique_Publisher_Thumbnail", IsUnique = true)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Browsable(false)]
        public virtual ICollection<Book> Books { get; set; }
    }
}
