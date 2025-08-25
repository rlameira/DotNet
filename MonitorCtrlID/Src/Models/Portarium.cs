using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Portarium
{
    public int Codportaria { get; set; }

    public string? Portaria { get; set; }

    public virtual ICollection<Antena> Antenas { get; set; } = new List<Antena>();

    public virtual ICollection<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();

    public virtual ICollection<Estacionamento> Estacionamentos { get; set; } = new List<Estacionamento>();
}
