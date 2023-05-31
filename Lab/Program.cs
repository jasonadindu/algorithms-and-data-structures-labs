int n = 0;

while (n <= 0)

{
    // Form validation 
    Console.WriteLine("Please enter integer value greater than zero");
    n = Int32.Parse(Console.ReadLine());
}


string[] words = new string[n]; // get console entered amount 

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter word {i + 1}");

    string newWord = Console.ReadLine();

    if (newWord.Length > 0 && !newWord.Contains(" "))
    {
        words[i] = newWord;

    }
    else
    {
        Console.WriteLine("Sorry but you must enter at least one character.");
        i--;
    }
    /*
    if(words.All(i => i == ""))
    {
        Console.WriteLine("Stop");
    }
    */
}
char charToCount = ' ';
while (!Char.IsLetter(charToCount))
{

    Console.WriteLine("Please enter a character  to count.");
    charToCount = Char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
}






Console.WriteLine($"\n You entered the character '{charToCount}'");

// get a count of how many times this character appears in all of the words 

int charCount = 0;

foreach (string word in words)
{
    char[] chars = word.ToCharArray();

    foreach (char c in chars)
    {
        if (c == charToCount)
        {
            charCount++;
        }
    }
}
Console.WriteLine($"The letter '{charToCount}' was counted {charCount.ToString()} times");