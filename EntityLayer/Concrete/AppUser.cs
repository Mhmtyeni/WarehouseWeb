using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public int CardId { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Basket> Baskets { get; set; }

    }
}
