using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCarProject.Models;

public partial class Devolucion
{
    [Key]
    public int? NoRenta { get; set; }

    public string? IdEmpleado { get; set; }

    public string? IdVehiculo { get; set; }

    public string? IdCliente { get; set; }

    public string? FechaDevolucion { get; set; }

    public int? MontoxDia { get; set; }

    public int? CantidadDeDias { get; set; }

    public string? Comentario { get; set; }

    public int? Estado { get; set; }
}
