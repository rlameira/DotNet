using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Predio
{
    public int Codpredio { get; set; }

    public string? Predio1 { get; set; }

    public virtual ICollection<Unidade> Unidades { get; set; } = new List<Unidade>();
}
