﻿using Microsoft.AspNetCore.Identity;

namespace AuthApi.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? lastName { get; set; }

    }
}