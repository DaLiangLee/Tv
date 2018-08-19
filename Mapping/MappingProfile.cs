using AutoMapper;
using Tv.Models;
using Tv.ViewModels;

namespace Tv.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TvNetwork, TvNetworkViewModel>();
            CreateMap<TvShow, TvShowViewModel>();
        }
    }
}