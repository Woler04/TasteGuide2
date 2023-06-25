using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TasteGuide.Data
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get;  set; }

        public string ImageFile { get; set; }
        public virtual ICollection<Review?> Reviews { get; set; }

        public Restaurant()
        {
            Reviews = new List<Review>();
        }
    }
}
