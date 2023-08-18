namespace T_shirt.Models.Models
{

    using System;

    using System.ComponentModel.DataAnnotations;

    using System.ComponentModel;

    public class TshirtType
    {
        [Key]

        public int Id { get; set; }

        [Required]
        [DisplayName("Tshirt Type")]

        public string Type { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]

        public int DisplayOrder { get; set; }
    }
}
