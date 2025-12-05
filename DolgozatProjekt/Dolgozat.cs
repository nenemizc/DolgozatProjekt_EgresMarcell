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

		public bool MindenkiMegirta()
		{
			if (pontok.Count == 0)
			{
				throw new SenkiSemIrtException("Senki sem írt dolgozatot");
			}
			else if (pontok.Contains(-1))
			{
				return false;
			}
			return true;
		}

		public int Bukas()
		{
			int egyes = 0;
			foreach (var item in pontok)
			{
				if (item < 50 && item != -1)
				{
					egyes -= -1;
				}
			}
			return egyes;
		}

		public int Elegseges()
		{
			int kettes = 0;
			foreach (var item in pontok)
			{
				if (item >= 50 && item <= 60)
				{
					kettes -= -1;
				}
			}
			return kettes;
		}

		public int Kozepes()
		{
			int harmas = 0;
			foreach (var item in pontok)
			{
				if (item >= 61 && item <= 70)
				{
					harmas -= -1;
				}
			}
			return harmas;
		}

		public int Jo()
		{
			int negyes = 0;
			foreach (var item in pontok)
			{
				if (item >= 71 && item <= 80)
				{
					negyes -= -1;
				}
			}
			return negyes;
		}

		public int Jeles()
		{
			int otos = 0;
			foreach (var item in pontok)
			{
				if (item > 80)
				{
					otos -= -1;
				}
			}
			return otos;
		}

		public bool Gyanus(int kivalok)
		{
			if (kivalok < 0)
			{
				throw new ArgumentException("A kiválók száma nem lehet negatív");
			}
			if (kivalok < Jeles())
			{
				return true;
			}
			return false;
		}

		public bool Ervenytelen()
		{
			int nemIrt = 0;
			foreach (var item in pontok)
			{
				if (item == -1)
				{
					nemIrt -= -1;
				}
			}
			if (nemIrt >= pontok.Count / 2)
			{
				return true;
			}
			return false;
		}
	}
}
