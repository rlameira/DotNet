namespace MonitorCtrlID;

partial class FrmPrincipal
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

  #region Windows Form Designer generated code

  /// <summary>
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
    components = new System.ComponentModel.Container();
    grpBoxInformacao = new GroupBox();
    txtBxMesagem = new TextBox();
    statusStrip1 = new StatusStrip();
    stsLblIP = new ToolStripStatusLabel();
    StsLblSession = new ToolStripStatusLabel();
    stsLblHoraAbertura = new ToolStripStatusLabel();
    stsLblHoraConexao = new ToolStripStatusLabel();
    stsLblReconectar = new ToolStripStatusLabel();
    tmrFluxo = new System.Windows.Forms.Timer(components);
    panel1 = new Panel();
    pictureBox1 = new PictureBox();
    grpBoxInformacao.SuspendLayout();
    statusStrip1.SuspendLayout();
    panel1.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
    SuspendLayout();
    // 
    // grpBoxInformacao
    // 
    grpBoxInformacao.Controls.Add(txtBxMesagem);
    grpBoxInformacao.Dock = DockStyle.Top;
    grpBoxInformacao.Location = new Point(0, 0);
    grpBoxInformacao.Name = "grpBoxInformacao";
    grpBoxInformacao.Size = new Size(604, 294);
    grpBoxInformacao.TabIndex = 0;
    grpBoxInformacao.TabStop = false;
    grpBoxInformacao.Text = "Informação";
    // 
    // txtBxMesagem
    // 
    txtBxMesagem.Dock = DockStyle.Fill;
    txtBxMesagem.Location = new Point(3, 19);
    txtBxMesagem.Multiline = true;
    txtBxMesagem.Name = "txtBxMesagem";
    txtBxMesagem.Size = new Size(598, 272);
    txtBxMesagem.TabIndex = 0;
    // 
    // statusStrip1
    // 
    statusStrip1.Items.AddRange(new ToolStripItem[] { stsLblIP, StsLblSession, stsLblHoraAbertura, stsLblHoraConexao, stsLblReconectar });
    statusStrip1.Location = new Point(0, 539);
    statusStrip1.Name = "statusStrip1";
    statusStrip1.Size = new Size(604, 22);
    statusStrip1.TabIndex = 1;
    statusStrip1.Text = "statusStrip1";
    statusStrip1.ItemClicked += statusStrip1_ItemClicked;
    // 
    // stsLblIP
    // 
    stsLblIP.Font = new Font("Segoe UI", 8.25F);
    stsLblIP.Name = "stsLblIP";
    stsLblIP.Size = new Size(117, 17);
    stsLblIP.Text = "toolStripStatusLabel1";
    // 
    // StsLblSession
    // 
    StsLblSession.Font = new Font("Segoe UI", 8.25F);
    StsLblSession.Name = "StsLblSession";
    StsLblSession.Size = new Size(49, 17);
    StsLblSession.Text = "Session:";
    // 
    // stsLblHoraAbertura
    // 
    stsLblHoraAbertura.Font = new Font("Segoe UI", 8.25F);
    stsLblHoraAbertura.Name = "stsLblHoraAbertura";
    stsLblHoraAbertura.Size = new Size(96, 17);
    stsLblHoraAbertura.Text = "Hora de Abertura";
    // 
    // stsLblHoraConexao
    // 
    stsLblHoraConexao.Font = new Font("Segoe UI", 8.25F);
    stsLblHoraConexao.Name = "stsLblHoraConexao";
    stsLblHoraConexao.Size = new Size(96, 17);
    stsLblHoraConexao.Text = "Hora de Conexao";
    // 
    // stsLblReconectar
    // 
    stsLblReconectar.Name = "stsLblReconectar";
    stsLblReconectar.Size = new Size(13, 17);
    stsLblReconectar.Text = "0";
    // 
    // tmrFluxo
    // 
    tmrFluxo.Interval = 2000;
    tmrFluxo.Tick += tmrFluxo_Tick;
    // 
    // panel1
    // 
    panel1.Controls.Add(pictureBox1);
    panel1.Dock = DockStyle.Bottom;
    panel1.Location = new Point(0, 294);
    panel1.Name = "panel1";
    panel1.Size = new Size(604, 245);
    panel1.TabIndex = 2;
    // 
    // pictureBox1
    // 
    pictureBox1.BorderStyle = BorderStyle.FixedSingle;
    pictureBox1.Dock = DockStyle.Bottom;
    pictureBox1.Image = Properties.Resources.SisPlenaAcessoMonitor_530;
    pictureBox1.InitialImage = null;
    pictureBox1.Location = new Point(0, 0);
    pictureBox1.Name = "pictureBox1";
    pictureBox1.Size = new Size(604, 245);
    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    pictureBox1.TabIndex = 3;
    pictureBox1.TabStop = false;
    // 
    // FrmPrincipal
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(604, 561);
    Controls.Add(grpBoxInformacao);
    Controls.Add(panel1);
    Controls.Add(statusStrip1);
    Name = "FrmPrincipal";
    Text = "Monitor CtrlID";
    Shown += FrmPrincipal_Shown;
    grpBoxInformacao.ResumeLayout(false);
    grpBoxInformacao.PerformLayout();
    statusStrip1.ResumeLayout(false);
    statusStrip1.PerformLayout();
    panel1.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
    ResumeLayout(false);
    PerformLayout();
  }

  #endregion

  private GroupBox grpBoxInformacao;
  private StatusStrip statusStrip1;
  private ToolStripStatusLabel stsLblIP;
  private ToolStripStatusLabel StsLblSession;
  private System.Windows.Forms.Timer tmrFluxo;
  private TextBox txtBxMesagem;
  private Panel panel1;
  private PictureBox pictureBox1;
  private ToolStripStatusLabel stsLblHoraAbertura;
  private ToolStripStatusLabel stsLblHoraConexao;
  private ToolStripStatusLabel stsLblReconectar;
}
