using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCard.Models
{
    [Table("CardDetail")]
    public class CardDetail
    {
        public static int Count { get; internal set; }
        public int Id { get; set; }
        [Required]
        public int shoppingCardId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        public Book Book { get; set; }
        public shoppingCard shoppingCard { get; set; }
    }
}
