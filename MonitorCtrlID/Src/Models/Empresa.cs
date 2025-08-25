using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Empresa
{
    public int Codempresa { get; set; }

    public string? Razaosocial { get; set; }

    public string? Nomefantasia { get; set; }

    public string? Habilitado { get; set; }

    public string? Condomino { get; set; }

    public string? Visitante { get; set; }

    public string? Cnpj { get; set; }

    public string? Telefones { get; set; }

    public string? Obs { get; set; }

    public string? Transportadora { get; set; }

    public virtual ICollection<Liberacaoid> Liberacaoids { get; set; } = new List<Liberacaoid>();
}
