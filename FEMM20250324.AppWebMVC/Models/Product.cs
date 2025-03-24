using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace FEMM20250324.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }


    [Required(ErrorMessage = "Un nombre para este producto es requerido")]
    public string ProductName { get; set; } = null!;


    public string? Description { get; set; }


    [Required(ErrorMessage = "Un precio para este producto es requerido")]
    [Range(typeof(decimal), "0", "79228162514264337593543950335")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Un precio de compra para este producto es requerido")]
    public decimal PurchasePrice { get; set; }


    [Required(ErrorMessage = "Seleccionar una bodega para este producto es requerido")]
    public int? WarehouseId { get; set; }

    [Required(ErrorMessage = "Seleccionar una Marca para este producto es requerido")]
    public int? BrandId { get; set; }

    public string? Notes { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
