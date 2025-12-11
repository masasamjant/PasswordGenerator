using System;
using System.Collections.Generic;
using System.Text;

namespace Masasamjant.Passwords
{
    [TestClass]
    public class PasswordValidatorUnitTest
    {
        [TestMethod]
        public void Test_Generated_Password_Is_Valid()
        {
            var properties = new PasswordGeneratorProperties(8, 15, PasswordComplexity.LowerCaseLetters | PasswordComplexity.UpperCaseLetters | PasswordComplexity.Numbers | PasswordComplexity.Specials);
            properties.ChangeSpecialCharacterCount(3);
            var generator = new PasswordGenerator(properties);
            var password = generator.Generate();
            var validator = new PasswordValidator(properties);
            var message = validator.ValidatePassword(password);
            Assert.IsNull(message);
        }
    }
}
