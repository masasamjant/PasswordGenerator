using System.Text;

namespace Masasamjant.Passwords
{
    /// <summary>
    /// Represents password generator.
    /// </summary>
    public sealed class PasswordGenerator
    {
        private readonly PasswordGeneratorProperties properties;
        private readonly Random random;

        /// <summary>
        /// Initializes new instance of the <see cref="PasswordGenerator"/> class.
        /// </summary>
        /// <param name="properties">The <see cref="PasswordGeneratorProperties"/>.</param>
        public PasswordGenerator(PasswordGeneratorProperties properties)
        {
            var diff = DateTime.Now.Subtract(DateTime.Today);
            int seed = (int)diff.Ticks;
            this.random = new Random(seed);
            this.properties = properties;
        }

        /// <summary>
        /// Generates random password.
        /// </summary>
        /// <returns>A password value.</returns>
        public string Generate()
        {
            // Get copy from current properties.
            var currentProperties = properties.Clone();

            // Check what characters should be included.
            bool hasSpecials = currentProperties.Complexity.HasFlag(PasswordComplexity.Specials);
            bool hasNumbers = currentProperties.Complexity.HasFlag(PasswordComplexity.Numbers);
            bool hasLowerCaseLetters = currentProperties.Complexity.HasFlag(PasswordComplexity.LowerCaseLetters);
            bool hasUpperCaseLetters = currentProperties.Complexity.HasFlag(PasswordComplexity.UpperCaseLetters);

            // If minimum length is same as maximum length, then that value is password length.
            // Otherwise take random length from min to max range.
            int length = currentProperties.MinLength == currentProperties.MaxLength
                ? currentProperties.MinLength : random.Next(currentProperties.MinLength, currentProperties.MaxLength + 1);

            // Get how many special characters should be included.
            int specialCount = hasSpecials ? GetSpecialCharacterCount(length, currentProperties) : 0;

            // Set how many number characters should be included.
            int numberCount = hasNumbers ? Math.Max(specialCount, 1) + 1 : 0;

            // List to get characters for final password.
            var characters = new List<char>(length);

            // Check if special characters should be included.
            if (hasSpecials)
            {
                // If should contain only specials, then fill only with them.
                if (hasNumbers == false && hasLowerCaseLetters == false && hasUpperCaseLetters == false)
                    specialCount = length;

                while (characters.Count < specialCount)
                    characters.Add(GetRandomCharacter(PasswordCharacters.Specials, random));
            }

            // Check if number characters should be included.
            if (hasNumbers)
            {
                // If should contain only numbers, then fill only with them.
                // If should contain only specials and numbers, then remain after specials if filled with numbers.
                if (hasSpecials == false && hasLowerCaseLetters == false && hasUpperCaseLetters == false)
                    numberCount = length;
                else if (hasLowerCaseLetters == false && hasUpperCaseLetters == false)
                    numberCount = length - specialCount;

                int n = 0;
                while (n < numberCount)
                {
                    characters.Add(GetRandomCharacter(PasswordCharacters.Numbers, random));
                    n++;
                }
            }

            // Check if lower and upper case letters should be included.
            if (hasLowerCaseLetters && hasUpperCaseLetters)
            {
                int remain = length - characters.Count;
                int c = remain / 2;
                int n = 0;

                // Fill half of the remain with lower case letters.
                while (n < c)
                {
                    characters.Add(GetRandomCharacter(PasswordCharacters.LowerCaseLetters, random));
                    n++;
                }

                // Fill what is left with upper case letters.
                while (characters.Count < length)
                    characters.Add(GetRandomCharacter(PasswordCharacters.UpperCaseLetters, random));
            }
            else if (hasLowerCaseLetters)
            {
                // Fill what is left with lower case letters.
                while (characters.Count < length)
                    characters.Add(GetRandomCharacter(PasswordCharacters.LowerCaseLetters, random));
            }
            else if (hasUpperCaseLetters)
            {
                // Fill what is left with upper case letters.
                while (characters.Count < length)
                    characters.Add(GetRandomCharacter(PasswordCharacters.UpperCaseLetters, random));
            }

            // Build final password by taking random characters from list.
            var builder = new StringBuilder(length);

            while (builder.Length < length)
            {
                int index = random.Next(0, characters.Count);
                builder.Append(characters[index]);
                characters.RemoveAt(index);
            }

            return builder.ToString();
        }

        private static int GetSpecialCharacterCount(int length, PasswordGeneratorProperties properties)
        {
            if (properties.SpecialCharacterCount.HasValue)
                return properties.SpecialCharacterCount.Value;
            else 
            {
                if (length <= 8)
                    return 1;
                else if (length <= 16)
                    return 2;
                else if (length <= 32)
                    return 4;
                else if (length <= 64)
                    return 6;
                else if (length <= 128)
                    return 8;
                return 10;
            }
        }

        private static char GetRandomCharacter(IList<char> list, Random random) => list[random.Next(0, list.Count)];
    }
}
