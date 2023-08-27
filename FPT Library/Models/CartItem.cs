using System.ComponentModel.DataAnnotations;

namespace FPT_Library.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public virtual Books Book { get; set; }
    }
}
