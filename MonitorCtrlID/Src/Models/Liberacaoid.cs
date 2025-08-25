using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Liberacaoid
{
    public int Codliberacao { get; set; }

    public int Codpessoavisitada { get; set; }

    public int Codpessoavisitante { get; set; }

    public int Codusuario { get; set; }

    public int? Codempresavisitada { get; set; }

    public int Numeroid { get; set; }

    public DateTime? Dtinicial { get; set; }

    public TimeSpan? Hrinicial { get; set; }

    public DateTime? Dtfinal { get; set; }

    public TimeSpan? Hrfinal { get; set; }

    public string? Departamento { get; set; }

    public string? Setor { get; set; }

    public DateTime? Dtcad { get; set; }

    public int? Codemp { get; set; }

    public int? Coddep { get; set; }

    public int? Codsetor { get; set; }

    public string? Saida { get; set; }

    public double? Numcartao { get; set; }

    public string? Pessoavisitada2 { get; set; }

    public string? Local { get; set; }

    public int? Codlocal { get; set; }

    public string? Servicoexecutado { get; set; }

    public int? Coddestino { get; set; }

    public virtual Empresa? CodempresavisitadaNavigation { get; set; }

    public virtual Pessoa CodpessoavisitadaNavigation { get; set; } = null!;

    public virtual Pessoa CodpessoavisitanteNavigation { get; set; } = null!;

    public virtual Usuario CodusuarioNavigation { get; set; } = null!;

    public virtual ICollection<Horarioequip> Horarioequips { get; set; } = new List<Horarioequip>();
}
