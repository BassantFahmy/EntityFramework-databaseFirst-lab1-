using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class CountryManager : Repository<Country, Entities>
    {
        public CountryManager(Entities context) : base(context)
        {
        }
    }
}
