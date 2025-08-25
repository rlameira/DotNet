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
    tmrFluxo = new System.Windows.Forms.Timer(components);
    grpBoxInformacao.SuspendLayout();
    statusStrip1.SuspendLayout();
    SuspendLayout();
    // 
    // grpBoxInformacao
    // 
    grpBoxInformacao.Controls.Add(txtBxMesagem);
    grpBoxInformacao.Dock = DockStyle.Top;
    grpBoxInformacao.Location = new Point(0, 0);
    grpBoxInformacao.Name = "grpBoxInformacao";
    grpBoxInformacao.Size = new Size(574, 333);
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
    txtBxMesagem.Size = new Size(568, 311);
    txtBxMesagem.TabIndex = 0;
    // 
    // statusStrip1
    // 
    statusStrip1.Items.AddRange(new ToolStripItem[] { stsLblIP, StsLblSession });
    statusStrip1.Location = new Point(0, 599);
    statusStrip1.Name = "statusStrip1";
    statusStrip1.Size = new Size(574, 22);
    statusStrip1.TabIndex = 1;
    statusStrip1.Text = "statusStrip1";
    statusStrip1.ItemClicked += statusStrip1_ItemClicked;
    // 
    // stsLblIP
    // 
    stsLblIP.Name = "stsLblIP";
    stsLblIP.Size = new Size(118, 17);
    stsLblIP.Text = "toolStripStatusLabel1";
    // 
    // StsLblSession
    // 
    StsLblSession.Name = "StsLblSession";
    StsLblSession.Size = new Size(118, 17);
    StsLblSession.Text = "toolStripStatusLabel1";
    // 
    // tmrFluxo
    // 
    tmrFluxo.Interval = 2000;
    tmrFluxo.Tick += tmrFluxo_Tick;
    // 
    // FrmPrincipal
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(574, 621);
    Controls.Add(statusStrip1);
    Controls.Add(grpBoxInformacao);
    Name = "FrmPrincipal";
    Text = "Form1";
    Shown += FrmPrincipal_Shown;
    grpBoxInformacao.ResumeLayout(false);
    grpBoxInformacao.PerformLayout();
    statusStrip1.ResumeLayout(false);
    statusStrip1.PerformLayout();
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
}
