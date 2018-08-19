using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tv.Models;

namespace Tv.Database
{
    public class TvRepository : ITvRepostitory
    {
        private readonly TvContext context;

        public TvRepository(TvContext context)
        {
            this.context = context;
        }

        public async Task<List<TvNetwork>> GetTvNetworksAsync()
        {
            return await context.TvNetworks.Include(x => x.TvShows).ToListAsync();
        }

        public async Task<TvNetwork> GetTvNetworkByIdAsync(int id, bool includeRelated = true)
        {
            if (includeRelated)
            {
                return await context.TvNetworks.Include(x => x.TvShows).SingleOrDefaultAsync(x => x.Id == id);
            }
            return await context.TvNetworks.FindAsync(id);
        }

        public void AddTvNetwork(TvNetwork model)
        {
            context.TvNetworks.Add(model);
        }

        public void RemoveTvNetwork(TvNetwork model)
        {
            context.TvNetworks.Remove(model);
        }
    }
}