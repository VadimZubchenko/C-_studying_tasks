  using System;
  using System.Collections;

  //Tässä määritellään luokka Henkilo.
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
      //Tässä luodaan pino asiakkaat.
      Stack asiakkaat = new Stack();

      Henkilo h1 = new Henkilo("Akseli", "040-123456", 1000);
      Henkilo h2 = new Henkilo("Majia", "040-234567", 2000);
      Henkilo h3 = new Henkilo("Niklas", "040-345678", 3000);

      //Tässä pinoon lisätään päivämäärä.
      asiakkaat.Push(DateTime.Now);

      //Seuraavassa pinoon lisätään Henkilo-olioita.
      asiakkaat.Push(h1);
      asiakkaat.Push(h2);
      asiakkaat.Push(h3);
      
      //Tässä pinon alkioiden lukumäärä otetaan talteen. 
      //Huomaa, että joka kerta, kun kutsutaan metodi 
      //Pop(), pinon koko pienenee! 
      int pinonKoko = asiakkaat.Count;

      Console.WriteLine("Alkioiden lukumäärä: " + pinonKoko);

      //Seuraavassa pinon sisältö tulostetaan näytölle.
      IEnumerator enumerator = asiakkaat.GetEnumerator();

      while (enumerator.MoveNext())
        Console.WriteLine(enumerator.Current);

      //Tässä pinon kaikki alkiot kopioidaan 
      //pinonAlkiot taulukkoon.
      object[] pinonAlkiot = asiakkaat.ToArray();

      Console.WriteLine("Alkiot tulostettuna taulukon kautta: ");

      //Seuraavassa taulukkon pinonAlkiot sisältö 
      //tulostetaan näytölle.
      foreach (object obj in pinonAlkiot)
        Console.WriteLine(obj);

      Console.WriteLine("Päällimmäisin alkio tulostettuna Peek()-metodilla: ");
      
      Console.WriteLine(asiakkaat.Peek());

      Console.WriteLine("Alkiot tulostettuna Pop()-metodilla:");
      
      for (int i = 0; i < pinonKoko; i++)
        Console.WriteLine(asiakkaat.Pop());

      Console.WriteLine("Alkioiden lukumäärä: " + asiakkaat.Count);
    }
  }
