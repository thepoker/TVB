using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace SilverlightHotelBrowser.Web
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public double Price { get; set; }
    }
}
