using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace FPT_Library.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        public string? Category { get; set; }
        [Required]
        public string? Author { get; set; }


    }
}
