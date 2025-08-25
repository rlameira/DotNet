using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Unidadesvisitada
{
    public int Codunidade { get; set; }

    public int Codpessoa { get; set; }

    public DateTime? Dataultimavisita { get; set; }

    public TimeSpan? Horaultimavisita { get; set; }

    public virtual Pessoa CodpessoaNavigation { get; set; } = null!;

    public virtual Unidade CodunidadeNavigation { get; set; } = null!;
}
