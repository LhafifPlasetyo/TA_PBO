using WindowsFormsApp3;
using System.Data.SqlClient;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float expected_tagihan = 10000;
            Akun test = new Akun();
            test.plus_tagihan();
            Assert.AreEqual(test.tagihan, expected_tagihan, 0.0001, "Code Error");

        }
    }
}