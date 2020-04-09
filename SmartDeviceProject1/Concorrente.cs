using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SmartDeviceProject1
{
  class Concorrente
  {
    //Atributos
    //--------------------------------------------------------
    private int idConcorrente;
    private DateTime cheque;
    private string nome;
    private string pathFile = @"\Micromax\PesquisaCE\";
    private StreamWriter fileWrite;
    private StreamReader fileRead;

    //Propriedades
    //--------------------------------------------------------
    public int IdConcorrente
    {
      get { return idConcorrente; }
      set { idConcorrente = value; }
    }
    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }
    public string PathFile
    {
      get { return pathFile; }
      set { pathFile = value; }
    }
    public DateTime Cheque
    {
      get { return cheque; }
      set { cheque = value; }
    }

    //Construtor
    //--------------------------------------------------------
    public Concorrente()
    {

    }

    //Metodos
    //--------------------------------------------------------
    public void AbrirArquivo()
    {
      if (File.Exists(pathFile + nome + ".txt"))
        //File.Delete(@"\Micromax\MarkPrice\" + nome + ".txt");
        File.Delete(pathFile + nome + ".txt");
      //fileWrite = new StreamWriter(@"\Micromax\MarkPrice\" + nome + ".txt");
      fileWrite = new StreamWriter(pathFile + nome + ".txt");
    }

    public void Inserir_Itens_Arquivo(string ean, string codigo, string valor)
    {
      string conc = "";
      int idCon = 0;
      switch (nome)
      {
        case "SHIBATA":
          conc = "1SHI";
          idCon = 1;
          break;
        case "SILVA":
          conc = "2SIL";
          idCon = 3;
          break;
        case "SEMAR":
          conc = "3SEM";
          idCon = 4;
          break;
        case "PIRATININGA":
          conc = "4PIRATININGA";
          idCon = 2;
          break;
      }      
      fileWrite.WriteLine(idCon.ToString() + ";" + codigo + ";" + valor);
    }

    public void FecharArquivo()
    {
      fileWrite.Close();
    }

    public void CopiarArquivo()
    {
      File.Copy(pathFile + nome + ".txt", @"\My Documents\" + nome + ".txt", true);
    }

    public bool VerificaArquivoExistente()
    {
      bool existe = false;
      //if (File.Exists(@"\Micromax\MarkPrice\" + nome + ".txt"))
      if (File.Exists(pathFile + nome + ".txt"))
      {
        existe = true;
      }

      return existe;
    }
  }
}
