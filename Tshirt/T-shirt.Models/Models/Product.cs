using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_shirt.Models.Models
{
    public class Product
    {

        [Key]
        public int Id {  get; set; }

        [Required]

        public string TshirtName { get; set; }

        public string Description {  get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        [Display(Name = "List Price")]
        [Range(1, 98)]
        public double ListPrice { get; set; }

    }
}


