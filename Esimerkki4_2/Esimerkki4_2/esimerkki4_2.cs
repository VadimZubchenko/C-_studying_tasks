using System;

class Esimerkki4_2
{

    /*
    * Tässä luodaan vakioluettelo vuodenajoista siten että kevät on yhtä kuin 1,
    * kesä on 2 jne. Huomaa, että enum-tyyppiset muuttujat pitää määritellä 
    * Main()-metodin ulkopuolella.
    */
    enum vuodenAjat { keväät = 1, kesä, syksy, talvi };

    static void Main(string[] args)
    {
        int suosikki;

        System.Console.WriteLine("Valitse luku väliltä 1-4:");
        //Tässä luetaan käyttäjän valinta näppäimistöltä. Huomaa, että koska
        //halutaan lukea numero käytetään Int32.Parse()-metodia syötteen kääntämiseksi
        //luvuksi.
        suosikki = Int32.Parse(System.Console.ReadLine());

        switch (suosikki)
        {

            case 1:
                Console.WriteLine("Valintasi on: " + vuodenAjat.keväät);
                break;
            case 2:
                System.Console.WriteLine("Valintasi on: " + vuodenAjat.kesä);
                break;

            case 3:
                System.Console.WriteLine("Valintasi on: " + vuodenAjat.syksy);
                break;

            case 4:
                System.Console.WriteLine("Valintasi on: " + vuodenAjat.talvi);
                break;

            default:
                System.Console.WriteLine("Valintas ei kuuluu väliin 1-4 !");
                break;
        }

        //Tässä määritellään kuukausi-muuttuja, joka on tyyppiä string.
        string kuukausi;

        System.Console.WriteLine("Mikä on lempikuukautesi nimi?");
        kuukausi = System.Console.ReadLine();

        switch (kuukausi)
        {
            case "Tammikuu":
                goto case "Toukokuu";
                System.Console.WriteLine("Lempikuukautesi on: " + kuukausi + ". Pidätkö talvesta?");
               
                break;
            case "Toukokuu":
                System.Console.WriteLine("Lempikuukautesi on: " + kuukausi + ". Pidätkö keväästä?");
                break;
            case "Heinäkuu":
                System.Console.WriteLine("Lempikuukautesi on: " + kuukausi + ". Pidätkö kesästä?");
                break;
            case "Syyskuu":
                goto default;
                System.Console.WriteLine("Lempikuukautesi on: " + kuukausi + ". Pidätkö syksystä?");
                break;

            default:
                Console.WriteLine("Valintaasi ei tunneta!");
                break;
        }

        //Tässä määritellään char-tyyppinen muuttuja jatka.
        char jatka;

        System.Console.WriteLine("Jatketaanko? (k/e)");

        //Tässä luetaan merkki näppäimistöltä jatka-muuttujaan. Huomaa, että joudutaan
        //tekemään eksplisiittinen tyyppimuunnos.
        jatka = (char)System.Console.Read();

        switch (jatka)
        {
            case 'k':
                System.Console.WriteLine("Valintasi on: " + jatka + "! Ilmeisesti haluat jatkaa!");
                break;

            case 'e':
                System.Console.WriteLine("Valintasi on: " + jatka + "! Ilmeisesti et halua jatkaa!");
                break;

            default:
                System.Console.WriteLine("Valintasi on: " + jatka + "! Väärä vastaus!");
                break;
        }

    }
}