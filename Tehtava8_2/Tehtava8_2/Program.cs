using System;

public interface ITuote
{
	String HaeTuote(string nimi, Tuote tuote);//Tuote HaeTuote(string nimi, Tuote t);
	float LaskeYhteisArvo();

}

public class Tuote : ITuote
{
	private string nimi;
	private float hinta;
	private int maara;

	public Tuote(string nimi, float hinta, int maara)
	{
		this.nimi = nimi;
		this.hinta = hinta;
		this.maara = maara;
	}
	

    public String HaeTuote(string nimi, Tuote tuote)
	{
		if (nimi.Equals(tuote.nimi))
			return tuote.ToString();// return tuote;
		else
			return null;

	}
	public float LaskeYhteisArvo()
	{
		float yht = this.hinta * this.maara;

		return yht;

	}
}
class Ohjelma
{
	static void Main(string[] args)
	{
		Tuote[] tuotteet = new Tuote[3];
		tuotteet[0] = new Tuote("kynä", 1.4f, 300);
		tuotteet[1] = new Tuote("vihko", 2.3f, 425);
		tuotteet[2] = new Tuote("tabletti", 349f, 251);

		for (int i = 0; i < tuotteet.Length; i++)
		{
			Console.WriteLine(tuotteet[i].HaeTuote("vihko", tuotteet[i]));
			Console.WriteLine(tuotteet[i].LaskeYhteisArvo());
		}
	}
}