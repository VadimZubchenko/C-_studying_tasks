  using System;
  
  //Seuraavassa määritellään Asiakas-luokka.
  class Asiakas
  {
    //Seuraavassa määritellään luokan kentät. 
    protected string nimi;
    protected int id;
    
    //Seuraavassa määritellään oletusmuodostin.
    public Asiakas()
    {
      nimi = "Tuntematon Asiakas";
      id = 0;
    }
    
    //Seuraavassa määritellään muodostin kaikilla 
    //attribuuteilla.
    public Asiakas(string nimi, int id)
    {
      this.nimi = nimi;
      this.id = id;
    }
   
    //Seuraavassa määritellään virtuaali LaskeBonus()-
    //metodi. 
    public virtual decimal LaskeBonus()
    {
      //Asiakas ei saa bonusta koska se ei ole etuasiakas!
      return 0.0m;
    }
    
    //Seuraavassa määritellään virtuaali TulostaTiedot()-
    //metodi.
    public virtual void TulostaTiedot()
    {
      Console.WriteLine("Asiakkaan tiedot: " + nimi + " " + id + ".");
    }
  }
  
  //Seuraavassa määritellään HopeaEtuAsiakas-luokka,
  //joka perii Asiakas-luokkaa.
  class HopeaEtuAsiakas : Asiakas
  {
    //Tässä määritellään ostot-kenttä. 
    decimal ostot;
    
    //Seuraavassa esitellään nimi-kenttä uudelleen vaikka 
    //samanniminen kenttä periytyy tähän luokkaan Asiakas-
    //luokasta.
    new string nimi;
    
    //Tässä määritellään oletusmuodostin. 
    public HopeaEtuAsiakas(): base()
    {
      //Seuraavassa luokan attribuutit alustetaan 
      //oletusarvoilla.
      ostot=0m;
      nimi="Tuntematon HopeaEtuAsiakas";
    }
    
    //Seuraavassa määritellään muodostin kaikilla 
    //attribuuteilla. 
    public HopeaEtuAsiakas(string nimi, int id, decimal ostot)
    : base(nimi, id)
    { 
      //Seuraavassa alustetaan nimi-kenttä. Huomaa, että  
      //base(nimi, id)-lause alustaa yliluokasta periytyvän 
      //nimi-kentän. Mutta koska nimi-kenttä on määritelty 
      //uudelleen tässä luokassa, se pitää erikseen alustaa! 
      //Ilman tätä alustusta HopeaEtuAsiakas-olioiden nimi-
      //kentän arvo olisi oletusarvo eli null!
      this.nimi = nimi;
      
      //Tässä luokan ostot-kenttä alustetaan ostot-
      //parametrilla.
      this.ostot = ostot;
    }
    
    //Seuraavassa ylikirjoitetaan TulostaTiedot()-metodi,
    //joka periytyy Asiakas-luokasta.
    public override void TulostaTiedot()
    {
      Console.WriteLine("HopeaEtuAsiakkaan tiedot: " + 
      nimi + " " + id + " Ostot={0,0:c2}.", ostot);
    }
    
    //Seuraavassa määritellään LaskeBonus()-metodi uudelleen 
    //siten, että sen paluuarvo on void. Huomaa, että 
    //tällaisessa tapauksessa metodia ei voida enää merkitä
    //override:lla. Tilanne voidaan korjata merkitsemällä 
    //metodia new:lla. Ilman new:ta kääntäjä varoittaa 
    //yliluokassa olevan LaskeBonus()-metodin peittämisestä!
    public new void LaskeBonus()
    {
      //Seuraavassa lasketaan bonuksen määrä, joka on 10 %
      //ostojen määrästä.
      decimal bonus = 0.1m * ostot;
      
      Console.WriteLine("Hopeaetuasiakkaan saama bonus on: {0,0:c2}.", bonus);
    }
  }
  
  class Esimerkki7_3
  {
    static void Main(string[] args)
    {
      //Tässä määritellään olio Asiakas-luokasta.
      Asiakas asiakas = new Asiakas("Emilia", 1000);
      
      //Tässä asiakkaan tiedot tulostetaan näytölle.
      asiakas.TulostaTiedot();
      
      //Tässä määritellään olio HopeaEtuAsiakas-luokasta.
      HopeaEtuAsiakas hopeaEtuAsiakas = new 
      HopeaEtuAsiakas("Julia", 2000, 5430.85m);
      
      hopeaEtuAsiakas.TulostaTiedot();
      
      //Tässä asiakkaan saama bonus lasketaan ja 
      //tulostetaan näytölle.
      hopeaEtuAsiakas.LaskeBonus();
    }
  }
