using System;


class Tyontekija
{
    string nimi, tehtava;
    int id;
    double palkka;

    public Tyontekija(string nimi, string tehtava, int id, double palkka)
    {
        this.nimi = nimi;
        this.tehtava = tehtava;
        this.id = id;
        this.palkka = palkka;
    }

    public void VertailePalkka(Tyontekija tyontekija)
    {
        if (this.palkka > tyontekija.palkka)
            Console.WriteLine("tyontekijan " + this.nimi + "n palkka on isompi kuin " + tyontekija.nimi + "lla");
        else if (this.palkka < tyontekija.palkka)
            Console.WriteLine("tyontekijan " + this.nimi + "n palkka on pienempi kuin " + tyontekija.nimi + "lla");
        else
            Console.WriteLine("tyontekijan " + this.nimi + "n palkka on sama kuin " + tyontekija.nimi + "lla");
    }
    public void TulostaTiedot()
    {
        Console.WriteLine("Tyontekija: {0}, Tehtävä: {1}, id: {2}, palkka: {3:C}", nimi, tehtava, id, palkka);

    }

}


class Ohjelma
{
    static void Main(string[] args)
    {

        Tyontekija[] tyontekija;

        tyontekija = new Tyontekija[3];



        tyontekija[0] = new Tyontekija("Väinö Isomaa", "opas", 124546, 2200);
        tyontekija[1] = new Tyontekija("Niilo Kaurasmäki", "vahtimestari", 123445, 1830);
        tyontekija[2] = new Tyontekija("Kalle Auramo", "IT insinööri", 123445, 3000);

        foreach (Tyontekija t in tyontekija)
        {
            t.TulostaTiedot();
        }
        Console.WriteLine();

        tyontekija[0].VertailePalkka(tyontekija[1]);
        tyontekija[0].VertailePalkka(tyontekija[2]);
        tyontekija[1].VertailePalkka(tyontekija[2]);

    }
}