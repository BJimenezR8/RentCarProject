using System;
using System.Collections.Generic;

namespace RentCarProject.Models;

public partial class Rentum
{
    public int? NoRenta { get; set; }

    public int? IdEmpleado { get; set; }

    public int? IdVehiculo { get; set; }

    public int? IdCliente { get; set; }

    public int? FechaRenta { get; set; }

    public int? MontoxDia { get; set; }

    public int? CantidadDeDias { get; set; }

    public int? Comentario { get; set; }

    public int? Estado { get; set; }
}
