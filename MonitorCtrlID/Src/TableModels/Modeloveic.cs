using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Modeloveic
{
    public int Codmodelo { get; set; }

    public string? Modelo { get; set; }

    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
