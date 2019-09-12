using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Q
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

        public static int BottomUpFib(int n)
        {
            int[] f = new int[n + 1];

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

    }
}
