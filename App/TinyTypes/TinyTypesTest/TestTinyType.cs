using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TinyTypesTest
{
    [TestClass]
    public class TestTinyType
    {
        [TestMethod]
        public void TestBehaviour()
        {
            #region arrange + act
            Author a1 = new Author("andrei", "ignat");
            Author a2 = new Author(
                new FirstName("andrei"),new LastName( "ignat"));

            Author a3 = new Author(firstName:"andrei",lastName: "ignat");
            #endregion
            #region assert
            Assert.AreEqual(a2.FullName(), a3.FullName());
            Assert.AreEqual(a2.FullName(), a3.FullName());
            #endregion

        }
    }
}