using System;
using System.Collections.Generic;

namespace MonitorCtrlID.src.Models;

public partial class Pessoa
{
    public int Codpessoa { get; set; }

    public string? Nome { get; set; }

    public string? Saladetrab { get; set; }

    public int Codunidade { get; set; }

    public int Codtipo { get; set; }

    public int Codempresa { get; set; }

    public int Coddepartamento { get; set; }

    public int Codsetor { get; set; }

    public int Codfuncao { get; set; }

    public string? Ativa { get; set; }

    public int? Codusuario { get; set; }

    public DateTime? Datacad { get; set; }

    public string? Documento { get; set; }

    public double? Cartao { get; set; }

    public string? Senha { get; set; }

    public TimeSpan? Hrlimitelib { get; set; }

    public DateTime? Dtlimitelb { get; set; }

    public int? Numliberacoes { get; set; }

    public string? Habilitado { get; set; }

    public string? Tipo1 { get; set; }

    public string? Tipo2 { get; set; }

    public int? Codigounico { get; set; }

    public double? Matricula { get; set; }

    public DateTime? Dtadmissao { get; set; }

    public DateTime? Dtdemissao { get; set; }

    public string? Rg { get; set; }

    public string? Cpf { get; set; }

    public string? Crm { get; set; }

    public int? Dddfixo1 { get; set; }

    public string? Fonefixo1 { get; set; }

    public int? Dddcelular1 { get; set; }

    public string? Fonecelular1 { get; set; }

    public string? Endlogradouro { get; set; }

    public int? Endnumero { get; set; }

    public string? Endcomplemento { get; set; }

    public int? Endcep { get; set; }

    public string? Arqfoto { get; set; }

    public string? Condomino { get; set; }

    public string? Visitante { get; set; }

    public string? Tipoultimoreg { get; set; }

    public DateTime? Dataehoraultimoreg { get; set; }

    public int? Ramal { get; set; }

    public DateTime? Dataalteracao { get; set; }

    public string? Rne { get; set; }

    public int? Codturma { get; set; }

    public string? Senhacoacao { get; set; }

    public double? Cartaocoacao { get; set; }

    public string? Placa { get; set; }

    public string? Obs { get; set; }

    public string? Alerta { get; set; }

    public string? Notasedocumentos { get; set; }

    public string? Liberaclube { get; set; }

    public string? Liberaacademia { get; set; }

    public string? Podeentrarcomveiculo { get; set; }

    public DateTime? Dataprevistaentrada { get; set; }

    public DateTime? Dataprevistasaida { get; set; }

    public TimeSpan? Horaprevistaentrada { get; set; }

    public TimeSpan? Horaprevistasaida { get; set; }

    public int? Codfilial { get; set; }

    public int? Codveiculo { get; set; }

    public int? Codtipodocumento { get; set; }

    public DateTime? Datanascimento { get; set; }

    public string? Email { get; set; }

    public string? Celular { get; set; }

    public virtual ICollection<Biometria10x> Biometria10xes { get; set; } = new List<Biometria10x>();

    public virtual ICollection<Biometria9x> Biometria9xes { get; set; } = new List<Biometria9x>();

    public virtual ICollection<Liberacaoid> LiberacaoidCodpessoavisitadaNavigations { get; set; } = new List<Liberacaoid>();

    public virtual ICollection<Liberacaoid> LiberacaoidCodpessoavisitanteNavigations { get; set; } = new List<Liberacaoid>();

    public virtual ICollection<Unidadesvisitada> Unidadesvisitada { get; set; } = new List<Unidadesvisitada>();
}
