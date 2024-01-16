using System.Collections.Generic;
/* 
    NB! There is absolutly no point to these tasks if you use AI or "google" to solve them.
    The point is to learn and practice, not to get the perfect answer.
*/

/* Task 1
    Declear two variables of type int, set the value of the first variable to 1 and the value of the second to 2.
    Now swap so the first variable gets the value of the second and vice versa.
*/

int firstVariable = 1;
int secondVariable = 2;

firstVariable = secondVariable;
secondVariable = firstVariable;


/* Task 2
    Without using the built in Math functionality and constants in .Net C#.
    Calculate the area of a circle with the radius 6.
*/

int radius = 6;
double pi = 3.14;
double calculate = pi * radius * radius;

Console.WriteLine(calculate);

/* Task 3
    Given the two strings "If at first you do not succeed, try, try again" and "Fall seven times, stand up eight"
    Create a variable that contains all the letter that are in both strings but only once and in alphabetical order (ofcouse this should not be done manualy).
    We consider A and a the same letter. 

    Example: "Bac." and "d,b c" => "abcd" 
*/

string firstString = "If at first you do not succeed, try, try again";
string secondString = "Fall seven times, stand up eight";
List<char> repeatedLetters = new List<char>();

foreach (char letter in firstString.ToLower())
{
    if (secondString.ToLower().Contains(letter) && !repeatedLetters.Contains(letter))
    {
        repeatedLetters.Add(letter);
    }
}

repeatedLetters.Sort();
string repeatedLettersString = string.Join("", repeatedLetters);
Console.WriteLine(repeatedLettersString);

/* Taske 4
    Declear thre variables of type int. The first two should have the values 6 and 2.
    Make it so that the third variable is 10.
*/

int var1 = 6;
int var2 = 2;
int var3 = var1 + 2 * (var2);

Console.WriteLine(var3);

/* Task 5
    Given a variabel of type double and set to a random value (i.e. you pick the value)
    Instanciate a second variable that is true if the first variable is grather than 22.34
*/

double randomValue = 12.25;
bool biggerThan = randomValue > 22.34;

Console.WriteLine(biggerThan);

/* Task 6
    Given the string "Life is short. Smile while you still have teeth." and the string "The best therapy is a good laugh and great friends.".
    Create a new variable that is the intersection of words between the two strings.
    Create a nre variable that is the union of words between the two strings.

    Example: 
    Intersection -> "Hello World" and "World of Warcraft" => "World"
    Union -> "Hello World" and "World of Warcraft" => "Hello World of Warcraft;  
*/

string firstSentence = "Life is short. Smile while you still have teeth.";
string secondSentence = "The best therapy is a good laugh and great friends.";
List<string> intersection = new List<string>();
List<string> union = new List<string>();

foreach (string word in firstSentence.Split(" "))
{
    if (secondSentence.Contains(word) && !intersection.Contains(word))
    {
        intersection.Add(word);
    }
}

string intersectionString = string.Join(" ", intersection);
Console.WriteLine(intersectionString);

foreach (string word in firstSentence.Split(" "))
{
    foreach (string word2 in secondSentence.Split(" "))
    {
        if (!union.Contains(word))
        {
            union.Add(word);
        }
        else if (!union.Contains(word2))
        {
            union.Add(word2);
        }
    }
}

string unionString = string.Join(" ", union);
Console.WriteLine(unionString);

/* Task 7
    Given the string "The quick brown fox jumps over the lazy dog.", calculate the sum of the ASCII values of the characters in the string.
*/

string sentence = "The quick brown fox jumps over the lazy dog.";
int sum = 0;

foreach (char letter in sentence)
{
    sum += (int)letter;
}

Console.WriteLine(sum);

/* Task 8
    Given the strings Kayak, Ship, Level, Banana. Count the number of palindromes (reads the same backward as forward).
    Example: "racecar" is a palindrome.
*/

List<string> words = new List<string>() { "Kayak", "Ship", "Level", "Banana" };
List<string> palindromes = new List<string>();
List<char> temp1 = new List<char>();
List<char> temp2 = new List<char>();

foreach (string word in words)
{
    for (int i = 0; i < word.Length; i++)
    {
        temp1.Add(word[i]);
        for (int j = word.Length; j > 0; j--)
        {
            temp2.Add(word[j]);
            if (temp1 == temp2)
            {
                palindromes.Add(word);
            }
        }
    }
}

string palindromesJoin = string.Join(" ", palindromes);
Console.WriteLine(palindromesJoin);