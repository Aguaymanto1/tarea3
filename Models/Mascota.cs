using System.ComponentModel.DataAnnotations;
namespace tarea3.Models;

public class Mascota
{
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public String nombre { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public String tipo { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public String raza { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio.")]
    public int edad { get; set; }
     [Required(ErrorMessage = "Este campo es obligatorio.")]
    public String contacto { get; set; }
}