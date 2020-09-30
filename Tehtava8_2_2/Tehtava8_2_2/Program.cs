using System;

public interface ITuote
{
    Tuote HaeTuote(string nimi, Tuote t);
    float LaskeYhteisArvo();
}

public interface IAsiakas
{
    Asiakas HaeAsiakas(string nimi, Asiakas a);
    float LaskeBonus();
}

public class Tuote : ITuote
{
    public string nimi;
    public float yksikkohinta;
    public int lukumaara;

    public Tuote(string nimi, float yksikkohinta, int lukumaara)
    {
        this.nimi = nimi;
        this.yksikkohinta = yksikkohinta;
        this.lukumaara = lukumaara;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public Tuote HaeTuote(string nimi, Tuote t)
    {
        if (nimi == t.nimi)
        {
            return t;
        }
        else
        {
            return null;
        }
    }

    public float LaskeYhteisArvo()
    {
        return this.yksikkohinta * this.lukumaara;
    }
}

public class Asiakas : IAsiakas
{
    public string nimi;
    public float ostokset;

    public Asiakas(string nimi, float ostokset)
    {
        this.nimi = nimi;
        this.ostokset = ostokset;
    }

    public Asiakas HaeAsiakas(string nimi, Asiakas a)
    {
        if (nimi.Equals(a.nimi))
        {
            return a;
        }
        else
        {
            return null;
        }
    }

    public float LaskeBonus()
    {
        if (this.ostokset <= 1000)
        {
            return (float)(ostokset * 0.02);
        }
        else if (ostokset > 1000 && ostokset <= 2000)
        {
            return (float)(ostokset * 0.03);
        }
        else
        {
            return (float)(ostokset * 0.05f);
        }
    }

    public override string ToString()
    {
        return this.nimi + ", " + this.ostokset;
    }
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Asiakas[] asiakkaat = new Asiakas[3];
        asiakkaat[0] = new Asiakas("Jari", 300f);
        asiakkaat[1] = new Asiakas("Teppo", 3900f);
        asiakkaat[2] = new Asiakas("Johanna", 2200f);

        for (int i = 0; i < asiakkaat.Length; i++)
        {
            Console.WriteLine(asiakkaat[i].HaeAsiakas("Teppo", asiakkaat[i]));
            Console.WriteLine(asiakkaat[i].LaskeBonus());
        }
    }
}

