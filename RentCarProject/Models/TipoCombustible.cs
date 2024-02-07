using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCarProject.Models;

public partial class TipoCombustible
{
    [Key]
    public int? IdTipoCombustible { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }
}
