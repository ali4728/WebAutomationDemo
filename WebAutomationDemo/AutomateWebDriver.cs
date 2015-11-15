using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Diagnostics;



namespace WebAutomationDemo
{
   
    public class AutomateWebDriver
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        

        public void Execute()
        {  
            FirefoxProfile profile = new FirefoxProfile();
           
         
            profile.SetPreference("browser.helperApps.alwaysAsk.force", false);         
            profile.SetPreference("browser.download.folderList", 2);
            profile.SetPreference("browser.download.dir", Directory.GetCurrentDirectory()); 
            profile.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
            profile.SetPreference("browser.download.useDownloadDir", true);
            profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/csv");



            driver = new FirefoxDriver(profile);
            baseURL = "";
            verificationErrors = new StringBuilder();



            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("Classic Login")).Click();
            driver.FindElement(By.Name("uname")).Clear();
            driver.FindElement(By.Name("uname")).SendKeys("");
            driver.FindElement(By.Name("pword")).Clear();
            driver.FindElement(By.Name("pword")).SendKeys("");
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            driver.FindElement(By.LinkText("Submit File for Analysis")).Click();
            driver.FindElement(By.LinkText("History of Submissions")).Click();
            driver.FindElement(By.LinkText("X12out_final.txt")).Click();            
            driver.FindElement(By.XPath("//input[@value='csv']")).Click();
            driver.FindElement(By.Name("report")).Click();
            Console.WriteLine("Run autoit");
            RunSaveProc();
            Console.WriteLine("Will wait for 15 sec");
            Thread.Sleep(12000);
            Console.WriteLine("Logging out");
            driver.FindElement(By.LinkText("Logout")).Click();


            driver.Quit();
        }
        
    
        private void RunSaveProc()
        {
            Process process = new Process();

            // Stop the process from opening a new window
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Setup executable and parameters
            process.StartInfo.FileName = "firefox_download.exe";
            //process.StartInfo.Arguments = "--test";

            // Go
            process.Start();
        }
    }
}
