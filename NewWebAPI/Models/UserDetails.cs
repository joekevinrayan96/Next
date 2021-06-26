using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebAPI.Models
{
    [Keyless]
    public class UserDetails
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}
