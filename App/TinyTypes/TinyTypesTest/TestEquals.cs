using Microsoft.VisualStudio.TestTools.UnitTesting;
using TinyTypesObjects;

namespace TinyTypesTest
{
    [TestClass]
    public class TestTinyTypeEquals
    {
        [TestMethod]
        public void TestSimpleStringEquals()
        {
            #region arrange
            string s = "http://msprogrammer.serviciipeweb.ro";
            #endregion
            #region act
            TinyType<string> tt1 = s;
            TinyType<string> tt2 = s;
            #endregion
            #region assert
            Assert.IsTrue(tt1.Equals(tt2));
            Assert.AreEqual(tt1, tt2);
            Assert.AreEqual<string>(tt1, tt2);
            Assert.AreEqual<TinyType<string>>(tt1, tt2);
            Assert.AreEqual<string>(s, tt2);
            #endregion
        }
        [TestMethod]
        public void TestSimpleIntEquals()
        {
            #region arrange
            int s = 1;
            #endregion
            #region act
            TinyType<int> tt1 = s;
            TinyType<int> tt2 = s;
            #endregion
            #region assert
            Assert.IsTrue(tt1.Equals(tt2));
            Assert.AreEqual(tt1, tt2);
            Assert.AreEqual<int>(tt1, tt2);
            Assert.AreEqual<TinyType<int>>(tt1, tt2);
            Assert.AreEqual<int>(s, tt2);
            
            #endregion
        }

    }
}
