using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Leetcodechallenge
{
    public class CarPoolingSolution
    {
        public static bool CarPooling(int[][] trips, int capacity)
        {
            int availableCapacity = capacity;
            Dictionary<int, int> destinationPassengerNumTracker = new Dictionary<int, int>();

            trips = SortCarPooling(trips);

            for (int i =0; i < trips.Length; i++)
            {
                int[] trip = trips[i];

                if (destinationPassengerNumTracker.ContainsKey(trip[2]))
                {
                    destinationPassengerNumTracker[trip[2]] += trip[0];
                }
                else
                {
                    destinationPassengerNumTracker[trip[2]] = trip[0];
                }
                int sumReachedDistinationPassengers = destinationPassengerNumTracker.Where(x => x.Key <= trip[1]).Sum(x => x.Value);
                if(sumReachedDistinationPassengers > 0)
                {
                }
                availableCapacity += sumReachedDistinationPassengers;


                if (trip[0] <= availableCapacity)
                {
                    availableCapacity -= trip[0];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static int[][] SortCarPooling(int[][] trips)
        {
            bool IsSwapped;
            do
            {
                IsSwapped = false;
                for (int i = 0; i < trips.Length -1; i++)
                {
                    int[] currentTrip = trips[i];
                    int[] nextTrip = trips[i + 1];

                    //Do the comparison of the numbers
                    if (currentTrip[1] > nextTrip[1])
                    {
                        //Do the swapping
                        //Keep the second value
                        int[] tempTrip = nextTrip;

                        //swap the highest value into the second value
                        trips[i + 1] = currentTrip;

                        //put the second value into the first
                        trips[i] = tempTrip;

                        IsSwapped = true;
                    }
                }
            } while (IsSwapped == true);
            return trips;
        }

    }
}
