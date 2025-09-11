using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Condominio
{
    public int Codcondominio { get; set; }

    public string? Condominio1 { get; set; }

    public virtual ICollection<Unidade> Unidades { get; set; } = new List<Unidade>();
}
