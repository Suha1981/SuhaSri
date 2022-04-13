using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Sri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // open chorme browser
            IWebDriver driver = new ChromeDriver();

            // luanch turnup portal //
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify user name text box and enter valid user name 
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify password text box and enter valid password

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // click on loging button
            IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));

            Loginbutton.Click();

            // check if user is loggid in successfully

            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in succefully, test passed,");

            }
            else
            {
                Console.WriteLine("Login failed, test failed,");
            }
        }
    }
}
