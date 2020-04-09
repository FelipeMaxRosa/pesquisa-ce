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
  public partial class FormPesquisa : Form
  {
    //Atributos
    //----------------------------------------------------------
    FormPrincipal frmPri;
    bool iniciado = false;
    int item = 0;
    Concorrente conc;
    public int totalItens = 0;
    Item[] lista;


    //Construtor
    //----------------------------------------------------------
    public FormPesquisa(object frm)
    {
      if (frm is FormPrincipal)
      {
        frmPri = (FormPrincipal)frm;
      }
      InitializeComponent();
    }

    //Métodos - Gerais
    //----------------------------------------------------------
    public void SalvaItem()
    {
      int num = Convert.ToInt32(txtItem.Text);
      int i = 0;
      while(num != lista[i].IdItem)
      {
        i++;
      }

      decimal preco = 0.00M;

      try
      {
        preco = Convert.ToDecimal(txtPreco.Text);
        txtPreco.Text = preco.ToString("0.00");
      }
      catch (Exception ex)
      {
        preco = 0.00M;
        txtPreco.Text = "0.00";
      }

      lista[i].Preco = preco;
      i++;
      if (i < totalItens)
      {
        /*txtItem.Text = lista[i].IdItem.ToString();
        
        if (!String.IsNullOrEmpty(lista[i].Ean))
          txtEAN.Text = lista[i].Ean.ToString();
        else
          txtEAN.Text = lista[i].Codigo.ToString();
        
        txtProduto.Text = lista[i].Descricao.ToString();
        txtPreco.Text = "";
        txtPreco.Focus();
        txtPreco.SelectAll();*/
        txtItem.Text = lista[i].IdItem.ToString();

        if (!String.IsNullOrEmpty(lista[i].Ean))
          txtEAN.Text = lista[i].Ean.ToString();
        else
          txtEAN.Text = lista[i].Codigo.ToString();

        txtProduto.Text = lista[i].Descricao.ToString();
        txtPreco.Text = lista[i].Preco.ToString("0.00");
        btnVoltar.Enabled = true;
        txtPreco.Focus();
        txtPreco.SelectAll();

        if ((totalItens - 1) == i)
        {
          btnAvancar.Enabled = false;
        }
      }
      else
      {
        btnConcluir.Visible = true;
        btnAvancar.Enabled = false;
      }
    }

    //Métodos - Eventos
    //----------------------------------------------------------
    private void FormPesquisa_Load(object sender, EventArgs e)
    {
      lista = new Item[totalItens];
      conc = new Concorrente();
      //StreamReader file = new StreamReader(@"\Micromax\MarkPrice\lista.csv");
      StreamReader file = new StreamReader(conc.PathFile + "lista.csv");
      int i = 0;
      string linha = file.ReadLine();
      do
      {
        linha = file.ReadLine();
        string[] linhaSeparada = linha.Split(';');
        lista[i] = new Item();
        lista[i].IdItem = i+1;
        lista[i].Ean = linhaSeparada[0];
        lista[i].Codigo = linhaSeparada[1];
        lista[i].Descricao = linhaSeparada[2];
        i++;
      } while (!file.EndOfStream);

      file.Close();
      cbxConcorrente.Focus();
    }

    private void btnEncerrar_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (cbxConcorrente.SelectedIndex >= 0)
      {
        Concorrente conc = new Concorrente();
        conc.Nome = cbxConcorrente.Text;
        if (conc.VerificaArquivoExistente())
        {
          if (MessageBox.Show("Exite uma pesquisa para este concorrente, deseja iniciar uma nova?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            iniciado = true;
            item = 0;
            cbxConcorrente.Enabled = false;
            btnOKConcorrente.Enabled = false;
            conc = new Concorrente();
            conc.IdConcorrente = cbxConcorrente.SelectedIndex;
            conc.Nome = cbxConcorrente.Text;

            //Atualiza Lista para o Concorrente Selecionado
            //------------------------------------------------------
            for (int i = 0; i < totalItens; i++)
            {
              lista[i].Concorrente = cbxConcorrente.Text;
            }

            //Carrega Item da Pesquisa
            //------------------------------------------------------
            txtItem.Text = lista[item].IdItem.ToString();
            if (!String.IsNullOrEmpty(lista[item].Ean))
              txtEAN.Text = lista[item].Ean;
            else
              txtEAN.Text = lista[item].Codigo;

            txtProduto.Text = lista[item].Descricao;
            txtPreco.Text = lista[item].Preco.ToString("0.00");

            txtItem.ReadOnly = false;
            txtPreco.ReadOnly = false;
            txtEAN.ReadOnly = false;
            btnVoltar.Enabled = false;
            btnVoltarTudo.Enabled = true;
            btnAvancar.Enabled = true;
            btnAvancarTudo.Enabled = true;
            btnOKItem.Enabled = true;
            txtPreco.Focus();
            txtPreco.SelectAll();
          }  
        }
        else
        {
          iniciado = true;
          item = 0;
          cbxConcorrente.Enabled = false;
          btnOKConcorrente.Enabled = false;
          conc = new Concorrente();
          conc.IdConcorrente = cbxConcorrente.SelectedIndex;
          conc.Nome = cbxConcorrente.Text;

          //Atualiza Lista para o Concorrente Selecionado
          //------------------------------------------------------
          for (int i = 0; i < totalItens; i++)
          {
            lista[i].Concorrente = cbxConcorrente.Text;
          }

          //Carrega Item da Pesquisa
          //------------------------------------------------------
          txtItem.Text = lista[item].IdItem.ToString();
          if (!String.IsNullOrEmpty(lista[item].Ean))
            txtEAN.Text = lista[item].Ean;
          else
            txtEAN.Text = lista[item].Codigo;

          txtProduto.Text = lista[item].Descricao;
          txtPreco.Text = lista[item].Preco.ToString("0.00");

          txtItem.ReadOnly = false;
          txtPreco.ReadOnly = false;
          txtEAN.ReadOnly = false;
          btnVoltar.Enabled = false;
          btnVoltarTudo.Enabled = true;
          btnAvancar.Enabled = true;
          btnAvancarTudo.Enabled = true;
          btnOKItem.Enabled = true;
          txtPreco.Focus();
          txtPreco.SelectAll();
        }
      }
      else
      {
        MessageBox.Show("Selecione um concorrente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
      }      
    }

    private void cbxConcorrente_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!iniciado)
      {
        if (cbxConcorrente.SelectedIndex >= 0)
        {
          btnOKConcorrente.Enabled = true;
          //cbxConcorrente.Enabled = false;
        }  
      }      
    }

    private void FormPesquisa_KeyDown(object sender, KeyEventArgs e)
    {

    }

    private void txtPreco_KeyDown(object sender, KeyEventArgs e)
    {
      if (iniciado)
      {
        try
        {
          Convert.ToDecimal(txtPreco.Text);
          if (e.KeyCode == Keys.Enter)
          {
            if (e.Shift)
            {

            }
            else
            {
              //btnOKItem.Focus();
              this.SalvaItem();
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Digite o valor corretamente!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
          txtPreco.Text = "";
          txtPreco.Focus();
        }
          
      }      
    }

    private void btnOKItem_Click(object sender, EventArgs e)
    {
      if (iniciado)
      {
        this.SalvaItem();  
      }      
    }

    private void btnOKItem_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (e.Shift)
        {

        }
        else
        {
          this.SalvaItem();
        }
      }
    }

    private void btnOKConcorrente_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (e.Shift)
        {

        }
        else
        {
          if (cbxConcorrente.SelectedIndex >= 0)
          {
            cbxConcorrente.Enabled = false;
            conc = new Concorrente();
            conc.IdConcorrente = cbxConcorrente.SelectedIndex;
            conc.Nome = cbxConcorrente.Text;
            //Carregar Arquivo de Pesquisa
            //Carregar Item      
            txtPreco.Focus();
          }
          else
          {
            MessageBox.Show("Selecione um concorrente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
          } 
        }
      }
    }

    private void txtEAN_LostFocus(object sender, EventArgs e)
    {

    }

    private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
      {
        e.Handled = true;
      }
    }

    private void btnAvancar_Click(object sender, EventArgs e)
    {
      int i = Convert.ToInt32(txtItem.Text);
      if (i < totalItens)
      {
        txtItem.Text = lista[i].IdItem.ToString();

        if (!String.IsNullOrEmpty(lista[i].Ean))
          txtEAN.Text = lista[i].Ean.ToString();
        else
          txtEAN.Text = lista[i].Codigo.ToString();

        txtProduto.Text = lista[i].Descricao.ToString();
        txtPreco.Text = lista[i].Preco.ToString("0.00");
        btnVoltar.Enabled = true;
        txtPreco.Focus();
        txtPreco.SelectAll();

        if ((totalItens-1) == i)
        {
          btnAvancar.Enabled = false;
          btnConcluir.Visible = true;
        }
      }
      else
      {
        btnAvancar.Enabled = false;
        btnConcluir.Visible = true;
      }
    }

    private void btnVoltar_Click(object sender, EventArgs e)
    {
      int i = Convert.ToInt32(txtItem.Text);
      i -= 2;
      if (i >= 0)
      {
        txtItem.Text = lista[i].IdItem.ToString();

        if (!String.IsNullOrEmpty(lista[i].Ean))
          txtEAN.Text = lista[i].Ean.ToString();
        else
          txtEAN.Text = lista[i].Codigo.ToString();

        txtProduto.Text = lista[i].Descricao.ToString();
        txtPreco.Text = lista[i].Preco.ToString("0.00");
        txtPreco.Focus();
        txtPreco.SelectAll();
        btnConcluir.Visible = false;
        btnAvancar.Enabled = true;

        if (i == 0)
        {
          btnVoltar.Enabled = false;
        }
      }
      else
      {
        btnVoltar.Enabled = false;
      }
    }

    private void btnVoltarTudo_Click(object sender, EventArgs e)
    {
      txtItem.Text = lista[0].IdItem.ToString();
      if (!String.IsNullOrEmpty(lista[0].Ean))
        txtEAN.Text = lista[0].Ean;  
      else
        txtEAN.Text = lista[0].Codigo;
      txtPreco.Text = lista[0].Preco.ToString("0.00");
      txtProduto.Text = lista[0].Descricao;
      btnVoltar.Enabled = false;
      btnAvancar.Enabled = true;
      btnAvancarTudo.Enabled = true;
      btnConcluir.Visible = false;
      txtPreco.Focus();
      txtPreco.SelectAll();
    }

    private void btnAvancarTudo_Click(object sender, EventArgs e)
    {
      txtItem.Text = lista[totalItens-1].IdItem.ToString();
      if (!String.IsNullOrEmpty(lista[totalItens - 1].Ean))
        txtEAN.Text = lista[totalItens - 1].Ean;
      else
        txtEAN.Text = lista[totalItens - 1].Codigo;
      txtPreco.Text = lista[totalItens - 1].Preco.ToString("0.00");
      txtProduto.Text = lista[totalItens - 1].Descricao;
      btnVoltar.Enabled = true;
      btnVoltarTudo.Enabled = true;
      btnAvancar.Enabled = false;
      btnConcluir.Visible = true;
      txtPreco.Focus();
      txtPreco.SelectAll();
    }

    private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
      {
        e.Handled = true;
      }
    }

    private void txtItem_KeyDown(object sender, KeyEventArgs e)
    {
      if (iniciado)
      {
        if (e.KeyCode == Keys.Enter)
        {
          if (e.Shift)
          {

          }
          else
          {
            int i_old = 0;
            while (lista[i_old].Descricao != txtProduto.Text)
            {
              i_old++;
            }

            int i = Convert.ToInt32(txtItem.Text);
            if (i <= totalItens)
            {
              txtItem.Text = lista[i-1].IdItem.ToString();

              if (!String.IsNullOrEmpty(lista[i-1].Ean))
                txtEAN.Text = lista[i-1].Ean.ToString();
              else
                txtEAN.Text = lista[i-1].Codigo.ToString();

              txtProduto.Text = lista[i-1].Descricao.ToString();
              txtPreco.Text = lista[i-1].Preco.ToString("0.00");
              btnVoltar.Enabled = true;
              txtPreco.Focus();
              txtPreco.SelectAll();

              if (totalItens == i)
              {
                btnAvancar.Enabled = false;
                btnAvancarTudo.Enabled = true;
                btnVoltarTudo.Enabled = true;
                btnVoltar.Enabled = true;
                btnConcluir.Visible = true;
              }
              else if (i == 1)
              {
                btnAvancar.Enabled = true;
                btnAvancarTudo.Enabled = true;
                btnVoltar.Enabled = false;
                btnVoltarTudo.Enabled = true;
                btnConcluir.Visible = false;
              }
              else
              {
                btnAvancar.Enabled = true;
                btnAvancarTudo.Enabled = true;
                btnVoltar.Enabled = true;
                btnVoltarTudo.Enabled = true;
                btnConcluir.Visible = false;
              }
            }
            else
            {
              MessageBox.Show("Item não consta na lista.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
              txtItem.Text = lista[i_old].IdItem.ToString();
              txtPreco.Focus();
              txtPreco.SelectAll();
            }
          }
        }       
      }
    }

    private void txtEAN_KeyDown(object sender, KeyEventArgs e)
    {
      if (iniciado)
      {
        if (e.KeyCode == Keys.Enter)
        {
          if (e.Shift)
          {

          }
          else
          {
            string ean = txtEAN.Text;
            bool encontrado = false;
            for (int i = 0; i < totalItens; i++)
            {
              if (lista[i].Ean == ean)
              {
                encontrado = true;
                txtItem.Text = lista[i].IdItem.ToString();
                txtProduto.Text = lista[i].Descricao;
                txtPreco.Text = lista[i].Preco.ToString("0.00");
                if (totalItens == lista[i].IdItem)
                {
                  btnAvancar.Enabled = false;
                  btnAvancarTudo.Enabled = true;
                  btnVoltarTudo.Enabled = true;
                  btnVoltar.Enabled = true;
                  btnConcluir.Visible = true;
                }
                else if (lista[i].IdItem == 1)
                {
                  btnAvancar.Enabled = true;
                  btnAvancarTudo.Enabled = true;
                  btnVoltar.Enabled = false;
                  btnVoltarTudo.Enabled = true;
                  btnConcluir.Visible = false;
                }
                else
                {
                  btnAvancar.Enabled = true;
                  btnAvancarTudo.Enabled = true;
                  btnVoltar.Enabled = true;
                  btnVoltarTudo.Enabled = true;
                  btnConcluir.Visible = false;
                }
                txtPreco.Focus();
                txtPreco.SelectAll();
              }
              else if (lista[i].Codigo == ean)
              {
                encontrado = true;
                txtItem.Text = lista[i].IdItem.ToString();
                txtProduto.Text = lista[i].Descricao;
                txtPreco.Text = lista[i].Preco.ToString("0.00");

                if (totalItens == lista[i].IdItem)
                {
                  btnAvancar.Enabled = false;
                  btnAvancarTudo.Enabled = true;
                  btnVoltarTudo.Enabled = true;
                  btnVoltar.Enabled = true;
                  btnConcluir.Visible = true;
                }
                else if (lista[i].IdItem == 1)
                {
                  btnAvancar.Enabled = true;
                  btnAvancarTudo.Enabled = true;
                  btnVoltar.Enabled = false;
                  btnVoltarTudo.Enabled = true;
                  btnConcluir.Visible = false;
                }
                else
                {
                  btnAvancar.Enabled = true;
                  btnAvancarTudo.Enabled = true;
                  btnVoltar.Enabled = true;
                  btnVoltarTudo.Enabled = true;
                  btnConcluir.Visible = false;
                }
                txtPreco.Focus();
                txtPreco.SelectAll();
              }
            }
            if (!encontrado)
            {
              MessageBox.Show("Nenhum item encontrado com este EAN.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
              int it = Convert.ToInt32(txtItem.Text);
              if (!String.IsNullOrEmpty(lista[it - 1].Ean))
                txtEAN.Text = lista[it - 1].Ean;
              else
                txtEAN.Text = lista[it - 1].Codigo;
              txtPreco.Focus();
              txtPreco.SelectAll();
            }
          }
        }
      }
    }

    private void FormPesquisa_Closing(object sender, CancelEventArgs e)
    {
      if (iniciado)
      {
        DialogResult res = MessageBox.Show("Deseja realmente cancelar a digitação?\nOs dados atuais serão perdidos.", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (res == DialogResult.No)
        {
          e.Cancel = (res == DialogResult.No);  
        }
        else
        {
          frmPri.Visible = true;
          this.Dispose();
        }
      }
      else
      {
        frmPri.Visible = true;
        this.Dispose();
      }
    }

    private void btnConcluir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Encerra Digitação do Concorrente?", "Pesquisa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {        
        Concorrente conc = new Concorrente();
        conc.Nome = cbxConcorrente.Text;
        conc.AbrirArquivo();
        for (int i = 0; i < totalItens; i++)
        {
          string preco = lista[i].Preco.ToString("0.00");
          preco = preco.Replace('.', ',');
          conc.Inserir_Itens_Arquivo(lista[i].Ean, lista[i].Codigo, preco);
        }
        conc.FecharArquivo();
        conc.CopiarArquivo();
        MessageBox.Show("Pesquisa Salva com sucesso!", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        frmPri.Visible = true;
        this.Dispose();
      }
    }

  }
}