using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchoolMicroServices.Web.Models
{
    public class ServicesApiSettings
    {
        public string IdentityBaseUrl { get; set; }
        public string GateWayBaseUrl { get; set; }
        public string PhotoStockUrl { get; set; }
        public ServicesApi Catalog { get; set; }
        public ServicesApi Basket { get; set; }
        public ServicesApi Discount { get; set; }
        public ServicesApi FakePayment { get; set; }
        public ServicesApi Order { get; set; }
    }
    public class ServicesApi
    {
        public string Path { get; set; }
    }
}
