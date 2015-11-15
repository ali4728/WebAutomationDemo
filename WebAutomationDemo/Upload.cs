using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;



namespace WebAutomationDemo
{

    public class Upload
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        

        public void Execute()
        {        
            driver = new FirefoxDriver();            
            baseURL = "http://only-testing-blog.blogspot.in/";
            verificationErrors = new StringBuilder();
            driver.Navigate().GoToUrl(baseURL + "/2014/01/textbox.html");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("img")).Clear();
            driver.FindElement(By.Name("img")).SendKeys("ribbon-black_68.png");
            Console.WriteLine("Wait 14 sec before clicking submit");
            Thread.Sleep(15000);
            driver.FindElement(By.Id("submitButton")).Click();
            Console.WriteLine("Submitted file Will wait for 20 more sec");
            Thread.Sleep(20000);
            driver.Quit();
        }
        

        
    }
}
