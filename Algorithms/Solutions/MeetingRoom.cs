using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class MeetingRoom
    {
        public static bool Meeting(int[,] rooms)
        {
            int length = rooms.Length/2;
            //sort the array
            for (int i =0; i< length - 1; i++)
            {
                for(int j = 1; j < 2; j++)
                {
                    if (rooms[i, j] > rooms[i + 1, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int[,] SortMeeting(int[,] rooms)
        {
            int length = rooms.Length / 2;
            //sort the array
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (rooms[i, j] > rooms[i + 1, j])
                    {
                        int tempStart = rooms[i, j];
                        int tempEnd = rooms[i, j + 1];

                        rooms[i, j] = rooms[i + 1, j];
                        rooms[i, j + 1] = rooms[i + 1, j + 1];

                        rooms[i + 1, j] = tempStart;
                        rooms[i + 1, j + 1] = tempEnd;
                    }
                }
            }
            return rooms;
        }

        public static int MeetingExtraRoom(int[,] rooms)
        {
            int length = rooms.Length / 2;
            int counter = 0;

            rooms = SortMeeting(rooms);

            //sort the array
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (rooms[i, j] > rooms[i + 1, j] || rooms[i, j + 1] > rooms[ i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

    }
}
