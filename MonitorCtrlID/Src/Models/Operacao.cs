using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Operacao
{
    public int Codpessoa { get; set; }

    public int Codequipamento { get; set; }

    public string Operacao1 { get; set; } = null!;

    public double? Cartao { get; set; }

    public string? Nome { get; set; }

    public string? Senha { get; set; }

    public int? Codhorario { get; set; }

    public DateTime? Datahora { get; set; }

    public DateTime? Opdisponivel { get; set; }

    public string? Parametro { get; set; }

    public int Codsensor { get; set; }

    public int? Codunidade { get; set; }

    public string? Tabela { get; set; }

    public string? Dados { get; set; }

    public string? Opcoes { get; set; }

    public int? Numerooperacao { get; set; }

    public int? Saidaauxiliar { get; set; }

    public int? Tempo { get; set; }

    public string? Dtinicio { get; set; }

    public string? Dtfim { get; set; }
}
