using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCarProject.Models;

public partial class Cliente
{
    [Key]
    public int? IdClientes { get; set; }

    public string? Nombre { get; set; }

    public string? Cedula { get; set; }

    public string? NoTarjetaCr { get; set; }

    public string? LimiteCredito { get; set; }

    public string? TipoPersona { get; set; }
}
