using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Areapessoa
{
    public int Codarea { get; set; }

    public long Cartao { get; set; }

    public long? Codpessoa { get; set; }

    public string? Liberadopara { get; set; }

    public string? Visitante { get; set; }

    public int? Codtipo { get; set; }

    public int? Codtipocartao { get; set; }

    public int? Codlocal { get; set; }

    public int? Codpaciente { get; set; }

    public int? Codleito { get; set; }

    public int? Codtipopessoa { get; set; }
}
