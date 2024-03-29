/* 
    NB! There is absolutly no point to these tasks if you use AI or "google" to solve them.
    The point is to learn and practice, not to get the perfect answer.
*/

/*  Task 1
    Create a function that given an array of integers returns the largers number in the array.
    Do not use any built in functionality.
*/

int returnLargestNumber(int[] numbers)
{
    int largestNumber = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > largestNumber)
        {
            largestNumber = numbers[i];
        }
    }
    return largestNumber;
}

/*  Task 2
    Create a function that returns an array of n posetive integers, where n is given as a parameter.
    The numbers should be unique but not consecutive.
    Do not use any built in functionality for sorting, matching etc. (You may use Random and Math functions)
*/

int[] returnUniqueNumbers(int n)
{
    int[] numbers = new int[n];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        numbers[i] = random.Next(1, 100);
    }
    return numbers;
}

/*  Task 3
    Create a function that given a string and a pattern returns true if the pattern matches the string.
    Do not use any built in functionality for matching (no regex)etc.

    A pattern is defined as a series of *,n,s and -.
    * matches anything except an empty string.
    n matches any number.
    s matches any string.
    - matches a single space.

    Example:
    pattern: sssss-nnn-*****
    string: "Hello 123 World"

*/

/* Could not complete this one on my own. */

/*  Task 4
    Create a function that reads an indetermind number of integers from the console and returns the sum of the numbers.
*/

int sumOfNumbers()
{
    int sum = 0;
    while (true)
    {
        string input = Console.ReadLine();
        if (input == "")
        {
            break;
        }
        sum += int.Parse(input);
    }
    return sum;
}


/*  Task 5
    Create a function that given a string returns the number of words in the string.
    Do not use any built in functionality for splitting strings etc.
*/

int numberOfWords()
{
    int wordCount = 0;
    string input = Console.ReadLine();
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            wordCount++;
        }
    }
    return wordCount + 1;
}

/*  Task 6
    Create the functions that given a color value in hex format reutns the RGB and CMYK values as *defined types*.
    Do not use any built in functionality.

    Hex is defined as #RRGGBB. Where RR, GG and BB are two digit hexadecimal numbers.
    RGB is defined as three integers between 0 and 255.
    CMYK is defined as four floats between 0 and 1.

    The conversion from RGB to CMYK is defined as:
    K = 1 - max(R, G, B) / 255
    C = (1 - R / 255 - K) / (1 - K)
    M = (1 - G / 255 - K) / (1 - K)
    Y = (1 - B / 255 - K) / (1 - K)

    Tip: 
    - You can use int.Parse("FF", System.Globalization.NumberStyles.HexNumber) to convert a hex number to an integer.
    - You can read a substring from a string using str.Substring(startIndex, length)
    - Notice that the task says defined types. This means you should create a class for RGB and CMYK.
    - You can return multiple values from a function by using a tuple.

*/

/* Could not complete this one on my own. */

class RGB
{
    public int R;
    public int G;
    public int B;
}

class CMYK
{
    public float C;
    public float M;
    public float Y;
    public float K;
}

(RGB, CMYK) HexToColorModel(string hex)
{
    RGB rgb = new RGB();
    rgb.R = int.Parse(hex.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
    rgb.G = int.Parse(hex.Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
    rgb.B = int.Parse(hex.Substring(5, 2), System.Globalization.NumberStyles.HexNumber);

    CMYK cmyk = new CMYK();
    cmyk.K = 1 - Math.Max(Math.Max(rgb.R, rgb.G), rgb.B) / 255f;
    cmyk.C = (1 - rgb.R / 255f - cmyk.K) / (1 - cmyk.K);
    cmyk.M = (1 - rgb.G / 255f - cmyk.K) / (1 - cmyk.K);
    cmyk.Y = (1 - rgb.B / 255f - cmyk.K) / (1 - cmyk.K);
    return cmyk;
}



