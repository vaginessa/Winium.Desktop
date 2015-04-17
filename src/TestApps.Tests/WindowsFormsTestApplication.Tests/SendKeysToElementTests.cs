﻿namespace WindowsFormsTestApplication.Tests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;

    #endregion

    public class SendKeysToElementTests : BaseForMainWindowTest
    {
        #region Public Methods and Operators

        [Test]
        public void SendEmptyKeysToElementTest()
        {
            var textBox = this.MainWindow.FindElement(By.Id("TextBox1"));
            textBox.SendKeys(string.Empty);

            Assert.AreEqual(string.Empty, textBox.Text);
        }

        [Test]
        public void SendKeysToElementTest()
        {
            const string NewText = "new test text";

            var textBox = this.MainWindow.FindElement(By.Id("TextBox1"));
            textBox.SendKeys(NewText);

            Assert.AreEqual(NewText, textBox.Text);
        }

        #endregion
    }
}
