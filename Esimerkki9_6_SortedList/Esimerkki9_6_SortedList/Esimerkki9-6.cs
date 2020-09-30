  using System;
  using System.Collections;
  
  //Seuraavassa m��ritell��n luokka TeleAlue.
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
     //T�ss� luodaan lajiteltu lista suuntaNumerot.
     SortedList suuntaNumerot = new SortedList();

     //Seuraavassa lis�t��n alkioita lajiteltuun listaan. 
     //Huomaa, ett� arvot ovat luokan TeleAlue olioita.
     suuntaNumerot.Add("06", new TeleAlue("Vaasan telealue", 
     50000));
     suuntaNumerot.Add("08", new TeleAlue("Oulun telealue", 
     30000));
     suuntaNumerot.Add("03", new TeleAlue("H�meen telealue", 
     500000));

     //T�ss� listan alkioiden lukum��r� tulostetaan n�yt�lle.
     Console.WriteLine("Alkioiden lukum��r� listassa: " + 
     suuntaNumerot.Count);

     //Seuraavassa listan alkiot tulostetaan n�yt�lle. 
     IDictionaryEnumerator dictEnumerator = 
     suuntaNumerot.GetEnumerator();
     
     while (dictEnumerator.MoveNext())
      Console.WriteLine(dictEnumerator.Key + "-->" + 
      dictEnumerator.Value);

     //Seuraavassa metodilla ContainsKey() tarkistetaan 
     //l�ytyyk� hakuavain "06" listassa.
     bool loytynyt = suuntaNumerot.ContainsKey("06");
     Console.WriteLine("06 suuntanumero l�ytyy listasta? " 
     + loytynyt);

     //T�ss� selvitet��n avaimen "08" indeksi ja se 
     //tulostetaan n�yt�lle.
     Console.WriteLine("08 suuntanumeron indeksi listassa: " 
     + suuntaNumerot.IndexOfKey("08"));
     
     //T�ss� selvitet��n avaimen "02" indeksi ja se 
     //tulostetaan n�yt�lle. Huomaa, ett� jos 
     //hakuavainta ei l�ydy, metodi palauttaa -1.
     Console.WriteLine("02 suuntanumeron indeksi listassa: " 
     + suuntaNumerot.IndexOfKey("02"));

     Console.WriteLine("Telealueiden nimet listassa: ");
     //Seuraavassa ensin suuntaNumerot listan arvot 
     //kopioidaan ICollection olioon, josta sitten 
     //alkiot luetaan IEnumerator oliolla ja tulostetaan
     //n�yt�lle.

     //T�ss� saadaan kokoelma listan arvoista (values).
     ICollection teleAlueet = suuntaNumerot.Values;

     //T�ss� luodaan IEnumerator olio GetEnumerator() 
     //metodilla. 
     IEnumerator enumerator = teleAlueet.GetEnumerator();

     //T�ss� luettelon alkiot tulostetaan n�yt�lle.
     while (enumerator.MoveNext())
      Console.Write("'" + enumerator.Current.ToString() +
      "' ");

     Console.WriteLine();

     //T�ss� listan 0 indeksin arvo muokataan. Huomaa, 
     //kuinka 0 indeksiss� olevan arvoksi luodaan uusi 
     //TeleAlue luokka.
     suuntaNumerot.SetByIndex(0, new TeleAlue("Uusi H�meen telealue",45000));
     
     Console.WriteLine("Lista 0 indeksin alkio muutoksen j�lkeen:");
     //T�ss� listan 0 indeksin alko tulostetaan n�yt�lle.
     Console.WriteLine(suuntaNumerot.GetKey(0) + "-->" + 
     suuntaNumerot.GetByIndex(0));

     //T�ss� '06' suuntanumero poistetaan listasta.
     suuntaNumerot.Remove("06");

     //T�ss� luodaan lista kokoelman avaimista.
     IList hakuAvainLista = suuntaNumerot.GetKeyList();

     //T�ss� luodaan lista kokoelman arvoista.
     IList arvoLista = suuntaNumerot.GetValueList();

     Console.WriteLine("Listan sis�lt� 06 suuntanumeron poiston j�lkeen:");

     //T�ss� avinListan ja arvoListan sis�ll�t 
     //tulostetaan n�yt�lle.
     for (int i = 0; i < hakuAvainLista.Count; i++)
      Console.WriteLine(hakuAvainLista[i] + " " + 
      arvoLista[i]);
    }
  } 
