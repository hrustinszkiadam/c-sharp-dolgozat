namespace DolgozatProject
{
	public class Dolgozat
	{
		private List<int> pontok;

		public Dolgozat()
		{
			pontok = new List<int>();
		}

		public void PontFelvesz(int x)
		{
			if (x < -1 || x > 100) throw new ArgumentException("A pontnak -1 és 100 között kell lennie", nameof(x));
			pontok.Add(x);
		}

		public bool MindenkiMegirta()
		{
			return !pontok.Contains(-1);
		}

		public int Bukas
		{
			get
			{
				return pontok.Count(x=> x != -1 && x < 50);
			}
		}
		public int Elegseges
		{
			get
			{
				return pontok.Count(x => x >= 50 && x <= 60);
			}
		}
		public int Kozepes
		{
			get
			{
				return pontok.Count(x => x >= 61 && x <= 70);
			}
		}
		public int Jo
		{
			get
			{
				return pontok.Count(x => x >= 71 && x <= 80);
			}
		}
		public int Jeles
		{
			get
			{
				return pontok.Count(x => x >= 81);
			}
		}

		public bool Gyanus(int kivalok)
		{
			if(kivalok < 0) throw new ArgumentException("A kiválók számának minimum 0-nak kell lennie!", nameof(kivalok));

			return kivalok < Jeles;
		}

		public bool Ervenytelen
		{
			get
			{
				return pontok.Count(x => x == -1) >= pontok.Count / 2;
			}
		}
	}
}
