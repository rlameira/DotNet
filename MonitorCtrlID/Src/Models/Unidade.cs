using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Unidade
{
    public int Codunidade { get; set; }

    public int Codcondominio { get; set; }

    public int Codpredio { get; set; }

    public string? Unidade1 { get; set; }

    public int? Andar { get; set; }

    public int? Numunidade { get; set; }

    public int? Numerodevagas { get; set; }

    public int? Vagaslivres { get; set; }

    public virtual Condominio CodcondominioNavigation { get; set; } = null!;

    public virtual Predio CodpredioNavigation { get; set; } = null!;

    public virtual ICollection<Unidadesvisitada> Unidadesvisitada { get; set; } = new List<Unidadesvisitada>();

    public virtual ICollection<Veiculosunidade> Veiculosunidades { get; set; } = new List<Veiculosunidade>();
}
