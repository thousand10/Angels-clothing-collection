using System;
using System.ComponentModel.DataAnnotations;



namespace angels.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        [StringLength(200)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Product Prize")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Product Image")]
        [DataType(DataType.Upload)]
        public string Image { get; set; }
        [Required]
        [Display(Name = "Product Info")]
        public string Info { get; set; }    
    }
}
