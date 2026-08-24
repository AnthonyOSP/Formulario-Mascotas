using System.ComponentModel.DataAnnotations;

namespace Proyecto_1.Models;

public class Mascota
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El tipo de mascota es obligatorio")]
    [Display(Name = "Tipo de mascota")]
    public string Tipo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La raza es obligatoria")]
    [Display(Name = "Raza")]
    public string Raza { get; set; } = string.Empty;

    [Range(0, 100, ErrorMessage = "Ingrese una edad válida")]
    [Display(Name = "Edad (años)")]
    public int Edad { get; set; }

    [Range(0, 500, ErrorMessage = "Ingrese un peso válido")]
    [Display(Name = "Peso (kg)")]
    public double Peso { get; set; }

    [Display(Name = "Color")]
    public string? Color { get; set; }

    [Display(Name = "Sexo")]
    public string? Sexo { get; set; }
}
