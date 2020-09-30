  using System;
  using System.Collections;
  
  //Seuraavassa määritellään luokka TeleAlue.
  class TeleAlue
  {
    string nimi; 
    int asukasLKM;
    
    public TeleAlue(string nimi, int asukasLKM)
    {
     this.nimi = nimi;
     this.asukasLKM = asukasLKM;
    } 

    public override string ToString()
    {
     return nimi + ", " + asukasLKM;
    }
  }
  
  class Esimerkki9_6
  {
    static void Main(string[] args)
    {
     //Tässä luodaan lajiteltu lista suuntaNumerot.
     SortedList suuntaNumerot = new SortedList();

     //Seuraavassa lisätään alkioita lajiteltuun listaan. 
     //Huomaa, että arvot ovat luokan TeleAlue olioita.
     suuntaNumerot.Add("06", new TeleAlue("Vaasan telealue", 
     50000));
     suuntaNumerot.Add("08", new TeleAlue("Oulun telealue", 
     30000));
     suuntaNumerot.Add("03", new TeleAlue("Hämeen telealue", 
     500000));

     //Tässä listan alkioiden lukumäärä tulostetaan näytölle.
     Console.WriteLine("Alkioiden lukumäärä listassa: " + 
     suuntaNumerot.Count);

     //Seuraavassa listan alkiot tulostetaan näytölle. 
     IDictionaryEnumerator dictEnumerator = 
     suuntaNumerot.GetEnumerator();
     
     while (dictEnumerator.MoveNext())
      Console.WriteLine(dictEnumerator.Key + "-->" + 
      dictEnumerator.Value);

     //Seuraavassa metodilla ContainsKey() tarkistetaan 
     //löytyykö hakuavain "06" listassa.
     bool loytynyt = suuntaNumerot.ContainsKey("06");
     Console.WriteLine("06 suuntanumero löytyy listasta? " 
     + loytynyt);

     //Tässä selvitetään avaimen "08" indeksi ja se 
     //tulostetaan näytölle.
     Console.WriteLine("08 suuntanumeron indeksi listassa: " 
     + suuntaNumerot.IndexOfKey("08"));
     
     //Tässä selvitetään avaimen "02" indeksi ja se 
     //tulostetaan näytölle. Huomaa, että jos 
     //hakuavainta ei löydy, metodi palauttaa -1.
     Console.WriteLine("02 suuntanumeron indeksi listassa: " 
     + suuntaNumerot.IndexOfKey("02"));

     Console.WriteLine("Telealueiden nimet listassa: ");
     //Seuraavassa ensin suuntaNumerot listan arvot 
     //kopioidaan ICollection olioon, josta sitten 
     //alkiot luetaan IEnumerator oliolla ja tulostetaan
     //näytölle.

     //Tässä saadaan kokoelma listan arvoista (values).
     ICollection teleAlueet = suuntaNumerot.Values;

     //Tässä luodaan IEnumerator olio GetEnumerator() 
     //metodilla. 
     IEnumerator enumerator = teleAlueet.GetEnumerator();

     //Tässä luettelon alkiot tulostetaan näytölle.
     while (enumerator.MoveNext())
      Console.Write("'" + enumerator.Current.ToString() +
      "' ");

     Console.WriteLine();

     //Tässä listan 0 indeksin arvo muokataan. Huomaa, 
     //kuinka 0 indeksissä olevan arvoksi luodaan uusi 
     //TeleAlue luokka.
     suuntaNumerot.SetByIndex(0, new TeleAlue("Uusi Hämeen telealue",45000));
     
     Console.WriteLine("Lista 0 indeksin alkio muutoksen jälkeen:");
     //Tässä listan 0 indeksin alko tulostetaan näytölle.
     Console.WriteLine(suuntaNumerot.GetKey(0) + "-->" + 
     suuntaNumerot.GetByIndex(0));

     //Tässä '06' suuntanumero poistetaan listasta.
     suuntaNumerot.Remove("06");

     //Tässä luodaan lista kokoelman avaimista.
     IList hakuAvainLista = suuntaNumerot.GetKeyList();

     //Tässä luodaan lista kokoelman arvoista.
     IList arvoLista = suuntaNumerot.GetValueList();

     Console.WriteLine("Listan sisältö 06 suuntanumeron poiston jälkeen:");

     //Tässä avinListan ja arvoListan sisällöt 
     //tulostetaan näytölle.
     for (int i = 0; i < hakuAvainLista.Count; i++)
      Console.WriteLine(hakuAvainLista[i] + " " + 
      arvoLista[i]);
    }
  } 
