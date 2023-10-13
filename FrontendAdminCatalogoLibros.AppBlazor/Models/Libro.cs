using System.ComponentModel.DataAnnotations;

namespace FrontendAdminCatalogoLibros.AppBlazor.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "La imagen es requerida")]
        public string Imagen { get; set; }


        [Required(ErrorMessage = "El número de páginas es requerido")]
        public int NumPaginas { get; set; }


        [Required(ErrorMessage = "La fecha de publicación es requerida")]
        public string FechaPublicacion { get; set; }


        [Required(ErrorMessage = "La descripción es requerida")]
        public string Descripcion { get; set; }


        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; }
        public Genero Genero { get; set; }
    }
}
