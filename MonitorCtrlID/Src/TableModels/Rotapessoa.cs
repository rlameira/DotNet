using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Rotapessoa
{
    public int Codrota { get; set; }

    public int Codpessoa { get; set; }

    public string Tipoultimoacesso { get; set; } = null!;

    public DateTime Dataultimoacesso { get; set; }

    public TimeSpan Horaultimoacesso { get; set; }
}
