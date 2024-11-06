// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SplitSentence();
StringList();




/* 01 Description
      Prompt the user to enter a sentence.  
      Split the sentence into individual words and 
      display each word on its own line.

        Example
        >>Enter a sentence: <<The cow jumped over the moon.
        >>The
        cow
        jumped
        over
        the
        moon.
        Would you like to continue (y/n)? <<y
        >>Enter a sentence: <<Hello, World!
        >>Hello,
        World!
        Would you like to continue (y/n)? <n
        <<Goodbye! 
 */

//https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split#code-try-5

static void SplitSentence()
{
    Console.Write("Enter a sentence: ");
    string userSentence = Console.ReadLine();
    //Console.WriteLine(userSentence);

    char[] saparateChar = { ',', ' ' };
    string[] words = userSentence.Split(saparateChar, StringSplitOptions.RemoveEmptyEntries);

    foreach(var word in words)
    {
        Console.WriteLine($"{word}");
    }
}


/* 02 Description
Repeatedly prompt the user to enter a string.
Store the string in a list and display the contents of the list 
with each element separated by a space.

Example
>>Enter some text: <<The
<<You have entered: The
Would you like to continue (y/n)? <<y
>>Enter some text: <<cow
<<You have entered: The cow
Would you like to continue (y/n)? <<y
>>Enter some text: <<jumped...
<<You have entered: The cow jumped...
Would you like to continue (y/n)? <<n
>>Goodbye! 
 */
static void StringList()
{
    // creating a list
    List<string> inputList = new List<string>();

    // using do while loop for outer loop and while loop for inner
    do
    {
        Console.Write("Enter a word: ");
        string input;
        while ((input = Console.ReadLine()) != string.Empty)
        {
            Console.Write("Would you like to enter another word Y/N? ");
            string userInputAnswer = Console.ReadLine();

            //Console.WriteLine($"Adding: {input} ");
            inputList.Add(input.Trim());

            if (userInputAnswer.ToLower() == "y")
            {
                Console.Write("Enter a word: ");
                continue;
            }
            else if (userInputAnswer.ToLower() == "n")
            {
                Console.WriteLine("Stopping here and displaying results. \n");
                break;
            }

        }
        Console.WriteLine("'inputList' content:");
        Console.WriteLine();
        foreach (string word in inputList)
        {
            Console.Write($"{word} ");
        }
        inputList.Clear();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Would you like to continue with another set of words Y/N? ");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "y")
        {
            continue;
        }
        else
        {
            Console.WriteLine("GoodBye!");
            break;
        }
    } while (true);
}

Console.WriteLine("press any ket to quit");
Console.ReadKey();
