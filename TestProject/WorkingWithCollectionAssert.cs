using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TestProject
{
    [TestClass]
    public class WorkingWithCollectionAssert
    {

        List<string> list = new List<string>
        {
            "Burak",
            "İbrahim",
            "Muhammed"
        };


        [TestMethod]
        public void ElemanlarAyniveSirasiAyni()
        {
            List<string> newlist = new List<string>
            {
                "Burak",
                "İbrahim",
                "Muhammed"
            };

            CollectionAssert.AreEqual(list, newlist);
        }

        [TestMethod]
        public void ElemanlarAyniveSirasiFarkliOlabilir()
        {
            List<string> newlist = new List<string>
            {
                
                "İbrahim",
                "Muhammed",
                "Burak"
            };

            CollectionAssert.AreEquivalent(list, newlist);
            CollectionAssert.AreEqual(list, newlist);
        }

        [TestMethod]
        public void ElemanlarveSirasiFarkliOlmali()
        {
            List<string> newlist = new List<string>
            {

                "İbrahim",
                "Muhammed",
                "Cemil"
            };

            CollectionAssert.AreNotEqual(list, newlist);
        }

        [TestMethod]
        public void ElemanlarFarkliOlmali()
        {
            List<string> newlist = new List<string>
            {

                "İbrahim",
                "Muhammed",
                "Cemil",
                "Cumali"
            };

            CollectionAssert.AreNotEquivalent(list, newlist);
        }


        [TestMethod]
        public void NulDegerOlmamali()
        {
            List<string> newlist = new List<string>
            {

                "İbrahim",
                "Muhammed",
                "Cemil",
                "Cumali",
                null
            };

            CollectionAssert.AllItemsAreNotNull(newlist);
        }


        [TestMethod]
        public void ElemanlarBenzersizOlmali()
        {
            List<string> newlist = new List<string>
            {

                "İbrahim",
                "Muhammed",
                "Cemil",
                "Cumali",
                "Cumali",
                "Cumali"

            };

            CollectionAssert.AllItemsAreUnique(newlist);
        }



        [TestMethod]
        public void TümElemanlarAyniTipteOlmali()
        {
            ArrayList arrayList = new ArrayList
            {
                1,"burak",1.5,true
            };

            CollectionAssert.AllItemsAreInstancesOfType(arrayList,typeof(string));
        }


        [TestMethod]
        public void Elemanİçeriyormu()
        {
            ArrayList arrayList = new ArrayList
            {
                1,"burak",1.5,true
            };

            CollectionAssert.Contains(arrayList,"burak");
        }

        [TestMethod]
        public void VerilenListeAltKumesimi()
        {
            List<string> newlist = new List<string>
            {
                "İbrahim"
               
            };

            CollectionAssert.IsSubsetOf(newlist, list);
        }

    }
}
