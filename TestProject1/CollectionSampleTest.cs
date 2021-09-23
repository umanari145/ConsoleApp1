using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1.util;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class CollectionSampleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionSample cs = new ConsoleApp1.util.CollectionSample();
            cs.startCollectionSample();

        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionSample cs = new ConsoleApp1.util.CollectionSample();
            List<Dictionary<String, String>> convertSample = cs.ConvertSample();
            cs.sortByCollection(convertSample);
        }

    }
}
