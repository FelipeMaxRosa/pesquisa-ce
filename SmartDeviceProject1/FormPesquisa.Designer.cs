namespace SmartDeviceProject1
{
  partial class FormPesquisa
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
      this.cbxConcorrente = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnOKConcorrente = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPreco = new System.Windows.Forms.TextBox();
      this.btnVoltar = new System.Windows.Forms.Button();
      this.btnAvancar = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.txtItem = new System.Windows.Forms.TextBox();
      this.btnConcluir = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.txtEAN = new System.Windows.Forms.TextBox();
      this.btnOKItem = new System.Windows.Forms.Button();
      this.btnVoltarTudo = new System.Windows.Forms.Button();
      this.btnAvancarTudo = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtProduto = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // cbxConcorrente
      // 
      this.cbxConcorrente.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.cbxConcorrente.Items.Add("SHIBATA");
      this.cbxConcorrente.Items.Add("SILVA");
      this.cbxConcorrente.Items.Add("SEMAR");
      this.cbxConcorrente.Items.Add("PIRATININGA");
      this.cbxConcorrente.Location = new System.Drawing.Point(5, 27);
      this.cbxConcorrente.Name = "cbxConcorrente";
      this.cbxConcorrente.Size = new System.Drawing.Size(196, 23);
      this.cbxConcorrente.TabIndex = 0;
      this.cbxConcorrente.SelectedIndexChanged += new System.EventHandler(this.cbxConcorrente_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(5, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 20);
      this.label1.Text = "Concorrente";
      // 
      // btnOKConcorrente
      // 
      this.btnOKConcorrente.Enabled = false;
      this.btnOKConcorrente.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.btnOKConcorrente.Location = new System.Drawing.Point(205, 27);
      this.btnOKConcorrente.Name = "btnOKConcorrente";
      this.btnOKConcorrente.Size = new System.Drawing.Size(28, 23);
      this.btnOKConcorrente.TabIndex = 1;
      this.btnOKConcorrente.Text = "OK";
      this.btnOKConcorrente.Click += new System.EventHandler(this.button1_Click);
      this.btnOKConcorrente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOKConcorrente_KeyDown);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(5, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(233, 20);
      this.label2.Text = "________________________________";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(5, 215);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(100, 20);
      this.label4.Text = "R$";
      // 
      // txtPreco
      // 
      this.txtPreco.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.txtPreco.Location = new System.Drawing.Point(5, 235);
      this.txtPreco.Name = "txtPreco";
      this.txtPreco.ReadOnly = true;
      this.txtPreco.Size = new System.Drawing.Size(58, 23);
      this.txtPreco.TabIndex = 7;
      this.txtPreco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPreco_KeyDown);
      this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
      // 
      // btnVoltar
      // 
      this.btnVoltar.Enabled = false;
      this.btnVoltar.Location = new System.Drawing.Point(133, 78);
      this.btnVoltar.Name = "btnVoltar";
      this.btnVoltar.Size = new System.Drawing.Size(28, 23);
      this.btnVoltar.TabIndex = 3;
      this.btnVoltar.Text = "<";
      this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
      // 
      // btnAvancar
      // 
      this.btnAvancar.Enabled = false;
      this.btnAvancar.Location = new System.Drawing.Point(171, 78);
      this.btnAvancar.Name = "btnAvancar";
      this.btnAvancar.Size = new System.Drawing.Size(28, 23);
      this.btnAvancar.TabIndex = 4;
      this.btnAvancar.Text = ">";
      this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(5, 80);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(56, 20);
      this.label5.Text = "Ítem:";
      // 
      // txtItem
      // 
      this.txtItem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.txtItem.Location = new System.Drawing.Point(47, 78);
      this.txtItem.Name = "txtItem";
      this.txtItem.ReadOnly = true;
      this.txtItem.Size = new System.Drawing.Size(36, 23);
      this.txtItem.TabIndex = 2;
      this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
      this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
      // 
      // btnConcluir
      // 
      this.btnConcluir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.btnConcluir.Location = new System.Drawing.Point(109, 221);
      this.btnConcluir.Name = "btnConcluir";
      this.btnConcluir.Size = new System.Drawing.Size(124, 37);
      this.btnConcluir.TabIndex = 9;
      this.btnConcluir.Text = "Concluir";
      this.btnConcluir.Visible = false;
      this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(5, 167);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(157, 20);
      this.label6.Text = "EAN / Código";
      // 
      // txtEAN
      // 
      this.txtEAN.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.txtEAN.Location = new System.Drawing.Point(5, 187);
      this.txtEAN.Name = "txtEAN";
      this.txtEAN.ReadOnly = true;
      this.txtEAN.Size = new System.Drawing.Size(100, 19);
      this.txtEAN.TabIndex = 5;
      this.txtEAN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEAN_KeyDown);
      this.txtEAN.LostFocus += new System.EventHandler(this.txtEAN_LostFocus);
      // 
      // btnOKItem
      // 
      this.btnOKItem.Enabled = false;
      this.btnOKItem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.btnOKItem.Location = new System.Drawing.Point(69, 235);
      this.btnOKItem.Name = "btnOKItem";
      this.btnOKItem.Size = new System.Drawing.Size(28, 23);
      this.btnOKItem.TabIndex = 8;
      this.btnOKItem.Text = "OK";
      this.btnOKItem.Click += new System.EventHandler(this.btnOKItem_Click);
      this.btnOKItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOKItem_KeyDown);
      // 
      // btnVoltarTudo
      // 
      this.btnVoltarTudo.Enabled = false;
      this.btnVoltarTudo.Location = new System.Drawing.Point(99, 78);
      this.btnVoltarTudo.Name = "btnVoltarTudo";
      this.btnVoltarTudo.Size = new System.Drawing.Size(28, 23);
      this.btnVoltarTudo.TabIndex = 15;
      this.btnVoltarTudo.Text = "<<";
      this.btnVoltarTudo.Click += new System.EventHandler(this.btnVoltarTudo_Click);
      // 
      // btnAvancarTudo
      // 
      this.btnAvancarTudo.Enabled = false;
      this.btnAvancarTudo.Location = new System.Drawing.Point(205, 78);
      this.btnAvancarTudo.Name = "btnAvancarTudo";
      this.btnAvancarTudo.Size = new System.Drawing.Size(28, 23);
      this.btnAvancarTudo.TabIndex = 16;
      this.btnAvancarTudo.Text = ">>";
      this.btnAvancarTudo.Click += new System.EventHandler(this.btnAvancarTudo_Click);
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(5, 115);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(157, 20);
      this.label3.Text = "Descrição do Produto";
      // 
      // txtProduto
      // 
      this.txtProduto.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
      this.txtProduto.Location = new System.Drawing.Point(5, 137);
      this.txtProduto.Name = "txtProduto";
      this.txtProduto.ReadOnly = true;
      this.txtProduto.Size = new System.Drawing.Size(228, 19);
      this.txtProduto.TabIndex = 24;
      // 
      // FormPesquisa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(238, 270);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtProduto);
      this.Controls.Add(this.btnAvancarTudo);
      this.Controls.Add(this.btnVoltarTudo);
      this.Controls.Add(this.btnOKItem);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtEAN);
      this.Controls.Add(this.btnConcluir);
      this.Controls.Add(this.txtItem);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnAvancar);
      this.Controls.Add(this.btnVoltar);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtPreco);
      this.Controls.Add(this.btnOKConcorrente);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbxConcorrente);
      this.Controls.Add(this.label2);
      this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
      this.KeyPreview = true;
      this.Name = "FormPesquisa";
      this.Text = "Pesquisa CE";
      this.Load += new System.EventHandler(this.FormPesquisa_Load);
      this.Closing += new System.ComponentModel.CancelEventHandler(this.FormPesquisa_Closing);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisa_KeyDown);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cbxConcorrente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnOKConcorrente;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPreco;
    private System.Windows.Forms.Button btnVoltar;
    private System.Windows.Forms.Button btnAvancar;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtItem;
    private System.Windows.Forms.Button btnConcluir;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtEAN;
    private System.Windows.Forms.Button btnOKItem;
    private System.Windows.Forms.Button btnVoltarTudo;
    private System.Windows.Forms.Button btnAvancarTudo;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtProduto;
  }
}