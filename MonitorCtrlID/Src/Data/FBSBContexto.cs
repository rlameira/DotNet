using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MonitorCtrlID.src.Models;

namespace MonitorCtrlID.Src.Data;

public partial class FBSBContexto : DbContext
{
    public FBSBContexto()
    {
    }

    public FBSBContexto(DbContextOptions<FBSBContexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Acessoscancela> Acessoscancelas { get; set; }

    public virtual DbSet<Antena> Antenas { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Areapessoa> Areapessoas { get; set; }

    public virtual DbSet<Areatipopessoa> Areatipopessoas { get; set; }

    public virtual DbSet<Baixasensortipopessoa> Baixasensortipopessoas { get; set; }

    public virtual DbSet<Biometria10x> Biometria10xes { get; set; }

    public virtual DbSet<Biometria9x> Biometria9xes { get; set; }

    public virtual DbSet<Biometrium> Biometria { get; set; }

    public virtual DbSet<Chave> Chaves { get; set; }

    public virtual DbSet<Condominio> Condominios { get; set; }

    public virtual DbSet<Configuracao> Configuracaos { get; set; }

    public virtual DbSet<Corveic> Corveics { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Dependente> Dependentes { get; set; }

    public virtual DbSet<Destino> Destinos { get; set; }

    public virtual DbSet<Dispositivolinear> Dispositivolinears { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Equipamento> Equipamentos { get; set; }

    public virtual DbSet<Equipamentoarea> Equipamentoareas { get; set; }

    public virtual DbSet<Equipamentopessoa> Equipamentopessoas { get; set; }

    public virtual DbSet<Estacionamento> Estacionamentos { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Funcao> Funcaos { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Horarioequip> Horarioequips { get; set; }

    public virtual DbSet<Horariosenviadosequip> Horariosenviadosequips { get; set; }

    public virtual DbSet<Horariospessoa> Horariospessoas { get; set; }

    public virtual DbSet<Idequipamento> Idequipamentos { get; set; }

    public virtual DbSet<Liberacao> Liberacaos { get; set; }

    public virtual DbSet<Liberacaoid> Liberacaoids { get; set; }

    public virtual DbSet<Liberacaomanual> Liberacaomanuals { get; set; }

    public virtual DbSet<Local> Locals { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Mapa> Mapas { get; set; }

    public virtual DbSet<Modeloequipamento> Modeloequipamentos { get; set; }

    public virtual DbSet<Modeloveic> Modeloveics { get; set; }

    public virtual DbSet<Motivoliberacao> Motivoliberacaos { get; set; }

    public virtual DbSet<Operacao> Operacaos { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    public virtual DbSet<Pessoaarea> Pessoaareas { get; set; }

    public virtual DbSet<Porta> Portas { get; set; }

    public virtual DbSet<Portarium> Portaria { get; set; }

    public virtual DbSet<Portasequipamento> Portasequipamentos { get; set; }

    public virtual DbSet<Predio> Predios { get; set; }

    public virtual DbSet<Registrosativo> Registrosativos { get; set; }

    public virtual DbSet<Registrosdosveiculo> Registrosdosveiculos { get; set; }

    public virtual DbSet<Reglinear> Reglinears { get; set; }

    public virtual DbSet<Regsensor> Regsensors { get; set; }

    public virtual DbSet<Rotapessoa> Rotapessoas { get; set; }

    public virtual DbSet<Rotatipopessoa> Rotatipopessoas { get; set; }

    public virtual DbSet<Rotum> Rota { get; set; }

    public virtual DbSet<Sensoresmapa> Sensoresmapas { get; set; }

    public virtual DbSet<Sensorrotum> Sensorrota { get; set; }

    public virtual DbSet<Serie> Series { get; set; }

    public virtual DbSet<Setore> Setores { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<Tipodocumento> Tipodocumentos { get; set; }

    public virtual DbSet<Tipolog> Tipologs { get; set; }

    public virtual DbSet<Tipopessoa> Tipopessoas { get; set; }

    public virtual DbSet<Tipopessoarotum> Tipopessoarota { get; set; }

    public virtual DbSet<Turma> Turmas { get; set; }

    public virtual DbSet<Unidade> Unidades { get; set; }

    public virtual DbSet<Unidadesvisitada> Unidadesvisitadas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Veiculo> Veiculos { get; set; }

    public virtual DbSet<Veiculopessoa> Veiculopessoas { get; set; }

    public virtual DbSet<Veiculosunidade> Veiculosunidades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseFirebird("User=SYSDBA;Password=masterkey;Database=D:\\Ronaldo\\Projetos\\Base\\Acesso\\Aluminio\\baseAluminio.fdb;DataSource=localhost;Port=3050;Dialect=3;Charset=UTF8;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acessoscancela>(entity =>
        {
            entity.HasKey(e => e.Acesso).HasName("RDB$PRIMARY1");

            entity.ToTable("ACESSOSCANCELAS");

            entity.HasIndex(e => e.Codantena, "RDB$FOREIGN33");

            entity.HasIndex(e => e.Codtag, "RDB$FOREIGN55");

            entity.HasIndex(e => e.Acesso, "RDB$PRIMARY1").IsUnique();

            entity.Property(e => e.Acesso).HasColumnName("ACESSO");
            entity.Property(e => e.Codantena).HasColumnName("CODANTENA");
            entity.Property(e => e.Codtag).HasColumnName("CODTAG");
            entity.Property(e => e.Data)
                .HasColumnType("DATE")
                .HasColumnName("DATA");
            entity.Property(e => e.Hora).HasColumnName("HORA");

            entity.HasOne(d => d.CodantenaNavigation).WithMany(p => p.Acessoscancelas)
                .HasForeignKey(d => d.Codantena)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_100");

            entity.HasOne(d => d.CodtagNavigation).WithMany(p => p.Acessoscancelas)
                .HasForeignKey(d => d.Codtag)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_122");
        });

        modelBuilder.Entity<Antena>(entity =>
        {
            entity.HasKey(e => e.Codantena).HasName("RDB$PRIMARY2");

            entity.ToTable("ANTENA");

            entity.HasIndex(e => e.Codportaria, "RDB$FOREIGN50");

            entity.HasIndex(e => e.Codantena, "RDB$PRIMARY2").IsUnique();

            entity.Property(e => e.Codantena).HasColumnName("CODANTENA");
            entity.Property(e => e.Antena1)
                .HasMaxLength(30)
                .HasColumnName("ANTENA");
            entity.Property(e => e.Ativo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ATIVO");
            entity.Property(e => e.Codportaria).HasColumnName("CODPORTARIA");
            entity.Property(e => e.EntrSaida)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENTR_SAIDA");
            entity.Property(e => e.Ip)
                .HasColumnType("CHAR(15)")
                .HasColumnName("IP");
            entity.Property(e => e.Ipdestino1a)
                .HasColumnType("CHAR(15)")
                .HasColumnName("IPDESTINO1A");
            entity.Property(e => e.Ipdestino1b)
                .HasColumnType("CHAR(15)")
                .HasColumnName("IPDESTINO1B");
            entity.Property(e => e.Numdispositivo).HasColumnName("NUMDISPOSITIVO");
            entity.Property(e => e.Porta).HasColumnName("PORTA");
            entity.Property(e => e.Portadestino1a).HasColumnName("PORTADESTINO1A");
            entity.Property(e => e.Portadestino1b).HasColumnName("PORTADESTINO1B");
            entity.Property(e => e.Rele1a).HasColumnName("RELE1A");
            entity.Property(e => e.Rele1b).HasColumnName("RELE1B");
            entity.Property(e => e.Tempo1).HasColumnName("TEMPO1");

            entity.HasOne(d => d.CodportariaNavigation).WithMany(p => p.Antenas)
                .HasForeignKey(d => d.Codportaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_117");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Codarea).HasName("RDB$PRIMARY70");

            entity.ToTable("AREA");

            entity.HasIndex(e => e.Codarea, "RDB$PRIMARY70").IsUnique();

            entity.Property(e => e.Codarea).HasColumnName("CODAREA");
            entity.Property(e => e.Area1)
                .HasMaxLength(50)
                .HasColumnName("AREA");
        });

        modelBuilder.Entity<Areapessoa>(entity =>
        {
            entity.HasKey(e => new { e.Cartao, e.Codarea });

            entity.ToTable("AREAPESSOA");

            entity.HasIndex(e => new { e.Cartao, e.Codarea }, "PK_AREAPESSOA").IsUnique();

            entity.Property(e => e.Cartao).HasColumnName("CARTAO");
            entity.Property(e => e.Codarea).HasColumnName("CODAREA");
            entity.Property(e => e.Codleito).HasColumnName("CODLEITO");
            entity.Property(e => e.Codlocal).HasColumnName("CODLOCAL");
            entity.Property(e => e.Codpaciente).HasColumnName("CODPACIENTE");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Codtipo).HasColumnName("CODTIPO");
            entity.Property(e => e.Codtipocartao).HasColumnName("CODTIPOCARTAO");
            entity.Property(e => e.Codtipopessoa).HasColumnName("CODTIPOPESSOA");
            entity.Property(e => e.Liberadopara)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERADOPARA");
            entity.Property(e => e.Visitante)
                .HasColumnType("CHAR(1)")
                .HasColumnName("VISITANTE");
        });

        modelBuilder.Entity<Areatipopessoa>(entity =>
        {
            entity.HasKey(e => new { e.Codtipo, e.Codarea }).HasName("RDB$PRIMARY73");

            entity.ToTable("AREATIPOPESSOA");

            entity.HasIndex(e => new { e.Codtipo, e.Codarea }, "RDB$PRIMARY73").IsUnique();

            entity.Property(e => e.Codtipo).HasColumnName("CODTIPO");
            entity.Property(e => e.Codarea).HasColumnName("CODAREA");
            entity.Property(e => e.Liberado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERADO");
            entity.Property(e => e.Selecionado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("SELECIONADO");
        });

        modelBuilder.Entity<Baixasensortipopessoa>(entity =>
        {
            entity.HasKey(e => new { e.Codtipopessoa, e.Codequipamento, e.Codsensor, e.Inout }).HasName("RDB$PRIMARY97");

            entity.ToTable("BAIXASENSORTIPOPESSOA");

            entity.HasIndex(e => new { e.Codsensor, e.Codtipopessoa, e.Codequipamento, e.Inout }, "RDB$PRIMARY97").IsUnique();

            entity.Property(e => e.Codtipopessoa).HasColumnName("CODTIPOPESSOA");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codsensor).HasColumnName("CODSENSOR");
            entity.Property(e => e.Inout).HasColumnName("INOUT");
            entity.Property(e => e.Baixabiometria)
                .HasColumnType("CHAR(1)")
                .HasColumnName("BAIXABIOMETRIA");
            entity.Property(e => e.Baixacartao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("BAIXACARTAO");
        });

        modelBuilder.Entity<Biometria10x>(entity =>
        {
            entity.HasKey(e => new { e.Iddedo, e.Codpessoa }).HasName("RDB$PRIMARY29");

            entity.ToTable("BIOMETRIA10X");

            entity.HasIndex(e => e.Codpessoa, "RDB$FOREIGN46");

            entity.HasIndex(e => new { e.Codpessoa, e.Iddedo }, "RDB$PRIMARY29").IsUnique();

            entity.Property(e => e.Iddedo).HasColumnName("IDDEDO");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Alerta)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ALERTA");
            entity.Property(e => e.Biometria).HasColumnName("BIOMETRIA");
            entity.Property(e => e.Coacao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("COACAO");

            entity.HasOne(d => d.CodpessoaNavigation).WithMany(p => p.Biometria10xes)
                .HasForeignKey(d => d.Codpessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_113");
        });

        modelBuilder.Entity<Biometria9x>(entity =>
        {
            entity.HasKey(e => new { e.Iddedo, e.Codpessoa }).HasName("RDB$PRIMARY28");

            entity.ToTable("BIOMETRIA9X");

            entity.HasIndex(e => e.Codpessoa, "RDB$FOREIGN45");

            entity.HasIndex(e => new { e.Codpessoa, e.Iddedo }, "RDB$PRIMARY28").IsUnique();

            entity.Property(e => e.Iddedo).HasColumnName("IDDEDO");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Alerta)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ALERTA");
            entity.Property(e => e.Biometria).HasColumnName("BIOMETRIA");
            entity.Property(e => e.Coacao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("COACAO");

            entity.HasOne(d => d.CodpessoaNavigation).WithMany(p => p.Biometria9xes)
                .HasForeignKey(d => d.Codpessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_112");
        });

        modelBuilder.Entity<Biometrium>(entity =>
        {
            entity.HasKey(e => new { e.Codpessoa, e.Iddedo }).HasName("RDB$PRIMARY102");

            entity.ToTable("BIOMETRIA");

            entity.HasIndex(e => new { e.Codpessoa, e.Iddedo }, "RDB$PRIMARY102").IsUnique();

            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Iddedo).HasColumnName("IDDEDO");
            entity.Property(e => e.Alerta)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ALERTA");
            entity.Property(e => e.Algoritmo).HasColumnName("ALGORITMO");
            entity.Property(e => e.Biometria).HasColumnName("BIOMETRIA");
            entity.Property(e => e.Coacao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("COACAO");
            entity.Property(e => e.Liberadoparaentrar)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERADOPARAENTRAR");
            entity.Property(e => e.Liberadoparasair)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERADOPARASAIR");
        });

        modelBuilder.Entity<Chave>(entity =>
        {
            entity.HasKey(e => e.Chave1);

            entity.ToTable("CHAVE");

            entity.HasIndex(e => e.Chave1, "PK_CHAVE").IsUnique();

            entity.Property(e => e.Chave1)
                .HasMaxLength(20)
                .HasColumnName("CHAVE");
        });

        modelBuilder.Entity<Condominio>(entity =>
        {
            entity.HasKey(e => e.Codcondominio).HasName("RDB$PRIMARY3");

            entity.ToTable("CONDOMINIO");

            entity.HasIndex(e => e.Codcondominio, "RDB$PRIMARY3").IsUnique();

            entity.Property(e => e.Codcondominio).HasColumnName("CODCONDOMINIO");
            entity.Property(e => e.Condominio1)
                .HasMaxLength(50)
                .HasColumnName("CONDOMINIO");
        });

        modelBuilder.Entity<Configuracao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONFIGURACAO");

            entity.Property(e => e.Algobiometria).HasColumnName("ALGOBIOMETRIA");
            entity.Property(e => e.Alturadaetiqueta).HasColumnName("ALTURADAETIQUETA");
            entity.Property(e => e.Alturafolha).HasColumnName("ALTURAFOLHA");
            entity.Property(e => e.Antenaetag)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ANTENAETAG");
            entity.Property(e => e.Antipassbackonline)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ANTIPASSBACKONLINE");
            entity.Property(e => e.Biometria).HasColumnName("BIOMETRIA");
            entity.Property(e => e.Cam1ip)
                .HasMaxLength(15)
                .HasColumnName("CAM1IP");
            entity.Property(e => e.Cam1pasta)
                .HasMaxLength(250)
                .HasColumnName("CAM1PASTA");
            entity.Property(e => e.Cam1senha)
                .HasMaxLength(30)
                .HasColumnName("CAM1SENHA");
            entity.Property(e => e.Cam1titulo)
                .HasMaxLength(15)
                .HasColumnName("CAM1TITULO");
            entity.Property(e => e.Cam1user)
                .HasMaxLength(100)
                .HasColumnName("CAM1USER");
            entity.Property(e => e.Cam2ip)
                .HasMaxLength(15)
                .HasColumnName("CAM2IP");
            entity.Property(e => e.Cam2pasta)
                .HasMaxLength(250)
                .HasColumnName("CAM2PASTA");
            entity.Property(e => e.Cam2senha)
                .HasMaxLength(30)
                .HasColumnName("CAM2SENHA");
            entity.Property(e => e.Cam2titulo)
                .HasMaxLength(15)
                .HasColumnName("CAM2TITULO");
            entity.Property(e => e.Cam2user)
                .HasMaxLength(100)
                .HasColumnName("CAM2USER");
            entity.Property(e => e.Cam3pasta)
                .HasMaxLength(250)
                .HasColumnName("CAM3PASTA");
            entity.Property(e => e.Cam3titulo)
                .HasMaxLength(15)
                .HasColumnName("CAM3TITULO");
            entity.Property(e => e.Camprincipal).HasColumnName("CAMPRINCIPAL");
            entity.Property(e => e.Cliente)
                .HasMaxLength(100)
                .HasColumnName("CLIENTE");
            entity.Property(e => e.Clubealuminio)
                .HasColumnType("CHAR(1)")
                .HasColumnName("CLUBEALUMINIO");
            entity.Property(e => e.Cnpjobrigatorio)
                .HasColumnType("CHAR(1)")
                .HasColumnName("CNPJOBRIGATORIO");
            entity.Property(e => e.Codtagmesmocodpessoa)
                .HasColumnType("CHAR(1)")
                .HasColumnName("CODTAGMESMOCODPESSOA");
            entity.Property(e => e.Densidadehorizontal).HasColumnName("DENSIDADEHORIZONTAL");
            entity.Property(e => e.Densidadevertical).HasColumnName("DENSIDADEVERTICAL");
            entity.Property(e => e.Dependenteacompanhado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("DEPENDENTEACOMPANHADO");
            entity.Property(e => e.Dtultimaatualizpessoa)
                .HasColumnType("DATE")
                .HasColumnName("DTULTIMAATUALIZPESSOA");
            entity.Property(e => e.Dtultimoenvio)
                .HasColumnType("DATE")
                .HasColumnName("DTULTIMOENVIO");
            entity.Property(e => e.Duplaentrada)
                .HasColumnType("CHAR(1)")
                .HasColumnName("DUPLAENTRADA");
            entity.Property(e => e.Eliminapessoadias).HasColumnName("ELIMINAPESSOADIAS");
            entity.Property(e => e.Enviarunidadenasenha)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENVIARUNIDADENASENHA");
            entity.Property(e => e.Espacoentrelinhas).HasColumnName("ESPACOENTRELINHAS");
            entity.Property(e => e.Etiqueta)
                .HasMaxLength(1)
                .HasColumnName("ETIQUETA");
            entity.Property(e => e.Foto)
                .HasColumnType("CHAR(1)")
                .HasColumnName("FOTO");
            entity.Property(e => e.Funcaoalerta)
                .HasColumnType("CHAR(1)")
                .HasColumnName("FUNCAOALERTA");
            entity.Property(e => e.Funcaotag)
                .HasColumnType("CHAR(1)")
                .HasColumnName("FUNCAOTAG");
            entity.Property(e => e.Gravasaida)
                .HasMaxLength(1)
                .HasColumnName("GRAVASAIDA");
            entity.Property(e => e.Habexclusaoautomatica)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABEXCLUSAOAUTOMATICA");
            entity.Property(e => e.Habexclusaopessoaparaop)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABEXCLUSAOPESSOAPARAOP");
            entity.Property(e => e.Habilitaabaopcao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABILITAABAOPCAO");
            entity.Property(e => e.Hableitorbioequip)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABLEITORBIOEQUIP");
            entity.Property(e => e.Hableitorbiousb)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABLEITORBIOUSB");
            entity.Property(e => e.Habportas)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABPORTAS");
            entity.Property(e => e.Larguradaetiqueta).HasColumnName("LARGURADAETIQUETA");
            entity.Property(e => e.Largurafolha).HasColumnName("LARGURAFOLHA");
            entity.Property(e => e.Liberacaoporequipamento)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERACAOPOREQUIPAMENTO");
            entity.Property(e => e.Limiar).HasColumnName("LIMIAR");
            entity.Property(e => e.Margemfoto).HasColumnName("MARGEMFOTO");
            entity.Property(e => e.Margemlateral).HasColumnName("MARGEMLATERAL");
            entity.Property(e => e.Margemsuperior).HasColumnName("MARGEMSUPERIOR");
            entity.Property(e => e.Maxcaracter).HasColumnName("MAXCARACTER");
            entity.Property(e => e.Menuarquivo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MENUARQUIVO");
            entity.Property(e => e.Menuhorarios)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MENUHORARIOS");
            entity.Property(e => e.Menuliberacaomanual)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MENULIBERACAOMANUAL");
            entity.Property(e => e.Menurelliberacao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MENURELLIBERACAO");
            entity.Property(e => e.Menurelliberacaomanual)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MENURELLIBERACAOMANUAL");
            entity.Property(e => e.Menurelpessoasequipamento)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MENURELPESSOASEQUIPAMENTO");
            entity.Property(e => e.Menutag)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MENUTAG");
            entity.Property(e => e.Menuunidade)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MENUUNIDADE");
            entity.Property(e => e.Mostragradeinicial)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAGRADEINICIAL");
            entity.Property(e => e.Mostragradeveiculo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAGRADEVEICULO");
            entity.Property(e => e.Parceiro)
                .HasMaxLength(50)
                .HasColumnName("PARCEIRO");
            entity.Property(e => e.Quantidadedecolunas).HasColumnName("QUANTIDADEDECOLUNAS");
            entity.Property(e => e.Quantidadedelinhas).HasColumnName("QUANTIDADEDELINHAS");
            entity.Property(e => e.Tag)
                .HasColumnType("CHAR(1)")
                .HasColumnName("TAG");
            entity.Property(e => e.Tamanhofonte).HasColumnName("TAMANHOFONTE");
            entity.Property(e => e.Tamanhofoto).HasColumnName("TAMANHOFOTO");
            entity.Property(e => e.Tempoliberacaomanual).HasColumnName("TEMPOLIBERACAOMANUAL");
            entity.Property(e => e.Tiposistema)
                .HasMaxLength(1)
                .HasColumnName("TIPOSISTEMA");
            entity.Property(e => e.Unidade)
                .HasColumnType("CHAR(1)")
                .HasColumnName("UNIDADE");
        });

        modelBuilder.Entity<Corveic>(entity =>
        {
            entity.HasKey(e => e.Codcor).HasName("RDB$PRIMARY24");

            entity.ToTable("CORVEIC");

            entity.HasIndex(e => e.Codcor, "RDB$PRIMARY24").IsUnique();

            entity.Property(e => e.Codcor).HasColumnName("CODCOR");
            entity.Property(e => e.Cor)
                .HasMaxLength(30)
                .HasColumnName("COR");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Coddepartamento).HasName("RDB$PRIMARY4");

            entity.ToTable("DEPARTAMENTO");

            entity.HasIndex(e => e.Coddepartamento, "RDB$PRIMARY4").IsUnique();

            entity.Property(e => e.Coddepartamento).HasColumnName("CODDEPARTAMENTO");
            entity.Property(e => e.Departamento1)
                .HasMaxLength(50)
                .HasColumnName("DEPARTAMENTO");
        });

        modelBuilder.Entity<Dependente>(entity =>
        {
            entity.HasKey(e => new { e.Codpessoa, e.Codpessoadependente }).HasName("RDB$PRIMARY89");

            entity.ToTable("DEPENDENTE");

            entity.HasIndex(e => new { e.Codpessoa, e.Codpessoadependente }, "RDB$PRIMARY89").IsUnique();

            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Codpessoadependente).HasColumnName("CODPESSOADEPENDENTE");
        });

        modelBuilder.Entity<Destino>(entity =>
        {
            entity.HasKey(e => e.Coddestino).HasName("RDB$PRIMARY101");

            entity.ToTable("DESTINO");

            entity.HasIndex(e => e.Coddestino, "RDB$PRIMARY101").IsUnique();

            entity.Property(e => e.Coddestino).HasColumnName("CODDESTINO");
            entity.Property(e => e.Destino1)
                .HasMaxLength(500)
                .HasColumnName("DESTINO");
            entity.Property(e => e.Obs)
                .HasMaxLength(3000)
                .HasColumnName("OBS");
            entity.Property(e => e.Ordem).HasColumnName("ORDEM");
        });

        modelBuilder.Entity<Dispositivolinear>(entity =>
        {
            entity.HasKey(e => e.Coddispositivo).HasName("RDB$PRIMARY104");

            entity.ToTable("DISPOSITIVOLINEAR");

            entity.HasIndex(e => e.Numhexdispo, "DIPLINEAR_NUMHEXA_IDX");

            entity.HasIndex(e => e.Coddispositivo, "RDB$PRIMARY104").IsUnique();

            entity.Property(e => e.Coddispositivo).HasColumnName("CODDISPOSITIVO");
            entity.Property(e => e.Bloco)
                .HasMaxLength(10)
                .HasColumnName("BLOCO");
            entity.Property(e => e.Codcor).HasColumnName("CODCOR");
            entity.Property(e => e.Codmarca).HasColumnName("CODMARCA");
            entity.Property(e => e.Codtipo).HasColumnName("CODTIPO");
            entity.Property(e => e.Displabel).HasColumnName("DISPLABEL");
            entity.Property(e => e.Numhexdispo)
                .HasMaxLength(10)
                .HasColumnName("NUMHEXDISPO");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("PLACA");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("UNIDADE");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Codempresa).HasName("RDB$PRIMARY5");

            entity.ToTable("EMPRESA");

            entity.HasIndex(e => e.Codempresa, "CODEMPRESA_IDX");

            entity.HasIndex(e => e.Codempresa, "RDB$PRIMARY5").IsUnique();

            entity.Property(e => e.Codempresa).HasColumnName("CODEMPRESA");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("CNPJ");
            entity.Property(e => e.Condomino)
                .HasColumnType("CHAR(1)")
                .HasColumnName("CONDOMINO");
            entity.Property(e => e.Habilitado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABILITADO");
            entity.Property(e => e.Nomefantasia)
                .HasMaxLength(250)
                .HasColumnName("NOMEFANTASIA");
            entity.Property(e => e.Obs)
                .HasMaxLength(1000)
                .HasColumnName("OBS");
            entity.Property(e => e.Razaosocial)
                .HasMaxLength(250)
                .HasColumnName("RAZAOSOCIAL");
            entity.Property(e => e.Telefones)
                .HasMaxLength(200)
                .HasColumnName("TELEFONES");
            entity.Property(e => e.Transportadora)
                .HasColumnType("CHAR(1)")
                .HasColumnName("TRANSPORTADORA");
            entity.Property(e => e.Visitante)
                .HasColumnType("CHAR(1)")
                .HasColumnName("VISITANTE");
        });

        modelBuilder.Entity<Equipamento>(entity =>
        {
            entity.HasKey(e => e.Codequipamento).HasName("RDB$PRIMARY6");

            entity.ToTable("EQUIPAMENTO");

            entity.HasIndex(e => e.Codequipamento, "EQUIPAMENTO_CODEQUIPAMENTO_IDX");

            entity.HasIndex(e => e.Codmodelo, "RDB$FOREIGN42");

            entity.HasIndex(e => e.Codportaria, "RDB$FOREIGN51");

            entity.HasIndex(e => e.Codequipamento, "RDB$PRIMARY6").IsUnique();

            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Academia)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ACADEMIA");
            entity.Property(e => e.Barreira)
                .HasColumnType("CHAR(1)")
                .HasColumnName("BARREIRA");
            entity.Property(e => e.Cancela)
                .HasColumnType("CHAR(1)")
                .HasColumnName("CANCELA");
            entity.Property(e => e.Capturadigital)
                .HasColumnType("CHAR(1)")
                .HasColumnName("CAPTURADIGITAL");
            entity.Property(e => e.Codmodelo).HasColumnName("CODMODELO");
            entity.Property(e => e.Codportaria).HasColumnName("CODPORTARIA");
            entity.Property(e => e.Dependenteacompanhado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("DEPENDENTEACOMPANHADO");
            entity.Property(e => e.Engolidor)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENGOLIDOR");
            entity.Property(e => e.EntrSaida)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENTR_SAIDA");
            entity.Property(e => e.Enviadigitais)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENVIADIGITAIS");
            entity.Property(e => e.Equipamento1)
                .HasMaxLength(30)
                .HasColumnName("EQUIPAMENTO");
            entity.Property(e => e.Habilitado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABILITADO");
            entity.Property(e => e.Ip)
                .HasColumnType("CHAR(15)")
                .HasColumnName("IP");
            entity.Property(e => e.Layout)
                .HasMaxLength(50)
                .HasColumnName("LAYOUT");
            entity.Property(e => e.Liberamanual)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERAMANUAL");
            entity.Property(e => e.Numdispositivo).HasColumnName("NUMDISPOSITIVO");
            entity.Property(e => e.Numserie)
                .HasMaxLength(20)
                .HasColumnName("NUMSERIE");
            entity.Property(e => e.Obs)
                .HasMaxLength(80)
                .HasColumnName("OBS");
            entity.Property(e => e.Porta).HasColumnName("PORTA");
            entity.Property(e => e.Thread)
                .HasColumnType("CHAR(1)")
                .HasColumnName("THREAD");

            entity.HasOne(d => d.CodmodeloNavigation).WithMany(p => p.Equipamentos)
                .HasForeignKey(d => d.Codmodelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_109");

            entity.HasOne(d => d.CodportariaNavigation).WithMany(p => p.Equipamentos)
                .HasForeignKey(d => d.Codportaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_118");
        });

        modelBuilder.Entity<Equipamentoarea>(entity =>
        {
            entity.HasKey(e => new { e.Codarea, e.Codequipamento }).HasName("RDB$PRIMARY71");

            entity.ToTable("EQUIPAMENTOAREA");

            entity.HasIndex(e => new { e.Codequipamento, e.Codarea }, "RDB$PRIMARY71").IsUnique();

            entity.Property(e => e.Codarea).HasColumnName("CODAREA");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
        });

        modelBuilder.Entity<Equipamentopessoa>(entity =>
        {
            entity.HasKey(e => new { e.Codequipamento, e.Codpessoa });

            entity.ToTable("EQUIPAMENTOPESSOA");

            entity.HasIndex(e => new { e.Codpessoa, e.Codequipamento }, "PK_EQUIPAMENTOPESSOA").IsUnique();

            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Dataenvio).HasColumnName("DATAENVIO");
            entity.Property(e => e.Enviado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENVIADO");
        });

        modelBuilder.Entity<Estacionamento>(entity =>
        {
            entity.HasKey(e => new { e.Codportaria, e.Codvaga }).HasName("RDB$PRIMARY7");

            entity.ToTable("ESTACIONAMENTO");

            entity.HasIndex(e => e.Codportaria, "RDB$FOREIGN52");

            entity.HasIndex(e => new { e.Codvaga, e.Codportaria }, "RDB$PRIMARY7").IsUnique();

            entity.Property(e => e.Codportaria).HasColumnName("CODPORTARIA");
            entity.Property(e => e.Codvaga).HasColumnName("CODVAGA");
            entity.Property(e => e.Livre)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIVRE");

            entity.HasOne(d => d.CodportariaNavigation).WithMany(p => p.Estacionamentos)
                .HasForeignKey(d => d.Codportaria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_119");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.Codevento).HasName("PK_NEW_TABLE");

            entity.ToTable("EVENTOS");

            entity.HasIndex(e => e.Codevento, "PK_NEW_TABLE").IsUnique();

            entity.Property(e => e.Codevento).HasColumnName("CODEVENTO");
            entity.Property(e => e.Alerta)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ALERTA");
            entity.Property(e => e.Evento1)
                .HasMaxLength(50)
                .HasColumnName("EVENTO");
            entity.Property(e => e.Listaprincipal)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LISTAPRINCIPAL");
            entity.Property(e => e.Siglaevento)
                .HasMaxLength(20)
                .HasColumnName("SIGLAEVENTO");
        });

        modelBuilder.Entity<Funcao>(entity =>
        {
            entity.HasKey(e => e.Codfuncao).HasName("RDB$PRIMARY8");

            entity.ToTable("FUNCAO");

            entity.HasIndex(e => e.Codfuncao, "RDB$PRIMARY8").IsUnique();

            entity.Property(e => e.Codfuncao).HasColumnName("CODFUNCAO");
            entity.Property(e => e.Funcao1)
                .HasMaxLength(50)
                .HasColumnName("FUNCAO");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.Codhorario).HasName("RDB$PRIMARY27");

            entity.ToTable("HORARIOS");

            entity.HasIndex(e => e.Codhorario, "RDB$PRIMARY27").IsUnique();

            entity.Property(e => e.Codhorario).HasColumnName("CODHORARIO");
            entity.Property(e => e.Descrhorario)
                .HasMaxLength(100)
                .HasColumnName("DESCRHORARIO");
            entity.Property(e => e.Entdom).HasColumnName("ENTDOM");
            entity.Property(e => e.Entfer).HasColumnName("ENTFER");
            entity.Property(e => e.Entqua).HasColumnName("ENTQUA");
            entity.Property(e => e.Entqui).HasColumnName("ENTQUI");
            entity.Property(e => e.Entsab).HasColumnName("ENTSAB");
            entity.Property(e => e.Entseg).HasColumnName("ENTSEG");
            entity.Property(e => e.Entsex).HasColumnName("ENTSEX");
            entity.Property(e => e.Entter).HasColumnName("ENTTER");
            entity.Property(e => e.Saidom).HasColumnName("SAIDOM");
            entity.Property(e => e.Saifer).HasColumnName("SAIFER");
            entity.Property(e => e.Saiqua).HasColumnName("SAIQUA");
            entity.Property(e => e.Saiqui).HasColumnName("SAIQUI");
            entity.Property(e => e.Saisab).HasColumnName("SAISAB");
            entity.Property(e => e.Saiseg).HasColumnName("SAISEG");
            entity.Property(e => e.Saisex).HasColumnName("SAISEX");
            entity.Property(e => e.Saiter).HasColumnName("SAITER");
        });

        modelBuilder.Entity<Horarioequip>(entity =>
        {
            entity.HasKey(e => new { e.Codhorario, e.Codequipamento }).HasName("RDB$PRIMARY30");

            entity.ToTable("HORARIOEQUIP");

            entity.HasIndex(e => e.Codequipamento, "RDB$FOREIGN39");

            entity.HasIndex(e => e.Codhorario, "RDB$FOREIGN67");

            entity.HasIndex(e => new { e.Codhorario, e.Codequipamento }, "RDB$PRIMARY30").IsUnique();

            entity.Property(e => e.Codhorario).HasColumnName("CODHORARIO");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Enviado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENVIADO");

            entity.HasOne(d => d.CodequipamentoNavigation).WithMany(p => p.Horarioequips)
                .HasForeignKey(d => d.Codequipamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_106");

            entity.HasOne(d => d.CodhorarioNavigation).WithMany(p => p.Horarioequips)
                .HasForeignKey(d => d.Codhorario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_134");

            entity.HasMany(d => d.Codliberacaos).WithMany(p => p.Horarioequips)
                .UsingEntity<Dictionary<string, object>>(
                    "Horariosdaliberacao",
                    r => r.HasOne<Liberacaoid>().WithMany()
                        .HasForeignKey("Codliberacao")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("INTEG_108"),
                    l => l.HasOne<Horarioequip>().WithMany()
                        .HasForeignKey("Codhorario", "Codequipamento")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("INTEG_135"),
                    j =>
                    {
                        j.HasKey("Codhorario", "Codequipamento", "Codliberacao").HasName("RDB$PRIMARY31");
                        j.ToTable("HORARIOSDALIBERACAO");
                        j.HasIndex(new[] { "Codliberacao" }, "RDB$FOREIGN41");
                        j.HasIndex(new[] { "Codhorario", "Codequipamento" }, "RDB$FOREIGN68");
                        j.HasIndex(new[] { "Codliberacao", "Codhorario", "Codequipamento" }, "RDB$PRIMARY31").IsUnique();
                        j.IndexerProperty<int>("Codhorario").HasColumnName("CODHORARIO");
                        j.IndexerProperty<int>("Codequipamento").HasColumnName("CODEQUIPAMENTO");
                        j.IndexerProperty<int>("Codliberacao").HasColumnName("CODLIBERACAO");
                    });
        });

        modelBuilder.Entity<Horariosenviadosequip>(entity =>
        {
            entity.HasKey(e => e.Codenvio).HasName("RDB$PRIMARY99");

            entity.ToTable("HORARIOSENVIADOSEQUIP");

            entity.HasIndex(e => e.Codenvio, "RDB$PRIMARY99").IsUnique();

            entity.Property(e => e.Codenvio).HasColumnName("CODENVIO");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codhorario).HasColumnName("CODHORARIO");
            entity.Property(e => e.Data).HasColumnName("DATA");
            entity.Property(e => e.Descricao)
                .HasMaxLength(1000)
                .HasColumnName("DESCRICAO");
        });

        modelBuilder.Entity<Horariospessoa>(entity =>
        {
            entity.HasKey(e => new { e.Codhorario, e.Codpessoa, e.Codporta, e.Sensor }).HasName("RDB$PRIMARY98");

            entity.ToTable("HORARIOSPESSOA");

            entity.HasIndex(e => new { e.Codpessoa, e.Codhorario, e.Codporta, e.Sensor }, "RDB$PRIMARY98").IsUnique();

            entity.Property(e => e.Codhorario).HasColumnName("CODHORARIO");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Codporta).HasColumnName("CODPORTA");
            entity.Property(e => e.Sensor).HasColumnName("SENSOR");
            entity.Property(e => e.Dtgravado).HasColumnName("DTGRAVADO");
            entity.Property(e => e.Dtvinculado).HasColumnName("DTVINCULADO");
        });

        modelBuilder.Entity<Idequipamento>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Codequipamento, e.Sensor, e.Codhorario }).HasName("RDB$PRIMARY90");

            entity.ToTable("IDEQUIPAMENTO");

            entity.HasIndex(e => new { e.Codhorario, e.Codequipamento, e.Id, e.Sensor }, "RDB$PRIMARY90").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Sensor).HasColumnName("SENSOR");
            entity.Property(e => e.Codhorario).HasColumnName("CODHORARIO");
        });

        modelBuilder.Entity<Liberacao>(entity =>
        {
            entity.HasKey(e => e.Codliberacao).HasName("RDB$PRIMARY96");

            entity.ToTable("LIBERACAO");

            entity.HasIndex(e => e.Codliberacao, "RDB$PRIMARY96").IsUnique();

            entity.Property(e => e.Codliberacao).HasColumnName("CODLIBERACAO");
            entity.Property(e => e.Cartao).HasColumnName("CARTAO");
            entity.Property(e => e.Coddestino).HasColumnName("CODDESTINO");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Codusuario).HasColumnName("CODUSUARIO");
            entity.Property(e => e.Codveiculo).HasColumnName("CODVEICULO");
            entity.Property(e => e.Dtliberacao).HasColumnName("DTLIBERACAO");
            entity.Property(e => e.Dtlimiteliberacao).HasColumnName("DTLIMITELIBERACAO");
            entity.Property(e => e.Entrada).HasColumnName("ENTRADA");
            entity.Property(e => e.Liberadoparaentrar)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERADOPARAENTRAR");
            entity.Property(e => e.Liberadoparasair)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERADOPARASAIR");
            entity.Property(e => e.Liberadorparasair)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERADORPARASAIR");
            entity.Property(e => e.Nomelocal)
                .HasMaxLength(200)
                .HasColumnName("NOMELOCAL");
            entity.Property(e => e.Notafiscal)
                .HasMaxLength(100)
                .HasColumnName("NOTAFISCAL");
            entity.Property(e => e.Pessoavisitada)
                .HasMaxLength(200)
                .HasColumnName("PESSOAVISITADA");
            entity.Property(e => e.Saida).HasColumnName("SAIDA");
        });

        modelBuilder.Entity<Liberacaoid>(entity =>
        {
            entity.HasKey(e => e.Codliberacao).HasName("RDB$PRIMARY9");

            entity.ToTable("LIBERACAOID");

            entity.HasIndex(e => e.Codemp, "LIBERACAOID_CODEMP_IDX");

            entity.HasIndex(e => e.Dtinicial, "LIBERACAOID_DTINICIAL_IDX");

            entity.HasIndex(e => e.Codempresavisitada, "RDB$FOREIGN37");

            entity.HasIndex(e => e.Codpessoavisitante, "RDB$FOREIGN47");

            entity.HasIndex(e => e.Codpessoavisitada, "RDB$FOREIGN48");

            entity.HasIndex(e => e.Codusuario, "RDB$FOREIGN62");

            entity.HasIndex(e => e.Codliberacao, "RDB$PRIMARY9").IsUnique();

            entity.Property(e => e.Codliberacao).HasColumnName("CODLIBERACAO");
            entity.Property(e => e.Coddep).HasColumnName("CODDEP");
            entity.Property(e => e.Coddestino).HasColumnName("CODDESTINO");
            entity.Property(e => e.Codemp).HasColumnName("CODEMP");
            entity.Property(e => e.Codempresavisitada).HasColumnName("CODEMPRESAVISITADA");
            entity.Property(e => e.Codlocal).HasColumnName("CODLOCAL");
            entity.Property(e => e.Codpessoavisitada).HasColumnName("CODPESSOAVISITADA");
            entity.Property(e => e.Codpessoavisitante).HasColumnName("CODPESSOAVISITANTE");
            entity.Property(e => e.Codsetor).HasColumnName("CODSETOR");
            entity.Property(e => e.Codusuario).HasColumnName("CODUSUARIO");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .HasColumnName("DEPARTAMENTO");
            entity.Property(e => e.Dtcad)
                .HasColumnType("DATE")
                .HasColumnName("DTCAD");
            entity.Property(e => e.Dtfinal)
                .HasColumnType("DATE")
                .HasColumnName("DTFINAL");
            entity.Property(e => e.Dtinicial)
                .HasColumnType("DATE")
                .HasColumnName("DTINICIAL");
            entity.Property(e => e.Hrfinal).HasColumnName("HRFINAL");
            entity.Property(e => e.Hrinicial).HasColumnName("HRINICIAL");
            entity.Property(e => e.Local)
                .HasMaxLength(70)
                .HasColumnName("LOCAL");
            entity.Property(e => e.Numcartao).HasColumnName("NUMCARTAO");
            entity.Property(e => e.Numeroid).HasColumnName("NUMEROID");
            entity.Property(e => e.Pessoavisitada2)
                .HasMaxLength(50)
                .HasColumnName("PESSOAVISITADA2");
            entity.Property(e => e.Saida)
                .HasColumnType("CHAR(1)")
                .HasColumnName("SAIDA");
            entity.Property(e => e.Servicoexecutado)
                .HasMaxLength(250)
                .HasColumnName("SERVICOEXECUTADO");
            entity.Property(e => e.Setor)
                .HasMaxLength(30)
                .HasColumnName("SETOR");

            entity.HasOne(d => d.CodempresavisitadaNavigation).WithMany(p => p.Liberacaoids)
                .HasForeignKey(d => d.Codempresavisitada)
                .HasConstraintName("INTEG_104");

            entity.HasOne(d => d.CodpessoavisitadaNavigation).WithMany(p => p.LiberacaoidCodpessoavisitadaNavigations)
                .HasForeignKey(d => d.Codpessoavisitada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_115");

            entity.HasOne(d => d.CodpessoavisitanteNavigation).WithMany(p => p.LiberacaoidCodpessoavisitanteNavigations)
                .HasForeignKey(d => d.Codpessoavisitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_114");

            entity.HasOne(d => d.CodusuarioNavigation).WithMany(p => p.Liberacaoids)
                .HasForeignKey(d => d.Codusuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_129");
        });

        modelBuilder.Entity<Liberacaomanual>(entity =>
        {
            entity.HasKey(e => e.Codliberacao).HasName("RDB$PRIMARY95");

            entity.ToTable("LIBERACAOMANUAL");

            entity.HasIndex(e => e.Codliberacao, "RDB$PRIMARY95").IsUnique();

            entity.Property(e => e.Codliberacao).HasColumnName("CODLIBERACAO");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Codusuario).HasColumnName("CODUSUARIO");
            entity.Property(e => e.Dtliberacao).HasColumnName("DTLIBERACAO");
            entity.Property(e => e.Entradasaida)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENTRADASAIDA");
            entity.Property(e => e.Motivo)
                .HasMaxLength(300)
                .HasColumnName("MOTIVO");
            entity.Property(e => e.Sensor).HasColumnName("SENSOR");
        });

        modelBuilder.Entity<Local>(entity =>
        {
            entity.HasKey(e => e.Codlocal).HasName("RDB$PRIMARY10");

            entity.ToTable("LOCAL");

            entity.HasIndex(e => e.Local1, "LOCAL_LOCAL_IDX");

            entity.HasIndex(e => e.Codlocal, "RDB$PRIMARY10").IsUnique();

            entity.Property(e => e.Codlocal).HasColumnName("CODLOCAL");
            entity.Property(e => e.Local1)
                .HasMaxLength(50)
                .HasColumnName("LOCAL");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => new { e.Codusuario, e.Codtipolog, e.Data, e.Hora }).HasName("RDB$PRIMARY92");

            entity.ToTable("LOGS");

            entity.HasIndex(e => new { e.Codtipolog, e.Codusuario, e.Data, e.Hora }, "RDB$PRIMARY92").IsUnique();

            entity.Property(e => e.Codusuario).HasColumnName("CODUSUARIO");
            entity.Property(e => e.Codtipolog).HasColumnName("CODTIPOLOG");
            entity.Property(e => e.Data)
                .HasColumnType("DATE")
                .HasColumnName("DATA");
            entity.Property(e => e.Hora).HasColumnName("HORA");
            entity.Property(e => e.Codvisitante).HasColumnName("CODVISITANTE");
        });

        modelBuilder.Entity<Mapa>(entity =>
        {
            entity.HasKey(e => e.Codmapa).HasName("RDB$PRIMARY84");

            entity.ToTable("MAPA");

            entity.HasIndex(e => e.Codmapa, "RDB$PRIMARY84").IsUnique();

            entity.Property(e => e.Codmapa).HasColumnName("CODMAPA");
            entity.Property(e => e.Altura).HasColumnName("ALTURA");
            entity.Property(e => e.Largura).HasColumnName("LARGURA");
            entity.Property(e => e.Mapa1)
                .HasMaxLength(100)
                .HasColumnName("MAPA");
            entity.Property(e => e.Pasta)
                .HasMaxLength(300)
                .HasColumnName("PASTA");
        });

        modelBuilder.Entity<Modeloequipamento>(entity =>
        {
            entity.HasKey(e => e.Codmodelo).HasName("RDB$PRIMARY11");

            entity.ToTable("MODELOEQUIPAMENTO");

            entity.HasIndex(e => e.Codmodelo, "RDB$PRIMARY11").IsUnique();

            entity.Property(e => e.Codmodelo).HasColumnName("CODMODELO");
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .HasColumnName("MODELO");
        });

        modelBuilder.Entity<Modeloveic>(entity =>
        {
            entity.HasKey(e => e.Codmodelo).HasName("RDB$PRIMARY23");

            entity.ToTable("MODELOVEIC");

            entity.HasIndex(e => e.Codmodelo, "RDB$PRIMARY23").IsUnique();

            entity.Property(e => e.Codmodelo).HasColumnName("CODMODELO");
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .HasColumnName("MODELO");
        });

        modelBuilder.Entity<Motivoliberacao>(entity =>
        {
            entity.HasKey(e => new { e.Codusuario, e.Data, e.Hora, e.Codequipamento, e.Sensor }).HasName("RDB$PRIMARY86");

            entity.ToTable("MOTIVOLIBERACAO");

            entity.HasIndex(e => new { e.Codequipamento, e.Codusuario, e.Data, e.Hora, e.Sensor }, "RDB$PRIMARY86").IsUnique();

            entity.Property(e => e.Codusuario).HasColumnName("CODUSUARIO");
            entity.Property(e => e.Data)
                .HasColumnType("DATE")
                .HasColumnName("DATA");
            entity.Property(e => e.Hora).HasColumnName("HORA");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Sensor).HasColumnName("SENSOR");
            entity.Property(e => e.Motivo)
                .HasMaxLength(150)
                .HasColumnName("MOTIVO");
        });

        modelBuilder.Entity<Operacao>(entity =>
        {
            entity.HasKey(e => new { e.Codpessoa, e.Codequipamento, e.Operacao1, e.Codsensor }).HasName("pk_OPERACAO");

            entity.ToTable("OPERACAO");

            entity.HasIndex(e => new { e.Codpessoa, e.Codsensor, e.Codequipamento, e.Operacao1 }, "pk_OPERACAO").IsUnique();

            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Operacao1)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OPERACAO");
            entity.Property(e => e.Codsensor).HasColumnName("CODSENSOR");
            entity.Property(e => e.Cartao).HasColumnName("CARTAO");
            entity.Property(e => e.Codhorario).HasColumnName("CODHORARIO");
            entity.Property(e => e.Codunidade).HasColumnName("CODUNIDADE");
            entity.Property(e => e.Dados)
                .HasMaxLength(1000)
                .HasColumnName("DADOS");
            entity.Property(e => e.Datahora).HasColumnName("DATAHORA");
            entity.Property(e => e.Dtfim)
                .HasMaxLength(8)
                .HasColumnName("DTFIM");
            entity.Property(e => e.Dtinicio)
                .HasMaxLength(8)
                .HasColumnName("DTINICIO");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("NOME");
            entity.Property(e => e.Numerooperacao).HasColumnName("NUMEROOPERACAO");
            entity.Property(e => e.Opcoes)
                .HasMaxLength(1000)
                .HasColumnName("OPCOES");
            entity.Property(e => e.Opdisponivel).HasColumnName("OPDISPONIVEL");
            entity.Property(e => e.Parametro)
                .HasMaxLength(500)
                .HasColumnName("PARAMETRO");
            entity.Property(e => e.Saidaauxiliar).HasColumnName("SAIDAAUXILIAR");
            entity.Property(e => e.Senha)
                .HasMaxLength(5)
                .HasColumnName("SENHA");
            entity.Property(e => e.Tabela)
                .HasMaxLength(50)
                .HasColumnName("TABELA");
            entity.Property(e => e.Tempo).HasColumnName("TEMPO");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Codpessoa).HasName("RDB$PRIMARY12");

            entity.ToTable("PESSOA");

            entity.HasIndex(e => e.Cartao, "CARTAOPESSOA_IDX");

            entity.HasIndex(e => e.Codempresa, "CODEMPRESA_PESSOA_IDX");

            entity.HasIndex(e => e.Codpessoa, "CODPESSOA_PESSOA_IDX");

            entity.HasIndex(e => e.Codunidade, "CODUNIDADE_PESSOA_IDX");

            entity.HasIndex(e => e.Cpf, "CPFEPESSOA_IDX");

            entity.HasIndex(e => e.Crm, "CRMEPESSOA_IDX");

            entity.HasIndex(e => e.Nome, "NOMEPESSOA_IDX");

            entity.HasIndex(e => e.Codigounico, "PESSOA_CODIGOUNICO_IDX");

            entity.HasIndex(e => e.Codpessoa, "PESSOA_CODPESSOA_IDX");

            entity.HasIndex(e => e.Codpessoa, "RDB$PRIMARY12").IsUnique();

            entity.HasIndex(e => e.Rg, "RGPESSOA_IDX");

            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Alerta)
                .HasMaxLength(2000)
                .HasColumnName("ALERTA");
            entity.Property(e => e.Arqfoto)
                .HasMaxLength(200)
                .HasColumnName("ARQFOTO");
            entity.Property(e => e.Ativa)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ATIVA");
            entity.Property(e => e.Cartao).HasColumnName("CARTAO");
            entity.Property(e => e.Cartaocoacao).HasColumnName("CARTAOCOACAO");
            entity.Property(e => e.Celular)
                .HasMaxLength(100)
                .HasColumnName("CELULAR");
            entity.Property(e => e.Coddepartamento).HasColumnName("CODDEPARTAMENTO");
            entity.Property(e => e.Codempresa).HasColumnName("CODEMPRESA");
            entity.Property(e => e.Codfilial).HasColumnName("CODFILIAL");
            entity.Property(e => e.Codfuncao).HasColumnName("CODFUNCAO");
            entity.Property(e => e.Codigounico).HasColumnName("CODIGOUNICO");
            entity.Property(e => e.Codsetor).HasColumnName("CODSETOR");
            entity.Property(e => e.Codtipo).HasColumnName("CODTIPO");
            entity.Property(e => e.Codtipodocumento).HasColumnName("CODTIPODOCUMENTO");
            entity.Property(e => e.Codturma).HasColumnName("CODTURMA");
            entity.Property(e => e.Codunidade).HasColumnName("CODUNIDADE");
            entity.Property(e => e.Codusuario).HasColumnName("CODUSUARIO");
            entity.Property(e => e.Codveiculo).HasColumnName("CODVEICULO");
            entity.Property(e => e.Condomino)
                .HasColumnType("CHAR(1)")
                .HasColumnName("CONDOMINO");
            entity.Property(e => e.Cpf)
                .HasMaxLength(12)
                .HasColumnName("CPF");
            entity.Property(e => e.Crm)
                .HasMaxLength(12)
                .HasColumnName("CRM");
            entity.Property(e => e.Dataalteracao).HasColumnName("DATAALTERACAO");
            entity.Property(e => e.Datacad)
                .HasColumnType("DATE")
                .HasColumnName("DATACAD");
            entity.Property(e => e.Dataehoraultimoreg).HasColumnName("DATAEHORAULTIMOREG");
            entity.Property(e => e.Datanascimento)
                .HasColumnType("DATE")
                .HasColumnName("DATANASCIMENTO");
            entity.Property(e => e.Dataprevistaentrada)
                .HasColumnType("DATE")
                .HasColumnName("DATAPREVISTAENTRADA");
            entity.Property(e => e.Dataprevistasaida)
                .HasColumnType("DATE")
                .HasColumnName("DATAPREVISTASAIDA");
            entity.Property(e => e.Dddcelular1).HasColumnName("DDDCELULAR1");
            entity.Property(e => e.Dddfixo1).HasColumnName("DDDFIXO1");
            entity.Property(e => e.Documento)
                .HasMaxLength(20)
                .HasColumnName("DOCUMENTO");
            entity.Property(e => e.Dtadmissao)
                .HasColumnType("DATE")
                .HasColumnName("DTADMISSAO");
            entity.Property(e => e.Dtdemissao)
                .HasColumnType("DATE")
                .HasColumnName("DTDEMISSAO");
            entity.Property(e => e.Dtlimitelb)
                .HasColumnType("DATE")
                .HasColumnName("DTLIMITELB");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Endcep).HasColumnName("ENDCEP");
            entity.Property(e => e.Endcomplemento)
                .HasMaxLength(20)
                .HasColumnName("ENDCOMPLEMENTO");
            entity.Property(e => e.Endlogradouro)
                .HasMaxLength(80)
                .HasColumnName("ENDLOGRADOURO");
            entity.Property(e => e.Endnumero).HasColumnName("ENDNUMERO");
            entity.Property(e => e.Fonecelular1)
                .HasMaxLength(10)
                .HasColumnName("FONECELULAR1");
            entity.Property(e => e.Fonefixo1)
                .HasMaxLength(10)
                .HasColumnName("FONEFIXO1");
            entity.Property(e => e.Habilitado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABILITADO");
            entity.Property(e => e.Horaprevistaentrada).HasColumnName("HORAPREVISTAENTRADA");
            entity.Property(e => e.Horaprevistasaida).HasColumnName("HORAPREVISTASAIDA");
            entity.Property(e => e.Hrlimitelib).HasColumnName("HRLIMITELIB");
            entity.Property(e => e.Liberaacademia)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERAACADEMIA");
            entity.Property(e => e.Liberaclube)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERACLUBE");
            entity.Property(e => e.Matricula).HasColumnName("MATRICULA");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("NOME");
            entity.Property(e => e.Notasedocumentos)
                .HasMaxLength(100)
                .HasColumnName("NOTASEDOCUMENTOS");
            entity.Property(e => e.Numliberacoes).HasColumnName("NUMLIBERACOES");
            entity.Property(e => e.Obs)
                .HasMaxLength(2000)
                .HasColumnName("OBS");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("PLACA");
            entity.Property(e => e.Podeentrarcomveiculo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("PODEENTRARCOMVEICULO");
            entity.Property(e => e.Ramal).HasColumnName("RAMAL");
            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .HasColumnName("RG");
            entity.Property(e => e.Rne)
                .HasMaxLength(20)
                .HasColumnName("RNE");
            entity.Property(e => e.Saladetrab)
                .HasMaxLength(10)
                .HasColumnName("SALADETRAB");
            entity.Property(e => e.Senha)
                .HasMaxLength(5)
                .HasColumnName("SENHA");
            entity.Property(e => e.Senhacoacao)
                .HasMaxLength(5)
                .HasColumnName("SENHACOACAO");
            entity.Property(e => e.Tipo1)
                .HasColumnType("CHAR(1)")
                .HasColumnName("TIPO1");
            entity.Property(e => e.Tipo2)
                .HasColumnType("CHAR(1)")
                .HasColumnName("TIPO2");
            entity.Property(e => e.Tipoultimoreg)
                .HasColumnType("CHAR(1)")
                .HasColumnName("TIPOULTIMOREG");
            entity.Property(e => e.Visitante)
                .HasColumnType("CHAR(1)")
                .HasColumnName("VISITANTE");
        });

        modelBuilder.Entity<Pessoaarea>(entity =>
        {
            entity.HasKey(e => new { e.Codarea, e.Codpessoa }).HasName("RDB$PRIMARY72");

            entity.ToTable("PESSOAAREA");

            entity.HasIndex(e => new { e.Codpessoa, e.Codarea }, "RDB$PRIMARY72").IsUnique();

            entity.Property(e => e.Codarea).HasColumnName("CODAREA");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Liberado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERADO");
            entity.Property(e => e.Ultimoacesso)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ULTIMOACESSO");
        });

        modelBuilder.Entity<Porta>(entity =>
        {
            entity.HasKey(e => e.Codporta);

            entity.ToTable("PORTAS");

            entity.HasIndex(e => e.Codporta, "PK_PORTAS").IsUnique();

            entity.HasIndex(e => e.Codporta, "PORTAS_CODPORTA_IDX");

            entity.Property(e => e.Codporta).HasColumnName("CODPORTA");
            entity.Property(e => e.Portas)
                .HasMaxLength(30)
                .HasColumnName("PORTAS");
        });

        modelBuilder.Entity<Portarium>(entity =>
        {
            entity.HasKey(e => e.Codportaria).HasName("RDB$PRIMARY13");

            entity.ToTable("PORTARIA");

            entity.HasIndex(e => e.Codportaria, "RDB$PRIMARY13").IsUnique();

            entity.Property(e => e.Codportaria).HasColumnName("CODPORTARIA");
            entity.Property(e => e.Portaria)
                .HasMaxLength(30)
                .HasColumnName("PORTARIA");
        });

        modelBuilder.Entity<Portasequipamento>(entity =>
        {
            entity.HasKey(e => new { e.Codequipamento, e.Codporta, e.Codsensor, e.Inout });

            entity.ToTable("PORTASEQUIPAMENTO");

            entity.HasIndex(e => new { e.Codsensor, e.Codporta, e.Codequipamento, e.Inout }, "PK_PORTASEQUIPAMENTO").IsUnique();

            entity.HasIndex(e => e.Codequipamento, "PORTASEQ_CODEQUIP_IDX");

            entity.HasIndex(e => e.Codporta, "PORTASEQ_CODPORTA_IDX");

            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codporta).HasColumnName("CODPORTA");
            entity.Property(e => e.Codsensor).HasColumnName("CODSENSOR");
            entity.Property(e => e.Inout).HasColumnName("INOUT");
            entity.Property(e => e.Antena)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ANTENA");
            entity.Property(e => e.Baixadocadastro)
                .HasColumnType("CHAR(1)")
                .HasColumnName("BAIXADOCADASTRO");
            entity.Property(e => e.Entradasaida)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENTRADASAIDA");
        });

        modelBuilder.Entity<Predio>(entity =>
        {
            entity.HasKey(e => e.Codpredio).HasName("RDB$PRIMARY14");

            entity.ToTable("PREDIO");

            entity.HasIndex(e => e.Codpredio, "CODPREDIO_PREDIO_IDX");

            entity.HasIndex(e => e.Codpredio, "RDB$PRIMARY14").IsUnique();

            entity.Property(e => e.Codpredio).HasColumnName("CODPREDIO");
            entity.Property(e => e.Predio1)
                .HasMaxLength(50)
                .HasColumnName("PREDIO");
        });

        modelBuilder.Entity<Registrosativo>(entity =>
        {
            entity.HasKey(e => new { e.Data, e.Hora, e.Codequipamento, e.Codpessoavisitante }).HasName("PKREGISTROSATIVOS");

            entity.ToTable("REGISTROSATIVOS");

            entity.HasIndex(e => new { e.Codpessoavisitante, e.Data, e.Hora }, "CODPESSOADATAHORA_REGATIVOS_IDX");

            entity.HasIndex(e => new { e.Codpessoavisitante, e.Dataehora }, "CODPESSOA_DATAEHORA_IDX");

            entity.HasIndex(e => e.Numcartao, "IDX_NUMCARTAO_REGISTROSATIVOS");

            entity.HasIndex(e => new { e.Codpessoavisitante, e.Codequipamento, e.Data, e.Hora }, "PKREGISTROSATIVOS").IsUnique();

            entity.HasIndex(e => e.Codequipamento, "REGATIVOS_CODEQUIPAMENTO_IDX");

            entity.HasIndex(e => e.Codpessoavisitante, "REGATIVOS_CODPESSOA_IDX");

            entity.HasIndex(e => e.Dataehora, "REGATIVOS_DATAEHORA_DESC_IDX").IsDescending();

            entity.HasIndex(e => e.Dataehora, "REGATIVOS_DATAEHORA_IDX");

            entity.HasIndex(e => e.Evento, "REGATIVOS_EVENTO_IDX");

            entity.HasIndex(e => new { e.Data, e.Hora }, "REGISTROSATIVOS_DATAHORA_IDX");

            entity.HasIndex(e => e.Data, "REGISTROSATIVOS_DATA_IDX");

            entity.Property(e => e.Data)
                .HasColumnType("DATE")
                .HasColumnName("DATA");
            entity.Property(e => e.Hora).HasColumnName("HORA");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codpessoavisitante).HasColumnName("CODPESSOAVISITANTE");
            entity.Property(e => e.Codempresa).HasColumnName("CODEMPRESA");
            entity.Property(e => e.Codpessoavisitada).HasColumnName("CODPESSOAVISITADA");
            entity.Property(e => e.Dataehora).HasColumnName("DATAEHORA");
            entity.Property(e => e.EntradaSaida)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENTRADA_SAIDA");
            entity.Property(e => e.Evento).HasColumnName("EVENTO");
            entity.Property(e => e.Inoutstate).HasColumnName("INOUTSTATE");
            entity.Property(e => e.Numcartao).HasColumnName("NUMCARTAO");
            entity.Property(e => e.Sensor).HasColumnName("SENSOR");
        });

        modelBuilder.Entity<Registrosdosveiculo>(entity =>
        {
            entity.HasKey(e => new { e.Data, e.Hora, e.Numcartao }).HasName("RDB$PRIMARY81");

            entity.ToTable("REGISTROSDOSVEICULOS");

            entity.HasIndex(e => new { e.Data, e.Hora, e.Numcartao }, "RDB$PRIMARY81").IsUnique();

            entity.Property(e => e.Data)
                .HasColumnType("DATE")
                .HasColumnName("DATA");
            entity.Property(e => e.Hora).HasColumnName("HORA");
            entity.Property(e => e.Numcartao).HasColumnName("NUMCARTAO");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codunidade).HasColumnName("CODUNIDADE");
            entity.Property(e => e.Codveiculo).HasColumnName("CODVEICULO");
            entity.Property(e => e.Dataehora).HasColumnName("DATAEHORA");
            entity.Property(e => e.EntradaSaida)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ENTRADA_SAIDA");
            entity.Property(e => e.Evento).HasColumnName("EVENTO");
            entity.Property(e => e.Inoutstate).HasColumnName("INOUTSTATE");
            entity.Property(e => e.Sensor).HasColumnName("SENSOR");
        });

        modelBuilder.Entity<Reglinear>(entity =>
        {
            entity.HasKey(e => new { e.Codigo, e.Codequipamento, e.Datahora }).HasName("RDB$PRIMARY105");

            entity.ToTable("REGLINEAR");

            entity.HasIndex(e => new { e.Codigo, e.Codequipamento, e.Datahora }, "RDB$PRIMARY105").IsUnique();

            entity.HasIndex(e => e.Codevento, "REGLINEAR_CODEVENTO_IDX");

            entity.HasIndex(e => e.Codmodelo, "REGLINEAR_CODMODELO_IDX");

            entity.HasIndex(e => e.Placa, "REGLINEAR_PLACA_IDX");

            entity.HasIndex(e => e.Unidade, "REGLINEAR_UNIDADE_IDX");

            entity.Property(e => e.Codigo).HasColumnName("CODIGO");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Datahora).HasColumnName("DATAHORA");
            entity.Property(e => e.Bloco)
                .HasMaxLength(10)
                .HasColumnName("BLOCO");
            entity.Property(e => e.Codbateria).HasColumnName("CODBATERIA");
            entity.Property(e => e.Codcor).HasColumnName("CODCOR");
            entity.Property(e => e.Codevento).HasColumnName("CODEVENTO");
            entity.Property(e => e.Codmodelo).HasColumnName("CODMODELO");
            entity.Property(e => e.Codtipo).HasColumnName("CODTIPO");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("PLACA");
            entity.Property(e => e.Rele).HasColumnName("RELE");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("UNIDADE");
        });

        modelBuilder.Entity<Regsensor>(entity =>
        {
            entity.HasKey(e => new { e.Codequipamento, e.Codsensor, e.Data, e.Hora }).HasName("RDB$PRIMARY74");

            entity.ToTable("REGSENSOR");

            entity.HasIndex(e => new { e.Codsensor, e.Codequipamento, e.Data, e.Hora }, "RDB$PRIMARY74").IsUnique();

            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codsensor).HasColumnName("CODSENSOR");
            entity.Property(e => e.Data)
                .HasColumnType("DATE")
                .HasColumnName("DATA");
            entity.Property(e => e.Hora).HasColumnName("HORA");
            entity.Property(e => e.Codevento).HasColumnName("CODEVENTO");
            entity.Property(e => e.Codmapa).HasColumnName("CODMAPA");
            entity.Property(e => e.Codusuario).HasColumnName("CODUSUARIO");
            entity.Property(e => e.Visto)
                .HasColumnType("CHAR(1)")
                .HasColumnName("VISTO");
        });

        modelBuilder.Entity<Rotapessoa>(entity =>
        {
            entity.HasKey(e => new { e.Codrota, e.Codpessoa }).HasName("RDB$PRIMARY93");

            entity.ToTable("ROTAPESSOA");

            entity.HasIndex(e => new { e.Codpessoa, e.Codrota }, "RDB$PRIMARY93").IsUnique();

            entity.Property(e => e.Codrota).HasColumnName("CODROTA");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Dataultimoacesso)
                .HasColumnType("DATE")
                .HasColumnName("DATAULTIMOACESSO");
            entity.Property(e => e.Horaultimoacesso).HasColumnName("HORAULTIMOACESSO");
            entity.Property(e => e.Tipoultimoacesso)
                .HasColumnType("CHAR(1)")
                .HasColumnName("TIPOULTIMOACESSO");
        });

        modelBuilder.Entity<Rotatipopessoa>(entity =>
        {
            entity.HasKey(e => new { e.Codrota, e.Codtipopessoa }).HasName("RDB$PRIMARY80");

            entity.ToTable("ROTATIPOPESSOA");

            entity.HasIndex(e => new { e.Codtipopessoa, e.Codrota }, "RDB$PRIMARY80").IsUnique();

            entity.Property(e => e.Codrota).HasColumnName("CODROTA");
            entity.Property(e => e.Codtipopessoa).HasColumnName("CODTIPOPESSOA");
            entity.Property(e => e.Selecionado)
                .HasColumnType("CHAR(1)")
                .HasColumnName("SELECIONADO");
        });

        modelBuilder.Entity<Rotum>(entity =>
        {
            entity.HasKey(e => e.Codrota).HasName("RDB$PRIMARY75");

            entity.ToTable("ROTA");

            entity.HasIndex(e => e.Codrota, "RDB$PRIMARY75").IsUnique();

            entity.Property(e => e.Codrota).HasColumnName("CODROTA");
            entity.Property(e => e.Codhorario).HasColumnName("CODHORARIO");
            entity.Property(e => e.Rota)
                .HasMaxLength(100)
                .HasColumnName("ROTA");
        });

        modelBuilder.Entity<Sensoresmapa>(entity =>
        {
            entity.HasKey(e => new { e.Codmapa, e.Codequipamento, e.Codsensor }).HasName("RDB$PRIMARY85");

            entity.ToTable("SENSORESMAPA");

            entity.HasIndex(e => new { e.Codmapa, e.Codsensor, e.Codequipamento }, "RDB$PRIMARY85").IsUnique();

            entity.Property(e => e.Codmapa).HasColumnName("CODMAPA");
            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codsensor).HasColumnName("CODSENSOR");
            entity.Property(e => e.Espx).HasColumnName("ESPX");
            entity.Property(e => e.Espy).HasColumnName("ESPY");
        });

        modelBuilder.Entity<Sensorrotum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SENSORROTA");

            entity.HasIndex(e => e.Codrota, "RDB$FOREIGN88");

            entity.Property(e => e.Codequipamento).HasColumnName("CODEQUIPAMENTO");
            entity.Property(e => e.Codrota).HasColumnName("CODROTA");
            entity.Property(e => e.Codsensor).HasColumnName("CODSENSOR");
            entity.Property(e => e.Inout).HasColumnName("INOUT");
            entity.Property(e => e.Sensortag)
                .HasColumnType("CHAR(1)")
                .HasColumnName("SENSORTAG");

            entity.HasOne(d => d.CodrotaNavigation).WithMany()
                .HasForeignKey(d => d.Codrota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_224");
        });

        modelBuilder.Entity<Serie>(entity =>
        {
            entity.HasKey(e => e.Codserie).HasName("RDB$PRIMARY82");

            entity.ToTable("SERIE");

            entity.HasIndex(e => e.Codserie, "RDB$PRIMARY82").IsUnique();

            entity.Property(e => e.Codserie).HasColumnName("CODSERIE");
            entity.Property(e => e.Serie1)
                .HasMaxLength(150)
                .HasColumnName("SERIE");
        });

        modelBuilder.Entity<Setore>(entity =>
        {
            entity.HasKey(e => e.Codsetor).HasName("RDB$PRIMARY16");

            entity.ToTable("SETORES");

            entity.HasIndex(e => e.Codsetor, "RDB$PRIMARY16").IsUnique();

            entity.Property(e => e.Codsetor).HasColumnName("CODSETOR");
            entity.Property(e => e.Setor)
                .HasColumnType("CHAR(30)")
                .HasColumnName("SETOR");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.Codtag).HasName("RDB$PRIMARY17");

            entity.ToTable("TAG");

            entity.HasIndex(e => e.Codtag, "RDB$PRIMARY17").IsUnique();

            entity.Property(e => e.Codtag).HasColumnName("CODTAG");
            entity.Property(e => e.Ativa)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ATIVA");
            entity.Property(e => e.Codtagantena2).HasColumnName("CODTAGANTENA2");
            entity.Property(e => e.Codtagnaantena)
                .HasMaxLength(40)
                .HasColumnName("CODTAGNAANTENA");
            entity.Property(e => e.Codveiculo).HasColumnName("CODVEICULO");

            entity.HasMany(d => d.Veiculosunidades).WithMany(p => p.Codtags)
                .UsingEntity<Dictionary<string, object>>(
                    "Tagveiculo",
                    r => r.HasOne<Veiculosunidade>().WithMany()
                        .HasForeignKey("Codunidade", "Codveiculo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("INTEG_133"),
                    l => l.HasOne<Tag>().WithMany()
                        .HasForeignKey("Codtag")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("INTEG_123"),
                    j =>
                    {
                        j.HasKey("Codtag", "Codunidade", "Codveiculo").HasName("RDB$PRIMARY26");
                        j.ToTable("TAGVEICULO");
                        j.HasIndex(new[] { "Codtag" }, "RDB$FOREIGN56");
                        j.HasIndex(new[] { "Codveiculo", "Codunidade" }, "RDB$FOREIGN66");
                        j.HasIndex(new[] { "Codtag", "Codveiculo", "Codunidade" }, "RDB$PRIMARY26").IsUnique();
                        j.IndexerProperty<int>("Codtag").HasColumnName("CODTAG");
                        j.IndexerProperty<int>("Codunidade").HasColumnName("CODUNIDADE");
                        j.IndexerProperty<int>("Codveiculo").HasColumnName("CODVEICULO");
                    });
        });

        modelBuilder.Entity<Tipodocumento>(entity =>
        {
            entity.HasKey(e => e.Codtipodocumento).HasName("RDB$PRIMARY100");

            entity.ToTable("TIPODOCUMENTO");

            entity.HasIndex(e => e.Codtipodocumento, "RDB$PRIMARY100").IsUnique();

            entity.Property(e => e.Codtipodocumento).HasColumnName("CODTIPODOCUMENTO");
            entity.Property(e => e.Documento)
                .HasMaxLength(100)
                .HasColumnName("DOCUMENTO");
            entity.Property(e => e.Ordem).HasColumnName("ORDEM");
        });

        modelBuilder.Entity<Tipolog>(entity =>
        {
            entity.HasKey(e => e.Codtipolog).HasName("RDB$PRIMARY91");

            entity.ToTable("TIPOLOG");

            entity.HasIndex(e => e.Codtipolog, "RDB$PRIMARY91").IsUnique();

            entity.Property(e => e.Codtipolog).HasColumnName("CODTIPOLOG");
            entity.Property(e => e.Tipolog1)
                .HasMaxLength(50)
                .HasColumnName("TIPOLOG");
        });

        modelBuilder.Entity<Tipopessoa>(entity =>
        {
            entity.HasKey(e => e.Codtipo).HasName("RDB$PRIMARY18");

            entity.ToTable("TIPOPESSOA");

            entity.HasIndex(e => e.Codtipo, "RDB$PRIMARY18").IsUnique();

            entity.Property(e => e.Codtipo).HasColumnName("CODTIPO");
            entity.Property(e => e.Atualizarplaca)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ATUALIZARPLACA");
            entity.Property(e => e.Dependente)
                .HasColumnType("CHAR(1)")
                .HasColumnName("DEPENDENTE");
            entity.Property(e => e.Habcampocartao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPOCARTAO");
            entity.Property(e => e.Habcampocartaocoacao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPOCARTAOCOACAO");
            entity.Property(e => e.Habcampocpf)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPOCPF");
            entity.Property(e => e.Habcampocrm)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPOCRM");
            entity.Property(e => e.Habcampomatricula)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPOMATRICULA");
            entity.Property(e => e.Habcampooab)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPOOAB");
            entity.Property(e => e.Habcamporg)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPORG");
            entity.Property(e => e.Habcamporne)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPORNE");
            entity.Property(e => e.Habcampoturma)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABCAMPOTURMA");
            entity.Property(e => e.Habentrarcomveiculo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABENTRARCOMVEICULO");
            entity.Property(e => e.Habentregaretirada)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABENTREGARETIRADA");
            entity.Property(e => e.Habiberacao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABIBERACAO");
            entity.Property(e => e.Habliberacao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABLIBERACAO");
            entity.Property(e => e.Habprevisao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABPREVISAO");
            entity.Property(e => e.Habsensor1)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABSENSOR1");
            entity.Property(e => e.Habsensor2)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABSENSOR2");
            entity.Property(e => e.Habsensor3)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABSENSOR3");
            entity.Property(e => e.Habsensor4)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABSENSOR4");
            entity.Property(e => e.Habtipodocumento)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABTIPODOCUMENTO");
            entity.Property(e => e.Habtransporte)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABTRANSPORTE");
            entity.Property(e => e.Liberaracessosaidamanual)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LIBERARACESSOSAIDAMANUAL");
            entity.Property(e => e.Local)
                .HasColumnType("CHAR(1)")
                .HasColumnName("LOCAL");
            entity.Property(e => e.Maxdedigitais)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MAXDEDIGITAIS");
            entity.Property(e => e.Mostraalerta)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAALERTA");
            entity.Property(e => e.Mostracampocartao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRACAMPOCARTAO");
            entity.Property(e => e.Mostracampocartaocoacao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRACAMPOCARTAOCOACAO");
            entity.Property(e => e.Mostracampomatricula)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRACAMPOMATRICULA");
            entity.Property(e => e.Mostracampoturma)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRACAMPOTURMA");
            entity.Property(e => e.Mostracelular)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRACELULAR");
            entity.Property(e => e.Mostradepartamento)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRADEPARTAMENTO");
            entity.Property(e => e.Mostradestino)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRADESTINO");
            entity.Property(e => e.Mostradtnascimento)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRADTNASCIMENTO");
            entity.Property(e => e.Mostraempresa)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAEMPRESA");
            entity.Property(e => e.Mostrafuncao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAFUNCAO");
            entity.Property(e => e.Mostranotafiscal)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRANOTAFISCAL");
            entity.Property(e => e.Mostraobs)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAOBS");
            entity.Property(e => e.Mostraplaca)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAPLACA");
            entity.Property(e => e.Mostraroperador)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAROPERADOR");
            entity.Property(e => e.Mostrasetor)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRASETOR");
            entity.Property(e => e.Mostraunidade)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAUNIDADE");
            entity.Property(e => e.Mostraveiculo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("MOSTRAVEICULO");
            entity.Property(e => e.Numliberacoes).HasColumnName("NUMLIBERACOES");
            entity.Property(e => e.Obralerta)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBRALERTA");
            entity.Property(e => e.Obrcartao)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBRCARTAO");
            entity.Property(e => e.Obrcelular)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBRCELULAR");
            entity.Property(e => e.Obrdestino)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBRDESTINO");
            entity.Property(e => e.Obrdtnascimento)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBRDTNASCIMENTO");
            entity.Property(e => e.Obrempresa)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBREMPRESA");
            entity.Property(e => e.Obrnotafiscal)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBRNOTAFISCAL");
            entity.Property(e => e.Obrobs)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBROBS");
            entity.Property(e => e.Obrveiculo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("OBRVEICULO");
            entity.Property(e => e.Ordem).HasColumnName("ORDEM");
            entity.Property(e => e.Responsavel)
                .HasColumnType("CHAR(1)")
                .HasColumnName("RESPONSAVEL");
            entity.Property(e => e.Somentetransportadora)
                .HasColumnType("CHAR(1)")
                .HasColumnName("SOMENTETRANSPORTADORA");
            entity.Property(e => e.Tipopessoa1)
                .HasMaxLength(40)
                .HasColumnName("TIPOPESSOA");
            entity.Property(e => e.Visitante)
                .HasColumnType("CHAR(1)")
                .HasColumnName("VISITANTE");
        });

        modelBuilder.Entity<Tipopessoarotum>(entity =>
        {
            entity.HasKey(e => new { e.Codrota, e.Codtipopessoa }).HasName("RDB$PRIMARY78");

            entity.ToTable("TIPOPESSOAROTA");

            entity.HasIndex(e => e.Codrota, "RDB$FOREIGN79");

            entity.HasIndex(e => new { e.Codtipopessoa, e.Codrota }, "RDB$PRIMARY78").IsUnique();

            entity.Property(e => e.Codrota).HasColumnName("CODROTA");
            entity.Property(e => e.Codtipopessoa).HasColumnName("CODTIPOPESSOA");

            entity.HasOne(d => d.CodrotaNavigation).WithMany(p => p.Tipopessoarota)
                .HasForeignKey(d => d.Codrota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_179");
        });

        modelBuilder.Entity<Turma>(entity =>
        {
            entity.HasKey(e => e.Codturma).HasName("RDB$PRIMARY83");

            entity.ToTable("TURMA");

            entity.HasIndex(e => e.Codturma, "RDB$PRIMARY83").IsUnique();

            entity.Property(e => e.Codturma).HasColumnName("CODTURMA");
            entity.Property(e => e.Codserie).HasColumnName("CODSERIE");
            entity.Property(e => e.Turma1)
                .HasMaxLength(150)
                .HasColumnName("TURMA");
            entity.Property(e => e.Turno)
                .HasColumnType("CHAR(1)")
                .HasColumnName("TURNO");
        });

        modelBuilder.Entity<Unidade>(entity =>
        {
            entity.HasKey(e => e.Codunidade).HasName("RDB$PRIMARY19");

            entity.ToTable("UNIDADE");

            entity.HasIndex(e => e.Codpredio, "CODPREDIO_UNIDADE_IDX");

            entity.HasIndex(e => e.Codunidade, "CODUNIDADE_UNIDADE_IDX");

            entity.HasIndex(e => e.Codcondominio, "RDB$FOREIGN34");

            entity.HasIndex(e => e.Codpredio, "RDB$FOREIGN53");

            entity.HasIndex(e => e.Codunidade, "RDB$PRIMARY19").IsUnique();

            entity.Property(e => e.Codunidade).HasColumnName("CODUNIDADE");
            entity.Property(e => e.Andar).HasColumnName("ANDAR");
            entity.Property(e => e.Codcondominio).HasColumnName("CODCONDOMINIO");
            entity.Property(e => e.Codpredio).HasColumnName("CODPREDIO");
            entity.Property(e => e.Numerodevagas).HasColumnName("NUMERODEVAGAS");
            entity.Property(e => e.Numunidade).HasColumnName("NUMUNIDADE");
            entity.Property(e => e.Unidade1)
                .HasMaxLength(50)
                .HasColumnName("UNIDADE");
            entity.Property(e => e.Vagaslivres).HasColumnName("VAGASLIVRES");

            entity.HasOne(d => d.CodcondominioNavigation).WithMany(p => p.Unidades)
                .HasForeignKey(d => d.Codcondominio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_101");

            entity.HasOne(d => d.CodpredioNavigation).WithMany(p => p.Unidades)
                .HasForeignKey(d => d.Codpredio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_120");
        });

        modelBuilder.Entity<Unidadesvisitada>(entity =>
        {
            entity.HasKey(e => new { e.Codunidade, e.Codpessoa }).HasName("RDB$PRIMARY20");

            entity.ToTable("UNIDADESVISITADAS");

            entity.HasIndex(e => e.Codpessoa, "RDB$FOREIGN44");

            entity.HasIndex(e => e.Codunidade, "RDB$FOREIGN59");

            entity.HasIndex(e => new { e.Codpessoa, e.Codunidade }, "RDB$PRIMARY20").IsUnique();

            entity.Property(e => e.Codunidade).HasColumnName("CODUNIDADE");
            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Dataultimavisita)
                .HasColumnType("DATE")
                .HasColumnName("DATAULTIMAVISITA");
            entity.Property(e => e.Horaultimavisita).HasColumnName("HORAULTIMAVISITA");

            entity.HasOne(d => d.CodpessoaNavigation).WithMany(p => p.Unidadesvisitada)
                .HasForeignKey(d => d.Codpessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_111");

            entity.HasOne(d => d.CodunidadeNavigation).WithMany(p => p.Unidadesvisitada)
                .HasForeignKey(d => d.Codunidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_126");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Codusuario).HasName("RDB$PRIMARY21");

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.Codusuario, "RDB$PRIMARY21").IsUnique();

            entity.Property(e => e.Codusuario).HasColumnName("CODUSUARIO");
            entity.Property(e => e.Adm)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ADM");
            entity.Property(e => e.Ativo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ATIVO");
            entity.Property(e => e.Desabilitamenu)
                .HasColumnType("CHAR(1)")
                .HasColumnName("DESABILITAMENU");
            entity.Property(e => e.Habilitabotaotipopessoa)
                .HasColumnType("CHAR(1)")
                .HasColumnName("HABILITABOTAOTIPOPESSOA");
            entity.Property(e => e.Rh)
                .HasColumnType("CHAR(1)")
                .HasColumnName("RH");
            entity.Property(e => e.Seguranca)
                .HasColumnType("CHAR(1)")
                .HasColumnName("SEGURANCA");
            entity.Property(e => e.Senha)
                .HasColumnType("CHAR(8)")
                .HasColumnName("SENHA");
            entity.Property(e => e.Usuario1)
                .HasColumnType("CHAR(8)")
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.HasKey(e => e.Codveiculo).HasName("RDB$PRIMARY22");

            entity.ToTable("VEICULOS");

            entity.HasIndex(e => e.Codmodelo, "RDB$FOREIGN64");

            entity.HasIndex(e => e.Codcor, "RDB$FOREIGN65");

            entity.HasIndex(e => e.Codveiculo, "RDB$PRIMARY22").IsUnique();

            entity.Property(e => e.Codveiculo).HasColumnName("CODVEICULO");
            entity.Property(e => e.Ativo)
                .HasColumnType("CHAR(1)")
                .HasColumnName("ATIVO");
            entity.Property(e => e.Codcor).HasColumnName("CODCOR");
            entity.Property(e => e.Codmodelo).HasColumnName("CODMODELO");
            entity.Property(e => e.Obsveiculo)
                .HasMaxLength(250)
                .HasColumnName("OBSVEICULO");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("PLACA");

            entity.HasOne(d => d.CodcorNavigation).WithMany(p => p.Veiculos)
                .HasForeignKey(d => d.Codcor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_132");

            entity.HasOne(d => d.CodmodeloNavigation).WithMany(p => p.Veiculos)
                .HasForeignKey(d => d.Codmodelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_131");
        });

        modelBuilder.Entity<Veiculopessoa>(entity =>
        {
            entity.HasKey(e => new { e.Codpessoa, e.Codveiculo }).HasName("RDB$PRIMARY103");

            entity.ToTable("VEICULOPESSOA");

            entity.HasIndex(e => new { e.Codpessoa, e.Codveiculo }, "RDB$PRIMARY103").IsUnique();

            entity.Property(e => e.Codpessoa).HasColumnName("CODPESSOA");
            entity.Property(e => e.Codveiculo).HasColumnName("CODVEICULO");
        });

        modelBuilder.Entity<Veiculosunidade>(entity =>
        {
            entity.HasKey(e => new { e.Codunidade, e.Codveiculo }).HasName("RDB$PRIMARY25");

            entity.ToTable("VEICULOSUNIDADE");

            entity.HasIndex(e => e.Codunidade, "RDB$FOREIGN60");

            entity.HasIndex(e => e.Codveiculo, "RDB$FOREIGN63");

            entity.HasIndex(e => new { e.Codveiculo, e.Codunidade }, "RDB$PRIMARY25").IsUnique();

            entity.Property(e => e.Codunidade).HasColumnName("CODUNIDADE");
            entity.Property(e => e.Codveiculo).HasColumnName("CODVEICULO");
            entity.Property(e => e.Ativo).HasColumnName("ATIVO");
            entity.Property(e => e.Obsveiculounidade)
                .HasMaxLength(250)
                .HasColumnName("OBSVEICULOUNIDADE");

            entity.HasOne(d => d.CodunidadeNavigation).WithMany(p => p.Veiculosunidades)
                .HasForeignKey(d => d.Codunidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_127");

            entity.HasOne(d => d.CodveiculoNavigation).WithMany(p => p.Veiculosunidades)
                .HasForeignKey(d => d.Codveiculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("INTEG_130");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
