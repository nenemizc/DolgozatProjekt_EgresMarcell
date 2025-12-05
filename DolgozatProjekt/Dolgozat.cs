namespace DolgozatProjekt
{
    public class Dolgozat
    {
		private List<int> pontok;

		public Dolgozat()
		{
			this.pontok = new List<int>();
		}

		internal List<int> Pontok { get => pontok; }

		public void PontFelvesz(int x)
		{
			if(x < -1 || x > 100)
			{
				throw new ArgumentException("Hibás pontszám.");
			}
			pontok.Add(x);
		}

		public void MindenkiMegirta()
		{
			if (pontok.Count > 0) 
			{

			}
	}
}
