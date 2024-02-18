using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCarProject.Models;

public partial class Marca
{
    [Key]
    public int? IdMarca { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }
}
