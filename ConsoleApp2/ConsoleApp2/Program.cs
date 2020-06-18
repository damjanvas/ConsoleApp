using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotel = new Hotel();

            var list = new List<(int, int)>
            {
                (0, 0),
                (0, 2),
                (2, 4),
                (2, 2),
            };

            var list1a = new List<(int, int)>
            {
                (-4, 2),
            };

            var list1b = new List<(int, int)>
            {
                (200, 400),
            };

            var list2 = new List<(int, int)>
            {
                (0, 5),
                (7, 13),
                (3, 9),
                (5, 7),
                (6, 6),
                (0, 4)
            };

            var list3 = new List<(int, int)>
            {
                (1, 3),
                (2, 5),
                (1, 9),
                (0, 15),
            };

            var list4 = new List<(int, int)>
            {
                (1, 3),
                (0, 15),
                (1, 9),
                (2, 5),
                (4, 9)
            };

            //var list5 = new List<(int, int)>
            //{
            //    (1, 3),
            //    (0, 4),
            //    (2, 3),
            //    (5, 5),
            //    (4, 10),
            //    (10, 10),
            //    (6, 7),
            //    (8, 10),
            //    (8, 9)
            //};

            hotel.CheckBookings(list4);

            Console.WriteLine();
            //Console.WriteLine("************************************************************************************");
            Console.WriteLine(new string('*', 100));
            Console.WriteLine();

            hotel.PrintReservations();

            Console.ReadLine();
        }
    }
}
