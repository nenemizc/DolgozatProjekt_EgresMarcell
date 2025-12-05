using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatProjekt.Tests
{
	[TestFixture]
	internal class DolgozatTest
	{
		Dolgozat dolgozat;

		[SetUp]
		public void SetUp()
		{
			dolgozat = new Dolgozat();
		}
		[Test]
		public void PontFelveszHibas()
		{
			Assert.Throws<ArgumentException>(() =>
			{
				dolgozat.PontFelvesz(-13);
			});
		}

		[Test]
		public void PontFelveszJo()
		{
			dolgozat.PontFelvesz(13);
			Assert.That(dolgozat.Pontok[0] == 13);
		}

		[Test]
		public void PontFelveszHatar()
		{
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(100);
			Assert.That(dolgozat.Pontok[0] == -1 && dolgozat.Pontok[1] == 100);
		}

		[Test]
		public void MindenkiMegIrtaHibas()
		{
			Assert.Throws<SenkiSemIrtException>(() =>
			{
				dolgozat.MindenkiMegirta();
			});
		}

		[Test]
		public void MinednkiMegIrtaIgen()
		{
			dolgozat.PontFelvesz(13);
			dolgozat.PontFelvesz(0);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(74);
			dolgozat.PontFelvesz(67);

			Assert.That(dolgozat.MindenkiMegirta());
		}

		[Test]
		public void MindenkiMegIrtaNem()
		{
			dolgozat.PontFelvesz(13);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(74);
			dolgozat.PontFelvesz(67);

			Assert.That(!dolgozat.MindenkiMegirta());
		}

		[Test]
		public void BukasVan()
		{
			dolgozat.PontFelvesz(13);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Bukas() == 1);
		}

		[Test]
		public void BukasNincs()
		{
			dolgozat.PontFelvesz(53);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Bukas() == 0);
		}

		[Test]
		public void BukasHatar()
		{
			dolgozat.PontFelvesz(50);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(49);
			dolgozat.PontFelvesz(0);
			

			Assert.That(dolgozat.Bukas() == 2);
		}

		[Test]
		public void ElegsegesVan()
		{
			dolgozat.PontFelvesz(53);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Elegseges() == 1);
		}

		[Test]
		public void ElegsegesNincs()
		{
			dolgozat.PontFelvesz(13);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Elegseges() == 0);
		}

		[Test]
		public void ElegsegesHatar()
		{
			dolgozat.PontFelvesz(50);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(60);
			dolgozat.PontFelvesz(61);


			Assert.That(dolgozat.Elegseges() == 2);
		}

		[Test]
		public void KozepesVan()
		{
			dolgozat.PontFelvesz(63);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Kozepes() == 1);
		}

		[Test]
		public void KozepesNincs()
		{
			dolgozat.PontFelvesz(13);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Kozepes() == 0);
		}

		[Test]
		public void KozepesHatar()
		{
			dolgozat.PontFelvesz(61);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(70);
			dolgozat.PontFelvesz(71);


			Assert.That(dolgozat.Kozepes() == 2);
		}

		[Test]
		public void JoVan()
		{
			dolgozat.PontFelvesz(73);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Jo() == 1);
		}

		[Test]
		public void JoNincs()
		{
			dolgozat.PontFelvesz(13);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Jo() == 0);
		}

		[Test]
		public void JoHatar()
		{
			dolgozat.PontFelvesz(71);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(80);
			dolgozat.PontFelvesz(81);


			Assert.That(dolgozat.Jo() == 2);
		}

		[Test]
		public void JelesVan()
		{
			dolgozat.PontFelvesz(83);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Jeles() == 1);
		}

		[Test]
		public void JelesNincs()
		{
			dolgozat.PontFelvesz(13);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Jeles() == 0);
		}

		[Test]
		public void JelesHatar()
		{
			dolgozat.PontFelvesz(81);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(80);
			dolgozat.PontFelvesz(100);


			Assert.That(dolgozat.Jeles() == 2);
		}

		[Test]
		public void GyanusHibas()
		{
			Assert.Throws<ArgumentException>(() =>
			{
				dolgozat.Gyanus(-13);
			});
		}

		[Test]
		public void GyanusIgen()
		{
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(100);

			Assert.That(dolgozat.Gyanus(1));
		}

		[Test]
		public void GyanusNem()
		{
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(100);

			Assert.That(!dolgozat.Gyanus(4));
		}

		[Test]
		public void ErvenytelenIgen()
		{
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Ervenytelen());
		}

		[Test]
		public void ErvenytelenHatar()
		{
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(-1);
			dolgozat.PontFelvesz(-1);

			Assert.That(dolgozat.Ervenytelen());
		}

		[Test]
		public void ErvenytelenNem()
		{
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(100);
			dolgozat.PontFelvesz(-1);

			Assert.That(!dolgozat.Ervenytelen());
		}
	}
}
