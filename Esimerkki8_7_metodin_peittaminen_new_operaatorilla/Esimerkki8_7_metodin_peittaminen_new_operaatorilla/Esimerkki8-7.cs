using System;

//Seuraavassa m‰‰ritell‰‰n liittym‰ IRobotti.
public interface IRobotti
{
    //T‰ss‰ esitell‰‰n liittym‰n metodit
    void Aloita();
}

//Seuraavassa m‰‰ritell‰‰n liittym‰ IVideoKamera.
public interface IVideoKamera : IRobotti
{
    //T‰ss‰ esitell‰‰n liittym‰n metodit
    new void Aloita();
    void Lopeta();
}

//Seuraavassa m‰‰ritell‰‰n luokka Robotti, joka 
//toteuttaa liittym‰n IVideoKamera.  
public class Robotti : IVideoKamera
{
    //Seuraavassa m‰‰ritell‰‰n liittym‰st‰ IRobotti 
    //per‰isin oleva metodi Aloita() eksplisiittisesti.
    void IRobotti.Aloita()
    {
        Console.WriteLine("Robotti aloittaa toiminnan...");
    }

    //Seuraavassa toteutetaan liittym‰n IVideoKamera metodi 
    //Aloita(). Huomaa, ettei t‰ss‰ saa merkit‰ liittym‰n
    //IVideoKamera nime‰.
    public void Aloita()
    {
        Console.WriteLine("Videokamera aloittaa toiminnan...");
    }

    //Seuraavassa toteutetaan liittym‰n IVideoKamera 
    //metodi Lopeta().
    public void Lopeta()
    {
        Console.WriteLine("Videokamera lopettaa toiminnan...");
    }
}

//Seuraavassa m‰‰ritell‰‰n ohjelman p‰‰luokka.
class Esimerkki8_7
{
    static void Main(string[] args)
    {
        //T‰ss‰ luodaan robotti-olio.
        Robotti robotti = new Robotti();

        //T‰ss‰ kutsutaan liittym‰n IVideoKamera 
        //metodi Aloita().
        robotti.Aloita();

        //Koska liittym‰n IRobotti  metodit toteutettiin 
        //eksplisiittisesti, robotti-olio pit‰‰ ensin muuntaa 
        //IRobotti-tyyppiseksi, mink‰ j‰lkeen liittym‰st‰
        //IRobotti periytyv‰t metodit pystyt‰‰n kutsumaan.
        IRobotti iRobotti = robotti as IRobotti;

        //T‰ss‰ kutsutaan liittym‰st‰ IRobotti periytyv‰ 
        //metodi Aloita().
        iRobotti.Aloita();

        //T‰ss‰ kutsutaan liittym‰st‰ IVideoKamera periytyv‰
        //metodi Lopeta().
        robotti.Lopeta();


       
    }
}
