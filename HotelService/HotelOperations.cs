using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService
{
    class HotelOperations : IHotelOperations
    {
        public List<Hotel> GetAllHotels()
        {
            List<Hotel> hotelList = new List<Hotel>();
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/" + "Hotels.json";
            using (StreamReader streamReader = new StreamReader(path))
            {
                var read = streamReader.ReadToEnd();
                hotelList = JsonConvert.DeserializeObject<List<Hotel>>(read);
            }
            return hotelList;
        }

        public Hotel GetHotelById(int id)
        {
            var hotel = GetAllHotels().Find(x => x.Id == id);
            return hotel;
        }
    }
}
