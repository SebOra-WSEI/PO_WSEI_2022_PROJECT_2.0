using BOOKSTORE_PROJECT_PO.Dal_Models;
using BOOKSTORE_PROJECT_PO.Models;
using System.Collections.Generic;
using System.Linq;

namespace BOOKSTORE_PROJECT_PO
{
    internal class CityDal
    {
        private BookstoreDBEntities db = new BookstoreDBEntities();
        public IList<CityDalModel> getCityList =>  
            db.Cities.Select(city => new CityDalModel { ID = city.ID, Name = city.CityName }).ToList();
    }
}
