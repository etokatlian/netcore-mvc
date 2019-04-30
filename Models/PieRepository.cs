using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;

namespace netcore_webapp.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDBContext _appDbContext;

        public PieRepository(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}