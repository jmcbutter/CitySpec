namespace CitySpec;

public static class ExtensionMethods
{
    public static bool IsInvalidName(this string str)
    {
        char[] forbiddenCharacters = {'!', '@', '#', '$', '%', '^', '*'};
        return string.IsNullOrEmpty(str) || str.Any(x => forbiddenCharacters.Contains(x));
    }
}