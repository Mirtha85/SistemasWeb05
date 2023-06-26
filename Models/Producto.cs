namespace SistemasWeb01.Models
{
    public class Producto
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ProductoId { get; set; }
        public string? NombreProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public string? ImagenProducto { get; set; }
        public int Talla { get; set; }
        //relacion
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = default!;
    }
}
