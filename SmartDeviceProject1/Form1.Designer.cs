namespace SmartDeviceProject1
{
  partial class FormPrincipal
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnIniciar = new System.Windows.Forms.Button();
      this.btnSair = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnConsultar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(69, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 20);
      this.label1.Text = "PESQUISA";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(69, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 20);
      this.label2.Text = "DE";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(33, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(172, 20);
      this.label3.Text = "SUPERMERCADOS";
      this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // btnIniciar
      // 
      this.btnIniciar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.btnIniciar.Location = new System.Drawing.Point(57, 87);
      this.btnIniciar.Name = "btnIniciar";
      this.btnIniciar.Size = new System.Drawing.Size(124, 37);
      this.btnIniciar.TabIndex = 5;
      this.btnIniciar.Text = "Nova";
      this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
      // 
      // btnSair
      // 
      this.btnSair.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.btnSair.Location = new System.Drawing.Point(57, 172);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(124, 37);
      this.btnSair.TabIndex = 6;
      this.btnSair.Text = "Sair";
      this.btnSair.Click += new System.EventHandler(this.btnEncerrar_Click);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
      this.label4.Location = new System.Drawing.Point(69, 223);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(100, 20);
      this.label4.Text = "Versão 1.0";
      this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
      this.label5.Location = new System.Drawing.Point(29, 243);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(180, 20);
      this.label5.Text = "by Felipe Maximiliano";
      this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // btnConsultar
      // 
      this.btnConsultar.Enabled = false;
      this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.btnConsultar.Location = new System.Drawing.Point(57, 129);
      this.btnConsultar.Name = "btnConsultar";
      this.btnConsultar.Size = new System.Drawing.Size(124, 37);
      this.btnConsultar.TabIndex = 10;
      this.btnConsultar.Text = "Consultar";
      this.btnConsultar.Click += new System.EventHandler(this.btnExportar_Click);
      // 
      // FormPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(638, 455);
      this.Controls.Add(this.btnConsultar);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.btnIniciar);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "FormPrincipal";
      this.Text = "Pesquisa CE";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnIniciar;
    private System.Windows.Forms.Button btnSair;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnConsultar;
  }
}

