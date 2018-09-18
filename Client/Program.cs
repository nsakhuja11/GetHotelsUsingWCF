using Client.HotelServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelOperationsClient hc = new HotelOperationsClient("BasicHttpBinding_IHotelOperations");
            int choice;
            Console.WriteLine("Enter 1 to Get All Hotels");
            Console.WriteLine("Enter 2 to Get Hotel By Id");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        List<Hotel> hotelList = new List<Hotel>(hc.GetAllHotels());
                        for(int i = 0; i < hotelList.Count; i++)
                        {
                            Console.WriteLine("Hotel Id : {0}",hotelList[i].Id);
                            Console.WriteLine("Hotel Name : {0}",hotelList[i].Name);
                            Console.WriteLine("Hotel Address : {0}", hotelList[i].Address);
                            Console.WriteLine("Hotel StarRating : {0}", hotelList[i].StarRating);
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Hotel hotel = hc.GetHotelById(id);
                        Console.WriteLine();
                        if (hotel != null)
                        {
                            Console.WriteLine("Hotel Id : {0}", hotel.Id);
                            Console.WriteLine("Hotel Name : {0}", hotel.Name);
                            Console.WriteLine("Hotel Address : {0}", hotel.Address);
                            Console.WriteLine("Hotel StarRating : {0}", hotel.StarRating);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Hotel Id doesn't exist");
                            Console.WriteLine();
                        }
                        break;
                }
                Console.WriteLine("Enter 1 to Get All Hotels");
                Console.WriteLine("Enter 2 to Get Hotel By Id");
                Console.WriteLine("Enter 0 to Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
