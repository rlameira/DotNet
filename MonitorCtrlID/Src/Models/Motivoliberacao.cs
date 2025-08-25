using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Motivoliberacao
{
    public int Codusuario { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan Hora { get; set; }

    public int Codequipamento { get; set; }

    public int Sensor { get; set; }

    public string? Motivo { get; set; }
}
