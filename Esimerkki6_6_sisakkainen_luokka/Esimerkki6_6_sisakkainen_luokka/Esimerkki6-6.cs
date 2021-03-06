using System;

//Seuraavass määritellään Firma-luokka.
public class Firma
{
    //Seuraavassa määritellään luokan kentät.
    string firmanNimi;
    int liikeVaihto;
    /*
     * Ulomman luokan kaikki staattiset jäsenet
     * (static members) näkyvät suoraan sisemmässä
     * luokassa huolimatta niiden saantimääreistä
     */
    static string ulkoinen = "Ulkoinen luokan instanssi!";

    //Seuraavassa määritellään johtaja-kenttä. Huomaa, 
    //että kentän tietotyyppi on Johtaja-luokka!
    Johtaja johtaja;

    //Seuraavassa määritellään luokan oletusmuodostin.
    public Firma()
    {
        firmanNimi = "Tuntematon";
        liikeVaihto = 0;

        //Tässä johtaja-olio alustetaan oletusmuodostimella.
        johtaja = new Johtaja();
    }

    //Seuraavassa määritellään muodostin kaikilla 
    //parametreilla.
    public Firma(string firmanNimi, int liikeVaihto, Johtaja
    johtaja)
    {
        this.firmanNimi = firmanNimi;
        this.liikeVaihto = liikeVaihto;

        //Tässä johtaja-kenttä alustetaan parametrina olevalla 
        //johtaja-oliolla.
        this.johtaja = johtaja;
    }

    //Seuraavassa määritellään TulostaTiedot()-metodi.
    public void FirmanTiedot()
    {
        Console.WriteLine("-------------\n");
        Console.WriteLine("Tässä ulommassa luokassa näkyy sisemmän luokan\n" +
            "public-staattiset jäsen: " + Johtaja.sisainen + "\n");
        Console.WriteLine("Firman nimi: {0}, liikevaihto: {1,0:c2} ", firmanNimi, liikeVaihto);

        //Seuraavassa kutsutaan kenttänä olevan johtja-olion 
        //JohtajanTiedot()-metodi, joka tulostaa johtajan 
        //tiedot. 
        johtaja.JohtajanTiedot();
    }

    //Seuraavassa määritellään Johtaja-luokka.
    public class Johtaja
    {
        //Seuraavassa määritellään luokan kentät.
        public string nimi;
        decimal palkka;

        /* vain tämä instance näkyy ulommassa luokassa
         * luokan nimen kautta: Johtaja.sisainen
         * jos ja vain jos se on public
         */
        public static string sisainen = "Sisäinen luokan instanssi!";

        //Seuraavassa määritellään luokan oletusmuodostin.
        public Johtaja()
        {
            nimi = "Tuntematon";
            palkka = 0.0m;
        }

        //Seuraavassa määritellään luokan muodostin kaikilla 
        //parametreilla.
        public Johtaja(string nimi, decimal palkka)
        {
            this.nimi = nimi;
            this.palkka = palkka;
        }

        //Seuraavassa määritellään luokan TulostaTiedot()-metodi.
        public void JohtajanTiedot()
        {
            Console.WriteLine("Johtaja: " + nimi + ", palkka: " + palkka + ".");
            Console.WriteLine("Tässä sisämmässä luokassa näkyy ulomman luokan\n" +
                "staattiset jäsen: " + ulkoinen + "\n");
        }
    } //Johtaja-luokan määrittely loppuu tähän.  
} //Firma-luokan määrittely loppuu tähän. 

class Esimerkki6_6
{
    static void Main(string[] args)
    {
        //Tässä määritellään jokuJohtaja-olio.
        Firma.Johtaja jokuJohtaja = new Firma.Johtaja("Johnny Logan", 100000.0m);

        //Tässä määritellään ekaFirma-olio.
        Firma ekaFirma = new Firma("Soft Intelligenece",
        10000000, jokuJohtaja);

        //Tässä kutsutaan ekaFirma-olion FirmanTiedot()-metodi.
        ekaFirma.FirmanTiedot();

        //Tässä määritellään tokaFirma-olio. Huomaa, kuinka 
        //lennossa luodaan uusi Johtaja-olio oletusmuodostimella 
        //seuraavalla lauseella: new Firma.Johtaja().

        Firma tokaFirma = new Firma("Easy Money", 500000, new
        Firma.Johtaja());

        //Tässä kutsutaan tokaFirma-olion FirmanTiedot()-metodi.
        tokaFirma.FirmanTiedot();

        //Tässä määritellään kolmasFirma-olio 
        //oletusmuodostimella.
        Firma kolmasFirma = new Firma();

        //Tässä kutsutaan kolmasFirma-olion FirmanTiedot()-
        //metodi.
        kolmasFirma.FirmanTiedot();
    }
}