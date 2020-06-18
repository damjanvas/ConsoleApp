using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Hotel
    {
        public int Size { get; set; } = 3;
        public int Date { get; set; } = 15;
        public Room[] Rooms { get; set; }

        public Hotel()
        {
            Rooms = new Room[Size];
            for (int i = 0; i < Size; i++)
            {
                var room = new Room();
                Rooms[i] = room;
            }
        }

        private void FormatDate(int n)
        {
            if (n > 9)
                Console.Write("    " + n + "     |");
            else
                Console.Write("    " + n + "      |");
        }

        public void CheckBookings(List<(int, int)> list)
        {
            Console.Write("           |");
            Console.Write(" StartDate |");
            Console.Write(" EndDate |");
            Console.Write(" Result: Accept / Decline ");
            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                var res = CheckBooking(list[i].Item1, list[i].Item2);

                Console.Write(" Booking " + (i + 1) + " |");

                FormatDate(list[i].Item1);
                FormatDate(list[i].Item2);

                if (res)
                    Console.Write("    Accept ");
                else
                    Console.Write("    Decline ");

                Console.WriteLine();
            }
        }

        public bool CheckBooking(int start, int end)
        {
            if (start < 0 || start > Date)
                return false;

            if (end < 0 || end > Date)
                return false;

            for (int i = 0; i < Size; i++)
            {
                var availableRoom = Rooms[i].CheckRoom(start, end);

                if (availableRoom)
                {
                    continue;
                }
                else
                {
                    Rooms[i].ReserveRoom(start, end);
                    return true;
                }
            }

            return false;
        }

        public void PrintReservations()
        {
            Console.Write("        |");
            for (int a = 0; a <= Date; a++)
            {
                if (a > 9)
                {
                    Console.Write(" Day " + a + "  |");
                }
                else
                {
                    Console.Write(" Day " + a + "   |");
                }

            }
            Console.WriteLine();

            for (int i = 0; i < Size; i++)
            {
                Console.Write(" Room " + i + " |");
                for (int j = 0; j <= Date; j++)
                {
                    var res = Rooms[i].CheckDay(j);

                    if (res)
                    {
                        Console.Write("   X     |");
                    }
                    else
                    {
                        Console.Write("         |");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
