using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class countMeetingSolution
    {
        //WIP:: Not passing all the test cases
        public static int countMeetings(List<int> firstDay, List<int> lastDay)
        {
            Dictionary<int, int> availabledays = new Dictionary<int, int>();
            int[] meetingsDay = new int[1000000];

            int meetingCounter = 0;
            for (int i = 0; i < firstDay.Count; i++)
            {
                int arrivalDay = firstDay[i];
                int departureDay = lastDay[i];

                availabledays[i] = (departureDay - arrivalDay) + 1;
            }

            //Sort the available days in ascending order
            availabledays = availabledays.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var investorDays in availabledays)
            {
                //Get arrival day
                int arrivalDay = firstDay[investorDays.Key];
                for (int j = 0; j < investorDays.Value; j++)
                {
                    if (meetingsDay[arrivalDay + j] == 0)
                    {
                        meetingCounter++;
                        meetingsDay[arrivalDay + j] = arrivalDay + j;
                        break;
                    }
                }
            }
            return meetingCounter;
        }
    }
}
