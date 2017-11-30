using System;
using System.Linq;

namespace PageObjects
{
    internal class MainPage
    {

        private const string url = "https://autotestdotnet.wordpress.com/";

        internal static void Open()
        {
            Browser.NavigateTo(url);           
        }

        internal static void OpenFirstNote()
        {
            var element = Browser.FindByXpath("//article/header");
            element.First().Click();
        }
    }
}