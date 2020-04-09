using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SmartDeviceProject1
{
  class Item
  {
    //Atributos
    //---------------------------------------------------------
    private string concorrente;
    private int idItem;
    private string ean;
    private string codigo;
    private string descricao;
    private decimal preco;
    private StreamReader sr;
    private StreamWriter sw;
    

    //Propriedades
    //---------------------------------------------------------
    public string Concorrente
    {
      get { return concorrente; }
      set { concorrente = value; }
    }
    public int IdItem
    {
      get { return idItem; }
      set { idItem = value; }
    }
    public string Ean
    {
      get { return ean; }
      set { ean = value; }
    }
    public string Codigo
    {
      get { return codigo; }
      set { codigo = value; }
    }
    public string Descricao
    {
      get { return descricao; }
      set { descricao = value; }
    }
    public decimal Preco
    {
      get { return preco; }
      set { preco = value; }
    }

    //Construtor
    //---------------------------------------------------------
    public Item()
    {
 
    }

    //Métodos
    //---------------------------------------------------------

  }
}
