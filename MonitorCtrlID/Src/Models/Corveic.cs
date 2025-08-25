using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Corveic
{
    public int Codcor { get; set; }

    public string? Cor { get; set; }

    public virtual ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
}
