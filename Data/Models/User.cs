using Microsoft.AspNetCore.Identity;

namespace Shop.Data.Models
{
    public class User : IdentityUser
    {
        public Dealer Dealer{ get; set; }
    }
}