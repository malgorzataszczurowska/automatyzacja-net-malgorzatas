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

        private IWebDriver driver;

        private StringBuilder verificationErrors;

        private string baseURL;

        private bool acceptNextAlert = true;
        private IEnumerable elements;

        public Example()

        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            baseURL = "https://www.google.pl/";

            verificationErrors = new StringBuilder();

        }







        [Fact]

        public void TheExampleTest()

        {

            driver.Navigate().GoToUrl(baseURL);

            driver.FindElement(By.Id("lst-ib")).Clear();

            driver.FindElement(By.Id("lst-ib")).SendKeys("code sprinters");
            driver.FindElement(By.Id("lst-ib")).Submit();
            driver.FindElement(By.LinkText("Code Sprinters -")).Click();
       
            var element = driver.FindElement(By.LinkText("Poznaj nasze podejście"));
            Assert.NotNull(element);

            var elemnets = driver.FindElements(By.LinkText("Poznaj nasze podejście"));
            Assert.Single(elemnets);
            
            driver.FindElement(By.LinkText("Akceptuję")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(condition: ExpectedConditions.InvisibilityOfElementWithText(By.LinkText("Akceptuję"), "Akceptuję"));

            WaitForClickable(By.LinkText("Poznaj nasze podejście"), 5);

            driver.FindElement(By.LinkText("Poznaj nasze podejście")).Click();

            Assert.Contains("WIEDZA NA PIERWSZYM MIEJSCU", driver.PageSource);
            




           

        }
        protected void WaitForClickable(By by, int seconds)

        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            wait.Until(ExpectedConditions.ElementToBeClickable(by));

        }



        protected void waitForElementPresent(IWebElement by, int seconds)

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
