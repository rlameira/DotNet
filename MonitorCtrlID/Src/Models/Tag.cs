using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Tag
{
    public int Codtag { get; set; }

    public string? Codtagnaantena { get; set; }

    public float? Codtagantena2 { get; set; }

    public string? Ativa { get; set; }

    public int? Codveiculo { get; set; }

    public virtual ICollection<Acessoscancela> Acessoscancelas { get; set; } = new List<Acessoscancela>();

    public virtual ICollection<Veiculosunidade> Veiculosunidades { get; set; } = new List<Veiculosunidade>();
}
