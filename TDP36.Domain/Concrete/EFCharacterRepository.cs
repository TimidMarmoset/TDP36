using System.Collections.Generic;
using TDP36.Domain.Abstract;
using TDP36.Domain.Entities;

namespace TDP36.Domain.Concrete
{
    public class EFCharacterRepository : ICharacterRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Character> Characters
        {
            get { return context.Characters; }
        }
    }
}
