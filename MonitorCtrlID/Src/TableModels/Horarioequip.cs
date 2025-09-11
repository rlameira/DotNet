using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Horarioequip
{
    public int Codhorario { get; set; }

    public int Codequipamento { get; set; }

    public string? Enviado { get; set; }

    public virtual Equipamento CodequipamentoNavigation { get; set; } = null!;

    public virtual Horario CodhorarioNavigation { get; set; } = null!;

    public virtual ICollection<Liberacaoid> Codliberacaos { get; set; } = new List<Liberacaoid>();
}
