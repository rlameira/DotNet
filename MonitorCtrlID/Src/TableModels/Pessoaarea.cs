using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Pessoaarea
{
    public int Codarea { get; set; }

    public int Codpessoa { get; set; }

    public string Ultimoacesso { get; set; } = null!;

    public string Liberado { get; set; } = null!;
}
