namespace T_shirt.Models.Models
{

    using Microsoft.AspNetCore.Identity;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ApplicationUser : IdentityUser
    {

        [Required]
        public string Name { get; set; }

        public string?  StreetAddress { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? PostalCode { get; set; }

        public int? CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))]

        public Company Company { get; set; }

        [NotMapped]

        public string Role { get; set; }
     
    }
}
