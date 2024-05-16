using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebApplication.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Column("Book Title")]
        public string Title { get; set; } = null!;
        [Column("Author")]
        public string Author { get; set; } = null!;
        [Column("Book Description")]
        public string Description => $"{Title} by {Author}";
    }
}
