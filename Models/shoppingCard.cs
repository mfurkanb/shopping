using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCard.Models
{
    [Table("shoppingCard")]
    public class shoppingCard
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;

        public ICollection<CardDetail> CardDetails { get; set; }

    }
}
