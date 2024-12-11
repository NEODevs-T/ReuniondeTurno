using System;
using System.Collections.Generic;

namespace ReunionWeb.ReunionDiaria.DTOs;


public class CambFecDTO
{
    public int IdCambFec { get; set; }

    public int IdReuDia { get; set; }

    public DateTime Cffec { get; set; }

    public DateTime CffecNew { get; set; }

    public string Cfuser { get; set; } = null!;

    public virtual ReunionDTO? ReuDia { get; set; } = null!;

}