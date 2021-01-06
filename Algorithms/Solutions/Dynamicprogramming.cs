using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class Dynamicprogramming
    {

        //GlobalConfiguration.Configuration
        //    .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
        //    .UseColouredConsoleLogProvider()
        //    .UseSimpleAssemblyNameTypeSerializer()
        //    .UseRecommendedSerializerSettings()
        //    .UseSqlServerStorage(@"Server=(local);initial catalog=algo;User ID=sa;Password=password@1;Connection Timeout=100000", new SqlServerStorageOptions
        //    {
        //        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
        //        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
        //        QueuePollInterval = TimeSpan.Zero,
        //        UseRecommendedIsolationLevel = true,
        //        UsePageLocksOnDequeue = true,
        //        DisableGlobalLocks = true
        //    });

        //WebApp.Start<Startup>("http://localhost:8085");

        //BackgroundJobServer server = new BackgroundJobServer();

        //int number = 3;
        //BackgroundJob.Enqueue(() => Dynamicprogramming.NormalFib(number));
        //BackgroundJob.Enqueue(() => Dynamicprogramming.BottomUpFib(number));
        //BackgroundJob.Enqueue(() => Dynamicprogramming.TopDownFibEntry(number));


        static int max = 15;
        static int defualtVal = -1;
        static int[] lookup = new int[max];

        public static int NormalFib(int n)
        {
            if(n <= 1)
            {
                return n;
            }

            return NormalFib(n - 1) + NormalFib(n - 2);
        }

        public static Int64 BottomUpFib(Int64 n)
        {
            Int64[] f = new Int64[n + 1];

            f[0] = 0;
            f[1] = 1;

            for(int i =2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }

        public static int TopDownFib(int n)
        {

            if (lookup[n] == defualtVal)
            {
                if (n <= 1)
                {
                    lookup[n] = n;
                }
                else
                {
                    lookup[n] = TopDownFib(n - 1) + TopDownFib(n - 2);
                }
            }

            return lookup[n];
        }

        public static int TopDownFibEntry(int n)
        {
            Initializer();
            return TopDownFib(n);
        }

        public static void Initializer()
        {
            //Initialize the table
            for (int i = 0; i < max; i++)
            {
                lookup[i] = defualtVal;
            }

        }

        public static Int64 DPFib(int n, Dictionary<int, Int64> memo = null)
        {
            if (memo == null) memo = new Dictionary<int, long> { };
            if (memo.ContainsKey(n)) return memo[n];
            if (n <= 2) return 1;

            memo[n] = DPFib(n - 1, memo) + DPFib(n - 2, memo);
            return memo[n];
        }

        public static Int64 GridTraveller(int n, int m, Dictionary<string, Int64> memo = null)
        {
            string key = $"{n},{m}";
            if (memo == null) memo = new Dictionary<string, Int64> { };
            if (memo.ContainsKey(key)) return memo[key];
            if (n == 1 && m == 1) return 1;
            if (n == 0 || m == 0) return 0;

            memo[key] = GridTraveller(n - 1, m, memo) + GridTraveller(n, m - 1, memo);
            return memo[key];
        }

        public static bool CanSum(int target, int[] numbers, Dictionary<int, bool> memo)
        {
            if (memo.ContainsKey(target)) return memo[target];
            if (target == 0) return true;
            if (target < 0) return false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = target - numbers[i];
                if (CanSum(remainder, numbers, memo) == true)
                {
                    memo[target] = true;
                    return true;
                }
            }

            memo[target] = false;
            return false;
        }

        public static ArrayList HowSum(int target, int[] numbers, Dictionary<int, ArrayList> memo = null)
        {
            if (memo == null) memo = new Dictionary<int, ArrayList> { };
            if (memo.ContainsKey(target)) return memo[target];
            if (target == 0) return new ArrayList { };
            if (target < 0) return null;

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = target - numbers[i];
                ArrayList remainderResult = HowSum(remainder, numbers, memo);

                if (remainderResult != null)
                {
                    remainderResult.Add(numbers[i]);
                    memo[target] = remainderResult;
                    return memo[target];
                }
            }
            memo[target] = null;
            return null;
        }

        public static int[] BestSum(int target, int[] numbers, Dictionary<int, int[]> memo = null)
        {
            if (memo == null) memo = new Dictionary<int, int[]> { };
            if (memo.ContainsKey(target)) return memo[target];
            if (target == 0) return new int[] { };
            if (target < 0) return null;

            int[] shortestCombinations = null;

            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = target - numbers[i];
                int[] remainderCombinations = BestSum(remainder, numbers, memo);

                if (remainderCombinations != null)
                {
                    int remainderArrLen = remainderCombinations.Length;
                    int[] combination = new int[remainderArrLen + 1];
                    Array.Copy(remainderCombinations, combination, remainderArrLen);
                    combination[remainderArrLen] = numbers[i];
                    if (shortestCombinations == null || combination.Length < shortestCombinations.Length)
                    {
                        shortestCombinations = combination;
                    }
                }
            }
            memo[target] = shortestCombinations;
            return shortestCombinations;
        }

        public static bool CanConstruct(string target, string[] wordBank, Dictionary<string, bool> memo = null)
        {
            if (memo == null) memo = new Dictionary<string, bool> { };
            if (memo.ContainsKey(target)) return memo[target];
            if (target == "") return true; ;

            for (int i = 0; i < wordBank.Length; i++)
            {
                if (target.StartsWith(wordBank[i]))
                {
                    var suffix = target.Substring(wordBank[i].Length);
                    if(CanConstruct(suffix, wordBank, memo)){
                        memo[target] = true;
                        return true;
                    }
                }
            }
            memo[target] = false;
            return false;
        }

        public static int CountConstruct(string target, string[] wordBank, Dictionary<string, int> memo = null)
        {
            if (memo == null) memo = new Dictionary<string, int> { };
            if (memo.ContainsKey(target)) return memo[target];
            if (target == "") return 1;

            int totalWay = 0;

            for (int i = 0; i < wordBank.Length; i++)
            {
                if (target.StartsWith(wordBank[i]))
                {
                    var suffix = target.Substring(wordBank[i].Length);
                    int possibleWays = CountConstruct(suffix, wordBank, memo);
                    totalWay += possibleWays;
                }
            }
            memo[target] = totalWay;
            return totalWay;
        }

    }
}
