using ProductApp.Utility;
using System.ComponentModel.DataAnnotations;

namespace ProductApp.Data
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Desc { get; set; }
        [Positve]
        public double Price { get; set; }
        [Positve]
        public double Quantity { get; set; }
    }
}
