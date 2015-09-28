using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringInterpolationDemo.Test
{
    [TestClass]
    public class DemoTest
    {
        [TestMethod]
        public void SimpleInterpolation()
        {
            var data = new DemoData() { Id = 100, Name = "David Smith" };

            var message = $"Id is {data.Id} and Name is '{data.Name}'";

            Assert.AreEqual<string>(message, "Id is 100 and Name is 'David Smith'");
        }

        [TestMethod]
        public void InterpolationWithNameOf()
        {
            var data = new DemoData() { Id = 100, Name = "David Smith" };

            var message = $"{nameof(data.Id)} is {data.Id} and {nameof(data.Name)} is '{data.Name}'";

            Assert.AreEqual<string>(message, "Id is 100 and Name is 'David Smith'");
        }

        [TestMethod]
        public void InterpolationWithNullConditional()
        {
            DemoData data = null;
            var message = $"Id is {data?.Id ?? 0} and Name is '{data?.Name ?? @"NONE"}'";

            Assert.AreEqual<string>(message, "Id is 0 and Name is 'NONE'");
        }
    }
}
