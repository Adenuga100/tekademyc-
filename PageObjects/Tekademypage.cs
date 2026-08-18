using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ILocator checkBox()
        {
            return _page.Locator("input[type='checkbox']");
        }

        public ILocator menu(string menus)
        {
            return _page.Locator($"span:has-text('{menus}')");
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

        public ILocator dashboard()
        {
            return _page.Locator("img[alt='Tekademy']");
        }

        public ILocator displayed(string message)
        {
            return _page.GetByText(message).First;
        }

        public ILocator redirected(string page)
        {
            return _page.GetByText(page).First;
        }
        
        public string GenerateRandomName()
        {
            string[] categories = { "Dev", "Tester", "QA"};
           

            Random random = new Random();

            string category = categories[random.Next(categories.Length)];
          

            return $"{category}";
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
            string category = GenerateRandomName();
            await select().SelectOptionAsync(category);
        }

        public async Task clickButton(string button)
        {
            await buttons(button).ClickAsync();
        }

        public async Task clickXButton()
        {
            await xButton().ClickAsync();
        }
        

        public async Task unableToClick(string button)
        {
            //await buttons(button).IsEnabledAsync();
            Assert.That(await buttons(button).IsEnabledAsync(), Is.False);
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

      

        public async Task Dashboard()
        {
            await dashboard().WaitForAsync();
        }

        public async Task displayedMessage(string message)
        {
            //await displayed(message).WaitForAsync();

            //Assert.That(await displayed(message).IsVisibleAsync(), Is.True);
            await displayed(message).WaitForAsync();

            Assert.That(await displayed(message).IsVisibleAsync(),Is.True);
        }

        public async Task redirectedTopage(string page)
        {
            //await displayed(message).WaitForAsync();

            //Assert.That(await displayed(message).IsVisibleAsync(), Is.True);
            await redirected(page).WaitForAsync();

            Assert.That(await redirected(page).IsVisibleAsync(), Is.True);
        }
        

        public async Task<string> GetTitleAsync()
        {
            return await _page.TitleAsync();
        }


    }
}
