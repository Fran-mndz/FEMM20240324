using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FEMM20250324.AppWebMVC.Models;

public partial class Brand
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre de la Marca es requerido")]
    public string BrandName { get; set; } = null!;

    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
