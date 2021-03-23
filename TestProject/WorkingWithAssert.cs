using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{ 

    [TestClass]
    public class WorkingWithAssert
    {
        [TestMethod]
        public void IfadelerEsitOlmali()
        {
            var ifade1 = 15;
            var ifade2 = 20;
            var beklenen = 300;



            double gerceklesen = FirstSimpleExample.Multiplication(ifade1, ifade2);



            Assert.AreEqual(beklenen, gerceklesen);
        }
        
        [TestMethod]
        public void BelliBirBasamakSinirlamak()
        {
            var ifade1 = 15.22;
            var ifade2 = 20.33;

            var beklenen = 309.42;
            var Delta = 0.01;


            double gerceklesen = FirstSimpleExample.Multiplication(ifade1, ifade2);



            Assert.AreEqual(beklenen, gerceklesen, Delta);
        }


        [TestMethod]
        public void BuyukKucukHarfDuyarliligi()
        {
            var beklenen = "helloworld";
            var gerceklesen = "HELLOWORLD";


            Assert.AreEqual(beklenen, gerceklesen,true);
        }


        [TestMethod]
        public void IfadelerEsitOlmamali()
        {
            var ifade1 = 15.22;
            var ifade2 = 20.33;

            var beklenen = 309.42;
            var Delta = 0.01;


            double gerceklesen = FirstSimpleExample.Multiplication(ifade1, ifade2);



            Assert.AreNotEqual(beklenen, gerceklesen, Delta);
        }


        [TestMethod]
        public void İfadeninReferanslarinindaEsitOlmasiDurumu()
        {

            int[] listInt = new int[]
            {
                1,2,3,4,5
            };

            int[] listInt2;

            int firstNumber = listInt[0];
            listInt2 = listInt;

            Assert.AreEqual(firstNumber, listInt[0],"Eşit değil");
            Assert.AreSame(listInt2, listInt, "aynı değil");
            Assert.AreSame(firstNumber, listInt[0], "Aynı değil");



        }

        [TestMethod]
        public void YapılanTestYeterliOlmadıgınıDusunuyorIsek()
        {

            int[] listInt = new int[]
            {
                1,2,3,4,5
            };

            int[] listInt2;

            listInt2 = listInt;

            Assert.AreSame(listInt2, listInt, "aynı değil");
            Assert.Inconclusive("Bu test yeterli değil. Ayrıntılandırılacak...");

        }


    }
}
