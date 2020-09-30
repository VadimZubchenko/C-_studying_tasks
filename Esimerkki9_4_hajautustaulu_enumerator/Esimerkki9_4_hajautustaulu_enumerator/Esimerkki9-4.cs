  //Hashtable-luokan k�ytt�� varten otetaan 
  //k�ytt��n System.Collections-kirjasto.
  using System;
  using System.Collections;

  class Esimerkki9_4
  {
    static void Main(string[] args)
    {
      //T�ss� luodaan sanaKirja-hajautustaulu.
      Hashtable sanaKirja = new Hashtable();

      //Seuraavassa lis�t��n alkioita hajautustauluun.
      sanaKirja.Add("Hei", "Hello");
      sanaKirja.Add("Mit� kuuluu?", "How are you?");
      sanaKirja.Add("Kiitos", "Thank you");

      //T�ss� sanakirjan alkioiden lukum��r� tulostetaan 
      //n�yt�lle.
      Console.WriteLine("Alkioiden lukum��r� sanakirjassa alussa: " + sanaKirja.Count);

      Console.WriteLine("Sanat sanakirjassa: ");

      //Seuraavassa ensin saadaan lista hajautustaulun 
      //hakuavaimista ja sitten ne tulostetaan n�yt�lle.
      foreach (string hakuavain in sanaKirja.Keys)
        Console.Write("'" + hakuavain + "'  ");

      Console.WriteLine();

      Console.WriteLine("Sanojen merkitykset sanakirjassa: ");

      //Seuraavassa ensin saadaan lista hajautustaulun 
      //arvoista ja sitten ne tulostetaan n�yt�lle.
      foreach (string arvo in sanaKirja.Values)
        Console.Write("'" + arvo + "'  ");
        
       Console.WriteLine();
       
      //Seuraavassa metodilla ContainsKey() tarkistetaan 
      //l�ytyyk� "Kiitos" hakuavain sanakirjasta.
       bool sanaLoytynyt=sanaKirja.ContainsKey("Kiitos");
       
      Console.WriteLine("'Kiitos' l�ytyy sanakirjasta? " +
      sanaLoytynyt);
      
      //T�ss� luodaan sanat taulukko, jonka koko on
      //sama kuin sanakirjan alkioiden lukumm�r�.
      string[] sanat = new string[sanaKirja.Count];
      
      //T�ss� sanakirjan kaikki sanat (avaimet) kopioidaan
      //sanat taulukkoon niin, ett� kopiointi alkaa 0 
      //indeksist�.
      sanaKirja.Keys.CopyTo(sanat, 0);

      Console.WriteLine("sanat-taulukon sis�lt�:");

      //T�ss� sanat taulukon sis�lt� tulostetaan n�yt�lle.
      for (int i = 0; i < sanat.Length; i++)
        Console.Write("'" + sanat[i] + "'  ");
      
      Console.WriteLine();

      //T�ss� luodaan merkitykset taulukko, jonka koko on
      //sama kuin sanakirjan alkioiden lukumm�r�.
      string[] merkitykset = new string[sanaKirja.Count];

      //T�ss� sanakirjan kaikki merkitykset (arvot) 
      //kopioidaan merkitykset taulukkoon niin, ett� 
      //kopiointi alkaa 0 indeksist�.
      sanaKirja.Values.CopyTo(merkitykset, 0);

      Console.WriteLine("merkitykset-taulukon sis�lt�:");

      //T�ss� merkitykset taulukon sis�lt� tulostetaan 
      //n�yt�lle.
      for (int i = 0; i < sanat.Length; i++)
        Console.Write("'" + merkitykset[i] + "'  ");

      Console.WriteLine();

      Console.WriteLine("Sanakirjan sis�lt�: ");
      
      //Seuraavassa sanakirjan sis�lt� tulostetaan n�yt�lle
      //l�pik�yntifunktion (enumerator) avulla. Huomaa, ett� 
      //hajautustaulun kanssa k�ytet��n IDictionaryEnumerator
      //liittym��.
      IDictionaryEnumerator enumerator = 
      sanaKirja.GetEnumerator();

      while (enumerator.MoveNext())
        Console.WriteLine(enumerator.Key + "=" + 
        enumerator.Value);

      //T�ss� "Hei" sana poistetaan hajautustaulusta.
      sanaKirja.Remove("Hei");

      //T�ss� sanakirjan alkioiden lukum��r� tulostetaan 
      //n�yt�lle.
      Console.WriteLine("Alkioiden lukum��r� Remove()-metodin kutsun j�lkeen: " + sanaKirja.Count);
    }
  }