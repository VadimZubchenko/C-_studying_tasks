using System;

//Seuraavassa määritellään Johtaja-luokka.
class Johtaja
{
    //Seuraavassa määritellään luokan kentät.
    string nimi;
    decimal palkka;

    //Seuraavassa määritellään luokan oletusmuodostin.
    public Johtaja()
    {
        nimi = "Tuntematon";
        palkka = 0.0m;
    }

    //Seuraavassa määritellään luokan muodostin kaikilla 
    //attribuuteilla.
    public Johtaja(string nimi, decimal palkka)
    {
        this.nimi = nimi;
        this.palkka = palkka;
    }

    //Seuraavassa määritellään luokan JohtajanTiedot()-metodi.
    public void JohtajanTiedot()
    {
        Console.WriteLine("Johtaja: " + nimi + ", palkka: " + palkka + ".");
    }
}

//Seuraavass määritellään Firma-luokka.
class Firma
{
    //Seuraavassa määritellään luokan kentät.
    string nimi;
    int liikeVaihto;

    //Seuraavassa määritellään johtaja-kenttä. Huomaa, 
    //että kentän tietotyyppi on Johtaja-luokka!
    Johtaja johtaja;

    //Seuraavassa määritellään luokan oletusmuodostin.
    public Firma()
    {
        nimi = "Tuntematon";
        liikeVaihto = 0;

        //Tässä johtaja-olio alustetaan oletusmuodostimella.
        johtaja = new Johtaja();
    }

    //Seuraavassa määritellään muodostin kaikilla 
    //attribuuteilla.
    public Firma(string nimi, int liikeVaihto, Johtaja johtaja)
    {
        this.nimi = nimi;
        this.liikeVaihto = liikeVaihto;

        //Tässä johtaja-kenttä alustetaan parametrina olevalla 
        //johtaja-oliolla.
        this.johtaja = johtaja;
    }

    //Seuraavassa määritellään FirmanTiedot()-metodi.
    public void FirmanTiedot()
    {
        Console.WriteLine("-------------");
        Console.WriteLine("Firman nimi: {0}, liikevaihto: {1,0:c2} ", nimi, liikeVaihto);

        //Seuraavassa kutsutaan kenttänä olevan johtja-olion 
        //JohtajanTiedot()-metodi, joka tulostaa johtajan tiedot.
        johtaja.JohtajanTiedot();
    }
}

class Esimerkki6_5
{
    static void Main(string[] args)
    {
        //Tässä määritellään jokuJohtaja-olio.
        Johtaja jokuJohtaja = new Johtaja("Johnny Logan",
        100000.0m);

        //Tässä määritellään ekaFirma-olio.
        Firma ekaFirma = new Firma("Soft Intelligenece",
        10000000, jokuJohtaja);

        //Tässä kutsutaan ekaFirma-olion FirmanTiedot()-metodi.
        ekaFirma.FirmanTiedot();


        //Tässä määritellään tokaFirma-olio. Huomaa, kuinka 
        //lennossa luodaan uusi Johtaja-olio oletusmuodostimella 
        //seuraavalla lauseella: new Johtaja().

        Firma tokaFirma = new Firma("Easy Money", 500000, new
        Johtaja());

        //Tässä kutsutaan tokaFirma-olion FirmanTiedot()-metodi.
        tokaFirma.FirmanTiedot();
    }
}