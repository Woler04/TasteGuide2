using Microsoft.AspNetCore.Identity;

namespace TasteGuide.Data
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Review?> Reviews { get; set; }

        public AppUser()
        {
            Reviews = new List<Review>();
        }
    }
}
