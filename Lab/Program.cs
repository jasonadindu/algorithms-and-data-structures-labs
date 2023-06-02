/*
 








Research and employ the StringBuilder class and explain its advantages or disadvantages over Strings.
 */

/*
string usedString = "Programmatic Python"; 
string lowerInput = usedString.ToLower();
char[] charArray = lowerInput.ToCharArray();

for (int i = 0; i < charArray.Length; i++)
{
    for (int j = i + 1; j < charArray.Length; j++)
    {
        if (charArray[j] == charArray[i])
        {
            Console.WriteLine($"{charArray[j]}");
        }
    }
}

1
*/

/*
 Question 1
 A program that produces an array of all of the characters that appear more than once in a string.
For example, the string “Programmatic Python” would result in the array ['p','r','o','a','m','t'].


using System.Text;


Console.WriteLine("To get repeated characters insert word:");
string usedString = Console.ReadLine();
string lowerInput = usedString.ToLower();
char[] _ = lowerInput.ToCharArray();

if (string.IsNullOrEmpty(usedString))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        StringBuilder repeatedCharacters = new StringBuilder();

        foreach (char c in usedString)
        {
            if (usedString.IndexOf(c) != usedString.LastIndexOf(c) && repeatedCharacters.ToString().IndexOf(c) == -1)
            {
                repeatedCharacters.Append(c);
            }
        }

        char[] repeatedArray = repeatedCharacters.ToString().ToCharArray();
        Console.WriteLine($"Output: {string.Join(", ", repeatedArray)}");
Console.WriteLine();


*/

/*
 Question 2
A program returns an array of strings that are unique words found in the argument.
For example, the string “To be or not to be” returns ["to","be","or","not"].

 */
/*
Console.WriteLine("Type in words");
string xy = Console.ReadLine();
string[] words = xy.ToLower().Split(" ");
List<string> uniqueWords = new List<string>();

foreach (string word in words)
{
    if (!uniqueWords.Contains(word))
    {
        uniqueWords.Add(word);
    }
}

string[] nuWords = uniqueWords.ToArray();
Console.WriteLine(string.Join(", ", nuWords));
Console.WriteLine();
*/


/*
 *Question 3
A program that reverses a provided string 


using System.Text;

Console.WriteLine("Insert at least two different words to reverse it:");
string comString = Console.ReadLine();
string[] words = comString.Split(" ");

StringBuilder reversedStringBuilder = new StringBuilder();

for (int i = words.Length - 1; i >= 0; i--)
{
    reversedStringBuilder.Append(words[i]);
    reversedStringBuilder.Append(" ");
}

reversedStringBuilder.Length--; // Remove the extra space at the end

Console.WriteLine(reversedStringBuilder.ToString());
Console.WriteLine();
 */

/*
 Question 4
A program that finds the longest unbroken word in a string and prints it
For example, the string "Tiptoe through the tulips" would print "through"
If there are multiple words tied for greatest length, print the last one
 */

using System.Text;

Console.WriteLine("Type sentence and print longest word: ");
string theString = Console.ReadLine();
string[] lgWords = theString.Split(' ');
StringBuilder longestWord = new StringBuilder();

for (int i = 0; i < lgWords.Length; i++)
{
    if (lgWords[i].Length > longestWord.Length)
    {
        longestWord.Clear();
        longestWord.Append(lgWords[i]);
    }
}

Console.WriteLine(longestWord);




