using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvcApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize to avoid nullability warning
        public string Email { get; set; } = string.Empty; // Initialize to avoid nullability warning
    }
}
