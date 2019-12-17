using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Index("Unique_Category_Name", IsUnique = true)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Browsable(false)]
        public virtual ICollection<Book> Books { get; set; }
    }
}
