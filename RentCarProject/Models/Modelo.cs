using System;
using System.Collections.Generic;

namespace RentCarProject.Models;

public partial class Modelo
{
    public int? Id { get; set; }

    public int? IdMarca { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }
}
