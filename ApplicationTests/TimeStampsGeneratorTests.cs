﻿using System;
using System.Linq;
using AnalysesEngine.Core.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApplicationTests
{
    [TestClass]
    public class TimeStampsGeneratorTests
    {
        [TestMethod]
        public void TestTimeStampsGeneration()
        {
            // testing that we get 6 timestamps
            var st = DateTime.Today.AddDays(-5);
            var et = DateTime.Today;
            var tsList = TimeStampsGenerator.Get(TimeSpan.FromDays(1),st,et );

            Assert.IsTrue(tsList.Count == 6, "has 6 timestamps");
            Assert.IsTrue(tsList[0]==st,"st is there");
            Assert.IsTrue(tsList[5]==et,"et is there");
            
        }

        [TestMethod]
        public void TestTimeStampsGenerationSingleDay()
        {
            // testing that we get st et
            var st = DateTime.Today;
            var et = DateTime.Now;
            var tsList = TimeStampsGenerator.Get(TimeSpan.FromDays(1), st, et);

            Assert.IsTrue(tsList.Count == 2, "has 2 timestamps");
            Assert.IsTrue(tsList[0] == st, "st is there");
            Assert.IsTrue(tsList[1] == et, "et is there");

        }
    }
}
