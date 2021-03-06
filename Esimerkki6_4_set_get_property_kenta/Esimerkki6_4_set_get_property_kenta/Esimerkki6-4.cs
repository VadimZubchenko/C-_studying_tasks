using System;

class Tyontekija
{
    //Tässä määritellään private kenttä palkka.
    private decimal palkka;

    //Seuraavassa määritellään property, joka hoitaa palkka-
    //kentän alustamisen ja palauttamisen. Lohkon nimeksi on 
    //laitettu BruttoPalkka.
    public decimal BruttoPalkka
    {
        //Seuraavassa määritellään get-metodi, joka palauttaa 
        //property-kentän arvo.
        get
        {
            return palkka;
        }

        //Seuraavassa määritellään set-metodi, joka alustaa 
        //property-kentän arvon. Huomaa, että varattu sana value 
        //hoitaa kentän alustamisen. Tässä käyttäjän antama arvo 
        //kerrotaan 1.5:lla ennen sen kopioimista palkka-
        //kenttään.         
        set
        {
            palkka = value * 1.5m;
        }
    }
}

class Esimerkki6_4
{
    static void Main(string[] args)
    {
        //Tässä määritellään tyontekija-olio.
        Tyontekija tyontekija = new Tyontekija();

        //Tässä alustetaan property-kenttä.
        tyontekija.BruttoPalkka = 1000.0m;

        //Tässä luetaan property-kentän arvo.
        System.Console.WriteLine("Työntekijän BruttoPalkka on {0,0:f2}.", tyontekija.BruttoPalkka);
    }
}
