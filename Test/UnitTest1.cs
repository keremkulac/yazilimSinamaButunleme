using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
  
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{

        //}
        IWebDriver driver;
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver(); 
            driver.Url = "https://n11.com/";
            // n11 sitesine gider
            driver.Navigate().GoToUrl(driver.Url);  
            // giriþ yap butonuna týklar 
            driver.FindElement(By.ClassName("btnSignIn")).Click();
            // email kýsmýna kerem yazar
            driver.FindElement(By.Id("email")).SendKeys("kerem");
            // þifre kýsmýna 123 yazar
            driver.FindElement(By.Id("password")).SendKeys("123");
            // giriþ yap butonuna týklar
            driver.FindElement(By.Id("loginButton")).Click();

        }
        [Test]
        public void Test2()
        {
           
            driver = new ChromeDriver();
            // google.com a gider
            driver.Navigate().GoToUrl("https://google.com/");
            // arama kýsmýna kerem yazar
            driver.FindElement(By.Name("q")).SendKeys("Kerem");
            // klavyeden enter tusuna basar
            driver.FindElement(By.Name("q")).Submit();
           
        }


    }
}