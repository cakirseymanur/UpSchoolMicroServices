using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpSchoolMicroServices.Web.Models.Catalogs
{
    public class ProductViewModel
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public string CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}
