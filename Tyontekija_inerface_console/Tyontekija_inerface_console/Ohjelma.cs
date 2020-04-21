using System;

namespace Tyontekija_inerface_console
{

    public interface IAsiakas
    {
        Asiakas HaeAsiakas(string nimi, Asiakas asiakas);
        double LaskeBonus();

    }

    public class Asiakas : IAsiakas
    {
        private string nimi;
        private int ostokset;

        public Asiakas(string nimi, int ostokset)
        {
            this.nimi = nimi;
            this.ostokset = ostokset;
        }

        public override string ToString()
        {
            return nimi + ", " + ostokset;
        }
        public Asiakas HaeAsiakas(string nimi, Asiakas asiakas)
        {
            if (nimi.Equals(asiakas.nimi))
                return asiakas;
            else
                return null;

        }
        public double LaskeBonus()
        {
            if (ostokset <= 1000)
                return ostokset * 0.02;

            else if (ostokset > 1000 && ostokset < 2000)
                return ostokset * 0.03;
            else
                return ostokset * 0.05;
        }
    }


    class Ohjelma
    {
        static void Main(string[] args)
        {
            Asiakas[] asiakkaat = new Asiakas[3];
            asiakkaat[0] = new Asiakas("Jari", 300);
            asiakkaat[1] = new Asiakas("Teppo", 3900);
            asiakkaat[2] = new Asiakas("Johanna", 2200);

            for (int i = 0; i < asiakkaat.Length; i++)
            {
                Console.WriteLine(asiakkaat[i].HaeAsiakas("Teppo", asiakkaat[i]));
                Console.WriteLine(asiakkaat[i].LaskeBonus());
            }
        }
    }


}
