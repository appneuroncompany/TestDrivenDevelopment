using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestDotNetFramework
{
    [TestClass]
    public class DataDrivenTest
    {
        private TestContext testContext;
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }



        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                   @"D:\GitHub\CSharpLessonsProjects\TestDrivenDevelopment\UnitTestDotNetFramework\Data.xml",
                   "Number", DataAccessMethod.Sequential)]
        [TestMethod()]
        public void TestMethod1()
        {
            int number = Convert.ToInt32(TestContext.DataRow["Size"]);
            bool result = number >= 0;
            Assert.IsTrue(result);
        }



    }
}
