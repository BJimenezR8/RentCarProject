using System;
using System.Collections.Generic;

namespace RentCarProject.Models;

public partial class Vehiculo
{
    public int? IdVehiculo { get; set; }

    public int? Descripcion { get; set; }

    public int? NoChasis { get; set; }

    public int? NoMotor { get; set; }

    public int? NoPlaca { get; set; }

    public int? IdTipoVehiculo { get; set; }

    public int? IdMarca { get; set; }

    public int? IdModelo { get; set; }

    public int? IdTipoCombustible { get; set; }

    public int? Estado { get; set; }
}
