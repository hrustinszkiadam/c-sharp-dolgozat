using DolgozatProject;

namespace TestDolgozatProject
{
	[TestFixture]
	[Category("PontFelvesz")]
	public class PontFelveszTests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void HelyesAdat_NemDobArgumentExceptiont()
		{
			Assert.DoesNotThrow(() => dolgozat.PontFelvesz(10));
		}

		[Test]
		public void TulNagyAdat_ArgumentExceptiontDob()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(101));
		}

		[Test]
		public void TulKicsiAdat_ArgumentExceptiontDob()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.PontFelvesz(-2));
		}
	}

	[TestFixture]
	[Category("MindenkiMegirta")]
	public class MindenkiMegirtaTests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void MindenkiIgen_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			dolgozat.PontFelvesz(20);

			Assert.IsTrue(dolgozat.MindenkiMegirta());
		}

		[Test]
		public void NemMindenki_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(20);

			Assert.IsFalse(dolgozat.MindenkiMegirta());
		}

		[Test]
		public void UresLista_HelyesenMukodik()
		{
			Assert.IsTrue(dolgozat.MindenkiMegirta());
		}
	}

	[TestFixture]
	[Category("Bukas")]
	public class BukasTests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Bukas, Is.EqualTo(0));
		}

		[Test]
		public void EgyBukas_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			Assert.That(dolgozat.Bukas, Is.EqualTo(1));
		}
		
		[Test]
		public void EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Bukas, Is.EqualTo(0));
		}
	}

	[TestFixture]
	[Category("Elegseges")]
	public class ElegsegesTests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
		}

		[Test]
		public void EgyElegseges_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(55);
			Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
		}

		[Test]
		public void EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
		}
	}

	[TestFixture]
	[Category("Kozepes")]
	public class KozepesTests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
		}

		[Test]
		public void EgyKozepes_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(65);
			Assert.That(dolgozat.Kozepes, Is.EqualTo(1));
		}

		[Test]
		public void EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Kozepes, Is.EqualTo(0));
		}
	}

	[TestFixture]
	[Category("Jo")]
	public class JoTests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Jo, Is.EqualTo(0));
		}

		[Test]
		public void EgyJo_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(75);
			Assert.That(dolgozat.Jo, Is.EqualTo(1));
		}

		[Test]
		public void EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Jo, Is.EqualTo(0));
		}
	}

	[TestFixture]
	[Category("Jeles")]
	public class JelesTests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void UresLista_HelyesenMukodik()
		{
			Assert.That(dolgozat.Jeles, Is.EqualTo(0));
		}

		[Test]
		public void EgyJeles_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.That(dolgozat.Jeles, Is.EqualTo(1));
		}

		[Test]
		public void EgyBukas_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			Assert.That(dolgozat.Jeles, Is.EqualTo(0));
		}
	}

	[TestFixture]
	[Category("Gyanus")]
	public class GyanusTests
	{
		public Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void NegativKivalok_ArgumentExceptiontDob()
		{
			Assert.Throws<ArgumentException>(() => dolgozat.Gyanus(-1));
		}

		[Test]
		public void NincsGyanus_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.IsFalse(dolgozat.Gyanus(1));
		}

		[Test]
		public void VanGyanus_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(90);
			Assert.IsTrue(dolgozat.Gyanus(0));

		}
	}

	[TestFixture]
	[Category("Ervenytelen")]
	public class ErvenytelenTests
	{
		Dolgozat dolgozat;

		[SetUp]
		public void Setup()
		{
			dolgozat = new Dolgozat();
		}

		[Test]
		public void UresLista_HelyesenMukodik()
		{
			Assert.IsTrue(dolgozat.Ervenytelen);
		}

		[Test]
		public void ErvenytelenDolgozat_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(10);

			Assert.IsTrue(dolgozat.Ervenytelen);
		}

		[Test]
		public void ErvenyesDolgozat_HelyesenMukodik()
		{
			dolgozat.PontFelvesz(10);
			dolgozat.PontFelvesz(20);
			dolgozat.PontFelvesz(-1);

			Assert.IsFalse(dolgozat.Ervenytelen);
		}
	}
}