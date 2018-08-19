using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Tv.Models
{
    public class TvNetwork
    {
        public TvNetwork()
        {
            TvShows = new Collection<TvShow>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TvShow> TvShows { get; set; }
    }
}