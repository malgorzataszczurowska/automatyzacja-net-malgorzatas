using OpenQA.Selenium.Chrome;
using System;

namespace PageObjects
{
    internal class Browser
    {
        private static ChromeDriver _driver;

        static Browser()
        {
            _driver = new ChromeDriver();
        }

        internal static void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}