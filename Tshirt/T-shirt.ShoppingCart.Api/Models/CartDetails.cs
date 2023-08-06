﻿namespace T_shirt.ShoppingCart.Api.Models
{

    using System.ComponentModel.DataAnnotations;

    using System.ComponentModel.DataAnnotations.Schema;
    using T_shirt.ShoppingCart.Api.Models.Details;

    public class CartDetails
    {

        [Key]

        public int CartDetailsId { get; set; }

        public int CartHeaderId { get; set; }

        [ForeignKey("CartHeaderId")]

        public CartHeader CartHeader {  get; set;}

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Count { get; set; }

    }
}