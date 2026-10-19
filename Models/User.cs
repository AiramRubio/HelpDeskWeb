<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
=======
﻿using Microsoft.AspNetCore.Identity;
>>>>>>> respaldo-remoto-origin-main
namespace HelpDeskWeb.Models

{
    public class User : IdentityUser
    {
<<<<<<< HEAD
        public string FullName { get; set; }
=======
        public string FullName { get; set;}
>>>>>>> respaldo-remoto-origin-main
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
