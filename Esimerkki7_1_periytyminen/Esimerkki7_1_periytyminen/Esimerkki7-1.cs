  using System;  
  
  //Seuraavassa määritellään Asiakas-luokka.
  class Asiakas
  {
    //Seuraavassa määritellään luokan kentät. Huomaa, että 
    //jäsenten saantimääreet eivät saa olla private jos ne 
    //halutaan perittäviksi! 
    protected string nimi;
    protected int id;
  
    //Seuraavassa määritellään oletusmuodostin.
    public Asiakas()
    {
      nimi = "Tuntematon";
      id = 0;
    }

    //Seuraavassa määritellään muodostin kaikilla 
    //parametreilla.
    public Asiakas(string nimi, int id)
    {
      this.nimi = nimi;
      this.id = id;
    }
    
    //Seuraavassa määritellään property-kenttä asiakkaan 
    //tietojen selvittämiseksi. Huomaa, että paluuarvoksi on    
    //asetettu string ja return-lauseen yhteydessä 
    //nimestä, välilyönnistä ja id:stä muodostetaan 
    //palautettava merkkijono.  
    public string AsiakkaanTiedot
    {
      get
      {
        return nimi + " " + id;
      }
    }
  }
  
  //Seuraavassa määritellään EtuAsiakas-luokka, joka perii 
  //Asiakas-luokkaa.
  class EtuAsiakas : Asiakas
  {
    //Seuraavassa määritellään ostot-kenttä EtuAsiakas-
    //luokalle. Huomaa, että periytymisen myötä luokkaan 
    //automaattisesti kopioituu yläluokan kaikki jäsenet, 
    //joiden saantimääreet eivät ole private!
    decimal ostot;
    
    //Seuraavassa määritellään EtuAsiakas-luokan 
    //oletusmuodostin. Yläluokasta periytyvien attribuuttien
    //alustamiseksi kutsutaan yläluokan vastaava muodostin 
    //base()-määreellä ja paikallinen muuttuja ostot 
    //alustetaan itse.
    public EtuAsiakas() : base()
    {
      //Tässä ostot-kentän oletusarvoksi laitetaan 0.
      ostot=0m;
    }
    
    //Seuraavassa määritellään EtuAsiakas-luokan muodostin 
    //kaikilla parametreilla. Luokkien yhteiset kentät 
    //alustetaan kätevästi kutsumalla yläluokan sopiva
    //muodostin base-määreellä ja paikallinen muuttuja ostot 
    //alustetaan itse.
    public EtuAsiakas(string nimi, int id, decimal ostot) : 
    base(nimi, id)
    {
      //Tässä alustetaan EtuAsiakas-luokan ostot-kenttä.
      this.ostot = ostot;
    }

    //Seuraavassa määritellään LaskeBonus()-metodi EtuAsiakas-
    //luokalle.
    public decimal LaskeBonus()
    {
      //Seuraavassa lasketaan bonuksen määrä ostojen 
      //perusteella.
      if (ostot >= 500 && ostot < 1000)
        return 0.03m * ostot;
      else if (ostot >= 1000 && ostot < 1500)
        return 0.04m * ostot;
      else if (ostot >= 1500)
        return 0.05m * ostot;
      else
        return 0.0m;
    }
  }

  class Esimerkki7_1
  {
    static void Main(string[] args)
    {
        //Tässä määritellään asiakas1-olio oletusmuodostimella.
        Asiakas asiakas1 = new Asiakas();

        //Tässä tulostetaan asiakas1-olion tiedot kutsumalla 
        //AsiakkaanTiedot-property.
        System.Console.WriteLine("Asiakkaan tiedot: " +
        asiakas1.AsiakkaanTiedot);

        //Tässä tulostetaan tyhjä rivi.
        System.Console.WriteLine();

        //Tässä määritellään asiakas2-olio parametrillisella 
        //muodostimella.
        Asiakas asiakas2 = new Asiakas("Dorothy", 100);

        //Tässä tulostetaan asiakas2-olion tiedot kutsumalla 
        //AsiakkaanTiedot-property.
        System.Console.WriteLine("Asiakkaan tiedot: " +
        asiakas2.AsiakkaanTiedot);

        //Tässä tulostetaan tyhjä rivi.
        System.Console.WriteLine();

        //Tässä määritellään etuasiakas1-olio
        //oletusmuodostimella.
        EtuAsiakas etuAsiakas1 = new EtuAsiakas();


        //Seuraavassa tulostetaan etuAsiakas1-olion tiedot 
        //kutsumalla AsiakkaanTiedot-property. Huomaa, kuinka 
        //AsiakkaanTiedot-property on kopioitunut EtuAsiakas-
        //luokalle.

        System.Console.WriteLine("Etuasiakkaan tiedot: " +
        etuAsiakas1.AsiakkaanTiedot);

        //Tässä tulostetaan etuAsiakas1-olion bonus kutsumalla 
        //LaskeBonus()-metodi.
        System.Console.WriteLine("Etuasiakkaan bonus on: {0, 0:c2}", etuAsiakas1.LaskeBonus());

        //Tässä tulostetaan tyhjä rivi.
        System.Console.WriteLine();

        //Tässä määritellään etuAsiakas2-olio parametrillisella 
        //muodostimella.
        EtuAsiakas etuAsiakas2 = new EtuAsiakas("Alfred", 200,
        1456.40m);

        //Tässä tulostetaan etuAsiakas2-olion tiedot kutsumalla 
        //AsiakkaanTiedot-property.
        System.Console.WriteLine("Etuasiakkaan tiedot: " +
        etuAsiakas2.AsiakkaanTiedot);

        //Tässä tulostetaan etuAsiakas2-olion bonus kutsumalla 
        //LaskeBonus()-metodi.
        System.Console.WriteLine("Etuasiakkaan bonus on: {0, 0:c2}", etuAsiakas2.LaskeBonus());

        EtuAsiakas etuAsiakasVadim = new EtuAsiakas("vadim", 23, 1600.00m);
        Console.WriteLine("Asiakkaan tiedot: " + etuAsiakasVadim.AsiakkaanTiedot);
        Console.WriteLine("Lasketaan bonus: {0,7:c2}", etuAsiakasVadim.LaskeBonus());
        Console.WriteLine("Lasketaan bonus: {0,10:c2}", etuAsiakasVadim.LaskeBonus());
        Console.WriteLine("Lasketaan bonus: {0,15:c2}", etuAsiakasVadim.LaskeBonus());
    }
  }
