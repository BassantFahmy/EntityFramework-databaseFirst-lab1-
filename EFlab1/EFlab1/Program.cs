using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFlab1
{
    class Program
    {
        static void Main(string[] args)
        {App_Start.EntityFrameworkProfilerBootstrapper.PreStart();
            UnitOfWork unitofwork = UnitOfWork.Create();
            unitofwork.CountryManager.Add(new Country { Name = "England" });
       


        }
    }
}

