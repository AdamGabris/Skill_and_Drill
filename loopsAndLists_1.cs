/* 
    NB! There is absolutly no point to these tasks if you use AI or "google" to solve them.
    The point is to learn and practice, not to get the perfect answer.
*/


/*  Task 1
    Using one for lopp, create a list of the duplicate words in the string, use as many lists as you need. 
    "If the zookeeper had to choose, would the zookeeper choose to use the moose the zookeeper uses, or would the zookeeper choose to choose a new moose to use?"
*/

string sentence = "If the zookeeper had to choose, would the zookeeper choose to use the moose the zookeeper uses, or would the zookeeper choose to choose a new moose to use?";
List<string> allWords = new List<string>();
List<string> duplicateWords = new List<string>();

foreach (string word in sentence.Split(" "))
{
    if (sentence.Contains(word) && !allWords.Contains(word))
    {
        allWords.Add(word);
    }
    else if (allWords.Contains(word) && !duplicateWords.Contains(word))
    {
        duplicateWords.Add(word);
    }
}

Console.WriteLine(string.Join(", ", duplicateWords));



/*  Task 2
    Using loops combine the two arrays into one.
    NB! We are asking you to use arrays not lists or anny other data structure, just arrays [].
    Yes there is merge function for lists, but that is not the point.

    first arrays values: a, b, c, d, e
    second arrays values: 1.1, 2.2, 3.3, 4.4, 5.5
*/

string[] lettersArray = new string[] { "a", "b", "c", "d", "e" };
double[] numbersArray = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
string[] combinedArray = new string[lettersArray.Length + numbersArray.Length];

int index = 0;

for (int i = 0; i < lettersArray.Length; i++)
{
    combinedArray[index] = lettersArray[i];
    index++;
}

for (int i = 0; i < numbersArray.Length; i++)
{
    combinedArray[index] = numbersArray[i].ToString();
    index++;
}

Console.WriteLine(string.Join(", ", combinedArray));


/*  Task 3
    Using two nested (one inside the other) for loops and a aray of type char, create the following pattern as a string: 
    *******
    *     *
    *     *
    *  *  *
    *     *
    *     *
    *******
*/


/*  Task 4
    Given the following array of digits, create an array of the numbers missing from the sequence.
    Again using loops and not built in functionality. 

    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 181, 183, 184, 185, 186, 187, 188, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206

*/

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 181, 183, 184, 185, 186, 187, 188, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206 };

List<int> missingNumbers = new List<int>();

for (int i = 1; i <= 206; i++)
{
    if (!numbers.Contains(i))
    {
        missingNumbers.Add(i);
    }
}

Console.WriteLine(string.Join(", ", missingNumbers));
/*  Task 5 (A bit harder)
    Find the length of the longest qonsecutive sequence of chars in the string below.
    Using only loops etc., no built in functionality for manipulating strings and arrays.

    aqcmhrtutdvmyiqcyoyktnfninieglriaqvuxktzkfvfncfrrhfpptgwnhrsbcyjaizodspxxenkcbzwbwnzmoibdjpfdgzpzhoqevdjrilkzayytwycigelbrnusgzeqpimcgcazegftxrnbxinfbpnoljovywqpkfbiamjpedhqfuunowldjnazyttfdpdcytcvhjw
*/

string reference = "aqcmhrtutdvmyiqcyoyktnfninieglriaqvuxktzkfvfncfrrhfpptgwnhrsbcyjaizodspxxenkcbzwbwnzmoibdjpfdgzpzhoqevdjrilkzayytwycigelbrnusgzeqpimcgcazegftxrnbxinfbpnoljovywqpkfbiamjpedhqfuunowldjnazyttfdpdcytcvhjw";
List<char> longestConsecutive = new List<char>();

for (int i = 0; i < reference.Length; i++)
{
    if (reference[i] == reference[i + 1])
    {
        longestConsecutive.Add(reference[i]);
    }
}


Console.WriteLine(string.Join(", ", longestConsecutive));

/* Did not know how to continue with this one. */