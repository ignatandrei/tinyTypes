using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinyTypesObjects;

namespace TinyTypesTest
{
    [TestClass]
    public class TestTinyTypeOperatorEqual
    {
        [TestMethod]
        public void TestSimpleIntOperatorEqual()
        {
            int nr = 7;
            TinyType<int> tt1 = nr;
            TinyType<int> tt2 = nr;

            Assert.AreEqual(tt1, tt2);
            Assert.IsFalse(tt1 == tt2);
        }
        [TestMethod]
        public void TestSimpleStringOperatorEqual()
        {
            string s = "http://msprogrammer.serviciipeweb.ro";
            TinyType<string> tt1 = s;
            TinyType<string> tt2 = s;

            Assert.AreEqual(tt1, tt2);
            Assert.IsFalse(tt1 == tt2);
        }
        [TestMethod]
        public void TestSimpleStringOperatorEqualWorks()
        {
            string s = "http://msprogrammer.serviciipeweb.ro";

            TinyTypeOfString tt1 = s;
            TinyTypeOfString tt2 = s;

            Assert.AreEqual(tt1, tt2);
            Assert.IsTrue(tt1 == tt2);
        }

        [TestMethod]
        public void TestSimpleIntOperatorEqualWorks()
        {
            int nr = 7;
            TinyTypeOf<int> tt1 = nr;
            TinyTypeOf<int> tt2 = nr;

            Assert.AreEqual(tt1, tt2);
            Assert.IsTrue(tt1 == tt2);
        }
        [TestMethod]
        public void TestSimpleIntNrOperatorEqualWorks()
        {
            int nr = 7;
            TinyType<int> tt1 = nr;
            
            Assert.AreEqual(tt1, nr);
            Assert.IsTrue(tt1 == nr);
        }
    }
}
