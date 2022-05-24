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

            // create Time and Material Record

            // go to TM page

            IWebElement AdministrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li(5)/a"));
            AdministrationDropdown.Click();

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]"));
            tmOption.Click();

            // Click on create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // select material from typeccode dropdown
            IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id='TimematerialEditForm']/div/[1]/div//span/span[2]/span"));
            typecodedropdown.Click();

            IWebElement materialoption = driver.FindElement(By.XPath("//*[@id='TypeCode'_Listbox']/Li[1]"));
            materialoption.Click();

            // Identify the code textbox and put a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("April2022");

            // Identify the description textbox and put a description
            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.SendKeys("April2022");

            // Idetify the Price per unit text box and out a price
            IWebElement Pricetextbox = driver.FindElement(By.Id("Price"));
            Pricetextbox.SendKeys("April2022");

            // Click on Save Button
            IWebElement Save = driver.FindElement(By.Id("SaveButton"));
            Save.Click();






        }

    }
}
