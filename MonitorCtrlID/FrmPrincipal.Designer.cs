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
    groupBox1 = new GroupBox();
    statusStrip1 = new StatusStrip();
    stsLblIP = new ToolStripStatusLabel();
    StsLblSession = new ToolStripStatusLabel();
    statusStrip1.SuspendLayout();
    SuspendLayout();
    // 
    // groupBox1
    // 
    groupBox1.Dock = DockStyle.Top;
    groupBox1.Location = new Point(0, 0);
    groupBox1.Name = "groupBox1";
    groupBox1.Size = new Size(574, 333);
    groupBox1.TabIndex = 0;
    groupBox1.TabStop = false;
    groupBox1.Text = "groupBox1";
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
    // FrmPrincipal
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(574, 621);
    Controls.Add(statusStrip1);
    Controls.Add(groupBox1);
    Name = "FrmPrincipal";
    Text = "Form1";
    statusStrip1.ResumeLayout(false);
    statusStrip1.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  #endregion

  private GroupBox groupBox1;
  private StatusStrip statusStrip1;
  private ToolStripStatusLabel stsLblIP;
  private ToolStripStatusLabel StsLblSession;
}
