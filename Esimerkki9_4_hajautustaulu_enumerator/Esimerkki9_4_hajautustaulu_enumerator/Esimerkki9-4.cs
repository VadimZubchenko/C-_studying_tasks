  //Hashtable-luokan käyttöä varten otetaan 
  //käyttöön System.Collections-kirjasto.
  using System;
  using System.Collections;

  class Esimerkki9_4
  {
    static void Main(string[] args)
    {
      //Tässä luodaan sanaKirja-hajautustaulu.
      Hashtable sanaKirja = new Hashtable();

      //Seuraavassa lisätään alkioita hajautustauluun.
      sanaKirja.Add("Hei", "Hello");
      sanaKirja.Add("Mitä kuuluu?", "How are you?");
      sanaKirja.Add("Kiitos", "Thank you");

      //Tässä sanakirjan alkioiden lukumäärä tulostetaan 
      //näytölle.
      Console.WriteLine("Alkioiden lukumäärä sanakirjassa alussa: " + sanaKirja.Count);

      Console.WriteLine("Sanat sanakirjassa: ");

      //Seuraavassa ensin saadaan lista hajautustaulun 
      //hakuavaimista ja sitten ne tulostetaan näytölle.
      foreach (string hakuavain in sanaKirja.Keys)
        Console.Write("'" + hakuavain + "'  ");

      Console.WriteLine();

      Console.WriteLine("Sanojen merkitykset sanakirjassa: ");

      //Seuraavassa ensin saadaan lista hajautustaulun 
      //arvoista ja sitten ne tulostetaan näytölle.
      foreach (string arvo in sanaKirja.Values)
        Console.Write("'" + arvo + "'  ");
        
       Console.WriteLine();
       
      //Seuraavassa metodilla ContainsKey() tarkistetaan 
      //löytyykö "Kiitos" hakuavain sanakirjasta.
       bool sanaLoytynyt=sanaKirja.ContainsKey("Kiitos");
       
      Console.WriteLine("'Kiitos' löytyy sanakirjasta? " +
      sanaLoytynyt);
      
      //Tässä luodaan sanat taulukko, jonka koko on
      //sama kuin sanakirjan alkioiden lukummärä.
      string[] sanat = new string[sanaKirja.Count];
      
      //Tässä sanakirjan kaikki sanat (avaimet) kopioidaan
      //sanat taulukkoon niin, että kopiointi alkaa 0 
      //indeksistä.
      sanaKirja.Keys.CopyTo(sanat, 0);

      Console.WriteLine("sanat-taulukon sisältö:");

      //Tässä sanat taulukon sisältö tulostetaan näytölle.
      for (int i = 0; i < sanat.Length; i++)
        Console.Write("'" + sanat[i] + "'  ");
      
      Console.WriteLine();

      //Tässä luodaan merkitykset taulukko, jonka koko on
      //sama kuin sanakirjan alkioiden lukummärä.
      string[] merkitykset = new string[sanaKirja.Count];

      //Tässä sanakirjan kaikki merkitykset (arvot) 
      //kopioidaan merkitykset taulukkoon niin, että 
      //kopiointi alkaa 0 indeksistä.
      sanaKirja.Values.CopyTo(merkitykset, 0);

      Console.WriteLine("merkitykset-taulukon sisältö:");

      //Tässä merkitykset taulukon sisältö tulostetaan 
      //näytölle.
      for (int i = 0; i < sanat.Length; i++)
        Console.Write("'" + merkitykset[i] + "'  ");

      Console.WriteLine();

      Console.WriteLine("Sanakirjan sisältö: ");
      
      //Seuraavassa sanakirjan sisältö tulostetaan näytölle
      //läpikäyntifunktion (enumerator) avulla. Huomaa, että 
      //hajautustaulun kanssa käytetään IDictionaryEnumerator
      //liittymää.
      IDictionaryEnumerator enumerator = 
      sanaKirja.GetEnumerator();

      while (enumerator.MoveNext())
        Console.WriteLine(enumerator.Key + "=" + 
        enumerator.Value);

      //Tässä "Hei" sana poistetaan hajautustaulusta.
      sanaKirja.Remove("Hei");

      //Tässä sanakirjan alkioiden lukumäärä tulostetaan 
      //näytölle.
      Console.WriteLine("Alkioiden lukumäärä Remove()-metodin kutsun jälkeen: " + sanaKirja.Count);
    }
  }