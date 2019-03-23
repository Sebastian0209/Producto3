using System.Data.Entity;

namespace api2.Models
{
    public class DataContex:DbContext
    {
        public DataContex():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<api2.Models.Product> Products { get; set; }
    }
}