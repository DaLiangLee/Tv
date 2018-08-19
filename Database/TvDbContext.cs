using Microsoft.EntityFrameworkCore;

namespace Tv.Database
{
    public class TvContext : DbContext
    {
        public TvContext(DbContextOptions<TvContext> options)
            : base(options)
        {

        }
    }
}