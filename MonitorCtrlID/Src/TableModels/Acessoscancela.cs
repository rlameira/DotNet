using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Acessoscancela
{
    public int Acesso { get; set; }

    public int Codtag { get; set; }

    public int Codantena { get; set; }

    public DateTime? Data { get; set; }

    public TimeSpan? Hora { get; set; }

    public virtual Antena CodantenaNavigation { get; set; } = null!;

    public virtual Tag CodtagNavigation { get; set; } = null!;
}
