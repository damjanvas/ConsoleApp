using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    public class Room
    {
        public List<int> ReservedDays { get; set; }

        public Room()
        {
            ReservedDays = new List<int>();
        }

        private List<int> CreateDaysList(int start, int end)
        {
            var list = new List<int>();
            for (int i = start; i <= end; i++)
            {
                list.Add(i);
            }

            return list;
        }

        public bool CheckRoom(int start, int end)
        {
            var list = CreateDaysList(start, end);

            var res = ReservedDays.Any(day => list.Contains(day));

            if (res)
                return true;
            else
                return false;
        }

        public void ReserveRoom(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                ReservedDays.Add(i);
            }
        }

        public bool CheckDay(int day)
        {
            return ReservedDays.Contains(day);
        }

    }
}
