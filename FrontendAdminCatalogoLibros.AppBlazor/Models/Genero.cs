using System.ComponentModel.DataAnnotations;

namespace FrontendAdminCatalogoLibros.AppBlazor.Models
{
    public class Genero
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
    }
}
