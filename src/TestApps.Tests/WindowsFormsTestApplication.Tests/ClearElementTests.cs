﻿namespace WindowsFormsTestApplication.Tests
{
    #region using

    using NUnit.Framework;

    using OpenQA.Selenium;

    #endregion

    public class ClearElementTests : BaseForMainWindowTest
    {

        #region Public Methods and Operators

        [Test]
        public void ClearTextBoxTest()
        {
            var textBox = this.MainWindow.FindElement(By.Id("TextBox1"));
            textBox.Clear();

            Assert.AreEqual(string.Empty, textBox.Text);
        }

        #endregion
    }
}
