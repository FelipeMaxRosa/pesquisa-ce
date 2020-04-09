using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1
{
  public partial class FormCheque : Form
  {
    //Atributos
    //-----------------------------------------------------------------
    FormPrincipal pri;

    //Construtor
    //-----------------------------------------------------------------
    public FormCheque(FormPrincipal form)
    {
      InitializeComponent();
      pri = form;
    }

    //Métodos
    //-----------------------------------------------------------------
    private void btnConcluir_Click(object sender, EventArgs e)
    {
      
    }
  }
}