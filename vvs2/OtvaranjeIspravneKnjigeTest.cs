// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class OtvaranjeispravneknjigeTest
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void otvaranjeispravneknjige()
    {
        // Test name: Otvaranje ispravne knjige
        // Step # | name | target | value
        // 1 | open | / | 
        driver.Navigate().GoToUrl("https://buybook.ba/");
        // 2 | setWindowSize | 1552x840 | 
        driver.Manage().Window.Size = new System.Drawing.Size(1552, 840);
        // 3 | click | css=.slick-current .row | 
        driver.FindElement(By.CssSelector(".slick-current .row")).Click();
        // 4 | click | css=.slick-current .row | 
        driver.FindElement(By.CssSelector(".slick-current .row")).Click();
        // 5 | doubleClick | css=.slick-current .row | 
        {
            var element = driver.FindElement(By.CssSelector(".slick-current .row"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        // 6 | click | css=.navbar-brand:nth-child(1) > .light-logo | 
        driver.FindElement(By.CssSelector(".navbar-brand:nth-child(1) > .light-logo")).Click();
    }
}
