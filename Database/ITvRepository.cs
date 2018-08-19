using System.Collections.Generic;
using System.Threading.Tasks;
using Tv.Models;

namespace Tv.Database
{
    public interface ITvRepostitory
    {
        Task<List<TvNetwork>> GetTvNetworksAsync();
        Task<TvNetwork> GetTvNetworkByIdAsync(int id, bool includeRelated = true);
        void AddTvNetwork(TvNetwork model);
        void RemoveTvNetwork(TvNetwork model);
    }
}