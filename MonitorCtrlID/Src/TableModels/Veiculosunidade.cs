using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Veiculosunidade
{
    public int Codunidade { get; set; }

    public int Codveiculo { get; set; }

    public int? Ativo { get; set; }

    public string? Obsveiculounidade { get; set; }

    public virtual Unidade CodunidadeNavigation { get; set; } = null!;

    public virtual Veiculo CodveiculoNavigation { get; set; } = null!;

    public virtual ICollection<Tag> Codtags { get; set; } = new List<Tag>();
}
