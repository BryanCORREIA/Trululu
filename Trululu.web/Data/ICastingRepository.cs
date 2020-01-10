using System;
using System.Collections.Generic;
using System.Linq;
using Trululu.web.Entities;

namespace Trululu.web.Data
{
   public interface ICastingRepository
        {
            public IEnumerable<Casting> GetAllCastings();

            public Casting GetCastingById(int castingId);
        }
    
}
