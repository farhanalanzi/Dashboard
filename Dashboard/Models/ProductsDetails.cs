using System.ComponentModel.DataAnnotations;

namespace Dashboard.Models
{
    public class ProductsDetails
    {

        [Key]
        public int Id { get; set; }


        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Color { get; set; }

        [Required]
        public int Qty { get; set; }

        [Required]
        public string Images { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
