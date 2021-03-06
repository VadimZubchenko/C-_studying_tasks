using System;
using System.Collections.Generic;
using System.Text;

namespace Esimerkki5_1
{
    //Tässä määritellään Asunto-luokka.
    class Asunto
    {

        /* 
          * Seuraavassa määritellään attribuutit. Huomaa, että niiden 
          * saantimääreet ovat public. Tämä tarkoittaa sitä, että 
          * ne ovat myös näkyvissä niiden oman luokkansa (Asunto) ulkopuolella. 
         */
        public decimal pinta_ala;
        public int huone_maara;
        public decimal vuokra;
        public bool vapaa;


        //Tässä määritellään tulostaTiedot()-metodi, joka tulostaa asunnon tiedot näytölle.
        public void tulostaTiedot()
        {
            System.Console.WriteLine("\tAsunnon tiedot");
            System.Console.WriteLine("\t--------------");
            System.Console.WriteLine("\tPinta-ala={0, 0:f2}", pinta_ala);
            System.Console.WriteLine("\tHuoneiden lukumäärä=" + huone_maara);
            System.Console.WriteLine("\tVuokra={0, 0:c2}", vuokra);
            System.Console.WriteLine("\tAsunto on vapaa? " + vapaa);
        }


        /*
         * Seuraavassa määritellään naytaTila()-metodi, joka tarkistaa
         * vapaa-attribuutin arvoa ja sen perusteella tulostaa eri viestejä
         * näytölle. Huomaa, sarkain (\t) tulostuksessa.
         */

        public void naytaTila()
        {
            //bool vapaa = true;
            if (vapaa)

                System.Console.WriteLine("\tAsunto on vapaa.");
            else
                System.Console.WriteLine("\tAsunto on varattu.");

        }
        /*
         * Seuraavassa määritellään VaraaAsunto()-metodi, joka
         * ensin tarkistaa attribuutin vapaa arvon ja jos se on
         * tosi (true), se muutetaan false:ksi. Jos asunto on
         * varattu, metodi tulostaa siitä viestin.
         */

        public void varaaAsunto()

        {

            if (vapaa)

            {

                vapaa = false;

                Console.WriteLine("\tAsunto on varattu.\n");

            }

            else

            {

                Console.WriteLine("\tAsuntoa ei pysty varaamaan!\n");

            }
        }

    }



    //Tämä on pääohjelman luokka, johon kuuluu Main()-metodi, josta ohjelma aloitetaan.
    class Esimerkki5_1
    {
        static void Main(string[] args)
        {

            //Tässä ilmoitetaan, että aiotaan luoda asunto-niminen olio Asunto-luokasta
            Asunto asunto;

            //Tässä varataan tietokoneen muistista tila asunto-oliolle 
            //ja se luodaan lopullisesti.  
            asunto = new Asunto();

            //Tässä olion attribuutit alustetaan.
            asunto.pinta_ala = 62.45m;
            asunto.huone_maara = 3;
            asunto.vuokra = 643.00m;
            asunto.vapaa = true;


            //Tässä kutsutaan asunto-olion tulostaTiedot()-metodi, joka tulostaa sen tiedot.
            asunto.tulostaTiedot();


            /*
             * Tässä kutsutaan asunto-olion naytaTila()-metodi, joka ilmoittaa,
             * onko asunto vapaa vai varattu.
             */
            asunto.naytaTila();

            /*
             * Tässä kutsutaan asunto-olion varaaAsunto()-metodi, jolla varataan asunto
             * ja tarkistetaan nyt sen tila uudestaan
             */
            asunto.varaaAsunto();
            asunto.tulostaTiedot();

            // tämä vaati käyttäjältä Enter painalusta, että lopetta.
            System.Console.Read();

        }
    }
}
