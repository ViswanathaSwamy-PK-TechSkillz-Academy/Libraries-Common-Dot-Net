using NamesGenerator.Interfaces;
using System.Text;

namespace NamesGenerator;

public class GenerateNames : IGenerateNames
{
    private static readonly string[] _consonants = ["b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x"];

    private static readonly string[] _vowels = ["a", "e", "i", "o", "u", "ae", "y"];

    private static readonly Random _random = new();

    public string[] GetNames(int nameLength = 10, int numberOfNames = 10)
    {
        string[] names = new string[numberOfNames];

        for (int index = 0; index < numberOfNames; index++)
        {
            names[index] = GetName(nameLength);
        }

        return names;
    }

    private static string GetName(int length = 10)
    {
        StringBuilder name = new(length);
        int index = 2;

        name.Append(_consonants[_random.Next(0, _consonants.Length)].ToUpper());
        name.Append(_vowels[_random.Next(0, _vowels.Length)]);

        while (index < length)
        {
            name.Append(_consonants[_random.Next(0, _consonants.Length)]);
            name.Append(_vowels[_random.Next(0, _vowels.Length)]);

            index += 2;
        }

        string? nameToReturn = name.ToString();

        // Range Operator nameToReturn[..10] instead of SubString()
        return (nameToReturn.Length >= 10) ? nameToReturn[..10] : nameToReturn;
    }

}