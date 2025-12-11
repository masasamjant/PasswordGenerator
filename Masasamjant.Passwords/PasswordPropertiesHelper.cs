namespace Masasamjant.Passwords
{
    internal static class PasswordPropertiesHelper
    {
        internal static int GetSpecialCharacterCount(this IPasswordProperties properties, int length)
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
    }
}
