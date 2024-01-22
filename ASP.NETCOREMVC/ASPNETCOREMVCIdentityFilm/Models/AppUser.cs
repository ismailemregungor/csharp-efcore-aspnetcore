using Microsoft.AspNetCore.Identity;

namespace ASPNETCOREMVCIdentityFilm.Models
{
    public class AppUser: IdentityUser<int>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
