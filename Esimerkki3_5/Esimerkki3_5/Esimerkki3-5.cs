using System;

class Esimerkki3_5
{
    public static void Main(string[] args)
    {
        //T‰ss‰ m‰‰ritell‰‰n byte-tyyppiset muuttujat.
        byte b1 = 242, b2 = 64;

        //Huomaa, ett‰ seuraavissa bittikohtaisten 
        //operaattoreiden yhteydess‰ joudutaan suorittamaan 
        //tyyppimuunnos koska operaattoreiden tuottama tulos 
        //on oletusarvoisesti tyyppi‰ int, mutta ohjelmassa 
        //m‰‰ritellyt muuttujat ovat tyyppi‰ byte.

        Console.Write("b1={0} b2={1}  ", b1, b2);

        //T‰ss‰ suoritetaan bittikohtainen JA-operaattori.
        byte jaTulos = (byte)(b1 & b2);

        Console.WriteLine("b1 & b2 = " + jaTulos);

        //T‰ss‰ muuttuja b2 alustetaan uudella arvolla.
        b2 = 223;

        Console.Write("b1={0} b2={1}  ", b1, b2);

        //T‰ss‰ suoritetaan bittikohtainen JA-operaattori 
        //uudelleen ja muuttuja jaTulos alustetaan uuden 
        //JA-operaattorin tuloksella.
        jaTulos = (byte)(b1 & b2);

        Console.WriteLine("b1 & b2 = " + jaTulos);

        //T‰ss‰ muuttuja b2 alustetaan uudella arvolla.
        b2 = 9;

        Console.Write("b1={0} b2={1}  ", b1, b2);

        //T‰ss‰ suoritetaan bittikohtainen TAI-operaattori.
        byte taiTulos = (byte)(b1 | b2);

        Console.WriteLine("b1 | b2 = " + taiTulos);

        //T‰ss‰ muuttuja b2 alustetaan uudella arvolla.
        b2 = 15;

        Console.Write("b1={0} b2={1}  ", b1, b2);

        //T‰ss‰ suoritetaan bittikohtainen poissulkeva 
        //TAI-operaattori.
        byte poisSulkevaTaiTulos = (byte)(b1 ^ b2);

        Console.WriteLine("b1 ^ b2 = " +
        poisSulkevaTaiTulos);

        Console.Write("poisSulkevaTaiTulos={0} b2={1}  ",
        poisSulkevaTaiTulos, b2);

        //Seuraavassa poissulkeva TAI-operaattori sovelletaan 
        //muuttujien b2 ja poisSulkevaTaiTulos v‰lill‰. 
        //Tuloksena on taas muuttuja b1.
        byte uusiPoisSulkevaTaiTulos =
        (byte)(poisSulkevaTaiTulos ^ b2);

        Console.WriteLine("poisSulkevaTaiTulos ^ b2 = " +
        uusiPoisSulkevaTaiTulos);

        Console.Write("b1={0}  ", b1);

        //T‰ss‰ suoritetaan bittikohtainen Ei-operaattori.
        byte eib1 = (byte)(~b1);

        Console.WriteLine("~b1 = " + eib1);

        Console.Write("b1={0}  ", b1);

        //T‰ss‰ suoritetaan bittikohtainen vasemmalle siirto.
        byte vasenSiirtob1 = (byte)(b1 << 2);

        Console.WriteLine("b1<<2 = " + vasenSiirtob1);

        Console.Write("b1={0}  ", b1);

        //T‰ss‰ suoritetaan bittikohtainen oikealle siirto.
        byte oikeaSiirtob1 = (byte)(b1 >> 2);

        Console.WriteLine("b1>>2 = " + oikeaSiirtob1);
    }
}