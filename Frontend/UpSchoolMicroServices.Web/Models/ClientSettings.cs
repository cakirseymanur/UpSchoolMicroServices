using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchoolMicroServices.Web.Models
{
    public class ClientSettings
    {
        public Client MvcClient { get; set; }
        public Client MvcClientForUser { get; set; }
    }
    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
