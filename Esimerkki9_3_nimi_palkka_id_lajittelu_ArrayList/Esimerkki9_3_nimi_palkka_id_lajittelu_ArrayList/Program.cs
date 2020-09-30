//ArrayList-luokan käyttöä varten otetaan 
//käyttöön System.Collections-kirjasto.
using System;
using System.Collections;

//Tässä määritellään luokka Henkilo, joka toteuttaa
//liittymän IComparable. Tämä on pakollinen jos halutaan
//pystyä lajittelemaan ArrayList-kokoelman Henkilo-olioita.
class Henkilo : IComparable
{
    string nimi;
    int id;
    float palkka;

    //Tässä määritellään luokalle attribuutti 
    //lajitteluKriteeti.
    public static string lajitteluKriteeti = "nimi";

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

    //Täsä määritellään staattinen metodi, joka saa 
    //argumenttina ArrayList-kokoelman ja tulostaa sen 
    //sisällön näytölle.
    public static void TulostaHenkilot(ArrayList henkilot)
    {
        //Seuraavassa ArrayList-kokoelman kaikki alkiot 
        //tulostetaan näytölle liittymän IEnumerator avulla.
        IEnumerator enumarator = henkilot.GetEnumerator();

        while (enumarator.MoveNext())
            Console.WriteLine(enumarator.Current);

        Console.WriteLine("-----------------");
    }

    public int VertaileID(Object obj)
    {
        //Tässä joudutaan muuntamaan obj-olio Henkilo-
        //tyyppiseksi. Tämä on mahdollista, koska obj on 
        //tyyppiä Object, joka on kaikkien luokkien kantaluokka.
        Henkilo tempHenkilo = (Henkilo)obj;

        if (this.id < tempHenkilo.id)
            return -1;
        else if (this.id > tempHenkilo.id)
            return 1;
        else
            return 0;
    }

    public int VertaileNimi(Object obj)
    {
        //Tässä joudutaan muuntamaan obj-olio Henkilo-
        //tyyppiseksi.
        Henkilo tempHenkilo = (Henkilo)obj;

        //Seuraavassa nimi-attribuutteja verrataan 
        //keskenään metodin CompareTo() avulla.
        if (this.nimi.CompareTo(tempHenkilo.nimi) < 1)
            return -1;
        else if (this.nimi.CompareTo(tempHenkilo.nimi) > 1)
            return 1;
        else
            return 0;
    }
    private int VertailePalkka(object obj)
    {
        //Tässä joudutaan muuntamaan obj-olio Henkilo-
        //tyyppiseksi. Tämä on mahdollista, koska obj on 
        //tyyppiä Object, joka on kaikkien luokkien kantaluokka.
        Henkilo tempHenkilo = (Henkilo)obj;

        if (this.palkka < tempHenkilo.palkka)
            return -1;
        else if (this.palkka > tempHenkilo.palkka)
            return 1;
        else
            return 0;
    }

    //Seuraavassa toteutetaan liittymän IComparable 
    //metodi CompareTo(), joka kutsutaan, kun oliot lajitellaan. 
    public int CompareTo(Object obj)
    {
        int vertailuTulos = 0;

        if (lajitteluKriteeti.Equals("nimi"))
            vertailuTulos = VertaileNimi(obj);
        else if (lajitteluKriteeti.Equals("palkka"))
            vertailuTulos = VertailePalkka(obj);
        else
            vertailuTulos = VertaileID(obj);

        return vertailuTulos;
    }


}

class Esimerkki9_3
{
    static void Main(string[] args)
    {
        //Tässä luodaan henkilot ArrayList
        ArrayList henkilot = new ArrayList();

        //seuraavassa määritellään Henkilo olioita.
        Henkilo h1 = new Henkilo("Eesus", 100, 4234.50f);
        Henkilo h2 = new Henkilo("DonnaLiisa", 300, 1234.60f);
        Henkilo h3 = new Henkilo("Alluusia", 200, 5234.70f);
        Henkilo h4 = new Henkilo("Buusia", 500, 2234.70f);
        Henkilo h5 = new Henkilo("Cesna", 200, 3234.70f);
        //Seuraavassa lisätään dataa ArrayList-kokoelmaan
        henkilot.Add(h1);
        henkilot.Add(h2);
        henkilot.Add(h3);
        henkilot.Add(h4);
        henkilot.Add(h5);

        Console.WriteLine("Henkilötiedot alussa:");

        //Tässä kutsutaan TulostaHenkilot staattinen metodi, 
        //joka saa argumenttina ArrayList-kokoelman.
        Henkilo.TulostaHenkilot(henkilot);

        //Tässä lajitteluKriteeti attribuutin arvoksi laitetaan
        //"nimi", eli Henkilo oliot lajitellaan niiden nimi 
        //attribuutin perusteella.
        Henkilo.lajitteluKriteeti = "nimi";

        //Tässä ArrayList-kokoelman sisältö lajitellaan 
        //nimen mukaan nousevaan järjestykseen.
        henkilot.Sort();

        Console.WriteLine("Henkilötiedot järjestyksessä "
        + Henkilo.lajitteluKriteeti + "-attribuutin mukaan:");

        //Tässä tulostetaan ArrayList-kokoelman henkilot sisältö.
        Henkilo.TulostaHenkilot(henkilot);

        //Tässä lajitteluKriteeti attribuutin arvoksi 
        //laitetaan "id", eli Henkilo oliot lajitellaan niiden
        //id-attribuutin perusteella.
        Henkilo.lajitteluKriteeti = "id";

        //Tässä ArrayList-kokoelman sisältö lajitellaan id 
        //mukaan nousevaan järjestykseen.
        henkilot.Sort();

        Console.WriteLine("Henkilötiedot järjestyksessä "
        + Henkilo.lajitteluKriteeti + "-attribuutin mukaan:");

        //Tässä taas tulostetaan henkilot-ArrayList tauluko
        //sisältö.
        Henkilo.TulostaHenkilot(henkilot);
        //Tässä lajitteluKriteeti attribuutin arvoksi 
        //laitetaan "id", eli Henkilo oliot lajitellaan niiden
        //id-attribuutin perusteella.
        Henkilo.lajitteluKriteeti = "palkka";

        //Tässä ArrayList-kokoelman sisältö lajitellaan 
        //palkan mukaan nousevaan järjestykseen.
        henkilot.Sort();

        Console.WriteLine("Henkilötiedot järjestyksessä "
        + Henkilo.lajitteluKriteeti + "-attribuutin mukaan:");

        //Tässä taas tulostetaan henkilot-ArrayList tauluko
        //sisältö.
        Henkilo.TulostaHenkilot(henkilot);
    }
}
