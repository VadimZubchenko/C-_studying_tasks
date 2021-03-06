using System;

class Tuote
{
    //Seuraavassa määritellään LaskeVoitto()-metodi, joka saa
    //syötteenä kaksi reaalilukua (ostoHinta ja myyntiHinta) 
    //ja palauttaa kaksi reaalilukua (alv ja voitto).
    public void LaskeVoitto(float ostoHinta, float
    myyntiHinta, out float alv, out float voitto)
    {
        alv = (myyntiHinta - ostoHinta) * 0.19f;
        voitto = myyntiHinta - ostoHinta - alv;
    }
}

class Esimerkki5_5
{
    static void Main()
    {
        //Seuraavassa määritellään muuttujat: viuluOstoHinta, 
        //viuluMyyntiHinta, myyntiAlv ja kauppaVoitto. Huomaa, 
        //että muuttujen viuluOstoHinta ja viluMyyntiHinta 
        //arvot ovat tiedossa, mutta ohjelman pitää laskea 
        //muuttujien myyntiAlv ja kauppaVoitto arvot.
        float viuluOstoHinta = 200000.00f;
        float viluMyyntiHinta = 243000.00f;
        float myyntiAlv;
        float kauppaVoitto;

        //Tässä määritellään Tuote-olio.
        Tuote viulu = new Tuote();

        //Seuraavassa kutsutaan viulu-olion LaskeVoitto()-
        //metodi, joka saa syötteenä muuttujat viuluOstoHinta 
        //ja viluMyyntiHinta ja palauttaa muuttujien myyntiAlv 
        //ja kauppaVoitto arvot. Palautettavat muuttujat 
        //joudutaan merkitsemään varatulla sanalla out.
        viulu.LaskeVoitto(viuluOstoHinta, viluMyyntiHinta, out 
     myyntiAlv, out kauppaVoitto);

        Console.WriteLine("Viulun osotohinta = " + viuluOstoHinta);
        Console.WriteLine("Viulun myyntihinta = " + viluMyyntiHinta);
        Console.WriteLine("-----------");
        Console.WriteLine("Viulun alv = {0,0:f2}", myyntiAlv);
        Console.WriteLine("Viulun myyntialv = {0,0:f2}",
        kauppaVoitto);
    }
}
