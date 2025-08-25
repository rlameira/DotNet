using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Estacionamento
{
    public int Codportaria { get; set; }

    public int Codvaga { get; set; }

    public string? Livre { get; set; }

    public virtual Portarium CodportariaNavigation { get; set; } = null!;
}
