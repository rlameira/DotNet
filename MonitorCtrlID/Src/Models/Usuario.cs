using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Usuario
{
    public int Codusuario { get; set; }

    public string? Usuario1 { get; set; }

    public string? Senha { get; set; }

    public string? Ativo { get; set; }

    public string? Adm { get; set; }

    public string? Habilitabotaotipopessoa { get; set; }

    public string? Rh { get; set; }

    public string? Seguranca { get; set; }

    public string? Desabilitamenu { get; set; }

    public virtual ICollection<Liberacaoid> Liberacaoids { get; set; } = new List<Liberacaoid>();
}
