using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Models
{
    public class ProductEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public float Cost { get; set; }
        public float Price { get; set; }
    }
}
