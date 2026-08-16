using Reqnroll;
using Tekademy1C_.Drivers;

namespace Tekademy1C_.Support
{
    [Binding]
    public class Hooks
    {
        private readonly PlaywrightDriver _driver;

        public Hooks(PlaywrightDriver driver)
        {
            _driver = driver;
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            await _driver.StartAsync();
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            await _driver.StopAsync();
        }
    }
}