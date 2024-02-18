using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCarProject.Models;

public partial class Inspeccion
{
    [Key]
    public int? IdTransaccion { get; set; }

    public int? IdVehiculo { get; set; }

    public int? IdCliente { get; set; }

    public string? Ralladuras { get; set; }

    public int? CantidadCombustible { get; set; }

    public int? GomaRepuesta { get; set; }

    public int? EstadoGomas { get; set; }
}
