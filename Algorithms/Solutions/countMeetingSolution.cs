using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class countMeetingSolution
    {
        public static int countMeetings(List<int> arrival, List<int> departure)
        {
            Dictionary<int, int> availabledays = new Dictionary<int, int>();
            int[] meetingsDay = new int[1000000];

            int meetingCounter = 0;
            for (int i = 0; i < arrival.Count; i++)
            {
                int arrivalDay = arrival[i];
                int departureDay = departure[i];

                availabledays[i] = (departureDay - arrivalDay) + 1;
            }

            //Sort the available days in ascending order
            availabledays = availabledays.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var investorDays in availabledays)
            {
                //Get arrival day
                int arrivalDay = arrival[investorDays.Key];
                bool isMeetingSet = false;
                for (int j = 0; j < investorDays.Value; j++)
                {
                    //meetingsDay[arrivalDay + j] = 0;
                    if (meetingsDay[arrivalDay + j] == 0 && !isMeetingSet)
                    {
                        meetingCounter++;
                        isMeetingSet = true;
                        meetingsDay[arrivalDay + j] = arrivalDay + j;
                        break;
                    }
                }
            }
            return meetingCounter;
        }
    }
}
