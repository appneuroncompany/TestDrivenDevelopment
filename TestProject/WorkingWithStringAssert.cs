using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestClass]
    public class WorkingWithStringAssert
    {
        [TestMethod]
        public void VerilenStringiIceriyormu() 
        {
            StringAssert.Contains("merhaba dunya ben burak", "en");
        }

        [TestMethod]
        public void VerilenStringIleBaslıyormu()
        {
            StringAssert.Contains("merhaba dunya ben burak", "mer");
        }

        [TestMethod]
        public void VerilenStringIleBitiyormu()
        {
            StringAssert.Contains("merhaba dunya ben burak", "rak");
        }

    }
}
