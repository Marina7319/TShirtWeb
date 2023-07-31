﻿namespace T_shirt.Models.Models
{

    using Microsoft.AspNetCore.Identity;

    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser : IdentityUser
    {

        [Required]
        public string Name { get; set; }

        public string?  StreetAddress { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? PostalCode { get; set; }
     
    }
}
