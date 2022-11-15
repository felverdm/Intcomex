using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntomexApi.Models.DBModel
{
    public class Products
    {
        [Key]
        public int ProductID { set; get; }
        public string ProductName { set; get; }
        public int SupplierID { set; get; }
        public int CategoryID { set; get; }
        public int QuantityPerUnit { set; get; }
        public decimal UnitPrice { set; get; }
        public int UnitsInStock { set; get; }
        public int UnitsOnOrder { set; get; }
        public int ReorderLevel { set; get; }
        public bool Discontinued { set; get; }

    }
}
