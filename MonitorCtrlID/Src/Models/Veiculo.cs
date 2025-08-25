using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Veiculo
{
    public int Codveiculo { get; set; }

    public int Codmodelo { get; set; }

    public int Codcor { get; set; }

    public string? Placa { get; set; }

    public string? Obsveiculo { get; set; }

    public string? Ativo { get; set; }

    public virtual Corveic CodcorNavigation { get; set; } = null!;

    public virtual Modeloveic CodmodeloNavigation { get; set; } = null!;

    public virtual ICollection<Veiculosunidade> Veiculosunidades { get; set; } = new List<Veiculosunidade>();
}
