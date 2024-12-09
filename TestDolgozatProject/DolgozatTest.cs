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

		[Test]
		public void Bukas_UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Bukas, Is.EqualTo(0));
		}

		[Test]
		public void Bukas_EgyBukas_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			Assert.That(dolgozat.Bukas, Is.EqualTo(1));
		}

		[Test]
		public void Bukas_EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Bukas, Is.EqualTo(0));
		}

		[Test]
		public void Elegseges_UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
		}

		[Test]
		public void Elegseges_EgyElegseges_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(55);
			Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
		}

		[Test]
		public void Elegseges_EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
		}

		[Test]
		public void Kozepes_UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
		}

		[Test]
		public void Kozepes_EgyKozepes_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(65);
			Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
		}

		[Test]
		public void Kozepes_EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
		}

		[Test]
		public void Jo_UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Jo, Is.EqualTo(0));
		}

		[Test]
		public void Jo_EgyJo_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(75);
			Assert.That(dolgozat.Jo, Is.EqualTo(1));
		}

		[Test]
		public void Jo_EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Jo, Is.EqualTo(0));
		}

		[Test]
		public void Jeles_UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Jeles, Is.EqualTo(0));
		}

		[Test]
		public void Jeles_EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Jeles, Is.EqualTo(1));
		}

		[Test]
		public void Jeles_EgyBukas_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			Assert.That(dolgozat.Jeles, Is.EqualTo(0));
		}

		[Test]
		public void Gyanus_NegativKivalok_ArgumentExceptiontDob()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.Gyanus(-1));
		}

		[Test]
		public void Gyanus_NincsGyanus_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.IsFalse(dolgozat.Gyanus(1));
		}

		[Test]
		public void Gyanus_VanGyanus_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.IsTrue(dolgozat.Gyanus(0));
		}

		[Test]
		public void Ervenytelen_UresLista_HelyesenMukodik()
		{
			Assert.IsTrue(dolgozat.Ervenytelen);
		}

		[Test]
		public void Ervenytelen_VanErvenytelen_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(10);

			Assert.IsTrue(dolgozat.Ervenytelen);
		}

		[Test]
		public void Ervenytelen_NincsErvenytelen_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			dolgozat.PontFelvesz(20);

			Assert.IsFalse(dolgozat.Ervenytelen);
		}
	}
}