using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FEMM20250324.AppWebMVC.Models;

public partial class User
{
    public int Id { get; set; }


    [Required(ErrorMessage = "Un nombre de usuario es requerido")]
    public string Username { get; set; } = null!;


    [Required(ErrorMessage = "Un email es requerido")]
    [EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
    public string Email { get; set; } = null!;


    [Required(ErrorMessage = "Una contraseña es requerida")]
    [DataType(DataType.Password)]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El passowrd debe tener entre 5 y 50 caracteres.")]
    public string Password { get; set; } = null!;


    [Required(ErrorMessage = "Un rol es requerido")]
    public string Role { get; set; } = null!;


    public string? Notes { get; set; }

    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El password debe tener entre 5 y 50 caracteres.")]
    [Display(Name = "Confirmar Password")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;
}
