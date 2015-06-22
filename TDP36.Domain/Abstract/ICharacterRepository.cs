using System;
using System.Collections.Generic;
using TDP36.Domain.Entities;

namespace TDP36.Domain.Abstract
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> Characters { get; }       
    }
}
