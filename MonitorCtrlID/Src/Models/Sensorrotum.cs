using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Sensorrotum
{
    public int Codequipamento { get; set; }

    public int Codsensor { get; set; }

    public int Inout { get; set; }

    public int Codrota { get; set; }

    public string? Sensortag { get; set; }

    public virtual Rotum CodrotaNavigation { get; set; } = null!;
}
