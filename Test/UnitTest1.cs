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
            // giri� yap butonuna t�klar 
            driver.FindElement(By.ClassName("btnSignIn")).Click();
            // email k�sm�na kerem yazar
            driver.FindElement(By.Id("email")).SendKeys("kerem");
            // �ifre k�sm�na 123 yazar
            driver.FindElement(By.Id("password")).SendKeys("123");
            // giri� yap butonuna t�klar
            driver.FindElement(By.Id("loginButton")).Click();

        }
        [Test]
        public void Test2()
        {
           
            driver = new ChromeDriver();
            // google.com a gider
            driver.Navigate().GoToUrl("https://google.com/");
            // arama k�sm�na kerem yazar
            driver.FindElement(By.Name("q")).SendKeys("Kerem");
            // klavyeden enter tusuna basar
            driver.FindElement(By.Name("q")).Submit();
           
        }


    }
}