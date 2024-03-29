// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class SearchTest
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
    public void search()
    {
        driver.Navigate().GoToUrl("https://buybook.ba/");
        Thread.Sleep(5000);
        driver.FindElement(By.CssSelector(".searchButt > .bi")).Click();
        driver.FindElement(By.CssSelector(".searchButtInput")).Click();
        driver.FindElement(By.CssSelector(".searchButtInput")).SendKeys("anomalija");
        driver.FindElement(By.CssSelector(".searchButtInput")).SendKeys(Keys.Enter);
        Assert.That(driver.Title, Is.EqualTo("Pretražite stranicu"));
        driver.Close();
    }
}