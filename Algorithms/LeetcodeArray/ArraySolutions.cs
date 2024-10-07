using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetcodeArray
{
    public class ArraySolutions
    {
        public static int[] RunningSum(int[] nums)
        {
            //int[] runningSum = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
            }
            return nums;
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int highestSum = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int[] row = accounts[i];
                int sum = 0;
                for (int j = 0; j < row.Length; j++)
                {
                    sum += row[j];
                }
                highestSum = sum > highestSum ? sum : highestSum;
            }
            return highestSum;
        }

        public static int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "--X" || operations[i] == "X--")
                {
                    x--;
                }
                else
                {
                    x++;
                }
            }
            return x;
        }

        public static int[] CountBits(int n)
        {
            int[] bits = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                bits[i] = bits[i / 2];
                if (i % 2 == 1) bits[i]++;
            }
            return bits;
        }

        public static int MostWordsFound(string[] sentences)
        {
            int highestWords = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                highestWords = sentences[i].Split(' ').Length > highestWords ? sentences[i].Length : highestWords;
            }
            return highestWords;
        }

        public static bool IsSubsequence(string s, string t)
        {
            int nextIndex = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                bool found = false;
                for (int j = nextIndex; j < t.Length; j++)
                {
                    nextIndex = j + 1;

                    if (s[i] == t[j])
                    {
                        sb.Append(s[i]);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return false;
                }
            }

            if (sb.ToString() == s)
            {
                return true;
            }
            return false;
        }

        public static int NumberOfArithmeticSlices(int[] nums)
        {
            int counter = 0;
            if (nums.Length < 3)
            {
                return 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = 0;
                bool hasPreviousDiff = false;
                for (int j = i; j < nums.Length - 1; j++)
                {
                    if (!hasPreviousDiff)
                    {
                        difference = nums[j + 1] - nums[j];
                        hasPreviousDiff = true;
                    }
                    else
                    {
                        if (difference != (nums[j + 1] - nums[j]))
                        {
                            break;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }

        public static double ChampagneTower(int poured, int query_row, int query_glass)
        {
            ////Get numbers of poured required to fill all the glasses at this row
            //int pouredRequired = 0;
            //for(int i =0; i <= query_row; i++)
            //{
            //    pouredRequired += i + 1;
            //}

            //int numGlasses = query_row + 1;
            //if (poured <= (pouredRequired - numGlasses))
            //{
            //    return Math.Round(0.0, 5);
            //}
            //else if( poured >= pouredRequired)
            //{
            //    return Math.Round(1.0, 5);
            //}
            //else
            //{
            //    if(query_row < 2)
            //    {
            //        int diff = pouredRequired - numGlasses;
            //        double numDiff = (double)diff / numGlasses;
            //        return Math.Round(numDiff, 5);
            //    }
            //    else
            //    {
            //        int diff = pouredRequired - poured;
            //        double numDiff = (double)diff / (numGlasses - 1);
            //        return Math.Round(numDiff, 5);
            //    }
            //}

            double[][] A = new double[102][];
            A[0][0] = (double)poured;
            for (int r = 0; r <= query_row; ++r)
            {
                for (int c = 0; c <= r; ++c)
                {
                    double q = (A[r][c] - 1.0) / 2.0;
                    if (q > 0)
                    {
                        A[r + 1][c] += q;
                        A[r + 1][c + 1] += q;
                    }
                }
            }

            return Math.Min(1, A[query_row][query_glass]);
        }

        public int DeleteAndEarn(int[] nums)
        {
            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (valuePairs.ContainsKey(nums[i]))
                {
                    valuePairs[valuePairs[i]] += valuePairs[i];
                }
                else
                {
                    valuePairs[i] = valuePairs[i];
                }
            }

            return 2;
        }

        public static string RemoveDuplicateLetters(string key)
        {
            // Store the result in this string.
            string result = "";

            // Loop over each character.
            foreach (char value in key)
            {
                // See if character is in the table.
                int indexofinitil = result.IndexOf(value);
                if (indexofinitil == -1)
                {
                    // Append to the table and the result.
                    result += value;
                }
                else
                {
                    if (indexofinitil < result.Length - 1 && result[indexofinitil + 1] < result[indexofinitil])
                    {
                        result = result.Remove(indexofinitil, 1);
                        result += value;
                    }
                    else if (result[result.Length - 1] < value)
                    {
                        result = result.Remove(indexofinitil, 1);
                        result += value;
                    }
                }
            }
            return result;
        }

        public static int TwoCitySchedCost(int[][] costs)
        {
            int sumA = 0, sumB = 0;
            for (int i = 0; i < costs.Length; i++)
            {
                if (costs[i][0] < costs[i][1])
                {

                }

                if (sumA + costs[i][0] < sumB + costs[i][1])
                {
                    sumA += costs[i][0];
                }
                else
                {
                    sumB += costs[i][1];
                }
            }
            return sumA + sumB;
        }

        public static int RomanToInt(string s)
        {
            int sum = 0;
            bool doSubstraction = false;
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    if (!doSubstraction)
                    {
                        if (map[s[i]] <= map[s[i - 1]])
                        {
                            sum += map[s[i]];
                        }
                        else
                        {
                            doSubstraction = true;
                        }
                    }
                    else
                    {
                        int temp = map[s[i + 1]] - map[s[i]];
                        sum += temp;
                        doSubstraction = false;
                    }
                }
                else
                {
                    if (!doSubstraction)
                    {
                        sum += map[s[i]];
                    }
                    else
                    {
                        int temp = map[s[i + 1]] - map[s[i]];
                        sum += temp;
                        doSubstraction = false;
                    }
                }
            }
            return sum;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            StringBuilder sb = new StringBuilder();
            bool check = false;
            int currentIndex = 0;

            if (strs.Length == 0)
            {
                return "";
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            do
            {
                char current = ' ';
                for (int i = 0; i < strs.Length; i++)
                {
                    string temp = strs[i];
                    if (temp.Length > currentIndex && current == ' ')
                    {
                        current = temp[currentIndex];
                    }
                    else
                    {
                        if (temp.Length > currentIndex)
                        {
                            if (current == temp[currentIndex])
                            {
                                if (i == strs.Length - 1)
                                {
                                    sb.Append(temp[currentIndex]);
                                    check = true;
                                }
                            }
                            else
                            {
                                check = false;
                                break;
                            }
                        }
                        else
                        {
                            check = false;
                            break;
                        }
                    }
                }
                currentIndex++;
            } while (check == true);

            return sb.ToString();
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[2 * n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                result[counter] = nums[i];
                result[counter + 1] = nums[n + i];
                counter += 2;
            }

            return result;
        }

        public static int MaxRepOpt1(string text)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (dic.ContainsKey(text[i].ToString()))
                {
                    dic[text[i].ToString()] = dic[text[i].ToString()] + 1;
                }
                else
                {
                    dic[text[i].ToString()] = 1;
                }
            }

            int highest = 0;
            foreach (var keyPair in dic)
            {
                if (keyPair.Value > highest)
                {
                    highest = keyPair.Value;
                }
            }

            return highest;
        }

        public static string BestHand(int[] ranks, char[] suits)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>() { { 5, "Flush" }, { 3, "Three of a Kind" }, { 2, "Pair" }, { 1, "High Card" } };
            Dictionary<int, int> rankTracker = new Dictionary<int, int>();
            Dictionary<int, int> suitTracker = new Dictionary<int, int>();
            int suitCounter = 1;

            for (int i = 0; i < suits.Length; i++)
            {
                if (suitTracker.ContainsKey(suits[i]))
                {
                    suitTracker[suits[i]] = suitTracker[suits[i]] + 1;
                    suitCounter++;
                }
                else
                {
                    suitTracker[suits[i]] = 1;
                }


                if (rankTracker.ContainsKey(ranks[i]))
                {
                    rankTracker[ranks[i]] = rankTracker[ranks[i]] + 1;
                }
                else
                {
                    rankTracker[ranks[i]] = 1;
                }
            }

            if (suitCounter == suits.Length)
            {
                return dic[suits.Length];
            }

            int highestRank = 0;
            foreach (var keyPair in rankTracker)
            {
                if (keyPair.Value > highestRank)
                {
                    highestRank = keyPair.Value;
                }
            }

            if (highestRank >= 3)
            {
                return dic[3];
            }
            else if (highestRank == 2)
            {
                return dic[2];
            }


            return dic[1];
        }

        public static long ZeroFilledSubarray(int[] nums)
        {
            HashSet<long> set = new HashSet<long>();
            Dictionary<int, int> dic = null;
            int zeroCounter = 0;
            long sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && zeroCounter == 0)
                {
                    dic = new Dictionary<int, int>();
                    zeroCounter++;
                    dic[zeroCounter] = 1;
                    sum += 1;
                }
                else if (nums[i] == 0)
                {
                    zeroCounter++;
                    dic[zeroCounter] = dic[zeroCounter - 1] + zeroCounter;
                    sum += zeroCounter;
                }
                else
                {
                    zeroCounter = 0;
                    dic = new Dictionary<int, int>();
                }
            }

            return sum;
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int counter = 1;
            int lastEncounteredVal = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (lastEncounteredVal != nums[i] && lastEncounteredVal < nums[i])
                {
                    nums[counter] = nums[i];
                    lastEncounteredVal = nums[i];
                    counter++;
                }
            }
            return counter;
        }

        public static int PivotIndex(int[] nums)
        {
            if (nums.Length == 1)
            {
                if (nums[0] == 0)
                {
                    return 0;
                }
                return -1;
            }

            int leftSum = 0, rightSum = 0;
            int totalSum = 0, progressiveSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                totalSum += nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    if (leftSum == (totalSum - nums[i]))
                    {
                        return i;
                    }
                }
                else if (i == (nums.Length - 1))
                {
                    if (rightSum == (totalSum - nums[i]))
                    {
                        return i;
                    }
                }
                else
                {
                    if (progressiveSum == (totalSum - nums[i] - progressiveSum))
                    {
                        return i;
                    }
                }

                progressiveSum += nums[i];
            }
            return -1;
        }

        public static int PivotIndex2(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            int leftSum = 0, rightSum = 0;

            return -1;
        }


        public static void ReverseString(char[] s)
        {
            if (s.Length == 1)
            {
                return;
            }
            int mid = s.Length / 2;

            for (int i = 0; i < mid; i++)
            {
                char temp = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = s[i];
                s[i] = temp;
            }
        }

        public static IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
        {
            List<IList<int>> listList = new List<IList<int>>();
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();

            for (int i = 0; i < items1.Length; i++)
            {
                int value = items1[i][0];
                if (dictionary.ContainsKey(value))
                {
                    listList.Add(new List<int>() { value, dictionary[value][1] + items1[i][1] });
                    dictionary.Remove(value);
                }
                else
                {
                    dictionary[value] = new List<int>() { value, items1[i][1] };
                }
            }

            for (int i = 0; i < items2.Length; i++)
            {
                int value = items2[i][0];
                if (dictionary.ContainsKey(value))
                {
                    listList.Add(new List<int>() { value, dictionary[value][1] + items2[i][1] });
                    dictionary.Remove(value);
                }
                else
                {
                    dictionary[value] = new List<int>() { value, items2[i][1] };
                }
            }

            //Populate the remaining item in the dictionary into the list
            foreach (var item in dictionary)
            {
                listList.Add(item.Value);
            }

            if (listList.Count == 1)
            {
                return listList;
            }

            //sort the value
            bool found;
            do
            {
                found = false;
                for (int i = 1; i < listList.Count; i++)
                {
                    if (listList[i - 1][0] > listList[i][0])
                    {
                        var temp = listList[i - 1];
                        listList[i - 1] = listList[i];
                        listList[i] = temp;
                        found = true;
                    }
                }
            } while (found);

            return listList;
        }

        public static long CountBadPairs(int[] nums)
        {
            long counter = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    int jDiff = j - i;
                    int numDiff = nums[j] - nums[i];
                    if (i < j && jDiff != numDiff)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static long CountBadPairs2(int[] nums)
        {
            long counter = 0;
            long len = nums.Length;
            long total = len * (len - 1) / 2;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < len; i++)
            {
                int v = i - nums[i];
                dict.TryGetValue(v, out int prev);
                counter += prev;
                dict[v] = prev + 1;
            }
            Console.WriteLine(total);
            return total - counter;
        }

        public static int CountKDifference(int[] nums, int k)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (k == Math.Abs(nums[i] - nums[j]))
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public static long FindPairs(int[] nums, int k)
        {
            int counter = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dict.TryGetValue(nums[i], out int prev);
                dict[nums[i]] = prev + 1;
            }

            foreach (var item in dict)
            {
                if (k > 0 && dict.ContainsKey(item.Key + k) || k == 0 && dict[item.Key] > 1)
                {
                    counter++;
                }
            }

            return counter;
        }


        public static long TaskSchedulerII(int[] tasks, int space)
        {
            return 1;
        }

        public static IList<IList<int>> FindSubsequences(int[] nums)
        {
            int startIndex = 0;
            List<int> previous;
            List<IList<int>> result = new List<IList<int>>();

            while (startIndex < nums.Length)
            {
                previous = new List<int>() { nums[startIndex] };
                for (int i = startIndex + 1; i < nums.Length; ++i)
                {
                    if (previous[previous.Count - 1] <= nums[i])
                    {
                        List<int> temp = new List<int>();
                        temp.AddRange(previous);
                        temp.Add(nums[i]);
                        previous = temp;
                        result.Add(temp);
                    }
                }
                startIndex++;
            }

            return result;
        }

        public static int GetCommon(int[] nums1, int[] nums2)
        {
            for (int i = 0; i < nums1.Length; ++i)
            {
                for (int j = 0; j < nums2.Length; ++j)
                {
                    if (nums2[j] > nums1[i])
                    {
                        break;
                    }

                    if (nums2[j] == nums1[i])
                    {
                        return nums1[i];
                    }
                }
            }

            return -1;
        }

        public static long MinOperations(int[] nums1, int[] nums2, int k)
        {
            int counter = 0;
            bool loop = false;
            bool increment = false;
            bool decrement = false;

            do
            {
                loop = false;
                increment = false;
                decrement = false;

                for (int i = 0; i < nums1.Length; i++)
                {
                    if (nums1[i] != nums2[i])
                    {
                        loop = true;
                        if (nums1[i] < nums2[i] && increment == false)
                        {
                            if (nums1[i] + k <= nums2[i])
                            {
                                nums1[i] = nums1[i] + k;
                                increment = true;
                            }
                            else
                            {
                                return -1;
                            }
                        }

                        if (nums1[i] > nums2[i] && decrement == false)
                        {
                            if (nums1[i] - k >= nums2[i])
                            {
                                nums1[i] = nums1[i] - k;
                                decrement = true;
                            }
                            else
                            {
                                return -1;
                            }
                        }
                    }

                    if (increment && decrement == true)
                    {
                        counter++;
                        break;
                    }
                }
            } while (loop);

            return -1;
        }

        public static int HighestCard(int[][] cards)
        {
            int res = -1;
            Dictionary<int, int> cardTracker = new Dictionary<int, int>();
            for (int i = 0; i < cards.Length; i++)
            {
                int[] row = cards[i];

                for (int j = 0; j < row.Length; j++)
                {
                    if (cardTracker.ContainsKey(row[j]))
                    {
                        cardTracker[row[j]]++;
                    }
                    else
                    {
                        cardTracker[row[j]] = 1;
                    }
                }
            }

            foreach (int key in cardTracker.Keys)
            {
                if (cardTracker[key] == 1)
                {
                    if (key > res)
                    {
                        res = key;
                    }
                }
            }
            return res;
        }

        public static void RotateArray(ref int[] B)
        {
            int temp = B[B.Length - 1];
            for (int i = B.Length - 1; i > 0; i--)
            {
                B[i] = B[i - 1];
            }
            B[0] = temp;
        }


        /// <summary>
        /// Year of the Rabbit codility challenge
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int solution(int[] A, int[] B)
        {
            // Implement your solution here
            int rotateCounter = 0;
            bool rotate = false;

            do
            {
                rotate = false;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == B[i])
                    {
                        rotate = true;
                        break;
                    }
                }

                if (rotate)
                {
                    rotateCounter++;

                    if (rotateCounter == B.Length)
                    {
                        return -1;
                    }

                    RotateArray(ref B);
                }

            } while (rotate);

            return rotateCounter >= 0 ? rotateCounter : -1;
        }


        public static int LengthOfLastWord(string s)
        {
            int counter = 0;
            s = s.Trim();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    return counter;
                }
                counter++;
            }
            return counter;
        }

        public static string StoneGameIII(int[] stoneValue)
        {
            long aliceScore = 0;
            long bobScore = 0;

            int currentIndex = 0;

            while (currentIndex != stoneValue.Length)
            {
                AliceStoneGame(stoneValue, currentIndex, aliceScore, out currentIndex, out aliceScore);

                BobStoneGame(stoneValue, currentIndex, bobScore, out currentIndex, out bobScore);
            }

            if (aliceScore > bobScore)
            {
                return "Alice";
            }
            else if (bobScore > aliceScore)
            {
                return "Bob";
            }
            else
            {
                return "Tie";
            }
        }

        public static void AliceStoneGame(int[] stoneValue, int currentIndex, long currentSum, out int newCurrentIndex, out long newCurrentSum)
        {
            int aliceCurrentScore = 0;
            int picked = 0;
            newCurrentIndex = 0;
            for (int i = currentIndex; i < stoneValue.Length; i++)
            {
                if (picked == 3)
                {
                    break;
                }
                picked++;

                if (aliceCurrentScore < aliceCurrentScore + stoneValue[i])
                {
                    aliceCurrentScore += stoneValue[i];
                }
                else
                {
                    if (picked == 1)
                    {
                        aliceCurrentScore += stoneValue[i];
                    }
                    else
                    {
                        break;
                    }
                }
                newCurrentIndex = i;
            }
            newCurrentIndex += 1;
            newCurrentSum = currentSum + aliceCurrentScore;
        }

        public static void BobStoneGame(int[] stoneValue, int currentIndex, long currentSum, out int newCurrentIndex, out long newCurrentSum)
        {
            int bobCurrentScore = 0;
            int picked = 0;
            newCurrentIndex = 0;
            for (int i = currentIndex; i < stoneValue.Length; i++)
            {
                picked++;
                if (picked == 3)
                {
                    break;
                }

                if (bobCurrentScore < bobCurrentScore + stoneValue[i])
                {
                    bobCurrentScore += stoneValue[i];
                }
                else
                {
                    if (picked == 1)
                    {
                        bobCurrentScore += stoneValue[i];
                    }
                    else
                    {
                        break;
                    }
                }
                newCurrentIndex = i;
            }

            newCurrentIndex += 1;
            newCurrentSum = currentSum + bobCurrentScore;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();

            for(int i = 0; i < nums.Length - 2; i++)
            {
                for(int j = i + 1; j < nums.Length - 1; j++)
                {
                    for(int k = j + 1; k < nums.Length; k++)
                    {
                        string key = GetKey(new int[] { nums[i], nums[j], nums[k] });                         

                        if (dictionary.ContainsKey(key))
                        {
                            
                        }
                    }
                }
            }
            return result;
        }

        public static string GetKey(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    int temp = nums[j];
                    if (nums[j] > nums[j + 1])
                    {
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            return $"{nums[0]}{nums[1]}{nums[2]}";
        }

    }
}
