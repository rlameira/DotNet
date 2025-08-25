using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Regsensor
{
    public int Codequipamento { get; set; }

    public int Codsensor { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan Hora { get; set; }

    public string? Visto { get; set; }

    public int? Codusuario { get; set; }

    public int? Codmapa { get; set; }

    public int Codevento { get; set; }
}
