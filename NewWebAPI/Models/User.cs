using System;
using System.Collections.Generic;

#nullable disable

namespace NewWebAPI.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Info { get; set; }
        public string Email { get; set; }
    }
}
