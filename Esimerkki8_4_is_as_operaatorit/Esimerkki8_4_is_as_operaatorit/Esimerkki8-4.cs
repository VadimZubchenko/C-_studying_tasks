  using System;

  //Seuraavassa m‰‰ritell‰‰n liittym‰ IRobotti.
  public interface IRobotti
  {
    //Seuraavassa esitell‰‰n liittym‰n metodit.
    void Aloita();
    void Lopeta();

    //T‰ss‰ m‰‰ritell‰‰n RobottiToiminnassa ñominaisuus.
    bool RobottiToiminnassa
    {
      get;
    }
  }

  //Seuraavassa m‰‰ritell‰‰n liittym‰ IPyori.
  public interface IPyori
  {
    void Pyori(double kulma);
  }

  //Seuraavassa m‰‰ritell‰‰n luokka Robotti, joka perii 
  //liittym‰n IRobotti.  
  public class Robotti : IRobotti
  {
    //T‰ss‰ m‰‰ritell‰‰n kentt‰ robottiToiminnassa, jota
    //IRobotti-liittym‰n RobottiToiminnassa-property k‰ytt‰‰. 
    private bool robottiToiminnassa = false;

    //Seuraavassa m‰‰ritell‰‰n IRobotti liittym‰n metodit.
    //Huomaa, ett‰ metodien saantim‰‰reiden pit‰‰ olla public!
    public void Aloita()
    {
      robottiToiminnassa = true;
      Console.WriteLine("Robotti aloittaa toiminnan...");
    }
    
    public void Lopeta()
    {
      robottiToiminnassa = false;
      Console.WriteLine("Robotti lopettaa toiminnan...");
    }

    //Seuraavassa toteutetaan RobottiToiminnassa property.  
    //Huomaa, ett‰ property:n saantim‰‰reen pit‰‰ olla public!
    public bool RobottiToiminnassa
    {
      get
      {
        return robottiToiminnassa;
      }
    }
  }
  
  class Esimerkki8_4  
  {
    static void Main(string[] args)
    {
      //T‰ss‰ luodaan robotti-olio.
      Robotti robotti = new Robotti();

      //T‰ss‰ tarkisteen tukeeko robotti IRobotti liittym‰‰. 
      if (robotti is IRobotti)
         Console.WriteLine("robotti-olio tukee liittym‰‰ IRobotti");
      else
         Console.WriteLine("robotti-olio ei tue liittym‰‰ IRobotti ");

      //T‰ss‰ tarkisteen tukeeko robotti IPyori liittym‰‰. 
      if(robotti is IPyori)
         Console.WriteLine("robotti-olio tukee liittymaa IPyori ");
      else
         Console.WriteLine("robotti-olio ei tue liittymaa IPyori ");
         
      //T‰ss‰ yritet‰‰n muuntaa robotti IPyori-tyypiseksi.
      IPyori  iPyoriRobotti = robotti as IPyori;
      
      if (iPyoriRobotti != null)
      {
         //Jos iPyoriRobotti ei ole null, IPyori-liittym‰st‰ 
         //periytyv‰ Pyori()-metodi kutsutaan.
         iPyoriRobotti.Pyori(45.0);
      }
      else
      {
         Console.WriteLine("robotti-oliota ei voi muuntaa iPyoriRobotti:ksi");
            //Jos luokka tukee liittym‰‰, as-operaattori suorittaa tyyppimuunnoksen
            //ja muuten se palauttaa null-arvon.
            
      }
    }
  }
