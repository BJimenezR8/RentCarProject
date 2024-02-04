using System;
using System.Collections.Generic;

namespace RentCarProject.Models;

public partial class Empleado
{
    public int? IdEmpleado { get; set; }

    public string? Nombre { get; set; }

    public int? Cedula { get; set; }

    public string? TandaLaboral { get; set; }

    public int? PorcientoComision { get; set; }

    public int? FechaIngreso { get; set; }

    public int? Estado { get; set; }
}
