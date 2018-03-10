using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TinyTypesTest
{
    class TestConstructor
    {
        public TestConstructor(string firstName)
        {
            FirstName = firstName;
        }

        public string FirstName { get; }
    }
    [TestClass]
    public class TestDocumentation
    {
        [TestMethod]
        public void TestValue()
        {
            var firstName = new FirstName("Jan");

            Assert.AreEqual(firstName.value , "Jan");
        }
        [TestMethod]
        public void TestConstructor()
        {
            var firstName = new FirstName("Jan");
            TestConstructor tc = new TestConstructor(firstName);
            Assert.AreEqual(tc.FirstName, "Jan");
        }
    }
}
