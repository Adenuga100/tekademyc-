using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using NUnit.Framework;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekademy1C.PageObjects;
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

        [When("user enter display order")]
        public async Task WhenUserEnterDisplayOrder()
        {
            await _tekademypage.enterDisplayed();
        }


        [When("user enter category name {string}")]
        public async Task WhenUserEnterCategoryName(string categoryName)
        {
            await _tekademypage.enterCategoryNameAsync(categoryName);
        }

        [When("user clear category name")]
        public async Task WhenUserClearCategoryName()
        {
            await _tekademypage.clearCategoryNameAsync();
        }


        [When("user enter existing category name {string}")]
        public async Task WhenUserEnterExistingCategoryName(string name)
        {
            await _tekademypage.existingCategoryName(name);
        }


        [When("user click on checkbox")]
        public async Task WhenUserClickOnCheckbox()
        {
            await _tekademypage.clickCheckbox();
        }

        [When("user click on {string} menus")]
        public async Task WhenUserClickOnMenus(string menus)
        {
            await _tekademypage.clickMenus(menus);
        }

        [When("user select categories")]
        public async Task WhenUserSelectCategories()
        {
            await _tekademypage.selectCategory();
        }


        [When("user click on {string} button")]
        public async Task WhenUserClickOnButton(string button)
        {
            await _tekademypage.clickButton(button);
        }

        [When("User click on Delete button")]
        public async Task WhenUserClickOnDeleteButton()
        {
            await _tekademypage.deletebutn();
        }

        [When("User click on Edit button")]
        public async Task WhenUserClickOnEditButton()
        {
            await _tekademypage.editbtn();
        }



        [When("user click on x button")]
        public async Task WhenUserClickOnXButton()
        {
            await _tekademypage.clickXButton();
        }


        [Then("user is unable to click on {string} button")]
        public async Task ThenUserIsUnableToClickOnButton(string button)
        {
            await _tekademypage.unableToClick(button);
        }

        [When("user enter title {string}")]
        public async Task WhenUserEnterTitle(string title)
        {
            await _tekademypage.enterTitleAsync(title);
        }

        [When("user clear title field")]
        public async Task WhenUserClearTitleField()
        {
            await _tekademypage.clearTitle();
        }

        [When("user unclick Publish immediately")]
        public async Task WhenUserUnclickPublishImmediately()
        {
            await _tekademypage.unCheckPublishImmediatelyAsync();
        }


        [When("user select a file {string}")]
        public async Task WhenUserSelectAFile(string filePath)
        {
            await _tekademypage.selectFileAsync(filePath);
        }


        [When("user enter tags {string}")]
        public async Task WhenUserEnterTags(string tags)
        {
            // Implementation for entering tags
            await _tekademypage.enterTagsAsync(tags);
        }


        [When("user enter descriptions {string}")]
        public async Task WhenUserEnterDescriptions(string descriptions)
        {
            await _tekademypage.enterDescription(descriptions);

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

        [Then("user redirected to {string} page")]
        public async Task ThenUserRedirectedToPage(string page)
        {
            await _tekademypage.redirectedTopage(page);
        }


        [Then("User should be logged in")]
        public async Task ThenUserShouldBeLoggedIn()
        {
            await _tekademypage.Dashboard();
        }

    }
}
