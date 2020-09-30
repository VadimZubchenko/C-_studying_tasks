  //Seuraavassa tiedostojenk‰sittelyyn liittyvien luokkien 
  //k‰ytt‰miseksi otetaan System.IO-kirjasto k‰yttˆˆn. 
  using System;
  using System.IO;

  class Esimerkki10_1
  {
    static void Main(string[] args)
    {
      //T‰ss‰ m‰‰ritell‰‰n tiedoston t‰ydellinen osoite. 
      //Huomaa, ett‰ koska \ on erikoismerkki, ennen sit‰
      //tulee laittaa toinen \, jotta k‰‰nt‰j‰ kohtelisi 
      //sit‰ tavalliseksi merkiksi.
      string tiedosto="C:\\Temp\\muistio.txt";

      //T‰ss‰ luodaan tiedosto jos sit‰ ei ole olemassa.
      if(!File.Exists(tiedosto))
        File.Create(tiedosto);
      
      //T‰ss‰ tarkistetaan onko tiedosto olemassa.
      Console.WriteLine("'" + tiedosto + "' on olemassa? " +
      File.Exists(tiedosto));

      //T‰ss‰ asetetaan tiedoston kaksi attribuuttia. Huomaa,
      //kuinka attribuutit erotetaan toisistaan.
      File.SetAttributes(tiedosto, FileAttributes.Hidden | 
      FileAttributes.ReadOnly);

      //T‰ss‰ tulsotetaan tiedoston attribuutit.
      Console.WriteLine("'" + tiedosto + "':n attribuutit: " 
      + File.GetAttributes(tiedosto));

      //T‰ss‰ tulostetaan tiedoston viimeinen hakuaika.
      Console.WriteLine("'" + tiedosto + "':n viimeisin hakuaika: " + File.GetLastAccessTime(tiedosto));
    }
  }
