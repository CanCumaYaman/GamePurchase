using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ISoldGameService
    {
        void Add(SoldGame soldGame);
        void Delete(SoldGame soldGame);
        void Update(SoldGame soldGame);
    }
}
