using CalidadT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadT1Test
{
    public class RomanoGeneratorTest
    {
        [Test]
        public void Caso01RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(4);
            Assert.AreEqual("IV", num);
        }

        [Test]
        public void Caso02RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(8);
            Assert.AreEqual("VIII", num);
        }

        [Test]
        public void Caso03RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(10);
            Assert.AreEqual("X", num);
        }

        [Test]
        public void Caso04RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(16);
            Assert.AreEqual("XVI", num);
        }

        [Test]
        public void Caso05RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(30);
            Assert.AreEqual("XXX", num);
        }

        [Test]
        public void Caso06RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(55);
            Assert.AreEqual("LV", num);
        }

        [Test]
        public void Caso07RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(70);
            Assert.AreEqual("LXX", num);
        }

        [Test]
        public void Caso08RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(100);
            Assert.AreEqual("C", num);
        }


        [Test]
        public void Caso09RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(145);
            Assert.AreEqual("CXLV", num);
        }

        [Test]
        public void Caso10RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(155);
            Assert.AreEqual("CLV", num);
        }

        [Test]
        public void Caso11RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(165);
            Assert.AreEqual("CLXV", num);
        }

        [Test]
        public void Caso12RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(170);
            Assert.AreEqual("CLXX", num);
        }

        [Test]
        public void Caso13RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(195);
            Assert.AreEqual("CXCV", num);
        }

        [Test]
        public void Caso14RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(205);
            Assert.AreEqual("CCV", num);
        }

        [Test]
        public void Caso15RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(209);
            Assert.AreEqual("CCIX", num);
        }

        [Test]
        public void Caso16RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(211);
            Assert.AreEqual("CCXI", num);
        }

        [Test]
        public void Caso17RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(214);
            Assert.AreEqual("CCXIV", num);
        }

        [Test]
        public void Caso18RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(444);
            Assert.AreEqual("CDXLIV", num);
        }

        [Test]
        public void Caso19RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(445);
            Assert.AreEqual("CDXLV", num);
        }

        [Test]
        public void Caso20RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(470);
            Assert.AreEqual("CDLXX", num);
        }

        [Test]
        public void Caso21RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(474);
            Assert.AreEqual("CDLXXIV", num);
        }

        [Test]
        public void Caso22RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(479);
            Assert.AreEqual("CDLXXIX", num);
        }

        [Test]
        public void Caso23RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(481);
            Assert.AreEqual("CDLXXXI", num);
        }

        [Test]
        public void Caso24RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(488);
            Assert.AreEqual("CDLXXXVIII", num);
        }

        [Test]
        public void Caso25RomanoGenerator()
        {
            var romano = new RomanoGenerator();
            var num = romano.GetRomano(489);
            Assert.AreEqual("CDLXXXIX", num);
        }
    }
}
