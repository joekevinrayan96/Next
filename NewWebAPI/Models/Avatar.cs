using System;
using System.Collections.Generic;

#nullable disable

namespace NewWebAPI.Models
{
    public partial class Avatar
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public string Url { get; set; }
    }
}
