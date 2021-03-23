using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestClass]
    public class WorkingWithTestContext
    {

        private static TestContext ClassTestContext { get; set; } // global class test context

        [ClassInitialize]
        public static void TestContextInitialize(TestContext testContext)
        {
            ClassTestContext = testContext;
            testContext.WriteLine("Baslangıc");
            testContext.WriteLine(" Test adı: {0}", testContext.TestName);
            testContext.WriteLine(" Test durumu: {0}", testContext.CurrentTestOutcome);
            testContext.Properties["bilgi"] = "Bu bir TestContext çalışmasıdır!";
        }

        [TestCleanup]
        public static void TestContextCleanup()
        {
            ClassTestContext.WriteLine("bitis");
            ClassTestContext.WriteLine(" Test adı: {0}", ClassTestContext.TestName);
            ClassTestContext.WriteLine(" Test durumu: {0}", ClassTestContext.CurrentTestOutcome);
        } 


        [TestMethod]
        public void TestContextMethod()
        {
            ClassTestContext.WriteLine(" Test sınıfı: {0}", ClassTestContext.FullyQualifiedTestClassName);
            ClassTestContext.WriteLine(" Test adı: {0}", ClassTestContext.TestName);
            ClassTestContext.WriteLine(" Test durumu: {0}", ClassTestContext.CurrentTestOutcome);
            ClassTestContext.WriteLine(" Test bilgisi: {0}", ClassTestContext.Properties["bilgi"]);

            Assert.AreEqual(1,1);
        }


    }
}
