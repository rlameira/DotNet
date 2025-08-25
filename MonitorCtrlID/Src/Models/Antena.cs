using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Antena
{
    public int Codantena { get; set; }

    public int Codportaria { get; set; }

    public string? Antena1 { get; set; }

    public string? Ip { get; set; }

    public int? Porta { get; set; }

    public int? Numdispositivo { get; set; }

    public string? EntrSaida { get; set; }

    public string? Ipdestino1a { get; set; }

    public int? Portadestino1a { get; set; }

    public int? Rele1a { get; set; }

    public int? Tempo1 { get; set; }

    public string? Ipdestino1b { get; set; }

    public int? Portadestino1b { get; set; }

    public int? Rele1b { get; set; }

    public string? Ativo { get; set; }

    public virtual ICollection<Acessoscancela> Acessoscancelas { get; set; } = new List<Acessoscancela>();

    public virtual Portarium CodportariaNavigation { get; set; } = null!;
}
