using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransferObject
{
    [Table("Books")]
    public class Book : IEntity
    {
        public Book()
        {
            this.Authors = new HashSet<Author>();
            this.Categories = new HashSet<Category>();
            this.UserBooks = new HashSet<UserBook>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Browsable(false)]
        public Publisher Publishers { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

        [Browsable(false)]
        public ICollection<Category> Categories { get; set; }

        [Browsable(false)]
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}
