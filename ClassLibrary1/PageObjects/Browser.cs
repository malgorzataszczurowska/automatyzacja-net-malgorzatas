﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PageObjects
{
    internal class Browser
    {
        private static IWebDriver driver;

        static Browser()
        {
            driver = new ChromeDriver();
        }

        internal static void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        internal static void Close()
        {
            driver.Quit();
        }
    }
}