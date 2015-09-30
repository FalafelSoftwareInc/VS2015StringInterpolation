using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringInterpolationDemo.Test
{
    [TestClass]
    public class DemoTest
    {
        [TestMethod]
        public void StringFormatAndConcat()
        {
            var data = new DemoData() { Id = 100, Name = "David Smith" };

            // string.Format
            var message = string.Format("Id is {0} and Name is '{1}'", data.Id, data.Name);
            Assert.AreEqual<string>("Id is 100 and Name is 'David Smith'", message);

            // concat string
            message = "Id is " + data.Id + " and Name is '" + data.Name + "'";
            Assert.AreEqual<string>("Id is 100 and Name is 'David Smith'", message);
        }

        [TestMethod]
        public void SimpleInterpolation()
        {
            var data = new DemoData() { Id = 100, Name = "David Smith" };
            var message = $"Id is {data.Id} and Name is '{data.Name}'";
            Assert.AreEqual<string>("Id is 100 and Name is 'David Smith'", message);
        }


        [TestMethod]
        public void InterpolationWithFormatSpecifier()
        {
            var data = new DemoData() { Id = 100, Name = "David Smith", Birthdate = new DateTime(1970, 2, 25)};
            var message = $"Name is '{data.Name}' and Birthday is {data.Birthdate:M}";
            Assert.AreEqual<string>("Name is 'David Smith' and Birthday is February 25", message);
        }

        [TestMethod]
        public void InterpolationWithNameOf()
        {
            var data = new DemoData() { Id = 100, Name = "David Smith" };
            var message = $"{nameof(data.Id)} is {data.Id} and {nameof(data.Name)} is '{data.Name}'";
            Assert.AreEqual<string>("Id is 100 and Name is 'David Smith'", message);
        }

        [TestMethod]
        public void InterpolationWithNullConditional()
        {
            DemoData data = null;
            var message = $"Id is {data?.Id ?? 0} and Name is '{data?.Name ?? @"NONE"}'";
            Assert.AreEqual<string>("Id is 0 and Name is 'NONE'", message);
        }
    }
}
