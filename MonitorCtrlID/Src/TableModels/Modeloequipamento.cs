using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Modeloequipamento
{
    public int Codmodelo { get; set; }

    public string? Modelo { get; set; }

    public virtual ICollection<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
}
