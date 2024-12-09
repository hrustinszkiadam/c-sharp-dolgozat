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
	}
}
