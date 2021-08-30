using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Globalization;


namespace CodeWarsKatasCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> birdList = new string[] { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" };
            IEnumerable<string> correctGeese = (GooseFilter(birdList));
            foreach(string bird in correctGeese)
            {
                Console.WriteLine(bird);
            }


        }

        //  Filter out the geese
        //  https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7/train/csharp
        //public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        //{
        //    // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
        //    string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
        //    List<string> correctGeese = new List<string>();

        //    foreach(string bird in birds)
        //    {
        //        bool inList = false;
        //        for(int i =0; i < geese.Length; i++)
        //        {
        //            if (bird.Contains(geese[i]))
        //            {
        //                inList = true;
        //            }
        //        }
        //        if (inList != true)
        //        {
        //            correctGeese.Add(bird);
        //        }
        //    }
        //    return correctGeese;
        //}


        //  8kyu interpreters: HQ9+
        //  https://www.codewars.com/kata/591588d49f4056e13f000001/train/csharp
        //public static string Interpret(string code)
        //{
        //    if (code == "H")
        //    {
        //        return "Hello World!";
        //    }
        //    else if (code == "Q")
        //    {
        //        return code;
        //    }
        //    else if (code == "9")
        //    {
        //        string beers = "";

        //        for (int i = 99; i > 1; i--)
        //        {
        //            beers += $"{i} bottles of beer on the wall, {i} bottles of beer.\n" +
        //                     $"Take one down and pass it around, {i - 1} bottles of beer on the wall.\n";
        //        }
        //        beers += $"2 bottles of beer on the wall, 2 bottles of beer.\n" +
        //                 $"Take one down and pass it around, 1 bottle of beer on the wall.\n" +
        //                 $"1 bottle of beer on the wall, 1 bottle of beer.\nTake one down and pass it around," +
        //                 $" no more bottles of beer on the wall.\nNo more bottles of beer on the wall, no more" +
        //                 $" bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";

        //        return beers;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}


        //  For UFC Fans(Total Beginners) : Conor McGregor vs George Saint Pierre
        //  https://www.codewars.com/kata/for-ufc-fans-total-beginners-conor-mcgregor-vs-george-saint-pierre/train/csharp
        //public static string Quote(string fighter)
        //{
        //    fighter = fighter.ToLower();
        //    if (fighter == "conor mcgregor")
        //    {
        //        return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
        //    }
        //    else 
        //    {
        //        return "I am not impressed by your performance.";
        //    }
        //}


        //  Counting sheep...
        //  https://www.codewars.com/kata/54edbc7200b811e956000556/train/csharp
        //public static int CountSheeps(bool[] sheeps)
        //{
        //    int result = 0;
        //    foreach(bool sheep in sheeps)
        //    {
        //        if (sheep == true)
        //        {
        //            result++;
        //        }
        //    }
        //    return result;
        //}


        //  You only need one - Beginner
        //  https://www.codewars.com/kata/you-only-need-one-beginner/train/csharp
        //public static bool Check(object[] a, object x)
        //{
        //    return a.Contains(x);
        //}


        //Opposite number
        //https://www.codewars.com/kata/opposite-number/train/csharp
        //public static int Opposite(int number)
        //{
        //    if (number > 0)
        //    {
        //        number = number - (number * 2);
        //        return number;
        //    }
        //    else
        //    {
        //        number = number + (number * -2);
        //        return number;
        //    }
        //}


        //Return Negative
        //https://www.codewars.com/kata/return-negative/train/csharp
        //public static int MakeNegative(int number)
        //{
        //    string changeIt = "";
        //    int negative = 0;
        //    if(number > 0)
        //    {
        //        changeIt = $"-{number.ToString()}";
        //        negative = Convert.ToInt32(changeIt);
        //        return negative;

        //    }
        //    return number;
        //}


        //Remove First and Last Character
        //https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/train/csharp
        //public static string Remove_char(string s)
        //{
        //    var removed = "";
        //    for(int i = 1; i < s.Length -1; i++)
        //    {
        //        removed += s[i];
        //    }
        //    return removed;
        //}


        //  MakeUpperCase
        //  https://www.codewars.com/kata/makeuppercase/train/csharp
        //public static string MakeUpperCase(string str)
        //{
        //    str = str.ToUpper();
        //    return str;
        //}


        //  Man in the west
        //  https://www.codewars.com/kata/man-in-the-west/train/csharp
        //public static bool CheckTheBucket(string[] bucket)
        //{
        //    foreach(string result in bucket)
        //    {
        //        if (result == "gold")
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}


        //Reversed sequence
        //https://www.codewars.com/kata/reversed-sequence/train/csharp
        //public static int[] ReverseSeq(int n)
        //{
        //    int[] sequence = new int[n];
        //    int value = n;
        //    for (int i = 0; i < n; i++)
        //    {
        //        sequence[i] = value;
        //        value--;
        //    }

        //    return sequence;
        //}

        // Are arrow functions odd?
        // https://www.codewars.com/kata/are-arrow-functions-odd/train/csharp
        //public static List<int> Odds(List<int> values) =>
        //    values.Where(value => value % 2 != 0).ToList();


        //  Count Odd Numbers below n
        //  https://www.codewars.com/kata/count-odd-numbers-below-n/train/csharp
        //public static ulong OddCount(ulong n)
        //{
        //    return n / 2;
        //}


        //  String repeat
        //  https://www.codewars.com/kata/string-repeat/train/csharp
        //public static string RepeatStr(int n, string s)
        //{
        //    string repeatedString = "";
        //    for(int i = 0; i < n; i++)
        //    {
        //        repeatedString += s;
        //    }
        //    return repeatedString;
        //}


        //  Remove String Spaces
        //  https://www.codewars.com/kata/remove-string-spaces/train/csharp
        //public static string NoSpace(string input)
        //{
        //    string unspaced = "";
        //    for (int letter = 0; letter < input.Length; letter++)
        //    {
        //        if (!Char.IsWhiteSpace(input[letter]))
        //        {
        //            unspaced += input[letter];
        //        }
        //    }
        //    return unspaced;
        //}


        //  A Strange Trip to the Market
        //  https://www.codewars.com/kata/a-strange-trip-to-the-market/train/csharp
        //public static bool IsLockNessMonster(string sentence)
        //{
        //    sentence = sentence.ToLower();
        //    if(sentence.Contains("tree fiddy") || sentence.Contains("3.50") || sentence.Contains("three fifty"))
        //    {
        //        return true;
        //    }
        //    return false;
        //}


        //Kata Example Twist
        //https://www.codewars.com/kata/525c1a07bb6dda6944000031/solutions/csharp

        //public static string[] Websites = new string[1000];
        //static string[] websites = TwistIt();
        //public static string[] TwistIt()
        //{
        //    Array.Fill(Websites, "codewars");
        //    return Websites;
        //}


        //  Basic subclasses - Adam and Eve
        //  https://www.codewars.com/kata/basic-subclasses-adam-and-eve/train/csharp
        //public class God
        //{
        //    public static Human[] Create()
        //    {
        //        Human[] people = new Human[2] { new Man(), new Woman() };
        //        return people;
        //    }
        //}
        //public class Human {}
        //public class Man : Human {}
        //public class Woman : Human {}


        //  Grasshopper - Terminal game combat function
        //  https://www.codewars.com/kata/grasshopper-terminal-game-combat-function-1/train/csharp
        //public static float Combat(float health, float damage)
        //{
        //    health -= damage;
        //    if (health < 0)
        //        health = 0;
        //    return health;
        //}


        //  Sentence Smash
        //  https://www.codewars.com/kata/sentence-smash/train/csharp
        //static void Main(string[] args)
        //{
        //    string[] words = { "this", "is", "a", "really", "long", "sentence" };

        //    Console.WriteLine(Smash(words));
        //}

        //public static string Smash(string[] words)
        //{
        //    var sentence = "";
        //    for (int index = 0; index < words.Length; index++)
        //    {
        //        if (index != words.Length - 1)
        //        {
        //            sentence += $"{words[index]} ";
        //        }
        //        else
        //        {
        //            sentence += $"{words[index]}";
        //        }
        //    }
        //    return sentence;
        //}


        //  Calculate average
        //  https://www.codewars.com/kata/calculate-average/train/csharp

        //static void Main(string[] args)
        //{
        //    double[] array = { };
        //    Console.WriteLine(FindAverage(array));
        //}

        //public static double FindAverage(double[] array)
        //  {
        //    double total = 0;
        //    if (!array.All(value => value.Equals(double.NaN)))
        //    {
        //        foreach (double value in array)
        //        {
        //            total += value;  
        //        }
        //        return total / array.Length;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //  }


        //  Calculate BMI
        //  https://www.codewars.com/kata/57a429e253ba3381850000fb/train/csharp

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Bmi(80, 1.80));
        //}

        //public static string Bmi(double weight, double height)
        //{
        //    double bmi = (weight / Math.Pow(height, 2));
        //    if (bmi <= 18.5)
        //    {
        //        return "Underweight";
        //    }
        //    else if (bmi <= 25.0)
        //    {
        //        return "Normal";
        //    }
        //    else if (bmi <= 30.0)
        //    {
        //        return "Overweight";
        //    }
        //    else
        //    {
        //        return "Obese";
        //    }
        //}



        //  The Supermarket Queue
        //  https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp

        //static void Main(string[] args)
        //{
        //    int[] customers = { 1, 2, 3, 4 };
        //    Console.WriteLine(QueueTime(customers, 2));
        //}
        //int[] customers = { 1, 2, 3, 4 };

        //public static long QueueTime(int[] customers, int n)
        //{
        //    int[] tillsFilled = new int[n];
        //    int nextCustomer = 0;
        //    int tempTime = -1;

        //    do
        //    {
        //        for (int index = 0; index < tillsFilled.Length; index++)
        //        {
        //            if (tillsFilled[index] != 0)
        //            {
        //                tillsFilled[index]--;
        //            }

        //            if (tillsFilled[index] == 0 && nextCustomer < customers.Length)
        //            {
        //                tillsFilled[index] = customers[nextCustomer];
        //                nextCustomer++;
        //            }  
        //        } 
        //        tempTime++;
        //    } while (!tillsFilled.All(till => till.Equals(0)));
        //    return tempTime;
        //}


        //  Detect Pangram
        //  https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp

        //public static bool IsPangram(string str)
        //{ 
        //    return str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
        //}


        //  Sum of Triangular Numbers
        //  https://www.codewars.com/kata/580878d5d27b84b64c000b51/train/csharp

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(SumTriangularNumbers(4)); 
        //}

        //public static int SumTriangularNumbers(int n)
        //{
        //    var result = 0;
        //    if ( n <= 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        result = (n * (n + 1) * (n + 2)) / 6;
        //    }
        //    return result;
        //}


        //  Break camelCase
        //  https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp

        //static void Main(string[] args)
        //{
        //    var alpha = "camelCasing";
        //    Console.WriteLine(BreakCamelCase(alpha));
        //}

        //public static string BreakCamelCase(string str)

        //{
        //    for (int index = 0; index < str.Length; index++)
        //    {
        //        if (Char.IsUpper(str[index]))
        //        {
        //            str = str.Insert(index, " ");
        //            index++;
        //        }
        //    }
        //    return str;
        //}


        //  Love vs friendship
        //  https://www.codewars.com/kata/59706036f6e5d1e22d000016/train/csharp

        //public static int WordsToMarks(string str)
        //{
        //    var wordTotal = 0;
        //    char[] wordSeperated = str.ToCharArray();
        //    foreach(char letter in wordSeperated)
        //    {
        //        wordTotal += (char.ToUpper(letter) - 64);
        //    }
        //    return wordTotal;
        //}


        // Find the stray number
        // https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp

        //public static int Stray(int[] numbers)
        //{
        //    Array.Sort(numbers);
        //    if (numbers[0] != numbers[1])
        //    {
        //        return numbers[0];
        //    }
        //    else
        //    {
        //        return numbers[numbers.Length - 1];
        //    }
        //}


        //  Two Sum
        //  https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp

        //public static int[] TwoSum(int[] numbers, int target)
        //{
        //    int[] answer = new int[2];
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        for (int j = 1; j < numbers.Length; j++)
        //        {
        //            if (numbers[i] + numbers[j] == target)
        //            {
        //                answer[0] = i;
        //                answer[1] = j;
        //                return answer;

        //            }
        //        }
        //    }
        //    return answer;
        //}


        //  Sort Number
        //  https://www.codewars.com/kata/5174a4c0f2769dd8b1000003/train/csharp

        //public static int[] SortNumbers(int[] nums)
        //{
        //    if (nums != null && nums.Length != 0)
        //    {
        //        Array.Sort(nums);
        //    }
        //    else
        //    {
        //        nums = new int[0];
        //    }
        //    return nums;
        //}


        // Testing 1-2-3
        // https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/train/csharp

        //public static List<string> Number(List<string> lines)
        //{
        //    for (int i = 0; i < lines.Count; i++)
        //    {
        //        lines[i] = $"{i + 1}: {lines[i]}";
        //    }
        //    return lines;
        //}


        //  The Coupon Code
        //  https://www.codewars.com/kata/539de388a540db7fec000642/train/csharp

        //public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        //{
        //    if (enteredCode == correctCode && Convert.ToDateTime(currentDate) <= Convert.ToDateTime(expirationDate))
        //        return true;
        //    else
        //        return false;
        //}
    }
}
