using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRank
{
    public class HackerArraySolutions
    {
        public void PrintValues()
        {
            double d = 4.0;
            double d1 = 4;
            int i = 3;
            string s = "HackerRank";
            int numInt;
            float numDouble;
            string stringVal = string.Empty;
            // Read and save an integer, double, and String to your variables.
            numInt = int.Parse(Console.ReadLine());
            numDouble = float.Parse(Console.ReadLine());
            stringVal = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine($"{numInt + i}");

            // Print the sum of the double variables on a new line.
            Console.WriteLine($"{string.Format("{0:n1}", numDouble + d)}");

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine($"{s} {stringVal}");
        }


        public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {
            int sumAttacks = 0;
            bool checkObstacle = k > 0 ? true : false;

            if (n == 1)
            {
                return 0;
            }



            return 1;
        }

        public static int countAttack(bool checkObstacle, bool goUP, int n, int r_q, int c_q, List<List<int>> obstacles)
        {
            int attacks = 0;


            return attacks;
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            int hourGlassSum = 0;
            bool isFirstAssignment = true;

            for (int i = 1; i < arr.Count - 1; i++)
            {
                for(int j = 1; j < arr[0].Count - 1; j++)
                {
                    int curRow = arr[i][j];
                    int previusRow = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1];
                    int nextRow = arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
                    int sum = curRow + previusRow + nextRow;

                    if (isFirstAssignment)
                    {
                        hourGlassSum = sum;
                        isFirstAssignment = false;
                    }
                    else
                    {
                        if (sum > hourGlassSum)
                        {
                            hourGlassSum = sum;
                        }
                    }
                }
            }

            return hourGlassSum;
        }

        public static void minimumBribes(List<int> q)
        {
            int numberOfBribes = 0;
            for(int i = q.Count; i > 0; i--)
            {
                int counter = 0;
                for(int j = i; j > 0; j--)
                {
                    if(i == q[j - 1])
                    {
                        q.RemoveAt(j-1);
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }

                if(counter > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                else
                {
                    numberOfBribes += counter;
                }
            }
            Console.WriteLine(numberOfBribes);
        }

        public static int minimumSwaps(int[] arr)
        {
            int swapCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == i + 1)
                        {
                            int tempValue = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tempValue;
                            swapCounter++;
                            break;
                        }
                    }
                }
            }
            return swapCounter;
        }

        public static int minimumSwaps3(int[] arr)
        {
            int swapCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == i + 1)
                        {
                            int tempValue = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tempValue;
                            swapCounter++;
                            break;
                        }
                    }
                }
            }
            return swapCounter;
        }


        public static int minimumSwaps2(int[] arr)
        {
            int swapCounter = 0;
            for (int i = 1; i <= arr.Length; i++)
            {
                if (arr[i - 1] != i)
                {
                    int tempIndex = i - 1;
                    while (arr[tempIndex] != i)
                    {
                        tempIndex++;
                    }
                    int tempValue = arr[tempIndex];
                    arr[tempIndex] = arr[i - 1];
                    arr[i - 1] = tempValue;
                    swapCounter++;
                }
            }
            return swapCounter;
        }


        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            int maxNum = 0;

            int[] indices = new int[n];
            for(int i = 0; i < queries.Count; i++)
            {
                List<int> temp = queries[i];

                for(int j = temp[0] - 1; j < temp[1]; j++)
                {
                    int currentSum = indices[j] + temp[2];
                    indices[j] = currentSum;
                    maxNum = maxNum > currentSum? maxNum : currentSum;
                }
            }

            return maxNum;
        }

        public static long arrayManipulation2(int n, List<List<int>> queries)
        {
            int maxNum = 0;

            int[] indices = new int[n + 1];
            for (int i = 0; i < queries.Count; i++)
            {
                int start = queries[i][0];
                int end = queries[i][1];

                indices[start - 1] += queries[i][2];
                indices[end] -= queries[i][2]; // end + 1 is being substracted
            }

            int tempSum = 0;
            for(int i = 0; i < indices.Length; i++)
            {
                tempSum += indices[i];
                maxNum = maxNum > tempSum? maxNum : tempSum;
            }

            return maxNum;
        }

        public static int makeAnagram(string a, string b)
        {
            var arrA = a.ToList();
            var arrB = b.ToList();
            int totalLetters = arrA.Count + arrB.Count;
            int counter = 0;

            for (int i = 0; i < arrA.Count; i++)
            {
                for(int j = 0; j < arrB.Count; j++)
                {
                    if(arrA[i] == arrB[j])
                    {
                        arrB.RemoveAt(j);
                        counter++;
                        break;
                    }
                }
            }

            return (totalLetters - (counter * 2));
        }

        public static int alternatingCharacters(string s)
        {
            var arr = s.ToList();
            int counter = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    counter++;
                }
            }

            return counter;
        }

        public static void plusMinus(List<int> arr)
        {
            decimal positive = 0, negative = 0, zero = 0;
            decimal itemCount = arr.Count;

            for(int i = 0; i < arr.Count; i++)
            {
                if(arr[i] == 0)
                {
                    zero++;
                }else if(arr[i] > 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }

            Console.WriteLine(Math.Round(positive / itemCount, 6).ToString());
            Console.WriteLine(Math.Round(negative / itemCount, 6));
            Console.WriteLine(Math.Round(zero / itemCount, 6));
        }

        public static void miniMaxSum(List<int> arr)
        {
            long minimum = arr[0], maximum = arr[0], total = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }

                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
                total += arr[i];
            }
            Console.WriteLine(total - maximum +" "+ (total - minimum));
        }

        public static string timeConversion(string s)
        {
            string[] tComp = s.Split(':');
            string temp = tComp[tComp.Length - 1];
            string seconds = temp.Substring(0, temp.Length - 2);

            int hour = int.Parse(tComp[0]);

            if(temp.Substring(temp.Length - 2, temp.Length - 2) == "PM")
            {
                if(hour != 12)
                {
                    hour += 12;
                }
            }
            else
            {
                if (hour == 12)
                {
                    hour = 12 - hour;
                }
            }

            string sHour = hour.ToString().Length > 1 ? hour.ToString() : $"0"+hour.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(sHour+":");
            sb.Append(tComp[1] + ":");
            sb.Append(seconds);

            return sb.ToString();
        }

        public static int lonelyinteger(List<int> a)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < a.Count; i++)
            {
                if (map.ContainsKey(a[i])) 
                {
                    map[a[i]]++;
                }
                else
                {
                    map[a[i]] = 1;
                }
            }

            foreach(var item in map)
            {
                if(item.Value == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiag = 0, rightDiag = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                List<int> value = arr[i];
                leftDiag += value[i];
                rightDiag += value[value.Count - (i + 1)];
            }

            return Math.Abs(leftDiag - rightDiag);
        }

        public static List<int> countingSort(List<int> arr)
        {
            List<int> newList = new List<int>();
            int[] newarr = new int[100];
            for(int i = 0; i < arr.Count; i++)
            {
                if(newarr[arr[i]] == 0)
                {
                    newarr[arr[i]] = 1;
                }
                else
                {
                    newarr[arr[i]]++;
                }
            }

            for(int i = 0; i < newarr.Length; i++)
            {
                newList.Add(newarr[i]);
            }

            return newList;
        }

        public static int findMedian1(List<int> arr)
        {
            int n = arr.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    int temp = arr[j];
                    if (arr[j] > arr[j + 1])
                    {
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            int mid = (arr.Count / 2) + 1;
            return arr[mid - 1];
        }

        public static int findMedian2(List<int> arr)
        {
            int newValue;
            for (int i = 1; i < arr.Count; i++)
            {
                newValue = arr[i];

                int j = i;

                while (j > 0 && arr[j - 1] > newValue)
                {
                    arr[j] = arr[j - 1];

                    j--;

                }
                arr[j] = newValue;
            }

            int mid = (arr.Count / 2) + 1;
            return arr[mid - 1];
        }

        public static string caesarCipher(string s, int k)
        {
            Dictionary<string, int> keyValues = new Dictionary<string, int>() { { "a", 0 }, { "b", 1 }, { "c", 2 }, { "d", 3 }, { "e", 4 }, { "f", 5 }, { "g", 6 }, { "h", 7 }, { "i", 8 }, { "j", 9 }, { "k", 10 }, { "l", 11 }, { "m", 12 }, { "n", 13 }, { "o", 14 }, { "p", 15 }, { "q", 16 }, { "r", 17 }, { "s", 18 }, { "t", 19 }, { "u", 20 }, { "v", 21 }, { "w", 22 }, { "x", 23 }, { "y", 24 }, { "z", 25 } };



            return "";
        }

        public static List<int> CutTheSticks(List<int> arr)
        {
            List<int> result = new List<int>();
            List<int> sorted = CutTheSticksSort(arr, 0, arr.Count - 1);
            while (sorted.Count > 0)
            {
                int deductedValue = sorted[0];
                result.Add(sorted.Count);
                for (int i = 0; i < sorted.Count; i++)
                {
                    if(sorted[i] == deductedValue)
                    {
                        sorted.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        sorted[i] = sorted[i] - deductedValue;
                    }
                }
            }

            return result;
        }

        private static List<int> CutTheSticksSort(List<int> arr, int low, int high)
        {
            if(low < high)
            {
                int partition = CutTheSticksSortPartition(arr, low, high);

                CutTheSticksSort(arr, low, partition - 1);
                CutTheSticksSort(arr, partition + 1, high);
            }
            return arr;
        }

        private static int CutTheSticksSortPartition(List<int> arr, int low, int high)
        {
            int pivot = arr[high], pivotLoc = low, temp = 0;
            
            for(int i = low; i <= high; i++)
            {
                if(arr[i] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotLoc];
                    arr[pivotLoc] = temp;
                    pivotLoc++;
                }
            }

            temp = arr[pivotLoc];
            arr[pivotLoc] = arr[high];
            arr[high] = temp;
            return pivotLoc;
        }

        public static string decryptPassword(string s)
        {
            //hAck3rr4nk

            //43Ah*ck0rr0nk

            //hAck3rr4nk
            StringBuilder sb = new StringBuilder();
            int lastDigitIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    if(i == s.Length - 1)
                    {
                        sb.Append(s[i].ToString());
                    }
                    else
                    {
                        sb.Append(s[i + 1].ToString());
                        sb.Append(s[i].ToString());
                        i += 2;
                    }
                }
                else if (s[i] == '0')
                {
                    if (lastDigitIndex == 0)
                    {
                        lastDigitIndex = i;
                    }
                    string temp = string.Empty;
                    int tempIndex = 0;
                    for (int k = 0; k < lastDigitIndex; k++)
                    {
                        if (char.IsDigit(s[k]))
                        {
                            temp = s[k].ToString();
                            tempIndex = k;
                        }
                    }

                    if(tempIndex == 0 && string.IsNullOrEmpty(temp))
                    {
                        sb.Append(s[i].ToString());
                    }
                    else
                    {
                        sb.Append(temp);
                        lastDigitIndex = tempIndex;
                    }
                }
                else if(!char.IsDigit(s[i]))
                {
                    sb.Append(s[i].ToString());
                }
            }
            return sb.ToString();
        }

        public static int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int low = 0, high = nums.Length - 1;
            for (int p = nums.Length - 1; p >= 0; p--)
            {
                if (Math.Abs(nums[low]) > Math.Abs(nums[high]))
                {
                    result[p] = nums[low]*nums[low];
                    low++;
                }
                else
                {
                    result[p] = nums[high] *nums[high];
                    high--;
                }
            }
            return result;
        }

        public static void Closesest(List<int> numbers)
        {
            List<int> sortedList = SortNumber(numbers);
            int miniDifference = Math.Abs(sortedList[0] - sortedList[1]);
            Console.WriteLine($"{sortedList[0]} {sortedList[1]}");

            for (int i = 1; i < sortedList.Count - 1; i++)
            {
                if(miniDifference == Math.Abs(sortedList[i] - sortedList[i + 1]))
                {
                    Console.WriteLine($"{sortedList[i]} {sortedList[i + 1]}");
                }
            }
        }


        public static List<int> SortNumber(List<int> arrayofNumbers)
        {
            return QuickSort(arrayofNumbers, 0, arrayofNumbers.Count - 1);
        }

        public static List<int> QuickSort(List<int> arrayofNumbers, int low, int high)
        {
            if (low < high)
            {
                int partition = QuickSortPartitions(arrayofNumbers, low, high);

                QuickSort(arrayofNumbers, low, partition - 1);
                QuickSort(arrayofNumbers, partition + 1, high);
            }
            return arrayofNumbers;
        }

        public static int QuickSortPartitions(List<int> arr, int low, int high)
        {
            int pivot = arr[high], pivotLoc = low, temp = 0;

            for (int i = low; i <= high; i++)
            {
                if (arr[i] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pivotLoc];
                    arr[pivotLoc] = temp;
                    pivotLoc++;
                }
            }

            temp = arr[pivotLoc];
            arr[pivotLoc] = arr[high];
            arr[high] = temp;
            return pivotLoc;
        }

        public static string palindromeChecker(string s, List<int> startIndex, List<int> endIndex, List<int> subs)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <  startIndex.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                int sub = subs[i];
                for (int j = startIndex[i]; j < endIndex[i]; j++)
                {
                  sb.Append(s[j]);
                }

                if(sb.Length == 1)
                {
                    result.Append("1");
                }
                else
                {
                    
                }
            }
            return "";
        }

    }
}
