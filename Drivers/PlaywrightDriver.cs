using Microsoft.Playwright;
using Tekademy1C_.Drivers;

namespace Tekademy1C_.Drivers
{
    public class PlaywrightDriver
    {
        private readonly string baseUrl = "https://tekademy-admin-app.vercel.app/app/dashboard";

        public IPlaywright Playwright { get; private set; }
        public IBrowser Browser { get; private set; }
        public IPage Page { get; private set; }

        public async Task StartAsync()
        {
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();


            Browser = await Playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = true
                });

            Page = await Browser.NewPageAsync();

            await Page.GotoAsync(baseUrl);

            await Page.WaitForSelectorAsync(
                "body",
                new PageWaitForSelectorOptions
                {
                    Timeout = 60000
                });

            await Page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        public async Task StopAsync()
        {
            //await Browser.CloseAsync();
            //Playwright.Dispose();
            await Page.CloseAsync();
            await Browser.CloseAsync();
        }
    }
}






