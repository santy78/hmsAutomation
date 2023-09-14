using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Automation
{
    internal class CreateDriver
    {
        // Type or member is obsolete
        /// <summary>
        /// Generate an EdgeDriver
        /// </summary>
        /// <returns></returns>
        internal static EdgeDriver GetEdgeDriver()
        {
            EdgeOptions options = new EdgeOptions();
            options.AddArguments("--disable-notifications");

            EdgeDriverService service = EdgeDriverService.CreateDefaultService();

            // Microsoft.Edge.SeleniumTools.EdgeDriverService service = Microsoft.Edge.SeleniumTools.EdgeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            return new EdgeDriver(service, options);
        }

        /// <summary>
        /// Get new FirefoxDriver
        /// </summary>
        /// <returns></returns>
        internal static FirefoxDriver GetFireFoxDriver()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.SetPreference("geo.enabled", false);
            options.SetPreference("geo.provider.use_corelocation", false);
            options.SetPreference("geo.prompt.testing", false);
            options.SetPreference("geo.prompt.testing.allow", false);
            options.SetPreference("dom.webnotifications.enabled", false); // TODO Test this.
            //options.AddArgument("-headless");
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            return new FirefoxDriver(service, options);
        }

        /// <summary>
        /// get a new ChromeDriver
        /// </summary>
        /// <returns></returns>
        internal static ChromeDriver GetChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications"); // disable notification popups
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            return new ChromeDriver(service, options);
        }

        /// <summary>
        /// get a new IEdriver
        /// </summary>
        /// <returns></returns>
        internal static InternetExplorerDriver GetIEDriver()
        {
            InternetExplorerDriverService service = InternetExplorerDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            return new InternetExplorerDriver(service);
        }
    }
}
