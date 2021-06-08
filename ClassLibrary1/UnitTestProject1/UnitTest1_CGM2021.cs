using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_CGM2021;

namespace Examen3EV_CGM2021
{
    [TestClass]
    public class UnitTest1_CGM2021
    {
        [TestMethod]
        public void CompruebaNotas_Fallido1()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.14;
            int suspensosEsperados = 3;
            int aprobadosEsperados = 1;
            int notablesEsperados = 2;
            int sobresalientesEsperados = 1;

            try
            {
                estadisticaNotas_CGM2021 nuevaEstadistica = new estadisticaNotas_CGM2021();
                double media = nuevaEstadistica.CalcularEstadistica_CGM2021(notas);

                Assert.AreEqual(suspensosEsperados, nuevaEstadistica.Suspenso);
                Assert.AreEqual(aprobadosEsperados, nuevaEstadistica.Aprobado);
                Assert.AreEqual(notablesEsperados, nuevaEstadistica.Notable);
                Assert.AreEqual(sobresalientesEsperados, nuevaEstadistica.Sobresaliente);
                Assert.AreEqual(mediaEsperada, media);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message,estadisticaNotas_CGM2021.mensajeDeError);
            }
        }

        [TestMethod]
        public void CompruebaNotas_Corecto()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(1);
            notas.Add(1);
            notas.Add(1);
            notas.Add(5);
            notas.Add(5);
            notas.Add(8);
            notas.Add(8);
            notas.Add(10);
            notas.Add(10);

            double mediaEsperada = 4.9;
            int suspensosEsperados = 4;
            int aprobadosEsperados = 2;
            int notablesEsperados = 2;
            int sobresalientesEsperados = 2;

            try
            {
                estadisticaNotas_CGM2021 nuevaEstadistica = new estadisticaNotas_CGM2021();
                double media = nuevaEstadistica.CalcularEstadistica_CGM2021(notas);

                Assert.AreEqual(suspensosEsperados, nuevaEstadistica.Suspenso);
                Assert.AreEqual(aprobadosEsperados, nuevaEstadistica.Aprobado);
                Assert.AreEqual(notablesEsperados, nuevaEstadistica.Notable);
                Assert.AreEqual(sobresalientesEsperados, nuevaEstadistica.Sobresaliente);
                Assert.AreEqual(mediaEsperada, media);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}
