namespace Tv.Models
{
    public class TvShow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TvNetworkId { get; set; }
        public TvNetwork TvNetwork { get; set; }
    }
}