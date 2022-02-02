namespace UdemyNLayerProject.API.DTOs
{
    public class ProductWithCategory:ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
