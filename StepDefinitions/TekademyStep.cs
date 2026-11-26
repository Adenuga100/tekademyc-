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
using System.Xml.Linq;
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


        [When("user select any role")]
        public async Task WhenUserSelectAnyRole()
        {
            await _tekademypage.userSelectAnyRole();
        }

        [When("user select any roles")]
        public async Task WhenUserSelectAnyRoles()
        {
            await _tekademypage.userSelectAnyRoles();
        }

        [When("user select any roles{string}")]
        public async Task WhenUserSelectAnyRoles(string super)
        {
            await _tekademypage.userSelectSuperRoles(super);
        }

        [When("user select any role {string}")]
        public async Task WhenUserSelectAnyRole(string role)
        {
            await _tekademypage.userSelectARole(role);
        }


        [When("user enter password {string}")]
        public async Task WhenUserEnterPassword(string pass)
        {
            await _tekademypage.enterPassword(pass);
        }

        [Then("user is able to see the password he or she entered in the password field")]
        public async Task ThenUserIsAbleToSeeThePasswordHeOrSheEnteredInThePasswordField()
        {
            await _tekademypage.isAbleToSeeThePasswordHeOrSheEnteredInThePasswordField();

        }

        [Then("user is unable to see the password he or she entered in the password field")]
        public async Task ThenUserIsUnableToSeeThePasswordHeOrSheEnteredInThePasswordField()
        {
            await _tekademypage.isUnableToSeeThePasswordHeOrSheEnteredInThePasswordField();
        }


        [When("user click on eye icon on password field")]
        public async Task WhenUserClickOnEyeIconOnPasswordField()
        {
            await _tekademypage.eyeIconOnPasswordField();
        }

        [When("user click on eye hide icon password field")]
        public async Task WhenUserClickOnEyeHideIconPasswordField()
        {
            await _tekademypage.eyeHideIconOnPasswordField();
        }


        [When("user enter date of birth")]
        public async Task WhenUserEnterDateOfBirth()
        {
            await _tekademypage.enterDateOfBirth();
        }

        [When("user enters date of birth")]
        public async Task WhenUserEntersDateOfBirth()
        {
            await _tekademypage.enterLeast13DateOfBirth();
        }

        [When("user enter last name")]
        public async Task WhenUserEnterLastName()
        {
            await _tekademypage.enterLastName();
        }

        [When("user enter email {string}")]
        public async Task WhenUserEnterEmail(string email)
        {
            await _tekademypage.enterEmailAddress(email);
        }

        [When("user enter email")]
        public async Task WhenUserEnterEmail()
        {
            await _tekademypage.enterEmailAsync();
        }

        [When("user enter first name")]
        public async Task WhenUserEnterFirstName()
        {
            await _tekademypage.enterFirstName();
        }

        [When("user click on checkbox")]
        public async Task WhenUserClickOnCheckbox()
        {
            await _tekademypage.clickCheckbox();
        }

        [When("user click assign icon")]
        public async Task WhenUserClickAssignIcon()
        {
            await _tekademypage.clickAssignIcon();
        }

        [When("user click suspended icon")]
        public async Task WhenUserClickSuspendedIcon()
        {
            await _tekademypage.clickSuspendedIcon();
        }

        [When("user click on active icon")]
        public async Task WhenUserClickOnActiveIcon()
        {
            await _tekademypage.clickActiveIcon();
        }

        [When("user click on delete icon")]
        public async Task WhenUserClickOnDeleteIcon()
        {
            await _tekademypage.clickDeleteIcon();
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

        [When("user enter {string} on search bar")]
        public async Task WhenUserEnterOnSearchBar(string name)
        {
            await _tekademypage.userEnterOnSearchBar(name);
        }

        [When("user select any role on all roles field")]
        public async Task WhenUserSelectAnyRoleOnAllRolesField()
        {
            await _tekademypage.userSelectAnyRoleOnAllRolesField();
        }

        [When("user select any roles on all roles field")]
        public async Task WhenUserSelectAnyRolesOnAllRolesField()
        {
            await _tekademypage.userSelectAnyRolesOnAllRolesField();
        }

        [When("user select any status on all status field")]
        public async Task WhenUserSelectAnyStatusOnAllStatusField()
        {
            await _tekademypage.userSelectAnyStatusOnAllStatusField();
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

        [Then("user verify the picked role is equal to the role on the user management page")]
        public async Task ThenUserVerifyThePickedRoleIsEqualToTheRoleOnTheUserManagementPage()
        {
            await _tekademypage.pickedRole();
        }

        [Then("user verify the active user as be suspended user management page")]
        public async Task ThenUserVerifyTheActiveUserAsBeSuspendedUserManagementPage()
        {
            await _tekademypage.suspendedRole();
        }

        [Then("user verify the suspended user as be Active user management page")]
        public async Task ThenUserVerifyTheSuspendedUserAsBeActiveUserManagementPage()
        {
            await _tekademypage.activeRole();
        }

        [Then("user verify the delete user has been deleted user management page")]
        public async Task ThenUserVerifyTheDeleteUserHasBeenDeletedUserManagementPage()
        {
            await _tekademypage.userVerifyTheDeleteUserHasBeenDeletedUserManagementPage();
        }

        [Then("user verify user have not delete")]
        public async Task ThenUserVerifyUserHaveNotDelete()
        {
            await _tekademypage.UserVerifyUserHaveNotDelete();
        }

        

        [Then("user view the search name under {string} on the table")]
        public async Task ThenUserViewTheSearchNameUnderOnTheTable(string table)
        {
            await _tekademypage.userViewTheSearchNameOnTheTable(table);

        }


        [Then("A password message should be displayed {string}")]
        public async Task ThenAPasswordMessageShouldBeDisplayed(string p0)
        {
            await _tekademypage.passwordMessageShouldBeDisplayed();
        }

        [Then("A message should be displayed {string} on {string} field")]
        public async Task ThenAMessageShouldBeDisplayedOnField(string pop, string locator)
        {
            await _tekademypage.aMessageShouldBeDisplayedOnField(pop, locator);
        }

        [Then("user redirected to {string} page")]
        public async Task ThenUserRedirectedToPage(string page)
        {
            await _tekademypage.redirectedTopage(page);
        }


        [Then("User should be logged in")]
        public async Task ThenUserShouldBeLoggedIn()
        {
            await _tekademypage.VerifyDashboardIsVisible();
        }

    }
}
