using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static Microsoft.Playwright.Assertions;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Tekademy1C.PageObjects
//{
//    internal class Tekademypage
//    {
//    }
//}


namespace Tekademy1C.PageObjects
{
    public class Tekademypage
    {
        private readonly IPage _page;

        public Tekademypage(IPage page)
        {
            _page = page;
        }

        public ILocator emailInput()
        {
            return _page.Locator("input[id='email']");
        }

        public ILocator passwordInput()
        {
            return _page.Locator("input[id='password']");
        }

        public ILocator loginbtn()
        {
            return _page.Locator("button[type='submit']");
        }

        public ILocator selectRoles()
        {
            return _page.Locator("[class='flex flex-wrap gap-2'] [type='button']") // Update 'label' to match your role container/checkbox locator
                .Filter(new LocatorFilterOptions { HasNotText = "SuperAdmin" });
        }

        public ILocator selectARole(string role)
        {
            return _page.Locator("[class='flex flex-wrap gap-2'] [type='button']") // Update 'label' to match your role container/checkbox locator
                .Filter(new LocatorFilterOptions { HasText = role });
        }

        public ILocator firstname()
        {
            return _page.Locator("input[id='user-firstName']");
        }

        public ILocator password()
        {
            return _page.Locator("input[id='user-password']");
        }

        public ILocator eyeIcon()
        {
            return _page.Locator("button[aria-label='Show password']");
        }

        public ILocator eyeHideIcon()
        {
            return _page.Locator("button[aria-label='Hide password']");
        }
        
        public ILocator lastname()
        {
            return _page.Locator("input[id='user-lastName']");
        }

        public ILocator userDateOfBirth()
        {
            return _page.Locator("input[id='user-dateOfBirth']");
        }
        
        public ILocator emailAddress()
        {
            return _page.Locator("input[id='user-email']");
        }

        public ILocator checkBox()
        {
            return _page.Locator("input[type='checkbox']");
        }

        public ILocator menu(string menus)
        {
            return _page.GetByRole(AriaRole.Link, new() { Name = $"{menus}" });
            //return _page.Locator($"span:has-text('{menus}')");
        }

        public ILocator select()
        {
            return _page.Locator("select");
        }

        public ILocator buttons(string button)
        {
            return _page.GetByRole(AriaRole.Button, new() { Name = button });
        }
        public ILocator xButton()
        {
            return _page.Locator("span:has-text('Close')");
        }

        public ILocator enterTitle()
        {
            return _page.Locator("input[id='resource-title']");
        }

        public ILocator unCheckPublishImmediately()
        {
            return _page.Locator("input[type='checkbox']");
        }

        public ILocator selectFileAsync()
        {
            return _page.Locator("input[type='file']");
        }

        public ILocator enterTags()
        {
            return _page.Locator("input[id='resource-tags']");
        }

        public ILocator enterDescriptions()
        {
            return _page.Locator("textarea[id='resource-description']");
        }

        public ILocator Dashboard()
        {
            return _page.GetByAltText("Tekademy");
        }
        public ILocator displayed(string message)
        {
            
            return _page.GetByText(message).First;
        }

        public ILocator passwordMessage()
        {
            return _page.Locator("ul[id='user-password-errors']");
        }
        
        public ILocator displayedOnField(string locator)
        {
            return _page.Locator($"input[id='user-{locator}']");
        }
        

        public ILocator redirected(string page)
        {
            return _page.GetByText(page).First;
        }
        //public class UserData
        //{
        //    public string Category { get; set; }
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }
        //    public string Email { get; set; }
        //    public string DateOfBirth { get; set; }
        //    public string Least13DateOfBirth { get; set; } = DateTime.Now.AddYears(-11).ToString("yyyy-MM-dd");
        //}
        public class UserData
        {
            public required string Category { get; set; }
            public required string FirstName { get; set; }
            public required string LastName { get; set; }
            public required string Email { get; set; }
            public required string DateOfBirth { get; set; }
            public string Least13DateOfBirth { get; set; } = DateTime.Now.AddYears(-11).ToString("yyyy-MM-dd");
        }

        public UserData GenerateRandomName()
        {
            string[] categories = { "Tester", "QA"};
            string[] firstNames = { "Yemi", "Bj", "Alice", "Bob", "Charlie", "David", "Eve", "Frank" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis" };
            string[] years = { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005" };
            string[] months = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            string[] days = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12",
                              "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23",
                              "24", "25", "26", "27", "28" };
            Random random = new Random();

            string category = categories[random.Next(categories.Length)];
            string firstNameValue = firstNames[random.Next(firstNames.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];
            string email = $"{firstNameValue.ToLower()}.{lastName.ToLower()}{random.Next(0, 10000)}@example.com";
            string dateOfBirth = $"{years[random.Next(years.Length)]}-{months[random.Next(months.Length)]}-{days[random.Next(days.Length)]}";

            // 2. Return matching UserData properties
            return new UserData
            {
                Category = category,
                FirstName = firstNameValue,
                LastName = lastName,
                Email = email,
                DateOfBirth = dateOfBirth
            };
        }

        public async Task OpenAsync(string url)
        {
            await _page.GotoAsync(url);
        }
        
        public async Task enterEmailAsync(string email)
        {
            await emailInput().FillAsync(email);
        }

        public async Task enterPasswordAsync(string password)
        {
            await passwordInput().FillAsync(password);
        }

        public async Task clickLoginButton()
        {
            await loginbtn().ClickAsync();
            

            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            Console.WriteLine(await _page.Locator("body").InnerTextAsync());

        }

        public async Task userSelectAnyRole()
        {
            // 1. Target all role elements EXCEPT SuperAdmin
         

            int totalCount = await selectRoles().CountAsync();
            if (totalCount == 0) return;

            // 2. Pick a single random index from available roles
            int randomIndex = Random.Shared.Next(0, totalCount);

            // 3. Click the selected role
            await selectRoles().Nth(randomIndex).ClickAsync();
        }

        public async Task userSelectARole(string role)
        {
            // 1. Target all role elements EXCEPT SuperAdmin


           

            // 3. Click the selected role
            await selectARole(role).ClickAsync();
        }
        public string PasswordVisible { get; set; }
        public async Task enterPassword(string pass)
        {
            await password().FillAsync(pass);
            PasswordVisible = await password().GetAttributeAsync("value");
        }

        public async Task <bool>isAbleToSeeThePasswordHeOrSheEnteredInThePasswordField()
        {
            // Fetch current input value from the password field
            string currentInputValue = await password().GetAttributeAsync("value");

            // Check if current value matches the stored password string
            return PasswordVisible == currentInputValue;
        }

        public async Task<bool> isUnableToSeeThePasswordHeOrSheEnteredInThePasswordField()
        {
            // Fetch current input value from the password field
            string currentInputValue = await password().GetAttributeAsync("value");

            // Check if current value matches the stored password string
            return PasswordVisible != currentInputValue;
        }
        
        public async Task eyeIconOnPasswordField()
        {
            await eyeIcon().ClickAsync();
        }

        public async Task eyeHideIconOnPasswordField()
        {
            await eyeHideIcon().ClickAsync();
        }
        
        public async Task enterFirstName()
        {
            UserData user = GenerateRandomName();
            await firstname().FillAsync(user.FirstName);
        }

        public async Task enterLastName()
        {
            UserData user = GenerateRandomName();
            await lastname().FillAsync(user.LastName);
        }

        public async Task enterEmailAddress(string email)
        {
            await emailAddress().FillAsync(email);
        }
        
        public async Task enterDateOfBirth()
        {
            UserData user = GenerateRandomName();
            await userDateOfBirth().FillAsync(user.DateOfBirth);
        }

        public async Task enterLeast13DateOfBirth()
        {
            UserData user = GenerateRandomName();
            await userDateOfBirth().FillAsync(user.Least13DateOfBirth);
            // Implementation for entering date of birth (at least 13 years old)
        }

        public async Task enterEmailAsync()
        {
            UserData user = GenerateRandomName();
            await emailAddress().FillAsync(user.Email);
        }
   

        public async Task clickCheckbox()
        {
            await checkBox().ClickAsync();
        }

        public async Task clickMenus(string menus)
        {
            await menu(menus).ClickAsync();
        }

        public async Task selectCategory()
        {
            // Generate all data once
            UserData user = GenerateRandomName();

            // Access individual properties
           
            
            await select().SelectOptionAsync(user.Category);
        }

        public async Task clickButton(string button)
        {
            await buttons(button).ClickAsync();
        }

        public async Task clickXButton()
        {
            await xButton().ClickAsync();
        }
        

        public async Task<bool> unableToClick(string button)
        {
            //await buttons(button).IsEnabledAsync();
            Assert.That(await buttons(button).IsEnabledAsync(), Is.False);
            return true;
        }

        public async Task enterTitleAsync(string title)
        {
            await enterTitle().FillAsync(title);
        }

        public async Task clearTitle()
        {
            await enterTitle().ClearAsync();
        }
        

        public async Task unCheckPublishImmediatelyAsync()
        {
            await unCheckPublishImmediately().ClickAsync();
        }

        public async Task selectFileAsync(string filePath)
        {
            await selectFileAsync().SetInputFilesAsync(filePath);
        }
      
        public async Task enterTagsAsync(string tags)
        {
            await enterTags().FillAsync(tags);
        }
        

        public async Task enterDescription(string title)
        {
            await enterDescriptions().FillAsync(title);
        }

      

        public async Task<bool> VerifyDashboardIsVisible()
        {
            await Expect(Dashboard()).ToBeVisibleAsync();
            return true;
        }

      
        public async Task<bool> displayedMessage(string message)
        {
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
            await displayed(message).WaitForAsync(new LocatorWaitForOptions { Timeout = 60000 });
           
            //await displayed(message).WaitForAsync();

            //Assert.That(await displayed(message).IsVisibleAsync(),Is.True);
            await Expect(displayed(message)).ToBeVisibleAsync();

            return true;
        }

        public async Task<bool> passwordMessageShouldBeDisplayed()
        {
            //await displayed(message).WaitForAsync();

            //Assert.That(await displayed(message).IsVisibleAsync(), Is.True);
            await passwordMessage().WaitForAsync();

            Assert.That(await passwordMessage().IsVisibleAsync(), Is.True);
            return true;
        }
        
        public async Task<bool> aMessageShouldBeDisplayedOnField(string pop , string locator)
        {
            // 1. Get the browser's native validation popup text
            string validationMessage = await displayedOnField(locator).EvaluateAsync<string>("el => el.validationMessage");

            // 2. Assert the message text matches
            Assert.That(validationMessage, Is.EqualTo(pop));
            return true;
        }

       

        public async Task<bool> redirectedTopage(string page)
        {
            //await displayed(message).WaitForAsync();

            //Assert.That(await displayed(message).IsVisibleAsync(), Is.True);
            await redirected(page).WaitForAsync();

            Assert.That(await redirected(page).IsVisibleAsync(), Is.True);
            return true;
        }
        

        public async Task<string> GetTitleAsync()
        {
            return await _page.TitleAsync();
        }


    }
}
