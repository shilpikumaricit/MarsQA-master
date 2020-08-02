using System;
<<<<<<< HEAD
=======
using System.Threading;
using MarsQA.Pages;
using MarsQA.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
using TechTalk.SpecFlow;

namespace MarsQA.StepDefination
{
    [Binding]
    public class AddProfile
    {
<<<<<<< HEAD
        [Given(@"login to Mars application as a seller")]
        public void GivenLoginToMarsApplicationAsASeller()
        {
            ScenarioContext.Current.Pending();
=======
        IWebDriver driver = new ChromeDriver();

        string Url = "http://localhost:5000/";
        string Username = "shilpikumaricit@gmail.com";
        string Password = "Shilpi@01";


        [Given(@"login to Mars application as a seller")]
        public void GivenLoginToMarsApplicationAsASeller()
        {
            LoginPage loginpage = new LoginPage(driver);
            loginpage.login(Url, Username, Password);
            Thread.Sleep(5000);
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [Given(@"navigate to profile page")]
        public void GivenNavigateToProfilePage()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("GivenNavigateToProfilePage");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [When(@"click on the edit button of Description")]
        public void WhenClickOnTheEditButtonOfDescription()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            AddLanguage language = new AddLanguage(driver);
            language.Addlanguage(GenerateRandomString.random());
            Thread.Sleep(5000);
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [Then(@"should be able to Add description")]
        public void ThenShouldBeAbleToAddDescription()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("ThenShouldBeAbleToAddDescription");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [Given(@"loging to Mars Application as a seller")]
        public void GivenLogingToMarsApplicationAsASeller()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("GivenLogingToMarsApplicationAsASeller");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [When(@"click on the edit button of discription")]
        public void WhenClickOnTheEditButtonOfDiscription()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("WhenClickOnTheEditButtonOfDiscription");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [When(@"seller should try to add empty valu in description field")]
        public void WhenSellerShouldTryToAddEmptyValuInDescriptionField()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("WhenSellerShouldTryToAddEmptyValuInDescriptionField");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [Then(@"seller should not able to add empty valu in discription field")]
        public void ThenSellerShouldNotAbleToAddEmptyValuInDiscriptionField()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("ThenSellerShouldNotAbleToAddEmptyValuInDiscriptionField");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [Given(@"as a seller loging to Mars Application")]
        public void GivenAsASellerLogingToMarsApplication()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("GivenAsASellerLogingToMarsApplication");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [Given(@"seller navigate to profile page")]
        public void GivenSellerNavigateToProfilePage()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("GivenSellerNavigateToProfilePage");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [When(@"seller click on the add language button")]
        public void WhenSellerClickOnTheAddLanguageButton()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("WhenSellerClickOnTheAddLanguageButton");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [Then(@"seller should able to add language")]
        public void ThenSellerShouldAbleToAddLanguage()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
=======
            Console.WriteLine("ThenSellerShouldAbleToAddLanguage");
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
        }

        [Then(@"seller should not be able to add language")]
        public void ThenSellerShouldNotBeAbleToAddLanguage()
        {
<<<<<<< HEAD
            ScenarioContext.Current.Pending();
        }

=======
            Console.WriteLine("ThenSellerShouldNotBeAbleToAddLanguage");
        }
        [AfterScenario("deleteTestItem")]
        public void DeleteTestItem()
        {
            driver.Quit();
        }
>>>>>>> 7e8bbc1... Initial check-in of module MarsQA
    }
}
