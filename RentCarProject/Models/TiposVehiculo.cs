using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCarProject.Models;

public partial class TiposVehiculo
{
    [Key]
    public int? IdTipoVehiculo { get; set; }

    public int? Descripcion { get; set; }

    public string? Estado { get; set; }
}
