using NUnit.Framework;
using Math;

namespace Math
{
    public class Tests
    {
        Class1 cals;

        [SetUp]
        public void Setup()
        {
            cals=new Class1();
                   }

        [TestCase(1,1,2)]
        [TestCase(1,5,6)]
        public void TestAdd(double a, double b, double result)
        {
            double res = cals.Add(a,b);
            Assert.AreEqual(res,result);
        }

        [TestCase(1,1,0)]
        [TestCase(1,5,-4)]
        public void TestMin(double a, double b, double result)
        {
            double res = cals.Min(a,b);
            Assert.AreEqual(res,result);
        }
    }
}