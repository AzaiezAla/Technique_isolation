using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NSubstitute;
using Technique_isolation;

namespace TestTechnique_isolation
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            var auth = new FakeAuthentification();
            var calc = new Calculavencer(auth);
            var result = calc.f1(5);
            Assert.AreEqual(5, result);


        }
        //Test avec Mock 
        // ma3dech te7tej ll FakeAuthentification() 55ater walet el implimantation de une maniaire automatique
        [Test]
        public void TestavecMock()
        {
            var auth =Substitute.For<IAuthentification>();
            auth.Isauthentified().Returns(true);
            var calc = new Calculavencer(auth);
            var result = calc.f1(5);
            Assert.AreEqual(5, result);


        }
    }
}