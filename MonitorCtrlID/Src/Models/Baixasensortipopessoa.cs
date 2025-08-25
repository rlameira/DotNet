using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Baixasensortipopessoa
{
    public int Codtipopessoa { get; set; }

    public int Codequipamento { get; set; }

    public int Codsensor { get; set; }

    public int Inout { get; set; }

    public string? Baixacartao { get; set; }

    public string? Baixabiometria { get; set; }
}
