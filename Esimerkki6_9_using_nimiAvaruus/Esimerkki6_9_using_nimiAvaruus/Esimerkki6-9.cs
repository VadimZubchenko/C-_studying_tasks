  //Seuraavien using-lauseiden avulla otetaan merkittyjen 
  //nimiavaruuksien sisällöt käyttöön.  
  using System;
  using Sovellus.Kayttoliittyma;
  using Sovellus.Tietokantayhteys;

  //Seuraavassa määritellään Sovellus-nimiavaruus.
  namespace Sovellus
  {
    //Seuraavassa määritellään Sovellus.Kayttoliittyma-
    //nimiavaruus.
    namespace Kayttoliittyma
    {
      //Seuraavassa määritellään 
      //Sovellus.Kayttoliittyma.Asiakas-luokka.
      class Asiakas
      {
        string nimi;
       
        public Asiakas(string nimi)
        {
          this.nimi = nimi;
        }
        
        //Seuraavassa määritellään TarkistaAsiakas()-metodi, 
        //jolla asiakkaan nimeä verrataan parametrina olevaan 
        //nimeen ja sen perusteella ilmoitetaan onko asiakkaan 
        //nimi oikein vai ei.  
        public void TarkistaAsiakas(string nimi)
        {
          //Tässä verrataan nimi-kentän ja nimi-parametrin 
          //arvoja sisäänrakennetulla Equals()-metodilla.
          if(this.nimi.Equals(nimi))
            Console.WriteLine(nimi + " on asiakkaan oikea nimi.");
          else
            Console.WriteLine(nimi + " ei ole asiakkaan oikea nimi!");
        }
      } //Sovellus.Kayttoliittyma.Asiakas-luokka loppuu tähän.
    } //Sovellus.Kayttoliittyma-nimiavaruus loppuu tähän.
  } //Sovellus-nimiavaruus loppuu tähän.
      
  //Tässä määritellään Sovellus.Tietokantayhteys-nimiavaruus.
  namespace Sovellus.Tietokantayhteys
  {
    //Tässä määritellään AvaaYhteys-luokka.
    class AvaaYhteys
    {
      public AvaaYhteys()
      {  
        Console.WriteLine("Tietokantayhteys on avattu!");
      }
    } // Sovellus.Tietokantayhteys.AvaaYhteys-luokka loppuu 
     //tähän.
  } //Sovellus.Tietokantayhteys-nimiavaruus loppuu tähän.

  class Esimerkki6_9
  {
    static void Main(string[] args)
    {
      //Seuraavassa luodaan asiakas-olio, joka on instanssi 
      //Sovellus.Kayttoliittyma.Asiakas-luokasta. Huomaa, 
      //että using-lauseiden takia ei tarvita nimiavaruuksiä 
      //merkitä enää! 
      Asiakas asiakas = new Asiakas("Sara");

      //Tässä kutsutaan TarkistaAsiakas()-metodi.
      asiakas.TarkistaAsiakas("Susan");

      //Tässä kutsutaan taas TarkistaAsiakas()-metodi 
      //uudella parametrin arvolla.
      asiakas.TarkistaAsiakas("Sara");

      //Seuraavassa luodaan yhteys-olio, joka on instanssi
      //Sovellus.Tietokantayhteys.AvaaYhteys()-luokasta.
      //Tässäkään using-lauseen takia ei tarvita 
      //nimiavaruuksiä merkitä enää!
      AvaaYhteys yhteys = new AvaaYhteys();
    }
  }
