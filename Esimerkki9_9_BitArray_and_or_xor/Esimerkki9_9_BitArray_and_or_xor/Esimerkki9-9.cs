using System;
using System.Collections;

class Esimerkki9_9
{
    //Tässä määritellään metodi, jolla bittitaulukoiden
    //sisältö tulostetaan.
    static void TulostaTaulukko(string otsikko, BitArray
    bittiTaulukko)
    {
        Console.WriteLine(otsikko);

        //Seuraavassa bittitaulukon sisältö tulostetaan näytölle.
        for (int i = 0; i < bittiTaulukko.Length; i++)
            Console.Write(bittiTaulukko[i] + " ");

        Console.WriteLine("\n----------------");
    }

    static void Main(string[] args)
    {
        //Tässä luodaan bittitaulukko tulos1, jonka koko on 3.
        BitArray tulos1 = new BitArray(3);

        //Seuraavassa bittitaulukon tulos1 kaikki alkiot
        //asetetaan true:ksi.
        tulos1.SetAll(true);

        //Seuraavassa ensin määritellään muuttuja otsikko, 
        //jolla tulostukselle laitetaan viesti ja sitten 
        //kutsutaan staattinen metodi TulostaTaulukko(), 
        //jolla taulukon sisältö tulostetaan näytölle. 
        string otsikko = "Taulukon tulos1 sisältö:";

        TulostaTaulukko(otsikko, tulos1);

        //Tässä luodaan bittitaulukko tulos2, joka alustetaan
        //taulukon tulos1 negaatiolla. 
        BitArray tulos2 = new BitArray(3);

        //Seuraavassa tulos2 -bittitaulukko alustetaan.
        tulos2[0] = false;
        tulos2[1] = true;
        tulos2[2] = false;

        //Seuraavassa määritellän uusi otsikko ja tulos2-
        //bittitaulukon sisältö tulostetaan näytölle.
        otsikko = "Taulukon tulos2 sisältö:";

        TulostaTaulukko(otsikko, tulos2);

        //Tässä suoritetaan TAI-operaattori taulukoiden välillä.
        tulos1.Or(tulos2);

        //Seuraavassa määritellän uusi otsikko ja tulos1-
        //bittitaulukon uusi sisältö tulostetaan näytölle.
        otsikko = "Taulukon tulos1 sisältö tulos1.Or(tulos2)-operaation jälkeen:";

        TulostaTaulukko(otsikko, tulos1);

        //Tässä suoritetaan poissulkeva TAI-operaattori 
        //taulukoiden välillä.
        tulos1.Xor(tulos2);
        
        otsikko = "Taulukon tulos1 sisältö tulos1.Xor(tulos2)-operaation jölkeen:";

        TulostaTaulukko(otsikko, tulos1);

        //Tässä suoritetaan poissulkeva TAI-operaattori 
        //taulukoiden välillä.
        tulos1.And(tulos2);

        otsikko = "Taulukon tulos1 sisältö tulos1.And(tulos2)-opeaation jälkeen:";

        TulostaTaulukko(otsikko, tulos1);
        //Tässä suoritetaan negaatio (negation)-operaattor
        //in bittitaulukon alkioihin.
        tulos1.Not();
        otsikko = "Taulukon tulos1 sisältö tulos1.not()-opeaation jälkeen:";
        TulostaTaulukko(otsikko, tulos1);

    }
}