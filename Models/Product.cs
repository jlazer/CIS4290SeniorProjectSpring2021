using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS4290SeniorProjectSpring2021.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public double UnitPrice { get; set; }
        public int MainCategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int ProductRating { get; set; }
        public int FeaturedProduct { get; set; }

    }
}