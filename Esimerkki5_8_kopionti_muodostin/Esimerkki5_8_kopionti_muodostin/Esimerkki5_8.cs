using System;

class Asiaks
{
    //Seuraavassa määritellään Asiakas-luokan attribuutit.
    string nimi;
    bool etuAsiakas;
    int tilausNumero;

    //Seuraavassa määritellään muodostin luokan kaikilla 
    //attribuuteilla. 
    public Asiaks(string nimi, bool etuAsiakas, int
    tilausNumero)
    {
        this.nimi = nimi;
        this.etuAsiakas = etuAsiakas;
        this.tilausNumero = tilausNumero;
    }

    //Seuraavassa määritellään muodostin, joka saa parametrina 
    //toisen Asiakas-olion. 
    public Asiaks(Asiaks asiakas)
    {
        //Seuraavassa asiakas-olion attribuuttien arvot 
        //kopioidaan kutsuvan olion attribuutteihin.
        this.nimi = asiakas.nimi;
        this.etuAsiakas = asiakas.etuAsiakas;
        this.tilausNumero = asiakas.tilausNumero;
    }

    //Seuraavassa määritellään oletusmuodostin ilman 
    //parametreja. Metodissa parametreille annetaan omat
    //oletusarvot. 
    public Asiaks()
    {
        nimi = "Ei tiedossa!";
        etuAsiakas = false;
        tilausNumero = 0;
    }

    //Seuraavassa määritellään VertaileAsiakas() -metodi.
    public void VertaileAsiakas(Asiaks asiakas)
    {
        //Seuraavassa kutsuvan olion ja parametrina olevan 
        //asiakas-olion nimi-attribuutit verrataan keskenään. 
        //Huomaa kuinka merkkijonot verrataan keskenään C#:n 
        //sisäänrekennetun Equals()-metodin avulla.
        if (this.nimi.Equals(asiakas.nimi))
            Console.WriteLine("\tAsiakkaat '" + this.nimi +
            "' ja '" + asiakas.nimi + "' ovat samannimisiä!");
        else
            Console.WriteLine("\tAsiakkaat '" + this.nimi +
            "' ja '" + asiakas.nimi + "' ovat eri nimisiä!");
    }

    public void TulostaTiedot()
    {
        Console.WriteLine("\tAsiakkaan nimi: " + nimi);
        Console.WriteLine("\tOnko etuasiakas: " +
        etuAsiakas);
        Console.WriteLine("\tAsiakkaan tilausnumero: " +
        tilausNumero);
        Console.WriteLine("\t------------------------");
    }
}

class Esimerkki5_8
{
    static void Main(string[] args)
    {
        //Tässä luodaan Asiakas-olio kaikilla parametreilla.
        Asiaks asiaks1 = new Asiaks("Alfred", true, 12345);

        //Tässä asiakkaan tiedot tulostetaan näytölle.
        asiaks1.TulostaTiedot();

        //Tässä luodaan kopio asiakas1-oliosta.
        Asiaks asiaks2 = new Asiaks(asiaks1);

        Console.WriteLine("\tKopioidun asiakkaan tiedot:");
        asiaks2.TulostaTiedot();

        //Tässä asiakas1-, asiakas2 -olioita verrataan keskenään.
        asiaks1.VertaileAsiakas(asiaks2);

        //Tässä luodaan asiakas3-olio.
        Asiaks asiakas3 = new Asiaks("Tiina", false, 4567);

        //Tässä asiakas1- ja asiakas3 -olioita verrataan keskenään.
        asiaks1.VertaileAsiakas(asiakas3);

        //Tässä luodaan asiakas3-olio.
        Asiaks asiakas4 = new Asiaks(asiakas3);
        //Tässä asiakas1- ja asiakas3 -olioita verrataan keskenään.
        asiakas3.VertaileAsiakas(asiakas4);
        // eri kakkoset keskenä
        asiaks2.VertaileAsiakas(asiakas3);

    }
}
