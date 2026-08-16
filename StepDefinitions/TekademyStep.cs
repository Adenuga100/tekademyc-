using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekademy1C.PageObjects;
using Microsoft.Playwright;
using NUnit.Framework;
using Reqnroll;
using Tekademy1C_.Drivers;

//namespace Tekademy1C.StepDefinitions
//{
//    internal class TekademyStep
//    {
//    }
//}

//using Reqnroll;
//using Tekademy1C_.Drivers;
//using Tekademy1C_.Pages;

namespace Tekademy1C_.StepDefinitions
{
    [Binding]
    public class TekademyStep
    {
        private readonly PlaywrightDriver _driver;
        private Tekademypage _tekademypage;

        public TekademyStep(PlaywrightDriver driver)
        {
            _driver = driver;
        }

        //[Given("I open the calculator application")]
        //public async Task GivenIOpenTheCalculatorApplication()
        //{
        //    _tekademypage = new Tekademypage(_driver.Page);

        //    await _tekademypage.OpenAsync();
        //}

        [Given("User navigates to takademy {string}")]
        public async Task GivenUserNavigatesToTakademyAsync(string url)
        {
            _tekademypage = new Tekademypage(_driver.Page);

            await _tekademypage.OpenAsync(url);
        }

        [When("User enters  email {string}")]
        public async Task WhenUserEntersEmail(string email)
        {
            await _tekademypage.enterEmailAsync(email);
        }

        [When("User enters  password {string}")]
        public async Task WhenUserEntersPassword(string password)
        {
            await _tekademypage.enterPasswordAsync(password);
        }

        [When("User clicks on login button")]
        public async Task WhenUserClicksOnLoginButton()
        {
            await _tekademypage.clickLoginButton();
        }

        [When("user click on checkbox")]
        public async Task WhenUserClickOnCheckbox()
        {
            await _tekademypage.clickCheckbox();
        }


        [Then("the page should be displayed")]
        public async Task ThenThePageShouldBeDisplayed()
        {
            var title = await _tekademypage.GetTitleAsync();

            Assert.That(title, Does.Contain("Google"));
        }

        [Then("A message should be displayed {string}")]
        public async Task ThenAMessageShouldBeDisplayed(string message)
        {
            await _tekademypage.displayedMessage(message);
        }


        [Then("User should be logged in")]
        public async Task ThenUserShouldBeLoggedIn()
        {
            await _tekademypage.Dashboard();
        }

    }
}
