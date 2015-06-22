using System.Collections.Generic;
using TDP36.Domain.Abstract;
using TDP36.Domain.Entities;

namespace TDP36.Domain.Concrete
{
    public class EFOpponentRepository : IOpponentRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Opponent> Opponents
        {
            get {  return context.Opponents; }
        }
    }
}
