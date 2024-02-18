using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RentCarProject.Models;

public partial class Combustible
{
    [Key]
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }
}
