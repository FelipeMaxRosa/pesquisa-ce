namespace SmartDeviceProject1
{
  partial class FormCheque
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.MainMenu mainMenu1;

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
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.btnConcluir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(69, 54);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(100, 24);
      this.dateTimePicker1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
      this.label1.Location = new System.Drawing.Point(55, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(144, 33);
      this.label1.Text = "CHEQUE PRÉ";
      // 
      // btnConcluir
      // 
      this.btnConcluir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
      this.btnConcluir.Location = new System.Drawing.Point(69, 86);
      this.btnConcluir.Name = "btnConcluir";
      this.btnConcluir.Size = new System.Drawing.Size(100, 37);
      this.btnConcluir.TabIndex = 10;
      this.btnConcluir.Text = "OK";
      this.btnConcluir.Visible = false;
      // 
      // FormCheque
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(238, 144);
      this.Controls.Add(this.btnConcluir);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dateTimePicker1);
      this.MaximizeBox = false;
      this.Menu = this.mainMenu1;
      this.Name = "FormCheque";
      this.Text = "Pesquisa CE";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnConcluir;
  }
}