using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //preparación
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.143;
            int suspendidosEsperados = 3;
            int aprobadosEsperados = 1;
            int notablesEsperados = 2;
            int sobresalientesEsperados = 1;

            //para probar
            notas.calcEst(notas.List<int>);

            double media = notas.Media;

            //Comprobación
            Assert.AreEqual(mediaEsperada, media);
        }
    }
}
