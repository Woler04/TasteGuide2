using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TasteGuide.Data
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }

        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public virtual AppUser? Author { get; set; }

        [ForeignKey("Restaurant")]
        public int? RestaurantId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }

    }
}
