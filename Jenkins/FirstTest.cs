using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Jenkins
{
    public class Tests
    {
        ChromeDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.by/");
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(true);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}