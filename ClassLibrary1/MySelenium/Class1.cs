using System;

using System.Text;

using OpenQA.Selenium;

using OpenQA.Selenium.Firefox;

using OpenQA.Selenium.Support.UI;

using Xunit;

using OpenQA.Selenium.Chrome;


using System.Threading;
using System.Collections;

namespace SeleniumTests

{

    public class Example : IDisposable

    {
        private const string SearchTextBoxId = "lst-ib";
        private const string Google = "https://www.google.com";
        private const string TextToSearch = "Code Sprinters";
        private const string PageTitle = "Code Sprinters -";
        private const string LinkTextToFind = "Poznaj nasze podejście";
        private const string Acceptance = "Akceptuję";

        private IWebDriver driver;

        private StringBuilder verificationErrors;
        private IEnumerable elements;

        public Example()

        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            verificationErrors = new StringBuilder();

        }

        [Fact]

        public void NavigatingToCodeSprintersSite()

        {

            driver.Navigate().GoToUrl(Google);
            Search(TextToSearch);
            OpenSearchResultByPageTitle(PageTitle);
            AcceptCookiePolicy(Acceptance);
            GetElementsByLinkText(LinkTextToFind);
         
            Assert.Contains("WIEDZA NA PIERWSZYM MIEJSCU", driver.PageSource);
       }

        private void GoToOurApproachPage()
        {
            AcceptCookiePolicy(Acceptance);
        }

        private void AcceptCookiePolicy(string Acceptance)
        {
            driver.FindElement(By.LinkText(Acceptance)).Click();
            new WebDriverWait(driver, TimeSpan.FromSeconds(11))
                .Until(ExpectedConditions.InvisibilityOfElementWithText(By.LinkText(Acceptance), Acceptance));
        }

        private void GetElementsByLinkText(string LinkTextToFind)
        {
            driver.FindElement(By.LinkText(LinkTextToFind)).Click();
        }

        private void Search(string query)
        {
            var searchbox = GetSearchbox();
            searchbox.Clear();
            searchbox.SendKeys(query);
            searchbox.Submit();
        }


        private void OpenSearchResultByPageTitle(string title)
        {
            driver.FindElement(By.LinkText(title)).Click();
        }

        private IWebElement GetSearchbox()
        {
            return driver.FindElement(By.Id(SearchTextBoxId));
        }

        protected void WaitForClickable(By by, int seconds)

        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            wait.Until(ExpectedConditions.ElementToBeClickable(by));

        }



        protected void WaitForClickable(IWebElement by, int seconds)

        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            wait.Until(ExpectedConditions.ElementToBeClickable(by));

        }

        //private bool IsElementPresent(By by)

        //{

        //    try

        //    {

        //        driver.FindElement(by);

        //        return true;

        //    }

        //    catch (NoSuchElementException)

        //    {

        //        return false;

        //    }

        //}



        //private bool IsAlertPresent()

        //{

        //    try

        //    {

        //        driver.SwitchTo().Alert();

        //        return true;

        //    }

        //    catch (NoAlertPresentException)

        //    {

        //        return false;

        //    }

        //}



        //private string CloseAlertAndGetItsText()

        //{

        //    try

        //    {

        //        IAlert alert = driver.SwitchTo().Alert();

        //        string alertText = alert.Text;

        //        if (acceptNextAlert)

        //        {

        //            alert.Accept();

        //        }

        //        else

        //        {

        //            alert.Dismiss();

        //        }

        //        return alertText;

        //    }

        //    finally

        //    {

        //        acceptNextAlert = true;

        //    }

        //}



        public void Dispose()

        {

            try

            {

                driver.Quit();

            }

            catch (Exception)

            {

                // Ignore errors if unable to close the browser

            }

            Assert.Equal("", verificationErrors.ToString());

        }

    }

}
