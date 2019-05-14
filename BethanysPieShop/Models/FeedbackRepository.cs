using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private AppDbContext _dbContext;

        public FeedbackRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddFeedback(Feedback feedback)
        {
            _dbContext.Feedbacks.Add(feedback);
            _dbContext.SaveChanges();
        }
    }
}
