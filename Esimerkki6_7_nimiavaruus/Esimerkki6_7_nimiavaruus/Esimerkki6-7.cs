
using System;

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

            //Seuraavassa määritellään Asiakas -luokan muuodostin.
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
                if (this.nimi.Equals(nimi))
                    Console.WriteLine(nimi + " on asiakkaan oikea nimi.");
                else
                    Console.WriteLine(nimi + " ei ole asiakkaan oikea nimi!");
            }
        } // Sovellus.Kayttoliittyma.Asiakas-luokka loppuu tähän.
    } // Sovellus.Kayttoliittyma-nimiavaruus loppuu tähän.
} //Sovellus-nimiavaruus loppuu tähän.

//Seuraavassa määritellään Sovellus.Tietokantayhteys-
//nimiavaruus.
namespace Sovellus.Tietokantayhteys
{
    //Seuraavassa määritellään 
    //Sovellus.Tietokantayhteys.AvaaYhteys-
    //luokka.
    class AvaaYhteys
    {
        public AvaaYhteys()
        {
            Console.WriteLine("Tietokantayhteys on avattu!");
        }
    } // Sovellus.Tietokantayhteys.AvaaYhteys-luokka loppuu 
      //tähän.
} //Sovellus.Tietokantayhteys-nimiavaruus loppuu tähän.

class Esimerkki6_7
{
    /* Main()-metodissa luokat instantioidaan, eli tehdään loukasta oliot.
    *  Kutsutaan metodit.
    */
    static void Main(string[] args)
    {
        //Tässä luodaan asiakas-olio, joka on instanssi  
        //Sovellus.Kayttoliittyma.Asiakas-luokasta. Huomaa, 
        //että luokan nimi joudutaan merkitsemään 
        //nimiavaruuksien kautta. 

        Sovellus.Kayttoliittyma.Asiakas asiakas = new
        Sovellus.Kayttoliittyma.Asiakas("Sara");

        Console.WriteLine("\nSovellus.Kayttoliittyma.Asiakas.TarkistaAsiakas()-metodin tuloste:");

        //Tässä kutsutaan TarkistaAsiakas()-metodi.
        asiakas.TarkistaAsiakas("Susan");

        Console.WriteLine("\nSovellus.Kayttoliittyma.Asiakas.TarkistaAsiakas()-metodin tuloste:");

        //Tässä kutsutaan taas TarkistaAsiakas()-metodi 
        //uudella parametrin arvolla.
        asiakas.TarkistaAsiakas("Sara");

        Console.WriteLine("\nSovellus.Tietokantayhteys.AvaaYhteys-muodostimen tuloste:");

        //Tässä luodaan yhteys-olio, joka on instanssi 
        //Sovellus.Tietokantayhteys.AvaaYhteys-luokasta.
        Sovellus.Tietokantayhteys.AvaaYhteys yhteys = new
        Sovellus.Tietokantayhteys.AvaaYhteys();
    }
}
