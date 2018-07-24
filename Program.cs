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

            driver.Url = "https://www.reddit.com/";

            driver.find_element_by_name('Trump').click();
        }
    }
}