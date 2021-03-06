using System;

class Auto
{
    //Seuraavassa määritellään luokan attribuutit. 
    public string merkki;
    public int vuosimalli;
    public decimal hinta;
    public bool myyty;

    //Seuraavassa määritellään AlustaTiedot()-metodi, jota 
    //käytetään luokan attribuuttien alustamiseksi. Huomaa, 
    //kuinka this-operaattorin avulla luokan omat attribuutit 
    //erotetaan metodin samannimisistä muuttujista. Ilman 
    //this-operaattorin käyttöä AlustaTiedot()-metodin sisällä 
    //olevat sijoituslauseet eivät toimisi lainkaan.
    public void AlustaTiedot(string merkki, int vuosimalli,
    decimal hinta, bool myyty)
    {
        this.merkki = merkki;
        this.vuosimalli = vuosimalli;
        this.hinta = hinta;
        this.myyty = myyty;
    }

    //Seuraavassa määritellään VertaaMalli()-metodi, jolla 
    //auton vuosimallia tarkistetaan. Huomaa, että koska 
    //luokan attribuutti on samanniminen kuin metodin parametri
    //vuosimalli, luokan attribuutti erotetaan 
    //this-operaattorilla.
    public string VertaaMalli(int vuosimalli)
    {
        if (this.vuosimalli > vuosimalli)
            return
              "Auto on " + vuosimalli + " vuosimallia uudempi!";
        else
            return
              "Auto ei ole " + vuosimalli + " vuosimallia uudempi!";
    }

    //Tässä määritellään NaytaTiedot()-metodi, joka tulostaa
    //luokan attribuutien arvot näytölle.
    public void NaytaTiedot()
    {
        System.Console.WriteLine("Auton tiedot");
        System.Console.WriteLine("------------");
        System.Console.WriteLine("Auton merkki: " + merkki);
        System.Console.WriteLine("Auton vuosimalli: " +
        vuosimalli);
        System.Console.WriteLine("Auton hinta: " + hinta);
        System.Console.WriteLine("Auto on myyty?: " + myyty);
    }
}

class Esimerkki5_3
{
    static void Main(string[] args)
    {
        //Tässä luodaan auto-olio ja alustetaan sen 
        //attribuuttien oletusarvoilla.
        Auto auto = new Auto();

        //Tässä kutsutaan AlustaTiedot()-metodi, jolla auto-olion 
        //attribuutit alustetaan. 
        auto.AlustaTiedot("Ford", 2005, 14500.00m, true);

        //Tässä auto-olion tiedot tulostetaan näytölle.
        auto.NaytaTiedot();

        //Tässä tarkistetaan onko auton vuosimalli uudempi 
        //kuin 2005.
        Console.WriteLine(auto.VertaaMalli(2005));
    }
}