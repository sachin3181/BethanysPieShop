using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _dbContext;

        public PieRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _dbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _dbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
