using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pass.Tests
{
    [TestClass]
    public class PassTests
    {
        
        [TestMethod]
        public void CheckPassword_IfHaveNumber_1returned()
        {
            //arrange
            var pass = new Password.Pass();
            var password = "1174";

            //act
            int result = pass.CheckPassword(password);

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CheckPassword_IfLowercaseHave_2returned()
        {
            //arrange
            var pass = new Password.Pass();
            var password = "imperialmonarchs";

            //act
            int result = pass.CheckPassword(password);

            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckPassword_IfCapitalLetterHave_3returned()
        {
            //arrange
            var pass = new Password.Pass();
            var password = "ImperialMonarchs";

            //act
            int result = pass.CheckPassword(password);

            //assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CheckPassword_IfSpecSymbolsHave_4returned()
        {
            //arrange
            var pass = new Password.Pass();
            var password = "imperialmonarch1174!";

            //act
            int result = pass.CheckPassword(password);

            //assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CheckPassword_IfLenghtMoreThan10_5returned()
        {
            //arrange
            var pass = new Password.Pass();
            var password = "ImperialMonarchs1174!";

            //act
            int result = pass.CheckPassword(password);

            //assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void CheckPassword_IfPasswordDontHaveCorrectForm_0returned()
        {
            //arrange
            var pass = new Password.Pass();
            var password = "ImperialMonarchs1337!";

            //act
            int result = pass.CheckPassword(password);

            //assert
            Assert.AreEqual(0, result);
        }
    }
}
