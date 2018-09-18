using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelService
{
    [ServiceContract]
    interface IHotelOperations
    {
        [OperationContract]
        List<Hotel> GetAllHotels();

        [OperationContract]
        Hotel GetHotelById(int id);
    }
}
