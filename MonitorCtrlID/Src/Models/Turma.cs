using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Turma
{
    public int Codturma { get; set; }

    public string Turma1 { get; set; } = null!;

    public int Codserie { get; set; }

    public string Turno { get; set; } = null!;
}
