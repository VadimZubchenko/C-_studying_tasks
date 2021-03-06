using System;

/*
 *
 * seuraavassa määritellään HenkiloTiedot-luokka.
 *
 */
class HenkiloTiedot
{
    protected string nimi;
    protected int id;

    public HenkiloTiedot(string nimi, int id)
    {
        this.nimi = nimi;
        this.id = id;
    }

    //Seuraavassa määritellään virtuaalimetodi
    //TulostaTiedot().
    public virtual void TulostaTiedot()
    {
        Console.WriteLine("Henkilön tiedot: " + nimi + " "
        + id);
    }
}

/*
 *
 * Seuraavassa määritellään Asiakas-luokka.
 *
 */
class Asiakas : HenkiloTiedot
{
    protected int suhteenKesto;

    public Asiakas(string nimi, int id, int suhteenKesto)
    : base(nimi, id)
    {
        this.suhteenKesto = suhteenKesto;
    }

    //Seuraavassa määritellään virtuaalimetodi LaskeBonus().
    public virtual void LaskeBonus()
    {
        short bonus;

        if (suhteenKesto < 1)
            bonus = 10;
        else
            bonus = 1000;

        Console.WriteLine("Asiakkaan bonus on: {0,0:c2}",
        bonus);
    }

    //Seuraavassa metodi TulostaTiedot() ylikirjoitetaan.
    public override void TulostaTiedot()
    {
        Console.WriteLine("Asiakkaan tiedot: " + nimi +
                            " " + id + " Suhteen kesto: " + suhteenKesto);
    }
}

/*
 * 
 * Seuraavassa määritellään HopeaEtuAsiakas-luokka.
 * 
 */
class HopeaEtuAsiakas : Asiakas
{
    public float ostot;

    public HopeaEtuAsiakas(string nimi, int id, int
    suhteenKesto, float ostot) : base(nimi, id, suhteenKesto)
    {
        this.ostot = ostot;
    }

    //Seuraavassa luodaan luokan oma versio metodista
    //LaskeBonus().
    public new void LaskeBonus()
    {
        Console.WriteLine("HopeaAsiakkaan bonus on: {0,0:c2}",
        (0.1f * ostot));
    }

    //Seuraavassa ylikirjoitetaan TulostaTiedot()-metodi.
    public override void TulostaTiedot()
    {
        Console.WriteLine("HopeaEtuAsiakkaan tiedot: " + nimi +
                            " " + id + " Ostot: {0,0:c2}", ostot);
    }
}

/*
 *
 * Seuraavassa määritellään Alihankija-luokka.
 *
 */
class Alihankija : HenkiloTiedot
{
    public float kauppaHinta;

    public Alihankija(string nimi, int id, float kauppaHinta)
    : base(nimi, id)
    {
        this.kauppaHinta = kauppaHinta;
    }

    public void LaskeAlennus()
    {
        float alennus;

        if (kauppaHinta < 10000)
            alennus = 0.2f * kauppaHinta;
        else
            alennus = 0.4f * kauppaHinta;

        Console.WriteLine("Alihankijan kauppahinta on: {0,0:c2} ja alennus on: {0,0:c2} ", kauppaHinta, alennus);
    }

    public override void TulostaTiedot()
    {
        Console.WriteLine("Alihankijan tiedot: " + nimi +
        " " + id + " Kauppahinta: {0,0:c2}", kauppaHinta);
    }
}


class Esimerkki7_6
{
    static void Main(string[] args)
    {
        /*
         * Tässä teen eri kokeilut upcast ja downcast ymmärtämiseen.
         *
         */
        // Asiakas on HenkiloTiedon aliluokka
        Asiakas vadimAsiakas = new Asiakas("Vadim", 111, 3);
        // HenkiloTiedot on ylin luokka
        HenkiloTiedot vadimHenkiloTiedot = new HenkiloTiedot("Vadim", 111);
        // muunnetaan Asiakas luokka sen yliluokkaan (upcast). 
        HenkiloTiedot vadimAsiakasHenkiloTeidoksi = (HenkiloTiedot)vadimAsiakas;

        Console.WriteLine("-----HenkiloTiedon alkuperainen TulostaTiedot()-----");
        vadimHenkiloTiedot.TulostaTiedot();
        Console.WriteLine("-----Asikaan muunnettu HenkiloTiedoksi TulostaTiedot()-----");
        vadimAsiakasHenkiloTeidoksi.TulostaTiedot();
        Console.WriteLine("-----Ja Asiakkaan alkuperainen TulostaTiedot()-----" );
        vadimAsiakas.TulostaTiedot();
        Console.WriteLine("\n\n");

        Console.WriteLine("Tässä yritetaan muuntaa yliluokka HenkiloTiedot alaluokaksi Asiakas");
        // yritetaan muuntaa yliluokka HenkiloTiedot alaluokaksi Asiakas
        try
        {
            Asiakas vadimAlaLuokkaHenkiloTiedot = (Asiakas)vadimHenkiloTiedot;
            // tulostetaan
            vadimAlaLuokkaHenkiloTiedot.TulostaTiedot();
        }
        catch
        {
            Console.WriteLine("Yläluokka ei muuttuu alaluokaksi...");
        }

        Console.WriteLine("----Yritetaan aikasemmin muunnettu alaluokka yliluokaksi muuntaa alaluokaksi-----");
        // yritetaan muuntaa yliluokka HenkiloTiedot alaluokaksi Asiakas
        Asiakas vadimVanhaAla_YliLuokkaHenkiloTiedot = (Asiakas)vadimAsiakasHenkiloTeidoksi;
            // tulostetaan
            vadimVanhaAla_YliLuokkaHenkiloTiedot.TulostaTiedot();

        Console.WriteLine("\n");

        // muunnetaan alasin luokka HopeaAsiakas ylinluokkaan HenkiloTiedot
        HopeaEtuAsiakas vadimHopeaAsiakas = new HopeaEtuAsiakas("Vadim", 111, 3, 100.10f);
        Console.WriteLine("----Tässä alinluokan TulostaTiedot ja LaskeBonus----");
        vadimHopeaAsiakas.TulostaTiedot();
        vadimHopeaAsiakas.LaskeBonus();
        Console.WriteLine("\n");

        Console.WriteLine("----Munnoksen vadimHopeaAsikass ylinluokaksi HenkiloTiedot() jälkeen----");
        HenkiloTiedot vadimHopeaYlinLuokkaan = (HenkiloTiedot)vadimHopeaAsiakas;
        vadimHopeaYlinLuokkaan.TulostaTiedot();
        Console.WriteLine("\n");

        Console.WriteLine("----Takaisin entinen ala ja nyt ylinluokka vadimHopeaYlinLuokkaan alaluokaksi----");
        HopeaEtuAsiakas entAlaNytYlaVadimHopea = (HopeaEtuAsiakas)vadimHopeaYlinLuokkaan;
        entAlaNytYlaVadimHopea.TulostaTiedot();
        entAlaNytYlaVadimHopea.LaskeBonus();
        Console.WriteLine("\n");


        // yritetään muuntaa aikasemmin muunnettu HopeaEtuAsiakas luokka muuntaa Asiakas luokaaksi
        Console.WriteLine("-----Munnetaan aikasemmin muunnettu HopeaEtuAsiakas-olio newAsiakas-olioksi");
        try
        {
            Asiakas newAsiakas = (Asiakas)entAlaNytYlaVadimHopea;
            newAsiakas.TulostaTiedot();
            newAsiakas.LaskeBonus();
        }
        catch
        {
            Console.WriteLine("Yläluokka ei muuttuu alaluokaksi...");
        }

        Console.WriteLine("\n");

        /*
         *
         * Tässä lopetetaan omat kokeilut, eli aikasemmin munnettu alaluokka yliluokaksi
         * saa muuntaa takaisin alaluokaksi (downcast)
         */

        //Seuraavassa määritellään hopeaEtuAsiakas-olio 
        HopeaEtuAsiakas hopeaEtuAsiakas = new
        HopeaEtuAsiakas("Laura", 3000, 10, 12345.00f);

        //tulostetaan tulevaa vertaulua varten
        Console.WriteLine("ToString: " + hopeaEtuAsiakas.ToString());
        hopeaEtuAsiakas.TulostaTiedot();
        hopeaEtuAsiakas.LaskeBonus();

        //Seuraavassa määritellään henkiloTiedot1-olio, joka 
        //alustetaan muuntamalla hopeaEtuAsiakas-olio 
        //(upcast). Tämä on mahdollista koska HenkiloTiedot
        //on HopeaEtuAsiakas-luokan välillinen yliluokka. 
        //Huomaa, että henkiloTiedot1-olio sisältää kuitenkin 
        //vain ne jäsenet, jotka on määritelty HenkiloTiedot-
        //luokassa, eli nimi, id ja TulostaTiedot()-metodi.

        HenkiloTiedot henkiloTiedot1 = (HenkiloTiedot)hopeaEtuAsiakas;

        Console.WriteLine("-- HopeaEtuAsiakas-olio on muunnettu HenkiloTiedot-olioksi --");

        //Seuraavassa kutsutaan henkiloTiedot1-olion 
        //TulostaTiedot()-metodi. Huomaa, että koska 
        //henkiloTiedot1-olio on alustettu muunntamalla 
        //hopeaEsuAsiakas-olio, käytännössä hopeaEsuAsiakas-olion 
        //TulostaTiedot() tulee kutsutuksi!
        //HopeaEtuAsiakkaan tiedot: Laura 3000 Ostot: 12 345,00 € eikä "Henkilön tiedot: Laura 3000"
        henkiloTiedot1.TulostaTiedot();

        Console.WriteLine("\t\t-------------------");

        Asiakas asiakas1 = new Asiakas("Lucia", 2000, 3);

        //tulostetaan tulevaa vertaulua varten
        Console.WriteLine("ToString: " + asiakas1.ToString());
        asiakas1.TulostaTiedot();
        asiakas1.LaskeBonus();

        //Seuraavassa määritellään henkiloTiedot2-olio, joka 
        //alustetaan muuntamalla asiakas1-olio (upcast). Tämä 
        //on mahdollista koska HenkiloTiedot on Asiakas-luokan
        //välitön yliluokka. Huomaa, että henkiloTiedot2-olio
        //sisältää kuitenkin vain ne jäsenet, jotka on 
        //määritelty HenkiloTiedot-luokassa, eli nimi, id ja 
        //TulostaTiedot()-metodi.
        
        HenkiloTiedot henkiloTiedot2 = (HenkiloTiedot)asiakas1;

        Console.WriteLine("-- Asiakas-olio on muunnettu HenkiloTiedot-olioksi --");

        //Seuraavassa kutsutaan henkiloTiedot2-olion
        //TulostaTiedot()-metodi. Huomaa, että koska 
        //henkiloTiedot2-olio on alustettu muunntamalla 
        //asiakas1-olio, käytännössä asiakas1-olion 
        //ylikirjoitettu TulostaTiedot() tulee kutsutuksi!
        //Asiakkaan tiedot: Lucia 2000 Suhteen kesto: 3 eikä "Henkilön tiedot: Lucia 2000"
        Console.WriteLine("ToString: " + henkiloTiedot2.ToString());
        henkiloTiedot2.TulostaTiedot();

        Console.WriteLine("\t\t-------------------");

        //Seuraavassa hopeaEtuAsiakas-olio muunnetaan asiakas1-
        //olioksi (upcast). Tämä on mahdollista koska Asiakas-
        //luokka on HopeaEtuAsiakas-luokan yliluokka. Huomaa, 
        //että muunnoksen seurauksena vain Asiakas-luokassa 
        //määritellyt jäsenet eli nimi, id, suhteenKesto,
        //LaskeBonus() ja TulostaTiedot() ovat käytössä, mutta 
        //ei ostot-kenttä! 
        asiakas1 = (Asiakas)hopeaEtuAsiakas;

        Console.WriteLine("-- HopeaEtuAsiakas-olio on muunnettu Asiakas-olioksi --");

        //Seuraavassa kutsutaan asiakas1-olion metodeja. 
        //Huomaa, että koska asiakas1 on alustettu muunntamalla 
        //hopeaEtuAsiakas-olio, tämän olion ylikirjoitettu 
        //TulostaTiedot()-metodit tulee kutsutuiksi.
        //HopeaEtuAsiakkaan tiedot: Laura 3000 Ostot: 12 345,00 €
        //Mutta, 
        //koska LaskeBonus()-metodi on merkitty new:lla 
        //HopeaEtuAsiakas-luokassa, Asiakas-luokassa määritelty 
        //LaskeBonus() tulee kutsutuksi
        //Asiakkaan bonus on: 1 000,00 € eikä "HopeaAsiakkaan bonus on: 1 234,50 €"
        Console.WriteLine("ToString: " + asiakas1.ToString());
        asiakas1.TulostaTiedot();
        asiakas1.LaskeBonus();

        Console.WriteLine("\t\t-------------------");

        //Seuraavassa henkiloTiedot1-olio muunnetaan 
        //hopeaEtuAsiakas2-olioksi (downcast). Huomaa, että 
        //tämä on mahdollista vain sen takia, että 
        //henkiloTiedot1-olio alunperin luotiin muuntamalla 
        //HopeaEtuAsiakas-luokan olio. Huomaa myös, että 
        //hopeaEtuAsiakas2 sisältää kaikki HopeaEtuAsiakas-
        //luokkaan kuuluvat jäsenet. nimi, id ja ostot

        HopeaEtuAsiakas hopeaEtuAsiakas2 = (HopeaEtuAsiakas)henkiloTiedot1;
        
        Console.WriteLine("-- HenkiloTiedot-olio on muunnettu HopeaEtuAsiakas-olioksi --");
        Console.WriteLine("jäsenet: nimi: " + hopeaEtuAsiakas2.nimi + "" +
            ", id: " + hopeaEtuAsiakas2.id + "" +
            ", suhteen kesto: "+ hopeaEtuAsiakas2.suhteenKesto + ""+
            ", ostot: "+ hopeaEtuAsiakas2.ostot);
        Console.WriteLine("ToString: " + hopeaEtuAsiakas2.ToString());
        hopeaEtuAsiakas2.TulostaTiedot();
        hopeaEtuAsiakas2.LaskeBonus();

        Console.WriteLine("\t\t-------------------");

        //Seuraavassa asiakas1-olio muunnetaan 
        //hopeaEtuAsiakas3-olioksi (downcast). Huomaa, että 
        //tämä on taas mahdollista vain sen takia, että 
        //asiakas1 aikaisemmin alustettiin muunntamalla 
        //HopeaEtuAsiakas-luokan olio.
        HopeaEtuAsiakas hopeaEtuAsiakas3 = (HopeaEtuAsiakas)asiakas1;

        Console.WriteLine("-- Asiakas-olio on muunnettu HopeaEtuAsiakas-olioksi --");

        Console.WriteLine("ToString: " + hopeaEtuAsiakas3.ToString());
        hopeaEtuAsiakas3.TulostaTiedot();
        hopeaEtuAsiakas3.LaskeBonus();
        
        Console.WriteLine("\t\t-------------------");

        //Seuraavassa määritellään olioita ilman 
        //tyyppimuunnosta.
        HenkiloTiedot henkiloTiedot3 = new HenkiloTiedot("Paul",
        5000);
        Asiakas asiakas2 = new Asiakas("Jyrki", 4000, 7);

        //Seuraava muunnos aliluokkaan (downcast) epäonnistuu 
        //koska henkiloTiedot3-olio luotiin suoraan 
        //HenkiloTiedot-luokan muodostimella!

        //HopeaEtuAsiakas hopeaEtuAsiakas4 = (HopeaEtuAsiakas)henkiloTiedot3;

        //Seuraava muunnos aliluokkaan (downcast) epäonnistuu 
        //koska asiakas2-olio luotiin suoraan Asiakas-luokan 
        //muodostimella!

        //HopeaEtuAsiakas hopeaEtuAsiakas5 = (HopeaEtuAsiakas)asiakas2;

        //Seuraava muunnos aliluokkaan (downcast) epäonnistuu 
        //koska henkiloTiedot3-olio luotiin suoraan 
        //HenkiloTiedot-luokan muodostimella!

        //Asiakas asiakas3 = (Asiakas)henkiloTiedot3;

        //Seuraava muunnos epäonnistuu koska Asiakas- ja 
        //AliHankija-luokat eivät ole yhteensopivia!

        //Alihankija aliHankija = (Alihankija) asiakas2;
    }
}