using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tv.Database;
using Tv.Models;
using Tv.ViewModels;

namespace Tv.Controllers
{
    public class TvController : Controller
    {
        private readonly TvContext context;
        private readonly IMapper mapper;

        public TvController(TvContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/tvnetworks")]
        public async Task<IEnumerable<TvNetworkViewModel>> GetTvNetworks()
        {
            var models = await context.TvNetworks.Include(x => x.TvShows).ToListAsync();
            var vms = mapper.Map<List<TvNetwork>, List<TvNetworkViewModel>>(models);
            return vms;
        }
    }
}