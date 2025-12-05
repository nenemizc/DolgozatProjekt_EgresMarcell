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

	}
}
