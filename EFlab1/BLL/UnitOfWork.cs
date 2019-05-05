using BLL.Managers;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UnitOfWork
    {
        private static Entities context = new Entities();
        private static UnitOfWork unitofwork;
        private UnitOfWork()
        {

        }
        public static UnitOfWork Create()
        {
            if(unitofwork == null)
            {
                unitofwork = new UnitOfWork();
            }
            return unitofwork;
        }
        public CityManager CityManager
        {
            get
            {
                return new CityManager(context);
            }
        }
        public CountryManager CountryManager
        {
            get
            {
                return new CountryManager(context);
            }
        }
    }
}
