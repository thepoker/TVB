using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;

namespace SilverlightHotelBrowser.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class HotelService
    {
        [OperationContract]
        public List<Hotel> GetHotels()
        {
            return new List<Hotel>
        {
        new Hotel
        {
        Name = "Brussels Hotel",
        Price = 100,
        Location = "Brussels",
        Country = "Belgium"
        },
        new Hotel
        {
        Name = "London Hotel",
        Price = 200,
        Location = "London",
        Country = "United Kingdom"
        },
        new Hotel
        {
        Name = "Paris Hotel",
        Price = 150,
        Location = "Paris",
        Country = "France"
        },
        new Hotel
        {
            Name = "New York Hotel",
        Price = 230,
        Location = "New York",
        Country = "USA"
        }
        };
        }
    }
}

