using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCarProject.Models;

public partial class Empleado
{
    [Key]
    public int? IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public string? Cedula { get; set; }

    public string? TandaLaboral { get; set; }

    public int? PorcientoComision { get; set; }

    public DateTime FechaIngreso { get; set; }

    public string? Estado { get; set; }
}
