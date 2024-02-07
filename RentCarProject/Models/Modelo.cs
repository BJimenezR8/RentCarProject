using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;


namespace RentCarProject.Models;

public partial class Modelo
{
    [Key]
    public int? Id { get; set; }

    public int? IdMarca { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

   

}
