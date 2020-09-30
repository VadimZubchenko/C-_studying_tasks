using System;
using System.Collections;

//Seuraavassa m��ritell��n luokka Henkilo.
class Henkilo
{
    string nimi, puhelinNumero;
    int id;

    public Henkilo(string nimi, string puhelinNumero, int id)
    {
        this.nimi = nimi;
        this.puhelinNumero = puhelinNumero;
        this.id = id;
    }

    public override string ToString()
    {
        return id + " " + nimi + " " + puhelinNumero;
    }
}

class Esimerkki9_7
{
    static void Main(string[] args)
    {
        //T�ss� luodaan jono asiakkaat.
        Queue asiakkaat = new Queue();

        Henkilo h1 = new Henkilo("Akseli", "040-123456", 1000);
        Henkilo h2 = new Henkilo("Majia", "040-234567", 2000);
        Henkilo h3 = new Henkilo("Niklas", "040-345678", 3000);

        //T�ss� jonoon lis�t��n p�iv�m��r�.
        asiakkaat.Enqueue(DateTime.Now);

        //Seuraavassa jonoon lis�t��n Henkilo-olioita.
        asiakkaat.Enqueue(h1);
        asiakkaat.Enqueue(h3);
        asiakkaat.Enqueue(h2);

        //T�ss� jonon alkioiden lukum��r� otetaan talteen. 
        //Huomaa, ett� joka kerta, kun kutsutaan metodi 
        //Dequeue(), jonon koko pienenee! 
        int jononKoko = asiakkaat.Count;

        Console.WriteLine("Alkioiden lukum��r�: " + jononKoko);

        //Seuraavassa jonon sis�lt� tulostetaan n�yt�lle.
        IEnumerator enumerator = asiakkaat.GetEnumerator();

        while (enumerator.MoveNext())
            Console.WriteLine(enumerator.Current);

        //Seuraavassa olio h2 tulostetaan n�yt�lle jos 
        //se on jonossa.
        if (asiakkaat.Contains(h2))
            Console.WriteLine("h2=" + h2);
        else
            Console.WriteLine("h2 ei ole jonossa!");

        //T�ss� jonon kaikki alkiot kopioidaan 
        //taulukkoon jononAlkiot.
        object[] jononAlkiot = asiakkaat.ToArray();

        Console.WriteLine("Alkiot tulostettuna taulukon kautta: ");

        //Seuraavassa taulukkon jononAlkiot sis�lt�
        //tulostetaan n�yt�lle.
        foreach (object obj in jononAlkiot)
            Console.WriteLine(obj);

        Console.WriteLine("Ensimm�inen alkio tulostettuna Peek()-metodilla: ");
        Console.WriteLine(asiakkaat.Peek());

        Console.WriteLine("Alkiot tulostettuna Dequeue()-metodilla:");
        for (int i = 0; i < jononKoko; i++)
            Console.WriteLine(asiakkaat.Dequeue());

        Console.WriteLine("Alkioiden lukum��r�: " +
                            asiakkaat.Count);
    }
}
