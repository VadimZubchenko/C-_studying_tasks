//ArrayList-luokan k�ytt�� varten otetaan
//k�ytt��n System.Collections-kirjasto.
using System;
using System.Collections;

//Seuraavassa m��ritell��n luokka Henkilo, joka toteuttaa
//liittym�n IComparable. T�m� on pakollinen jos halutaan
//pysty� lajittelemaan ArrayList-kokoelman Henkilo-olioita.
class Henkilo : IComparable
{
    string nimi;
    int id;
    float palkka;

    public Henkilo(string nimi, int id, float palkka)
    {
        this.nimi = nimi;
        this.id = id;
        this.palkka = palkka;
    }

    public override string ToString()
    {
        return id + " " + nimi + " " + palkka;
    }

    //Seuraavassa toteutetaan IComparable-liittym�n metodi
    //CompareTo(), joka kutsutaan aina, kun oliot lajitellaan. 
    public int CompareTo(Object obj)
    {
        //T�ss� joudutaan muuntamaan obj-olio Henkilo-
        //tyyppiseksi. T�m� on mahdollista, koska obj on 
        //tyyppi� Object, joka on kaikkien luokkien kantaluokka.
        Henkilo tempHenkilo = (Henkilo)obj;

        if (this.palkka < tempHenkilo.palkka)
            return -1;
        else if (this.palkka > tempHenkilo.palkka)
            return 1;
        else
            return 0;
    }
}

class Esimerkki9_2
{
    static void Main(string[] args)
    {
        //T�ss� luodaan ArrayList-kokoelma henkilot. 
        ArrayList henkilot = new ArrayList();

        //seuraavassa m��ritell��n Henkilo-olioita.
        Henkilo h1 = new Henkilo("Pessi", 100, 4234.50f);
        Henkilo h2 = new Henkilo("AnnaLiisa", 200, 1234.60f);
        Henkilo h3 = new Henkilo("Illuusia", 300, 3234.70f);

        //Seuraavassa lis�t��n dataa ArrayList-kokoelmaan.
        henkilot.Add(h1);
        henkilot.Add(h2);
        henkilot.Add(h3);

        Console.WriteLine("Henkil�tiedot alussa:");

        //Seuraavassa ArrayList-kokoelman kaikki alkiot 
        //tulostetaan n�yt�lle k�ytt�m�ll� liittym��
        //IEnumerator.
        IEnumerator enumarator = henkilot.GetEnumerator();
        while (enumarator.MoveNext())
            Console.WriteLine(enumarator.Current);

        Console.WriteLine("-----------------");

        //Seuraavassa selvitet��n sis�lt��k� 
        //ArrayList-kokoelma henkilot oliota h2.
        Console.WriteLine("IndexOf() avulla selvitetaan index ");
        if (henkilot.Contains(h2))
        {
            //T�ss� selvitet��n h2-olion indeksi.
            int h2Indeksi = henkilot.IndexOf(h2);
            Console.WriteLine("h2-olion indeksi on " +
            h2Indeksi);
            Console.WriteLine("h2: " +
            henkilot[h2Indeksi]);
        }

        Console.WriteLine("-----------------");

        //T�ss� haetaan h3-olio metodin BinarySearch() avulla.
        Console.WriteLine("BinarySearch() avulla selvitetaan index ");
        int h3Indeksi = henkilot.BinarySearch(h3);
        Console.WriteLine("h3-olion indeksi on " +
        h3Indeksi);
        Console.WriteLine("h3: " +
        henkilot[h3Indeksi]);
        Console.WriteLine("-----------------");

        //T�ss� ArrayList-kokoelman sis�lt� lajitellaan 
        //palkan mukaan nousevaan j�rjestykseen.
        henkilot.Sort();

        Console.WriteLine("Henkil�tiedot nousevassa j�rjestyksess� palkan mukaan:");

        //T�ss� l�pik�yntifunktio enumerator 
        //alustetaan uudelleen.
        enumarator = henkilot.GetEnumerator();

        //Seuraavassa k�yd��n luettelo l�pi ja kaikki 
        //alkiot taas tulostetaan n�yt�lle. 
        while (enumarator.MoveNext())
            Console.WriteLine(enumarator.Current);

        Console.WriteLine("-----------------");

        //T�ss� ArrayList-kokoelman henkilot sis�lt� 
        //lajitellaan palkan mukaan laskevaan j�rjestykseen.
        henkilot.Reverse();

        Console.WriteLine("Henkil�tiedot laskevassa j�rjestyksess� palkan mukaan:");

        //T�ss� ArrayList-kokoelman henkilot kaikki alkiot 
        //taas tulostetaan n�yt�lle. Huomaa, ett� t�ss� 
        //taulukon sis�lt� k�yd��n indeksin avulla l�pi.
        for (int i = 0; i < henkilot.Count; i++)
            Console.WriteLine(henkilot[i]);

        Console.WriteLine("-----------------");

        //T�ss� poistetaan kokoelman henkilot kaikki alkiot.
        henkilot.Clear();

        Console.WriteLine("Henkil�iden lukum��r� Clear() metodin kutsun j�lkeen:");

        //T�ss� taas tulostetaan taulukon alkioiden lukum��r�.
        Console.WriteLine("henkilot.Count=" +
        henkilot.Count);
    }
}
