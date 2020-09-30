  using System;
  using System.Collections;

  //T�ss� m��ritell��n luokka Henkilo.
  class Henkilo
  {
    string nimi, puhelinNumero;
    int id;

    public Henkilo(string nimi, string puhelinNumero, int id)
    {
     this.nimi = nimi;
     this.puhelinNumero = puhelinNumero;
     this.id = id;
    }

    public override string ToString()
    {
     return id + " " + nimi + " " + puhelinNumero;
    }
  }

  class Esimerkki9_8
  {
    static void Main(string[] args)
    {
      //T�ss� luodaan pino asiakkaat.
      Stack asiakkaat = new Stack();

      Henkilo h1 = new Henkilo("Akseli", "040-123456", 1000);
      Henkilo h2 = new Henkilo("Majia", "040-234567", 2000);
      Henkilo h3 = new Henkilo("Niklas", "040-345678", 3000);

      //T�ss� pinoon lis�t��n p�iv�m��r�.
      asiakkaat.Push(DateTime.Now);

      //Seuraavassa pinoon lis�t��n Henkilo-olioita.
      asiakkaat.Push(h1);
      asiakkaat.Push(h2);
      asiakkaat.Push(h3);
      
      //T�ss� pinon alkioiden lukum��r� otetaan talteen. 
      //Huomaa, ett� joka kerta, kun kutsutaan metodi 
      //Pop(), pinon koko pienenee! 
      int pinonKoko = asiakkaat.Count;

      Console.WriteLine("Alkioiden lukum��r�: " + pinonKoko);

      //Seuraavassa pinon sis�lt� tulostetaan n�yt�lle.
      IEnumerator enumerator = asiakkaat.GetEnumerator();

      while (enumerator.MoveNext())
        Console.WriteLine(enumerator.Current);

      //T�ss� pinon kaikki alkiot kopioidaan 
      //pinonAlkiot taulukkoon.
      object[] pinonAlkiot = asiakkaat.ToArray();

      Console.WriteLine("Alkiot tulostettuna taulukon kautta: ");

      //Seuraavassa taulukkon pinonAlkiot sis�lt� 
      //tulostetaan n�yt�lle.
      foreach (object obj in pinonAlkiot)
        Console.WriteLine(obj);

      Console.WriteLine("P��llimm�isin alkio tulostettuna Peek()-metodilla: ");
      
      Console.WriteLine(asiakkaat.Peek());

      Console.WriteLine("Alkiot tulostettuna Pop()-metodilla:");
      
      for (int i = 0; i < pinonKoko; i++)
        Console.WriteLine(asiakkaat.Pop());

      Console.WriteLine("Alkioiden lukum��r�: " + asiakkaat.Count);
    }
  }
