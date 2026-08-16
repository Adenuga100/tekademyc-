using Microsoft.Playwright;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public ILocator dashboard()
        {
            return _page.Locator("img[alt='Tekademy']");
        }

        public ILocator displayed(string message)
        {
            return _page.GetByText(message).First;
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

        public async Task<string> GetTitleAsync()
        {
            return await _page.TitleAsync();
        }


    }
}
