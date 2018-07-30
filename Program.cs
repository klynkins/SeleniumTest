using System;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService("/Users/katelynncampbell/Documents/SeleniumTest/bin/Debug/netcoreapp2.1");
            IWebDriver driver = new FirefoxDriver(service);

            driver.Url = "https://www.yahoo.com/";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.FindElement(By.Id("login")).SendKeys("" + Keys.Enter);
            driver.FindElement(By.Id("pass")).SendKeys("" + Keys.Enter);

            driver.FindElement(By.XPath("")).Click(); 
            driver.FindElement(By.XPath("")).Click();
            driver.FindElement(By.XPath("")).Click();

            IList<IWebElement> stockNames = driver.FindElements();
            Console.WriteLine("Total number of portfolio stocks: " + stockNames.Count);
            Console.WriteLine("You owe the following stocks: ");

            foreach (var stocks in stockNames)
            {
                Console.WriteLine(stocks.Text);
            }

            Console.WriteLine("\n");

            driver.Close();   
        }
    }
}