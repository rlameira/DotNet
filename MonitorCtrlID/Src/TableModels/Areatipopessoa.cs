using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Areatipopessoa
{
    public int Codtipo { get; set; }

    public int Codarea { get; set; }

    public string Liberado { get; set; } = null!;

    public string Selecionado { get; set; } = null!;
}
