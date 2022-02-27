using hospital.Domain.Entities;
using hospital.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hospital.Domain.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please enter a product name.")]
        [StringLength(40)]
        public int ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a product price.")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }


        [Required(ErrorMessage = "Please enter a product Description.")]
        public int Description { get; set; }
         
        public int StockID { get; set; } 

        [Required(ErrorMessage = "Please enter a product Category.")]
        public int CategoryID { get; set; } 

        public string ?IdentityID { get; set; } 
    }
}
