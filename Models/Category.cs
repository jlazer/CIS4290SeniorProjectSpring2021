using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CIS4290SeniorProjectSpring2021.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Parent { get; set; }
    }

    public class ConnectionStringforOnlineStore : DbContext
    {
        public ConnectionStringforOnlineStore()
        { }
        public DbSet<Category> Categories { get; set; }
    }
}