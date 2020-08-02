using System.Threading;
using MarsQA.Pages;
using MarsQA.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MarsQA
{
    public class Tests
    {

        IWebDriver driver = new ChromeDriver();

        string Url = "http://localhost:5000/";
        string Username = "shilpikumaricit@gmail.com";
        string Password = "Shilpi@01";
        [SetUp]
        public void Setup()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.login(Url,Username,Password);
            Thread.Sleep(5000);
        }

        [Test]
        public void Test1()
        {
            AddLanguage language = new AddLanguage(driver);
            language.Addlanguage(GenerateRandomString.random());
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}