﻿namespace  T_shirt.Models.Models
{

    using System.ComponentModel;

    using System.ComponentModel.DataAnnotations;

    public class Category
    {

        [Key]

        public int Id {  get; set; }

        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }


    }
}
