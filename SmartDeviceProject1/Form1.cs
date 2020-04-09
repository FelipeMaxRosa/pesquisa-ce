using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SmartDeviceProject1
{
  public partial class FormPrincipal : Form
  {
    int totalItens = 0;

    //Construtor
    //----------------------------------------------------------------------
    public FormPrincipal()
    {
      InitializeComponent();
    }

    //Metodos Eventos
    //----------------------------------------------------------------------
    private void btnEncerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Maximized;
    }

    private void btnIniciar_Click(object sender, EventArgs e)
    {
      Concorrente conc = new Concorrente();
      try
      {
        StreamReader sr = new StreamReader(conc.PathFile + "lista.csv");
        int i = 0;
        while (!sr.EndOfStream)
        {
          string line = sr.ReadLine();
          i++;
        }
        totalItens = i - 1;
        sr.Close();

        FormPesquisa pesq = new FormPesquisa(this);
        pesq.WindowState = FormWindowState.Maximized;
        pesq.totalItens = totalItens;
        pesq.Show();
        this.Visible = false;      
      }
      catch (Exception ex)
      {
        MessageBox.Show("Arquivo de Pesquisa não encontrado!");
      }
      
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {

    }
  }
}
