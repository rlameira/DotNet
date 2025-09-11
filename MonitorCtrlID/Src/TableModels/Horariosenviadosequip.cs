using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Horariosenviadosequip
{
    public int Codenvio { get; set; }

    public string? Descricao { get; set; }

    public DateTime? Data { get; set; }

    public int? Codhorario { get; set; }

    public int? Codequipamento { get; set; }
}
