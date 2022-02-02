using System.ComponentModel.DataAnnotations;

namespace UdemyNLayerProject.API.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} Alanı Gerekli")]
        public string Name { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="{0} Alanı 1'den büyük değer olmalıdır.")]
        public int Stock { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "{0} Alanı 1'den büyük değer olmalıdır.")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
