using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CodeWarsKatasCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 9, 10, 11, 12, 14, 15 };
            Console.WriteLine(FirstNonConsecutive(array));
        }

        /*  Find the first non-consecutive number
          https://www.codewars.com/kata/58f8a3a27a5c28d92e000144/train/csharp
        public static object FirstNonConsecutive(int[] arr)
        {
            
            int index = 0;
            while (index < arr.Length - 1)
            {
                if(index + 1 < arr.Length)
                {
                    if (arr[index] + 1 != arr[index + 1])
                    {
                        return arr[index + 1];
                    }
                    else
                    {
                        index++;
                    }
                }
                else
                {
                    index++;
                }
                
            }
            return null;
        }*/


        /*public static string GetReadableTime(int seconds)
        {
            int hours = (seconds / 3600);
            string formattedHours = (hours < 10) ?  $"0{hours}" :  $"{hours}";

            seconds % = 3600;
            int minutes = seconds / 60;
            string formattedMins = (minutes < 10) ? $"0{minutes}" : $"{minutes}";

            seconds % = 60;
            string formattedSecs = (seconds < 10) ? $"0{seconds}" : $"{seconds}";

            return $"{formattedHours}:{formattedMins}:{formattedSecs}";
        }*/


        /*Moving Zeros To The End
        https://www.codewars.com/kata/52597aa56021e91c93000cb0/solutions/csharp
        public static int[] MoveZeroes(int[] arr)
        {
            int[] answer = new int[arr.Length];
            int indexOfArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    answer[indexOfArr] = arr[i];
                    indexOfArr++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    answer[indexOfArr] = arr[i];
                    indexOfArr++;
                }
            }
            return answer;
        }*\



        /*Create Phone Number
        https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp
        public static string CreatePhoneNumber(int[] numbers)
        {
            string phoneNumber = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                if(i < 1)
                {
                    phoneNumber += $"({numbers[i]}";
                }
                else if (i < 3 || i > 3)
                {
                    phoneNumber += $"{numbers[i]}";
                }

                if (i == 3)
                {
                    phoneNumber += $") {numbers[i]}";
                }
                if(i == 5)
                {
                    phoneNumber += "-";
                }
            }
            return phoneNumber;
        }*/


        /*Multiples of 3 or 5
        https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
        public static int Solution(int value)
        {
            int threes = 0;
            int fives = 0;
            value--;
            while (value > 2)
            {
                if (value % 3 == 0 && value % 5 != 0)
                {
                    threes += value;
                }
                if (value % 5 == 0)
                {
                    fives += value;
                }
                value--;
            }
                return threes + fives;
        }*/


        /*Replace With Alphabet Position
        https://www.codewars.com/kata/546f922b54af40e1e90001da/train/csharp
        public static string AlphabetPosition(string text)
        {
            string onlyLetters = "";
            string answer = "";

            foreach(char letter in text)
            {
                if (Char.IsLetter(letter))
                {
                    onlyLetters += letter;
                }
            }

            for (int i = 0; i < onlyLetters.Count(); i++)
            {
                if (i.Equals(onlyLetters.Count() - 1))
                {
                    answer += $"{Char.ToUpper(onlyLetters[i]) - 64}";
                }
                else 
                {
                    answer += $"{Char.ToUpper(onlyLetters[i]) - 64} ";
                }
            }
            return answer;
        }*/


        /*The Deaf Rats of Hamelin
        https://www.codewars.com/kata/598106cb34e205e074000031/train/csharp
        public static int CountDeafRats(string town)
        {
            int piedPiper = 0; 
            List<string> townList = new List<string>();
            string aRat = "";

            for (int i = 0; i < town.Length; i++)
            {
                if (town[i] != 'P' && town[i] != ' ')
                {
                    aRat = $"{town[i]}{town[i + 1]}";
                    townList.Add(aRat);
                    i++;
                }
                if(town[i] == 'P')
                {
                    townList.Add($"{town[i]}");
                    piedPiper = townList.IndexOf("P");
                }
            }

            int ratCount = 0;
            for (int i = 0; i < townList.Count(); i++)
            {
                if (townList[i] == "O~" && i < piedPiper)
                {
                    ratCount++;
                }
                if (townList[i] == "~O" && i > piedPiper)
                {
                    ratCount++;
                }
            }
            return ratCount;
        }*/


        /*public static string GetOrder(string input) TODO
        {
            string[] orders = new string[] { "burger", "fries", "chicken", "pizza", "sandwich", "onionrings", "milkshake" , "coke" };
            Regex.Replace(input, "burger", );
            string fixedOrder = "";
            foreach(string order in orders)
            {
                if ( == order)
                {
                    pu
                }
            }

            return string.Empty;*/


        /*Find the unique number
        https://www.codewars.com/kata/585d7d5adb20cf33cb000235/train/csharp
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int[] nums = numbers.ToArray();
            int firstOne = nums[0];
            int lastOne = nums[nums.Length - 1];
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != firstOne && nums[i] != lastOne)
                {
                    return nums[i];
                }
                else if (nums[i] != firstOne)
                {
                    return firstOne;
                }
                else if (nums[i] != lastOne)
                {
                    return lastOne;
                }
            }
            return firstOne;
        }*/


        /*Unique In Order
        https://www.codewars.com/kata/54e6533c92449cc251001667/train/csharp
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> answer = new List<T>();
            T[] useable = iterable.ToArray();
            if (iterable == null || iterable.Count() == 0)
            {
                return iterable;
            }
            answer.Add(useable[0]);
            T lastOne = useable[0];
            for(int i = 1; i < useable.Length; i++)
            {
                if(IComparer<T>.Equals(lastOne, useable[i]))
                {

                }
                else
                {
                    answer.Add(useable[i]);

                }
                lastOne = useable[i];
            }
            return answer;
        }*/


        /*Find the smallest - TODO
        https://www.codewars.com/kata/573992c724fc289553000e95/train/csharp
        public static long[] Smallest(long n)
        {
            long min = 0;
            long indexOfSmall = 0;
            int[] originalNumber = n.ToString().Select(t => int.Parse(t.ToString())).ToArray();

            for (int i = 1; i < originalNumber.Length; i++)
            {
                if(i < 2)
                {
                    min = originalNumber[i];
                    indexOfSmall = i;
                }
                if (min > originalNumber[i])
                {
                    min = originalNumber[i];
                    indexOfSmall = i;
                }
            }

            int indexOfRemoved = 0;
            long[] smallestRemoved = new long[originalNumber.Length - 1];

            for (int i = 0; i < originalNumber.Length; i++)
            {
                if(originalNumber[i] == min )
                {
                    indexOfSmall = i;
                }
                else
                {
                    smallestRemoved[indexOfRemoved] = originalNumber[i];
                    indexOfRemoved++;
                }
            }

            int index = 0;
            long newMin = min;
            long indexOfNewSmall = 0;
            string smallestNumber = "";

            while (index < originalNumber.Length - 1)
            {
                if(min < smallestRemoved[index])
                {
                    smallestNumber += min;
                    indexOfNewSmall = index;
                    min = 10; 
                }
                else
                {
                    smallestNumber += smallestRemoved[index];
                    index++;
                    if (index < smallestRemoved.Length && index > 1)
                    {
                        min = smallestRemoved[index];
                    }

                }
            }

            long smallConvertedToNumber = Convert.ToInt64(smallestNumber);
            long[] answer = new long[3]{ smallConvertedToNumber, indexOfSmall, indexOfNewSmall };
            return answer;
        }*/


        /*public static string Likes(string[] name)
        {
            if(name.Length == 0)
            {
                return "no one likes this";
            }
            if(name.Length == 1)
            {
                return $"{name[0]} likes this";
            }
            if(name.Length == 2)
            {
                return $"{name[0]} and {name[1]} like this";
            }
            if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else
            {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }*/


        /*Filter out the geese
          https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7/train/csharp
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
            List<string> correctGeese = new List<string>();

            foreach (string bird in birds)
            {
                bool inList = false;
                foreach (string goose in geese)
                {
                    if (bird.Contains(goose))
                    {
                        inList = true;
                    }
                }
                if (!inList)
                {
                    correctGeese.Add(bird);
                }
            }
            return correctGeese;
        }*/


        /* 8kyu interpreters: HQ9+
         https://www.codewars.com/kata/591588d49f4056e13f000001/train/csharp
        public static string Interpret(string code)
        {
        if (code == "H")
        {
           return "Hello World!";
        }
        else if (code == "Q")
        {
           return code;
        }
        else if (code == "9")
        {
           string beers = "";

           for (int i = 99; i > 1; i--)
           {
               beers += $"{i} bottles of beer on the wall, {i} bottles of beer.\n" +
                        $"Take one down and pass it around, {i - 1} bottles of beer on the wall.\n";
           }
           beers += $"2 bottles of beer on the wall, 2 bottles of beer.\n" +
                    $"Take one down and pass it around, 1 bottle of beer on the wall.\n" +
                    $"1 bottle of beer on the wall, 1 bottle of beer.\nTake one down and pass it around," +
                    $" no more bottles of beer on the wall.\nNo more bottles of beer on the wall, no more" +
                    $" bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";

           return beers;
        }
        else
        {
           return null;
        }

        }*/


        /*For UFC Fans(Total Beginners) : Conor McGregor vs George Saint Pierre
          https://www.codewars.com/kata/for-ufc-fans-total-beginners-conor-mcgregor-vs-george-saint-pierre/train/csharp
        public static string Quote(string fighter)
        {
            fighter = fighter.ToLower();
            if (fighter == "conor mcgregor")
            {
                return "I'd like to take this chance to apologize.. To absolutely NOBODY!";
            }
            else
            {
                return "I am not impressed by your performance.";
            }
        }*/


        /*Counting sheep...
          https://www.codewars.com/kata/54edbc7200b811e956000556/train/csharp
        public static int CountSheeps(bool[] sheeps)
        {
            int result = 0;
            foreach (bool sheep in sheeps)
            {
                if (sheep == true)
                {
                    result++;
                }
            }
            return result;
        }*/


        /*You only need one - Beginner
        https://www.codewars.com/kata/you-only-need-one-beginner/train/csharp
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }*/


        /*Opposite number
        https://www.codewars.com/kata/opposite-number/train/csharp
        public static int Opposite(int number)
        {
            if (number > 0)
            {
                number = number - (number * 2);
                return number;
            }
            else
            {
                number = number + (number * -2);
                return number;
            }
        }*/


        /*Return Negative
        https://www.codewars.com/kata/return-negative/train/csharp
        public static int MakeNegative(int number)
        {
            string changeIt = "";
            int negative = 0;
            if (number > 0)
            {
                changeIt = $"-{number.ToString()}";
                negative = Convert.ToInt32(changeIt);
                return negative;

            }
            return number;
        }*/


        /*Remove First and Last Character
        https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/train/csharp
        public static string Remove_char(string s)
        {
            var removed = "";
            for (int i = 1; i < s.Length - 1; i++)
            {
                removed += s[i];
            }
            return removed;
        }*/


        /*MakeUpperCase
        https://www.codewars.com/kata/makeuppercase/train/csharp
        public static string MakeUpperCase(string str)
        {
            str = str.ToUpper();
            return str;
        }*/


        /*Man in the west
          https://www.codewars.com/kata/man-in-the-west/train/csharp
        public static bool CheckTheBucket(string[] bucket)
        {
            foreach (string result in bucket)
            {
                if (result == "gold")
                {
                    return true;
                }
            }
            return false;
        }*/


        /*Reversed sequence
        https://www.codewars.com/kata/reversed-sequence/train/csharp
        public static int[] ReverseSeq(int n)
        {
            int[] sequence = new int[n];
            int value = n;
            for (int i = 0; i < n; i++)
            {
                sequence[i] = value;
                value--;
            }

            return sequence;
        }*/


        /*Are arrow functions odd?
         https://www.codewars.com/kata/are-arrow-functions-odd/train/csharp
        public static List<int> Odds(List<int> values) =>
            values.Where(value => value % 2 != 0).ToList();*/


        /*Count Odd Numbers below n
        https://www.codewars.com/kata/count-odd-numbers-below-n/train/csharp
        public static ulong OddCount(ulong n)
        {
            return n / 2;
        }*/


        /*String repeat
          https://www.codewars.com/kata/string-repeat/train/csharp
        public static string RepeatStr(int n, string s)
        {
            string repeatedString = "";
            for (int i = 0; i < n; i++)
            {
                repeatedString += s;
            }
            return repeatedString;
        }*/


        /*Remove String Spaces
        https://www.codewars.com/kata/remove-string-spaces/train/csharp
        public static string NoSpace(string input)
        {
            string unspaced = "";
            for (int letter = 0; letter < input.Length; letter++)
            {
                if (!Char.IsWhiteSpace(input[letter]))
                {
                    unspaced += input[letter];
                }
            }
            return unspaced;
        }*/


        /*A Strange Trip to the Market
          https://www.codewars.com/kata/a-strange-trip-to-the-market/train/csharp
        public static bool IsLockNessMonster(string sentence)
        {
            sentence = sentence.ToLower();
            if (sentence.Contains("tree fiddy") || sentence.Contains("3.50") || sentence.Contains("three fifty"))
            {
                return true;
            }
            return false;
        }*/


        /*Kata Example Twist
        https://www.codewars.com/kata/525c1a07bb6dda6944000031/solutions/csharp

        public static string[] Websites = new string[1000];
        static string[] websites = TwistIt();
        public static string[] TwistIt()
        {
            Array.Fill(Websites, "codewars");
            return Websites;
        }*/


        /*Basic subclasses - Adam and Eve
        https://www.codewars.com/kata/basic-subclasses-adam-and-eve/train/csharp
        public class God
        {
            public static Human[] Create()
            {
                Human[] people = new Human[2] { new Man(), new Woman() };
                return people;
            }
        }
        public class Human { }
        public class Man : Human { }
        public class Woman : Human { }*/


        /*Grasshopper - Terminal game combat function
          https://www.codewars.com/kata/grasshopper-terminal-game-combat-function-1/train/csharp
        public static float Combat(float health, float damage)
        {
            health -= damage;
            if (health < 0)
                health = 0;
            return health;
        }*/


        /*Sentence Smash
          https://www.codewars.com/kata/sentence-smash/train/csharp
        static void Main(string[] args)
        {
            string[] words = { "this", "is", "a", "really", "long", "sentence" };

            Console.WriteLine(Smash(words));
        }*/


        /*public static string Smash(string[] words)
        {
            var sentence = "";
            for (int index = 0; index < words.Length; index++)
            {
                if (index != words.Length - 1)
                {
                    sentence += $"{words[index]} ";
                }
                else
                {
                    sentence += $"{words[index]}";
                }
            }
            return sentence;
        }*/


        /*Calculate average
          https://www.codewars.com/kata/calculate-average/train/csharp

        static void Main(string[] args)
        {
            double[] array = { };
            Console.WriteLine(FindAverage(array));
        }

        public static double FindAverage(double[] array)
        {
            double total = 0;
            if (!array.All(value => value.Equals(double.NaN)))
            {
                foreach (double value in array)
                {
                    total += value;
                }
                return total / array.Length;
            }
            else
            {
                return 0;
            }
        }*/


        /*Calculate BMI
          https://www.codewars.com/kata/57a429e253ba3381850000fb/train/csharp

        static void Main(string[] args)
        {
            Console.WriteLine(Bmi(80, 1.80));
        }

        public static string Bmi(double weight, double height)
        {
            double bmi = (weight / Math.Pow(height, 2));
            if (bmi <= 18.5)
            {
                return "Underweight";
            }
            else if (bmi <= 25.0)
            {
                return "Normal";
            }
            else if (bmi <= 30.0)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }*/


        /*The Supermarket Queue
        https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp

        static void Main(string[] args)
        {
            int[] customers = { 1, 2, 3, 4 };
            Console.WriteLine(QueueTime(customers, 2));
        }
        int[] customers = { 1, 2, 3, 4 };

        public static long QueueTime(int[] customers, int n)
        {
            int[] tillsFilled = new int[n];
            int nextCustomer = 0;
            int tempTime = -1;

            do
            {
                for (int index = 0; index < tillsFilled.Length; index++)
                {
                    if (tillsFilled[index] != 0)
                    {
                        tillsFilled[index]--;
                    }

                    if (tillsFilled[index] == 0 && nextCustomer < customers.Length)
                    {
                        tillsFilled[index] = customers[nextCustomer];
                        nextCustomer++;
                    }
                }
                tempTime++;
            } while (!tillsFilled.All(till => till.Equals(0)));
            return tempTime;
        }*/


        /*Detect Pangram
          https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp

        public static bool IsPangram(string str)
        {
            return str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
        }*/


        /*Sum of Triangular Numbers
          https://www.codewars.com/kata/580878d5d27b84b64c000b51/train/csharp

        static void Main(string[] args)
        {
            Console.WriteLine(SumTriangularNumbers(4));
        }

        public static int SumTriangularNumbers(int n)
        {
            var result = 0;
            if (n <= 0)
            {
                return 0;
            }
            else
            {
                result = (n * (n + 1) * (n + 2)) / 6;
            }
            return result;
        }*/


        /*Break camelCase
          https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp

        static void Main(string[] args)
        {
            var alpha = "camelCasing";
            Console.WriteLine(BreakCamelCase(alpha));
        }

        public static string BreakCamelCase(string str)

        {
            for (int index = 0; index < str.Length; index++)
            {
                if (Char.IsUpper(str[index]))
                {
                    str = str.Insert(index, " ");
                    index++;
                }
            }
            return str;
        }*/


        /*Love vs friendship
        https://www.codewars.com/kata/59706036f6e5d1e22d000016/train/csharp

        public static int WordsToMarks(string str)
        {
            var wordTotal = 0;
            char[] wordSeperated = str.ToCharArray();
            foreach (char letter in wordSeperated)
            {
                wordTotal += (char.ToUpper(letter) - 64);
            }
            return wordTotal;
        }*/


        /*Find the stray number
         https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp

        public static int Stray(int[] numbers)
        {
            Array.Sort(numbers);
            if (numbers[0] != numbers[1])
            {
                return numbers[0];
            }
            else
            {
                return numbers[numbers.Length - 1];
            }
        }*/


        /*Two Sum
          https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp

        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] answer = new int[2];
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        answer[0] = i;
                        answer[1] = j;
                        return answer;

                    }
                }
            }
            return answer;
        }*/


        /*Sort Number
          https://www.codewars.com/kata/5174a4c0f2769dd8b1000003/train/csharp

        public static int[] SortNumbers(int[] nums)
        {
            if (nums != null && nums.Length != 0)
            {
                Array.Sort(nums);
            }
            else
            {
                nums = new int[0];
            }
            return nums;
        }*/


        /*Testing 1-2-3
         https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/train/csharp

        public static List<string> Number(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = $"{i + 1}: {lines[i]}";
            }
            return lines;
        }*/


        /*The Coupon Code
        https://www.codewars.com/kata/539de388a540db7fec000642/train/csharp

        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {
            if (enteredCode == correctCode && Convert.ToDateTime(currentDate) <= Convert.ToDateTime(expirationDate))
                return true;
            else
                return false;
        }*/
    }
}
