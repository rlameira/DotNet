using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Tipodocumento
{
    public int Codtipodocumento { get; set; }

    public string? Documento { get; set; }

    public int? Ordem { get; set; }
}
