using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Liberacao
{
    public int Codliberacao { get; set; }

    public int? Codpessoa { get; set; }

    public int? Coddestino { get; set; }

    public DateTime? Dtliberacao { get; set; }

    public DateTime? Dtlimiteliberacao { get; set; }

    public DateTime? Entrada { get; set; }

    public DateTime? Saida { get; set; }

    public int? Codveiculo { get; set; }

    public int? Codusuario { get; set; }

    public long? Cartao { get; set; }

    public string? Nomelocal { get; set; }

    public string? Pessoavisitada { get; set; }

    public string? Notafiscal { get; set; }

    public string? Liberadoparaentrar { get; set; }

    public string? Liberadorparasair { get; set; }

    public string? Liberadoparasair { get; set; }
}
