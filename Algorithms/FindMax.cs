using System;
using System.Text;
using System.Linq;

namespace CSharp_Algorithms_n_DataStructures.Algorithms;

public class StringAlgorithms
{
    public static Boolean IsUpper(string str)
    {
        return str.All(char.IsUpper);
    }
    public static Boolean IsLower(string str)
    {
        return str.All(char.IsLower);
    }

    /** 
        <summary>
            Checks if the string passed contains letters, digits and lower case letters
        </summary>
        
        <param name="str">
            String passed to test content
        </param>
        
        <returns>
            Returns true if the string passed contains letters, and flase otherwise
        </returns>
    */
    public static Boolean IsLetter(string str)
    {
        return str.All(char.IsLetter);
    }

    /** 
        <summary>
            Checks if the string passed contains letters, digits and lower case letters
        </summary>
        
        <param name="str">
            String passed to test content
        </param>
        
        <returns>
            Returns true if the string passed contains lowercase letters and digits, and flase otherwise
        </returns>
    */
    public static Boolean IsPasswordComplex(string str)
    {
        return str.All(char.IsLetter) && str.All(char.IsDigit) && str.All(char.IsLower);
    }

    /** 
        <summary>
            Normalises text for easier parsing: makes all characters lowercase, trims space
            characters and replaces commas with just spaces.
        </summary>
        
        <param name="input">
            String passed to normalise test content
        </param>
        
        <returns>
            Returns a normalised string: no commas, all lowercase characters
        </returns>
    */
    public static string NormaliseString(string input)
    {
        return input.ToLower().Trim().Replace(",", "");
    }

    public static string Reverse(string input)
    {
        if(string.IsNullOrEmpty(input)) return input;

        StringBuilder reversed = new StringBuilder(input.Length);
        for(int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }
    public static string ReverseAlternative(string input)
    {
        if(string.IsNullOrEmpty(input)) return input;

        char[] characters = input.ToCharArray();
        Array.Reverse(characters);

        return new String(characters);
    }

    public static string ReverseEachWord(string input)
    {
        if(string.IsNullOrEmpty(input)) return input;

        StringBuilder result = new StringBuilder();

        String[] arrayOfWords = input.Split(" ");
        for(int i = 0; i < arrayOfWords.Length; i++)
        {
            result.Append(Reverse(arrayOfWords[i]));

            if(i != arrayOfWords.Length-1) result.Append(" ");
        }
        
        return result.ToString();
    }

}