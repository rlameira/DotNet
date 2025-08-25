using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Rotum
{
    public int Codrota { get; set; }

    public string Rota { get; set; } = null!;

    public int Codhorario { get; set; }

    public virtual ICollection<Tipopessoarotum> Tipopessoarota { get; set; } = new List<Tipopessoarotum>();
}
