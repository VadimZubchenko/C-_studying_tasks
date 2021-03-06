  using System;

  //seuraavassa määritellään HenkiloTiedot-abstraktiluokka.
  abstract class HenkiloTiedot
  {
    //Seuraavassa määritellään luokan kentät. 
    protected string nimi;
    protected int id;
  
    //Seuraavassa määritellään oletusmuodostin.
    public HenkiloTiedot()
    {
      nimi = "Tuntematon";
      id = 0;
    }
  
    //Seuraavassa määritellään muodostin kaikilla 
    //attribuuteilla.
    public HenkiloTiedot(string nimi, int id)
    {
      this.nimi = nimi;
      this.id = id;
    }
    
    //Seuraavassa esitellään LaskeBonus()-abstraktimetodi.
    //Huomaa, että metodin esittely loppuu puolipisteeseen.
    public abstract decimal LaskeBonus();
    
  }
  
  //Seuraavassa määritellään Asiakas-luokka, joka perii 
  //HenkiloTiedot-luokkaa.
  class Asiakas : HenkiloTiedot
  {
    //Seuraavassa määritellään oletusmuodostin.
    public Asiakas(): base()
    {
    }
    
    //Seuraavassa määritellään muodostin kaikilla 
    //attribuuteilla.
    public Asiakas(string nimi, int id):base(nimi, id)
    {
    }
    
    //Seuraavassa LaskeBonus()-metodi ylikirjoitetaan ja sitä 
    //merkitään sinetöidyksi (sealed). Tämän jälkeen yritys
    //sen ylikirjoittamiseksi aiheuttaa virheen jo 
    //käännösvaiheessa.
    sealed public override decimal LaskeBonus()
    {
      //Tässä palautetaan 0.0.
      return 0.0m;
    }
  }
  
  //Seuraavassa määritellään HopeaEtuAsiakas-luokka, joka perii 
  //Asiakas-luokkaa.
  class HopeaEtuAsiakas : Asiakas
  {
    //Tässä määritellään HopeaEtuAsiakas-luokalle oma ostot-
    //kenttä. 
    decimal ostot;
    
    //Tässä määritellään oletusmuodostin. 
    public HopeaEtuAsiakas(): base()
    {
    }
    
    //Tässä määritellään muodostin kaikilla attribuuteilla. 
    public HopeaEtuAsiakas(string nimi, int id, decimal ostot)
    : base(nimi, id)
    {
      //Tässä alustetaan ostot-kenttä.
      this.ostot = ostot;
    }
    
    //Seuraavassa ylikirjoitetaan LaskeBonus()-metodi, joka 
    //periytyy Asiakas-luokasta. Huomaa, että metodin 
    //ylikirjoittaminen aliluokassa on pakollinen.
    public override decimal LaskeBonus()
    {
      return 0.1m * ostot;
    }
    
    //Seuraavassa määritellään HopeaEtuAsiakas-luokalle oma 
    //TulostaTiedot()-metodi.
    public void TulostaTiedot()
    {
      Console.WriteLine("HopeaEtuAsiakkaan tiedot: " + 
      nimi + " " + id + " Ostot={0,0:c2}", ostot);
    }
  }
  
  class Esimerkki7_5
  {
    static void Main(string[] args)
    {
      //Tässä määritellään hopeaEtuAsiakas-olio.
      HopeaEtuAsiakas hopeaEtuAsiakas = new 
      HopeaEtuAsiakas("Emanuel", 2000, 5430.85m);
  
      //Tässä tulostetaan hopeaEtuAsiakas-olion tiedot.
      hopeaEtuAsiakas.TulostaTiedot();
  
      //Tässä kutsutaan LaskeBonus()-metodi.
      Console.WriteLine("HopeaEtuAsiakkaan bonus on: {0,0:c2}", hopeaEtuAsiakas.LaskeBonus());
    }
  }