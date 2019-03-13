using System;
using System.Collections.Generic;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fizzbuzz.tests
{
    [TestClass]
    public class FizzBuzzJazzTests
    {
        [TestMethod]
        public void CountFuzzJazz()
        {
            FizzBuzzService service = new FizzBuzzService();
            List<string> list = (List<string>)service.GetJazzFuzz();
            int jazzCount = 0;
            int fuzzCount = 0;
            foreach (var i in list)
            {
                if (i.Contains("Fuzz"))
                    fuzzCount++;
                if (i.Contains("Jazz"))
                    jazzCount++;
            }

            for (int x = 1; x <= 100 / 9; x++)
            {
                Assert.IsTrue(list[100-(4 * x)].Contains("Fuzz"));
                Assert.IsTrue(list[100-(9 * x)].Contains("Jazz"));
            }

            Assert.AreEqual(list.Count, 100);
            Assert.AreEqual(list.Count / 9, jazzCount);
            Assert.AreEqual(list.Count / 4, fuzzCount);
        }

        [TestMethod]
        public void CountFizzBuzz()
        {
            FizzBuzzService service = new FizzBuzzService();
            List<string> list = (List<string>)service.GetFizzBuzz();
            int fizzCount = 0;
            int buzzCount = 0;
            foreach (var i in list)
            {
                if (i.Contains("Fizz"))
                    fizzCount++;
                if (i.Contains("Buzz"))
                    buzzCount++;
            }
            for (int x = 1; x <= 100 / 5; x++)
            {
                Assert.IsTrue(list[(3 * x) - 1].Contains("Fizz"));
                Assert.IsTrue(list[(5 * x) - 1].Contains("Buzz"));
            }

            Assert.AreEqual(list.Count, 100);
            Assert.AreEqual(list.Count / 3, fizzCount);
            Assert.AreEqual(list.Count / 5, buzzCount);

        }
    }
}
