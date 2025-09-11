using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Equipamentopessoa
{
    public int Codequipamento { get; set; }

    public int Codpessoa { get; set; }

    public string? Enviado { get; set; }

    public DateTime? Dataenvio { get; set; }
}
