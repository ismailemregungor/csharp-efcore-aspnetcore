using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace ASPNETCOREWebApiDbFirstFilmApi.Models
{
    public partial class AspNetRole : IdentityRole<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public string? ConcurrencyStamp { get; set; }
    }
}
