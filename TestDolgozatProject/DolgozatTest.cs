using DolgozatProject;

namespace TestDolgozatProject
{
	public class Tests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void PontFelvesz_HelyesAdat_NemDobArgumentExceptiont()
		{
			Assert.DoesNotThrow(() => dolgozat.PontFelvesz(10));
		}

		[Test]
		public void PontFelvesz_TulNagyAdat_ArgumentExceptiontDob()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(101));
		}

		[Test]
		public void PontFelvesz_TulKicsiAdat_ArgumentExceptiontDob()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(-2));
		}

		[Test]
		public void MindenkiMegirta_MindenkiIgen_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			dolgozat.PontFelvesz(20);

			Assert.IsTrue(dolgozat.MindenkiMegirta());
		}

		[Test]
		public void MindenkiMegirta_NemMindenki_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(20);

			Assert.IsFalse(dolgozat.MindenkiMegirta());
		}

		[Test]
		public void MindenkiMegirta_UresLista_HelyesenMukodik()
		{
			Assert.IsTrue(dolgozat.MindenkiMegirta());
		}

	}
}