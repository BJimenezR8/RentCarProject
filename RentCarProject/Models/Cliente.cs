using System;
using System.Collections.Generic;

namespace RentCarProject.Models;

public partial class Cliente
{
    public int? IdClientes { get; set; }

    public string? Nombre { get; set; }

    public int? Cedula { get; set; }

    public int? NoTarjetaCr { get; set; }

    public int? LimiteCredito { get; set; }

    public string? TipoPersona { get; set; }
}
