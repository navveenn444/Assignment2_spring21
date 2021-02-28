
using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 101, 102, 103, 104, 105, 106 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                /* validating input parameters*/
                if (n != nums.Length / 2 || nums.Length == 0 || n < 1) //
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                int[] arrshuffle = new int[nums.Length]; //initialize a new array
                int a = 0;
                int b = n;
                for (int i = 0; i < 2 * n; i += 2) //Incrementing i by 2 for adding two elements in each iteration. * a is incremented for x's and b is incremented for y's 
                {
                    arrshuffle[i] = nums[a];
                    arrshuffle[i + 1] = nums[b];
                    a++;
                    b++;
                }
                foreach (var x in arrshuffle)
                {
                    Console.Write(x + " "); //displaying the new array as x1 y1 x2 y2...
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int count = 0, p = 0;
                for (int i = 0; i < ar2.Length; i++)
                {
                    if (ar2[i] == 0)
                        count++; //count the number of zeroes in the array
                    else
                    {
                        ar2[p] = ar2[i]; // if the value is not zero, position it from the start of the array
                        p++;
                    }
                }
                for (int i = ar2.Length - count; i < ar2.Length; i++)
                {
                    ar2[i] = 0; //input the zeroes in the array after all the non-zero elements
                }
                foreach (var z in ar2)
                {
                    Console.Write(z + " "); //Displaying the output array after all the zeroes are moved to the end.
                }
                Console.WriteLine();


            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                if (nums.Length == 0) // if input arr is of length 0, return as invalid input
                {
                    Console.WriteLine("Invalid input"); 
                    return;
                }
                Dictionary<int, int> coolpairs = new Dictionary<int, int>(); //Initialized the dictionary to add elements from nums array
                int count = 1;
                int add = 0;
                
                for (int i = 0; i < nums.Length; i++) //Iterate through the dictionary
                {
                    if (coolpairs.ContainsKey(nums[i])) //if the key is present already in the dictionary, ignore adding the value by incrementing the position in dictionary
                    {
                        coolpairs[nums[i]]++;
                    }
                    else
                    {
                        coolpairs.Add(nums[i], count); // Add the given element if it is not present in the dictionary already with key as element and value as 1.
                    }
                }
                foreach (var b in coolpairs)
                {
                    int n = b.Value;
                    add += n * (n - 1) / 2;  //Calculating the total no. of cool pairs= n*(n-1)/2 and adding it to the add var
                }

                Console.WriteLine(add); //Printing the sum of all cool pairs
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                int x = 0, y = 0;
                Dictionary<int, int> diff = new Dictionary<int, int>(); //Creating a dictionary to store difference between target and current element value
                for (int i = 0; i < nums.Length; i++)
                {
                    if (diff.ContainsKey(nums[i])) //if key is contained in the dictionary, display i and value as output
                    {
                        x = diff[nums[i]];
                        y = i;
                        Console.WriteLine("[" + x + "," + y + "]");
                    }
                    else
                    {
                        diff.Add(target - nums[i], i); //if the key is not present, add the difference of target and current element in the dictionary. Also position of the current element is the value being added here.
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                if (indices.Length != s.Length) // Check if the input matches the pre-condition
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                char[] newStr = new char[s.Length]; // Initialize a new array for shuffled string
                for (int i = 0; i < s.Length; i++)
                {
                    newStr[indices[i]] = s[i]; // placing the respective indices[i] in the new array
                }
                foreach (var x in newStr)
                {
                    Console.Write(x); //printing char output array
                }
                Console.WriteLine();

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                if (s1.Length != s2.Length) // Two strings are not isomorphic if the length of two strings are different
                {
                    return false;
                }
                // Create a dictionary to compare the similarity of the characters from both the input strings
                Dictionary<char, char> dict = new Dictionary<char, char>(); //
                // Use the loop to traverse through both the strings to compare the similarity of the strings
                for (int i = 0; i < s1.Length; i++)
                {
                    // If the dictionary contains the key then we compare it with the corresponding value with the character at the same position from the second string
                    if (dict.ContainsKey(s1[i]))
                    {
                        // Return false if the dictionary value from first string doesn't match with the second string's character at the corresponding position 
                        if (dict[s1[i]] != s2[i])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        dict.Add(s1[i], s2[i]); // If the dictionary does not contain the first string character at that corresponding position we add it to the dictionary
                    }
                }
                HashSet<char> set = new HashSet<char>(dict.Values); // Declare a hash set to store all the dicitonary values
                if (set.Count == dict.Values.Count) // if the total count in hashset and dictionary are same then it is isomorphic 
                {
                    return true;
                }
               
                return false;  //Return false in all other cases
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                Dictionary<int, List<int>> score = new Dictionary<int, List<int>>();
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    if (score.ContainsKey(items[i, 0])) //insert score in value list if key is found

                    {
                        score[items[i, 0]].Add((items[i, 1]));
                    }
                    //add ID and score from items list to dictionary if the key is not found.
                    else
                    {
                        score.Add(items[i, 0], new List<int>());
                        score[items[i, 0]].Add((items[i, 1]));
                    }
                }
                //Traverse through dictionary
                foreach (var s in score)
                {
                    s.Value.Sort(); //sorting the values of dictionary
                    s.Value.Reverse(); //we get descending order by reversing
                }
                foreach (var b in score)
                {
                    int sum = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        sum += b.Value[i]; //Adding first five marks for each student
                    }
                    b.Value[1] = sum; // Insert the sum value in dictionary list
                }
                Console.Write("[");
                foreach (var b in score)
                {
                    Console.Write("[{0},{1}]", b.Key, b.Value[1] / 5); //Print the average of the sum
                }
                Console.Write("]");
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                int sum = 0;
                int a = n;
                Dictionary<int, int> happy = new Dictionary<int, int>(); //Initializing the dictionary 
                while (n != 1) //the loop runs until n=sum=1
                {
                    while (n != 0) 
                    {
                        sum += (n % 10) * (n % 10); //square the digit and add it to the sum
                        n /= 10;
                    }
                    n = sum;
                    //if sum is in happy dictionary or the starting number=sum then automatically it is not Happy number, it keeps on continuning 
                    if (happy.ContainsKey(sum) || sum == a)
                        return false;
                    happy.Add(sum, 1);
                    sum = 0;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                int profit = 0; // Initialize max variable for profit
                //this is used for initializing min price of stock on that particular day.
                int buystock = prices[0];
                for (int i = 1; i < prices.Length; i++)
                {
                    //Finding the min of buy_stock and prices[i]
                    buystock = Math.Min(buystock, prices[i]); 
                    //FInding the max of earlier max and (prices[i] - buy_stock) for the profit.
                    profit = Math.Max(profit, (prices[i] - buystock));
                }
                return profit; // return the max
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                int m = 1, n = 2;
                int ways = 0;
                if (steps == 1) //there will be only 1 way to climb if the steps = 1
                    Console.WriteLine(1);
                if (steps == 2) //there will be only 2 way to climb if the steps = 2
                    Console.WriteLine(2);
                else
                {
                    for (int i = 2; i < steps; i++)
                    //adding preceeding 2 elements will fetch the no. of possible ways
                    {
                        ways = m + n;
                        m = n;
                        n = ways;
                    }
                }
                Console.WriteLine(ways); //printing the total no. of ways 

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
