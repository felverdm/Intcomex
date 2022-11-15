using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntomexApi.Models.DBModel
{
    public class Categories
    {
        [Key]
        public int CategoryID { set; get; }
        public string CategoryName { set; get; }
        public string CategoryDescription { set; get; }
        public string CategoryImage { set; get; }

    }
}
