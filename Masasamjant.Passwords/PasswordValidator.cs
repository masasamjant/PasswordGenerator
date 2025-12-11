using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masasamjant.Passwords
{
    /// <summary>
    /// Represent password validator.
    /// </summary>
    public sealed class PasswordValidator
    {
        private readonly IPasswordProperties properties;

        /// <summary>
        /// Initializes new instance of the <see cref="PasswordValidator"/> class.
        /// </summary>
        /// <param name="properties"></param>
        public PasswordValidator(IPasswordProperties properties)
        {
            this.properties = properties;
        }

        public string? ValidatePassword(string password)
        {
            var currentProperties = properties;

            // First validate that password meets lenghth requirements.
            if (password.Length < properties.MinLength)
                return $"Password minimum length is {properties.MinLength} characters.";

            if (password.Length > properties.MaxLength)
                return $"Password maximum length is {properties.MaxLength} characters.";

            
            bool includeSpecials = currentProperties.Complexity.HasFlag(PasswordComplexity.Specials);
            bool includeNumbers = currentProperties.Complexity.HasFlag(PasswordComplexity.Numbers);
            bool includeLowerCaseLetters = currentProperties.Complexity.HasFlag(PasswordComplexity.LowerCaseLetters);
            bool includeUpperCaseLetters = currentProperties.Complexity.HasFlag(PasswordComplexity.UpperCaseLetters);

            int length = password.Length;
            int requiredSpecialCount = includeSpecials ? currentProperties.GetSpecialCharacterCount(length) : 0;
            int requiredNumberCount = includeNumbers ? Math.Max(requiredSpecialCount, 1) + 1 : 0;

            if (includeSpecials)
            {
                int specialCount = 0;
                
                foreach (char c in password)
                {
                    if (PasswordCharacters.Specials.Contains(c))
                    {
                        specialCount++;
                        if (specialCount == requiredSpecialCount)
                            break;
                    }
                }

                if (specialCount == 0)
                    return $"Password must have at least {requiredSpecialCount} character that is not letter or number.";
            }

            if (includeNumbers)
            {
                int numberCount = 0;

                foreach (char c in password)
                {
                    if (PasswordCharacters.Numbers.Contains(c))
                    {
                        numberCount++;
                        if (numberCount == requiredNumberCount)
                            break;
                    }
                }

                if (numberCount == 0)
                    return $"Password must have at least {requiredNumberCount} character that is number.";
            }

            if (includeLowerCaseLetters)
            {
                if (!password.Any(PasswordCharacters.LowerCaseLetters.Contains))
                    return "Password must have lower-case letters.";

                if (!includeNumbers && !includeSpecials && !includeUpperCaseLetters)
                {
                    char c = password[0];
                    if (password.All(x => x == c))
                        return "Password must have different lower-case letters.";
                }
            }

            if (includeUpperCaseLetters)
            {

                if (!password.Any(PasswordCharacters.UpperCaseLetters.Contains))
                    return "Password must have upper-case letters.";
                
                if (!includeNumbers && !includeSpecials && !includeLowerCaseLetters)
                {
                    char c = password[0];
                    if (password.All(x => x == c))
                        return "Password must have different upper-case letters.";
                }
            }

            return null;
        }
    }
}
