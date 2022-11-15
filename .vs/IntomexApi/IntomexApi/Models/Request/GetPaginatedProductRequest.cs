using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntomexApi.Models.Request
{
    public class GetPaginatedProductRequest
    {
        public int NumerOfItems { set; get; }
        public int Page { set; get; }
    }
}
