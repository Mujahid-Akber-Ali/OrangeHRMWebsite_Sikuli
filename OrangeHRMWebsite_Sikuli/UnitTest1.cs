using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SikuliModule;
using System;
using System.Threading;
using WindowsInput;

namespace SekuliIntegrator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            InputSimulator sim = new InputSimulator();
            driver.Manage().Window.Maximize();

            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\username.png");
            sim.Keyboard.TextEntry("Admin");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\password.png");
            sim.Keyboard.TextEntry("admin123");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\login.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\admin.png");


            Thread.Sleep(3000);
            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\add.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\userrole.png");


            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\admin-label.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\employeename.png");
            sim.Keyboard.TextEntry("an");

            Thread.Sleep(1000);
            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\employeename-1.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\status.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\enable.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\username-1.png");
            sim.Keyboard.TextEntry("mujahid");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\password-1.png");
            sim.Keyboard.TextEntry("Mujahid+123");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\confirmpassword.png");
            sim.Keyboard.TextEntry("Mujahid+123");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\save.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\username-2.png");
            sim.Keyboard.TextEntry("mujahid");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\search.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\pen.png");

            Thread.Sleep(3000);
            var element = driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input"));
            Actions action = new Actions(driver);
            action.DoubleClick(element).Perform();

            driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input")).SendKeys("MujahidAkberAli");

            Thread.Sleep(3000);
            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\save.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\username-2.png");
            sim.Keyboard.TextEntry("MujahidAkberAli");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\search.png");

            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\delete.png");


            SikuliAction.Click(@"C:\Users\aadil\Desktop\OrangeHRMWebsite_Sikuli\OrangeHRMWebsite_Sikuli\screenshots\yesdelete.png");
            Thread.Sleep(1000);

            driver.Close();

        }
    }
}