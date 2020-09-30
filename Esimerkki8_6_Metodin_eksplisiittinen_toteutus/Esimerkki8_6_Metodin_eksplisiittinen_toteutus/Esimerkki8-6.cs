  using System;

  //Seuraavassa m‰‰ritell‰‰n liittym‰ IRobotti.
  public interface IRobotti
  {
    //Seuraavassa esitell‰‰n liittym‰n metodit
    void Aloita();
    void Lopeta();

    //Seuraavassa esitell‰‰n ominaisuus RobottiToiminnassa.
    bool RobottiToiminnassa
    {
      get;
    }
  }

  //Seuraavassa m‰‰ritell‰‰n liittym‰ IVideoKamera.
  public interface IVideoKamera
  {
    //Seuraavassa esitell‰‰n liittym‰n metodit.
    void Aloita();
    void Lopeta();
  }

  //Seuraavassa m‰‰ritell‰‰n luokka Robotti, joka 
  //toteuttaa liittym‰t IRobotti ja IVideoKamera. 
  public class Robotti :IRobotti, IVideoKamera
  {
    //T‰ss‰ m‰‰ritell‰‰n robottiToiminnassa-kentt‰, jota
    //IRobotti-liittym‰n RobottiToiminnassa-property k‰ytt‰‰. 
    private bool robottiToiminnassa = false;

    //Seuraavassa toteutetaan liittym‰n IRobotti metodit 
    //eksplisiittisesti. Huomaa, kuinka liittym‰n nimi on
    //merkitty metodien nimen yhteydess‰. Huomaa, myˆs ett‰
    //saantim‰‰rett‰ ei saa merkit‰ eksplisiittisen 
    //toteutuksen yhteydess‰!
    void IRobotti.Aloita()
    {
      robottiToiminnassa = true;
      Console.WriteLine("Robotti aloittaa toiminnan...");
    }

    void IRobotti.Lopeta()
    {
      robottiToiminnassa = false;
      Console.WriteLine("Robotti lopettaa toiminnan...");
    }

    //Seuraavassa toteutetaan RobottiToiminnassa-property.  
    //Huomaa, ett‰ t‰ss‰ ei ole pakko merkit‰ liittym‰n 
    //nime‰ koska luokkaan ei periydy muita samannimis‰ 
    //ominiaisuuksia.
    public bool RobottiToiminnassa
    {
      get
      {
        return robottiToiminnassa;
      }
    }

    //Seuraavassa m‰‰ritell‰‰n liittym‰n IVideoKamera 
    //metodit. Huomaa, ettei t‰ss‰ saa merkit‰ liittym‰‰ 
    //IVideoKamera.
    public void Aloita()
    {
       Console.WriteLine("Videokamera aloittaa toiminnan...");
    }

    public void Lopeta()
    {
      Console.WriteLine("Videokamera lopettaa toiminnan...");
    }
  }

  //Seuraavassa m‰‰ritell‰‰n ohjelman p‰‰luokka.
  class Esimerkki8_6  
  {
    static void Main(string[] args)
    {
      //T‰ss‰ luodaan robotti olio.
      Robotti robotti = new Robotti();

      //T‰ss‰ kutsutaan IVideoKamera liittym‰n Aloita() 
      //metodi.
      robotti.Aloita();

      //T‰ss‰ kutsutaan IVideoKamera liittym‰n Lopeta() 
      //metodi.
      robotti.Lopeta();

      //Koska IRobotti liittym‰n metodit toteutettiin 
      //eksplisiittisesti, robotti olio pit‰‰ ensin muuntaa 
      //IRobotti liittym‰ksi, mink‰ j‰lkeen pystyt‰‰n 
      //kutsumaan IRobotti liittym‰n metodit.
      IRobotti iRobotti = robotti as IRobotti;

      //T‰ss‰ kutsutaan IRobotti liittym‰n Aloita() metodi.
      iRobotti.Aloita();

      //T‰ss‰ kutsutaan IRobotti liittym‰n RobottiToiminnassa 
      //property. Huomaa, ett‰ koska Robotti luokassa on vain 
      //yksi RobottiToiminnassa property, se voidaan kutsua 
      //myˆs robotti olion kautta seuraavasti:
      //Console.WriteLine("Robotti on toiminnassa: " + 
      //robotti.RobottiToiminnassa);

      Console.WriteLine("Robotti on toiminnassa: " + 
      iRobotti.RobottiToiminnassa);
    
      //T‰ss‰ kutsutaan IRobotti liittym‰n Lopeta() metodi.
      iRobotti.Lopeta(); 
    }
  }
