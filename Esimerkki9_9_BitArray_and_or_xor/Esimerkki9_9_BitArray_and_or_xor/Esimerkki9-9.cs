using System;
using System.Collections;

class Esimerkki9_9
{
    //T�ss� m��ritell��n metodi, jolla bittitaulukoiden
    //sis�lt� tulostetaan.
    static void TulostaTaulukko(string otsikko, BitArray
    bittiTaulukko)
    {
        Console.WriteLine(otsikko);

        //Seuraavassa bittitaulukon sis�lt� tulostetaan n�yt�lle.
        for (int i = 0; i < bittiTaulukko.Length; i++)
            Console.Write(bittiTaulukko[i] + " ");

        Console.WriteLine("\n----------------");
    }

    static void Main(string[] args)
    {
        //T�ss� luodaan bittitaulukko tulos1, jonka koko on 3.
        BitArray tulos1 = new BitArray(3);

        //Seuraavassa bittitaulukon tulos1 kaikki alkiot
        //asetetaan true:ksi.
        tulos1.SetAll(true);

        //Seuraavassa ensin m��ritell��n muuttuja otsikko, 
        //jolla tulostukselle laitetaan viesti ja sitten 
        //kutsutaan staattinen metodi TulostaTaulukko(), 
        //jolla taulukon sis�lt� tulostetaan n�yt�lle. 
        string otsikko = "Taulukon tulos1 sis�lt�:";

        TulostaTaulukko(otsikko, tulos1);

        //T�ss� luodaan bittitaulukko tulos2, joka alustetaan
        //taulukon tulos1 negaatiolla. 
        BitArray tulos2 = new BitArray(3);

        //Seuraavassa tulos2 -bittitaulukko alustetaan.
        tulos2[0] = false;
        tulos2[1] = true;
        tulos2[2] = false;

        //Seuraavassa m��ritell�n uusi otsikko ja tulos2-
        //bittitaulukon sis�lt� tulostetaan n�yt�lle.
        otsikko = "Taulukon tulos2 sis�lt�:";

        TulostaTaulukko(otsikko, tulos2);

        //T�ss� suoritetaan TAI-operaattori taulukoiden v�lill�.
        tulos1.Or(tulos2);

        //Seuraavassa m��ritell�n uusi otsikko ja tulos1-
        //bittitaulukon uusi sis�lt� tulostetaan n�yt�lle.
        otsikko = "Taulukon tulos1 sis�lt� tulos1.Or(tulos2)-operaation j�lkeen:";

        TulostaTaulukko(otsikko, tulos1);

        //T�ss� suoritetaan poissulkeva TAI-operaattori 
        //taulukoiden v�lill�.
        tulos1.Xor(tulos2);
        
        otsikko = "Taulukon tulos1 sis�lt� tulos1.Xor(tulos2)-operaation j�lkeen:";

        TulostaTaulukko(otsikko, tulos1);

        //T�ss� suoritetaan poissulkeva TAI-operaattori 
        //taulukoiden v�lill�.
        tulos1.And(tulos2);

        otsikko = "Taulukon tulos1 sis�lt� tulos1.And(tulos2)-opeaation j�lkeen:";

        TulostaTaulukko(otsikko, tulos1);
        //T�ss� suoritetaan negaatio (negation)-operaattor
        //in bittitaulukon alkioihin.
        tulos1.Not();
        otsikko = "Taulukon tulos1 sis�lt� tulos1.not()-opeaation j�lkeen:";
        TulostaTaulukko(otsikko, tulos1);

    }
}