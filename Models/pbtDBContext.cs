using Microsoft.EntityFrameworkCore;

namespace PBT.Models
{
    public class pbtDBContext : DbContext
    {
        public pbtDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
