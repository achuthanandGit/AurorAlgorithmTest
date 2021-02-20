using NUnit.Framework;
using System.Collections.Generic;
using AurorAlgorithmAssessment;

namespace AurorAlgorithmUnitTest
{
    [TestFixture]
    public class StringInterpolationTest
    {

        private StringInterpolation _strIntepolation;

        [SetUp]
        public void Setup()
        {
            _strIntepolation = new StringInterpolation();
        }

        [Test]
        public void Test_Actual_Equals_Expected()
        {
            Assert.AreEqual("Hello Jim", 
                actual: _strIntepolation.Interpolate("Hello [name]", new Dictionary<string, string> { { "name", "Jim" } }));
        }

        [Test]
        public void Test_Actual_Not_Equals_Expected()
        {
            Assert.AreNotEqual("Hello [name]", 
                actual: _strIntepolation.Interpolate("Hello [name]", new Dictionary<string, string> { { "name", "Jim" } }));
        }

        [Test]
        public void Test_Escapes_With_Double_Bracket()
        {
            Assert.AreEqual("Hello Jim [author]", 
                actual: _strIntepolation.Interpolate("Hello [name] [[author]]", new Dictionary<string, string> { { "name", "Jim" } }));
        }

        [Test]
        public void Test_With_No_Value_In_Dict()
        {
            Assert.AreEqual("Hello [name]", 
                actual: _strIntepolation.Interpolate("Hello [name]", new Dictionary<string, string> { { "nickname", "Jim" } }));
        }

        [Test]
        public void Test_with_UnEqual_Brackets()
        {
            Assert.AreEqual("Hello Jim [[author]",
                actual: _strIntepolation.Interpolate("Hello [name] [[author]", new Dictionary<string, string> { { "name", "Jim" } }));
        }


    }
}