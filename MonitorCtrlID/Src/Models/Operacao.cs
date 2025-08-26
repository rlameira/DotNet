using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Operacao
{
    public int CodPessoa { get; set; }

    public int CodEquipamento { get; set; }

    public string Operacao1 { get; set; } = null!;

    public double? Cartao { get; set; }

    public string? Nome { get; set; }

    public string? Senha { get; set; }

    public int? CodHorario { get; set; }

    public DateTime? DataHora { get; set; }

    public DateTime? OpDisponivel { get; set; }

    public string? Parametro { get; set; }

    public int CodSensor { get; set; }

    public int? CodUnidade { get; set; }

    public string? Tabela { get; set; }

    public string? Dados { get; set; }

    public string? Opcoes { get; set; }

    public int? NumeroOperacao { get; set; }

    public int? SaidaAuxiliar { get; set; }

    public int? Tempo { get; set; }

    public string? DtInicio { get; set; }

    public string? DtFim { get; set; }
}
