using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        [Owner("Burak")]
        [TestCategory("SimpleTest")]
        public void TestAddition()
        {
            var ifade1 = 15;
            var ifade2 = 20;
            var beklenen = 35;



            double gerceklesen = FirstSimpleExample.Addition(ifade1, ifade2);



            Assert.AreEqual(beklenen,gerceklesen);
        }



        [TestMethod]
        [Owner("Burak")]
        [TestCategory("SimpleTest")]
        public void TestMultiplication()
        {
            var ifade1 = 15;
            var ifade2 = 20;
            var beklenen = 300;



            double gerceklesen = FirstSimpleExample.Multiplication(ifade1, ifade2);



            Assert.AreEqual(beklenen, gerceklesen);
        }



        [TestMethod]
        [ExpectedException(typeof(Exception),AllowDerivedTypes =true)]
        public void TestException1()
        {
            FirstSimpleExample.ExpectedException((3));
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestException2()
        {
            FirstSimpleExample.ExpectedException(3);
        }

        [TestMethod]
        public void TestException3()
        {
            FirstSimpleExample.ExpectedException(3);
        }

        [TestMethod, Timeout(1000)]
        public void TestMethodTimeout()
        {
            Thread.Sleep(1500);
            Assert.AreEqual(1, 1);
        }
    }
}
