using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Tipopessoarotum
{
    public int Codrota { get; set; }

    public int Codtipopessoa { get; set; }

    public virtual Rotum CodrotaNavigation { get; set; } = null!;
}
