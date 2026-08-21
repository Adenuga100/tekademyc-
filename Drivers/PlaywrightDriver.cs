using Microsoft.Playwright;

namespace Tekademy1C_.Drivers
{
    public class PlaywrightDriver
    {
        public IPlaywright Playwright { get; private set; }
        public IBrowser Browser { get; private set; }
        public IPage Page { get; private set; }

        public async Task StartAsync()
        {
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

            Browser = await Playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = true, // Set to false if you want to see the browser window
                });

            Page = await Browser.NewPageAsync();
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