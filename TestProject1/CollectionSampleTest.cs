using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1.util;
using System.Collections.Generic;
using ConsoleApp1.Util;

namespace TestProject1
{
    [TestClass]
    public class CollectionSampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionSample cs = new CollectionSample();
            cs.StartCollectionSample();

        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionSample cs = new CollectionSample();
            List<Dictionary<String, String>> convertSample = cs.ConvertSample();
            cs.SortByCollection(convertSample);
        }

        [TestMethod]
        public void TestMethod3()
        {
            CollectionClassSample cs = new CollectionClassSample();
            cs.StartCollectionSample();

        }

    }
}
