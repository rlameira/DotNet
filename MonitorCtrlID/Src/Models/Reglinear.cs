using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Reglinear
{
    public long Codigo { get; set; }

    public int Codequipamento { get; set; }

    public DateTime Datahora { get; set; }

    public int? Codtipo { get; set; }

    public int? Codbateria { get; set; }

    public int? Codevento { get; set; }

    public int? Rele { get; set; }

    public string? Unidade { get; set; }

    public string? Bloco { get; set; }

    public string? Placa { get; set; }

    public int? Codcor { get; set; }

    public int? Codmodelo { get; set; }
}
